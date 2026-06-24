using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using NHibernate;
using NHibernate.Transform;

namespace EleWise.ELMA.Documents.Services;

[Service(Type = ComponentType.Server)]
internal sealed class DmsObjectPermissionUpdateQueueItemRepository : IDmsObjectPermissionUpdateQueueItemRepository
{
	private readonly IRuntimeApplication runtimeApplication;

	private readonly ITransformationProvider transformationProvider;

	private readonly ISessionProvider sessionProvider;

	private readonly ILogger logger;

	private readonly string deleteQueueItem;

	private readonly string getDocumentsCount;

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

	public DmsObjectPermissionUpdateQueueItemRepository(IRuntimeApplication runtimeApplication, ITransformationProvider transformationProvider, ISessionProvider sessionProvider, ILogger logger)
	{
		this.runtimeApplication = runtimeApplication;
		this.transformationProvider = transformationProvider;
		this.sessionProvider = sessionProvider;
		this.logger = logger;
		deleteQueueItem = string.Format("DELETE FROM {0} WHERE {1} = {3}{2}", transformationProvider.Dialect.QuoteIfNeeded("DmsObjectPermissionUpdateQueueItem"), transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.Dialect.QuoteIfNeeded("queueItemId"), transformationProvider.ParameterSeparator);
		getDocumentsCount = string.Format("SELECT COUNT(*) FROM {0} WHERE {1} = :{2}", transformationProvider.Dialect.QuoteIfNeeded("DmsObjectPermissionUpdateQueueItem"), transformationProvider.Dialect.QuoteIfNeeded("FolderId"), transformationProvider.Dialect.QuoteIfNeeded("folderId"));
	}

	public void BulkInsertQueueItems(IDmsObject folder, long user, string patch)
	{
		DataTable dataTable = new DataTable("DmsObjectPermissionUpdateQueueItem");
		dataTable.Columns.Add("Id", typeof(long));
		dataTable.Columns.Add("DmsObject", typeof(long));
		dataTable.Columns.Add("Patch", typeof(byte[]));
		dataTable.Columns.Add("CreationDate", typeof(DateTime));
		dataTable.Columns.Add("Attempt", typeof(int));
		dataTable.Columns.Add("NextUpdateDate", typeof(DateTime));
		dataTable.Columns.Add("User", typeof(long));
		dataTable.Columns.Add("FolderId", typeof(long));
		dataTable.Columns.Add("FolderName", typeof(string));
		DateTime dateTime = DateTime.Now - TimeSpan.FromHours(1.0);
		IEnumerable<long> folderContent = GetFolderContent(folder.Id);
		long id = folder.Id;
		string name = folder.Name;
		byte[] value = ((patch != null && patch.Any()) ? ClassSerializationHelper.SerializeObject(patch) : null);
		foreach (long item in folderContent)
		{
			DataRow dataRow = dataTable.NewRow();
			dataRow["DmsObject"] = item;
			dataRow["Patch"] = value;
			dataRow["CreationDate"] = dateTime;
			dataRow["Attempt"] = 0;
			dataRow["NextUpdateDate"] = dateTime;
			dataRow["User"] = user;
			dataRow["FolderId"] = id;
			dataRow["FolderName"] = name;
			dataTable.Rows.Add(dataRow);
			if (dataTable.Rows.Count > 500)
			{
				transformationProvider.BulkInsert(dataTable.TableName, dataTable);
				dataTable.Rows.Clear();
			}
		}
		if (dataTable.Rows.Count > 0)
		{
			transformationProvider.BulkInsert(dataTable.TableName, dataTable);
		}
	}

	private IEnumerable<long> GetFolderContent(long folderId)
	{
		try
		{
			return sessionProvider.GetSession(string.Empty).GetNamedQuery("GetDocumentsFromFolder").SetParameter<long>("folderId", folderId)
				.List<long>();
		}
		catch (Exception ex)
		{
			logger.Error(ex.Message, ex);
		}
		return Enumerable.Empty<long>();
	}

	public bool TryGetDocumentsCount(long folderId, out long count)
	{
		count = 0L;
		try
		{
			object value = ((IQuery)sessionProvider.GetSession(string.Empty).CreateSQLQuery(getDocumentsCount)).SetParameter<long>("folderId", folderId).UniqueResult();
			count = Convert.ToInt64(value);
			return true;
		}
		catch (Exception ex)
		{
			logger.Error(ex.Message, ex);
		}
		return false;
	}

	public void Delete(DmsObjectPermissionUpdateQueueItem queueItem)
	{
		transformationProvider.ExecuteNonQuery(deleteQueueItem, new Dictionary<string, object> { { "queueItemId", queueItem.Id } });
	}

	public IEnumerable<DmsObjectPermissionUpdateQueueItem> GetItems(int count)
	{
		try
		{
			return sessionProvider.GetSession(string.Empty).GetNamedQuery("GetDmsObjectPermissionUpdateQueueItems").SetParameter<Guid>("serverConnectionUid", runtimeApplication.ConnectionUid)
				.SetParameter<DateTime>("currentTimestamp", DateTime.Now.ToServerDateTime())
				.SetParameter<int>("count", count)
				.SetParameter<int>("attemptLength", AttemptIntervals.Length)
				.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(DmsObjectPermissionUpdateQueueItem)))
				.List<DmsObjectPermissionUpdateQueueItem>();
		}
		catch (Exception ex)
		{
			logger.Error(ex.Message, ex);
		}
		return Enumerable.Empty<DmsObjectPermissionUpdateQueueItem>();
	}

	public void ReleaseItems()
	{
		IEnumerable<Guid> activeConnectionUids = runtimeApplication.GetActiveConnectionUids();
		if (!activeConnectionUids.Any())
		{
			return;
		}
		HashSet<Guid> hashSet = new HashSet<Guid>();
		string sql = string.Format("SELECT DISTINCT {1} FROM {0} WHERE {1} IS NOT NULL", transformationProvider.NoLockTableExpression("DmsObjectPermissionUpdateQueueItem", "pruqi"), transformationProvider.Dialect.QuoteIfNeeded("ServerConnectionUid"));
		try
		{
			using IDataReader dataReader = transformationProvider.ExecuteQuery(sql);
			while (dataReader.Read())
			{
				hashSet.Add(transformationProvider.Dialect.GetGuid(dataReader["ServerConnectionUid"]));
			}
		}
		catch (Exception ex)
		{
			_ = ex.Message;
		}
		foreach (Guid item in hashSet.Except(activeConnectionUids))
		{
			try
			{
				sessionProvider.GetSession(string.Empty).GetNamedQuery("ReleaseDmsObjectPermissionUpdateQueueItems").SetParameter<Guid>("serverConnectionUid", item)
					.List();
			}
			catch (Exception exception)
			{
				logger.Error(SR.T("Ошибка удаления элемента очереди обновления ролей проекта для сервера с UID = {0}", item), exception);
			}
		}
	}

	public void UpdateFailedQueueItem(DmsObjectPermissionUpdateQueueItem queueItem)
	{
		string where = string.Format("{0}={1}", transformationProvider.Dialect.QuoteIfNeeded("Id"), queueItem.Id);
		transformationProvider.Update("DmsObjectPermissionUpdateQueueItem", new string[4] { "Attempt", "LastUpdateDate", "NextUpdateDate", "ServerConnectionUid" }, new object[4] { queueItem.Attempt, queueItem.LastUpdateDate, queueItem.NextUpdateDate, queueItem.ServerConnectionUid }, where);
	}
}
