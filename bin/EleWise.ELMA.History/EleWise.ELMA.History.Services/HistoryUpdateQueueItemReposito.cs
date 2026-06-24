using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.History.Constants;
using EleWise.ELMA.History.Enums;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using NHibernate;
using NHibernate.Transform;
using NHibernate.Type;

namespace EleWise.ELMA.History.Services;

[Service]
internal sealed class HistoryUpdateQueueItemRepository : IHistoryUpdateQueueItemRepository
{
	private readonly IRuntimeApplication runtimeApplication;

	private readonly ITransformationProvider transformationProvider;

	private readonly ISessionProvider sessionProvider;

	private readonly ILogger logger;

	private readonly ICacheService cacheService;

	private readonly ITransformationProviderExtension transformationProviderExtension;

	private readonly string historyUpdateInQueueQuery;

	private readonly string deleteQueueItem;

	private const string GetHistoryUpdateQueueItemsProcedureName = "GetHistoryUpdateQueueItems";

	private const string ServerConnectionUidParamName = "serverConnectionUid";

	private const string CurrentTimestampParamName = "currentTimestamp";

	private const string CountParamName = "count";

	private const string AttemptLengthParamName = "attemptLength";

	private const string ReleaseHistoryUpdateQueueItemsProcedureName = "ReleaseHistoryUpdateQueueItems";

	private const string HistoryUpdateQueueItemsUpsertProcedureName = "HistoryUpdateQueueItemsUpsert";

	private const string QueueItemIdParamName = "queueItemId";

	private const string TvpParamName = "tvp";

	private const string ObjectIdParamName = "objectId";

	private const string ObjectTypeUidParamName = "objectTypeUid";

	private const string AttemptParamName = "attempt";

	internal static readonly TimeSpan[] AttemptIntervals = new TimeSpan[17]
	{
		TimeSpan.Zero,
		TimeSpan.FromMinutes(1.0),
		TimeSpan.FromMinutes(1.0),
		TimeSpan.FromMinutes(1.0),
		TimeSpan.FromMinutes(2.0),
		TimeSpan.FromMinutes(2.0),
		TimeSpan.FromMinutes(3.0),
		TimeSpan.FromMinutes(5.0),
		TimeSpan.FromMinutes(10.0),
		TimeSpan.FromMinutes(15.0),
		TimeSpan.FromMinutes(20.0),
		TimeSpan.FromMinutes(30.0),
		TimeSpan.FromMinutes(30.0),
		TimeSpan.FromHours(1.0),
		TimeSpan.FromHours(3.0),
		TimeSpan.FromHours(6.0),
		TimeSpan.FromHours(12.0)
	};

	internal static string CacheKey(long objectId, Guid objectTypeUid)
	{
		return string.Format("{0}_{1}_{2}", "HistoryUpdatingStatusFor", objectId, objectTypeUid);
	}

	public HistoryUpdateQueueItemRepository(IRuntimeApplication runtimeApplication, ITransformationProvider transformationProvider, ISessionProvider sessionProvider, ILogger logger, ICacheService cacheService, IEnumerable<ITransformationProviderExtension> transformationProviderExtensions)
	{
		this.runtimeApplication = runtimeApplication;
		this.transformationProvider = transformationProvider;
		this.sessionProvider = sessionProvider;
		this.logger = logger;
		this.cacheService = cacheService;
		transformationProviderExtension = transformationProviderExtensions.FirstOrDefault((ITransformationProviderExtension ext) => ext.CanUse);
		historyUpdateInQueueQuery = string.Format("SELECT COUNT({0}) FROM {1} WHERE {2} = {5}objectId AND {3} = {5}objectTypeUid AND {4} < {5}attempt", transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.Id), transformationProvider.NoLockTableExpression(HistoryUpdateQueueItemConstants.TableName, "huqi"), transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.ObjectId), transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.ObjectTypeUid), transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.Attempt), transformationProvider.ParameterSeparator);
		deleteQueueItem = $"DELETE FROM {transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.TableName)} WHERE {transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.Id)} = {transformationProvider.ParameterSeparator}queueItemId";
	}

	public IEnumerable<HistoryUpdateQueueItem> GetItems(int count)
	{
		try
		{
			return sessionProvider.GetSession(string.Empty).GetNamedQuery("GetHistoryUpdateQueueItems").SetParameter<Guid>("serverConnectionUid", runtimeApplication.ConnectionUid)
				.SetParameter<DateTime>("currentTimestamp", DateTime.Now.ToServerDateTime())
				.SetParameter<int>("count", count)
				.SetParameter<int>("attemptLength", AttemptIntervals.Length)
				.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(HistoryUpdateQueueItem)))
				.List<HistoryUpdateQueueItem>();
		}
		catch (Exception ex)
		{
			logger.Error(ex.Message, ex);
		}
		return Enumerable.Empty<HistoryUpdateQueueItem>();
	}

	public void ReleaseItems()
	{
		IEnumerable<Guid> activeConnectionUids = runtimeApplication.GetActiveConnectionUids();
		if (!activeConnectionUids.Any())
		{
			return;
		}
		HashSet<Guid> hashSet = new HashSet<Guid>();
		string sql = string.Format("SELECT DISTINCT {1} FROM {0} WHERE {1} IS NOT NULL", transformationProvider.NoLockTableExpression(HistoryUpdateQueueItemConstants.TableName, "huqi"), transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.ServerConnectionUid));
		using (IDataReader dataReader = transformationProvider.ExecuteQuery(sql))
		{
			while (dataReader.Read())
			{
				hashSet.Add(transformationProvider.Dialect.GetGuid(dataReader[HistoryUpdateQueueItemConstants.ServerConnectionUid]));
			}
		}
		foreach (Guid item in hashSet.Except(activeConnectionUids))
		{
			try
			{
				sessionProvider.GetSession(string.Empty).GetNamedQuery("ReleaseHistoryUpdateQueueItems").SetParameter<Guid>("serverConnectionUid", item)
					.List();
			}
			catch (Exception exception)
			{
				logger.Error(SR.T("Ошибка удаления элемента очереди обновления истории для сервера с UID = {0}", item), exception);
			}
		}
	}

	public void BulkInsertQueueItems(IEnumerable<InverseRelatedEntityModel> objects, bool forDelete)
	{
		DataTable dataTable = new DataTable();
		dataTable.Columns.Add(HistoryUpdateQueueItemConstants.Id, typeof(long));
		dataTable.Columns.Add(HistoryUpdateQueueItemConstants.ObjectId, typeof(long));
		dataTable.Columns.Add(HistoryUpdateQueueItemConstants.ObjectTypeUid, typeof(Guid));
		dataTable.Columns.Add(HistoryUpdateQueueItemConstants.DeleteRelated, typeof(bool));
		dataTable.Columns.Add(HistoryUpdateQueueItemConstants.CreationDate, typeof(DateTime));
		dataTable.Columns.Add(HistoryUpdateQueueItemConstants.NextUpdateDate, typeof(DateTime));
		DateTime dateTime = DateTime.Now - TimeSpan.FromHours(1.0);
		long[] array = transformationProvider.ReserveIds(objects.Count(), HistoryUpdateQueueItemConstants.TableName);
		foreach (InverseRelatedEntityModel @object in objects)
		{
			DataRow dataRow = dataTable.NewRow();
			dataRow[HistoryUpdateQueueItemConstants.Id] = array[dataTable.Rows.Count];
			dataRow[HistoryUpdateQueueItemConstants.ObjectId] = @object.Id;
			dataRow[HistoryUpdateQueueItemConstants.ObjectTypeUid] = @object.TypeUid;
			dataRow[HistoryUpdateQueueItemConstants.DeleteRelated] = forDelete;
			dataRow[HistoryUpdateQueueItemConstants.CreationDate] = dateTime;
			dataRow[HistoryUpdateQueueItemConstants.NextUpdateDate] = dateTime;
			dataTable.Rows.Add(dataRow);
		}
		sessionProvider.GetSession(string.Empty).GetNamedQuery("HistoryUpdateQueueItemsUpsert").SetParameter("tvp", (object)dataTable, (IType)(object)transformationProviderExtension.HistoryUpdateQueueItem)
			.CleanUpCache(cleanUpCache: false)
			.ExecuteUpdate();
	}

	public void InsertQueueItem(long objectId, Guid objectTypeUid, bool forDelete)
	{
		DateTime dateTime = DateTime.Now - TimeSpan.FromHours(1.0);
		cacheService.Insert(CacheKey(objectId, objectTypeUid), HistoryUpdatingStatus.InProgress, "HistoryCacheRegion", TimeSpan.FromMinutes(HistoryConst.HistoryCacheStatusDuration));
		transformationProviderExtension.InsertIfNotExists(HistoryUpdateQueueItemConstants.TableName, new Dictionary<string, object>
		{
			{
				HistoryUpdateQueueItemConstants.ObjectId,
				objectId
			},
			{
				HistoryUpdateQueueItemConstants.ObjectTypeUid,
				objectTypeUid
			},
			{
				HistoryUpdateQueueItemConstants.DeleteRelated,
				forDelete
			},
			{
				HistoryUpdateQueueItemConstants.CreationDate,
				dateTime
			},
			{
				HistoryUpdateQueueItemConstants.Attempt,
				0
			},
			{
				HistoryUpdateQueueItemConstants.NextUpdateDate,
				dateTime
			}
		}, isNeedInsertId: true, new string[2]
		{
			HistoryUpdateQueueItemConstants.ObjectId,
			HistoryUpdateQueueItemConstants.ObjectTypeUid
		});
	}

	public void UpdateQueueItem(HistoryUpdateQueueItem queueItem)
	{
		string where = $"{transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.Id)}={queueItem.Id}";
		transformationProvider.Update(HistoryUpdateQueueItemConstants.TableName, new string[4]
		{
			HistoryUpdateQueueItemConstants.Attempt,
			HistoryUpdateQueueItemConstants.LastUpdateDate,
			HistoryUpdateQueueItemConstants.NextUpdateDate,
			HistoryUpdateQueueItemConstants.ServerConnectionUid
		}, new object[4] { queueItem.Attempt, queueItem.LastUpdateDate, queueItem.NextUpdateDate, queueItem.ServerConnectionUid }, where);
	}

	public void DeleteQueueItem(HistoryUpdateQueueItem queueItem)
	{
		transformationProvider.ExecuteNonQuery(deleteQueueItem, new Dictionary<string, object> { { "queueItemId", queueItem.Id } });
		if (queueItem.DeleteRelated && queueItem.ObjectId >= 0)
		{
			InsertQueueItem(queueItem.ObjectId, queueItem.ObjectTypeUid, forDelete: false);
		}
		else
		{
			cacheService.Insert(CacheKey(queueItem.ObjectId, queueItem.ObjectTypeUid), HistoryUpdatingStatus.Finished, "HistoryCacheRegion", TimeSpan.FromMinutes(HistoryConst.HistoryCacheStatusDuration));
		}
	}

	public bool HisotoryObjectUpdateInQueue(long objectId, Guid objectTypeUid)
	{
		return Convert.ToBoolean(transformationProvider.ExecuteScalar(historyUpdateInQueueQuery, new Dictionary<string, object>
		{
			{ "objectId", objectId },
			{ "objectTypeUid", objectTypeUid },
			{ "attempt", AttemptIntervals.Length }
		}));
	}

	public void DeleteQueueItemsByObjectTypeUid(Guid objectTypeUid)
	{
		transformationProvider.ExecuteNonQuery(string.Format("DELETE FROM {0} WHERE {1} = {2}{3}", transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.TableName), transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.ObjectTypeUid), transformationProvider.ParameterSeparator, "objectTypeUid"), new Dictionary<string, object> { { "objectTypeUid", objectTypeUid } });
	}

	public void DeleteQueueItemsByObjectTypeUids(IEnumerable<Guid> objectTypeUids)
	{
		transformationProvider.ExecuteNonQuery($"DELETE FROM {transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.TableName)} WHERE {ElmaInExpression.ToString(transformationProvider.Dialect.QuoteIfNeeded(HistoryUpdateQueueItemConstants.ObjectTypeUid), objectTypeUids.Select((Guid u) => transformationProvider.GuidQuerySintaxis(u)), DbType.Guid)}");
	}
}
