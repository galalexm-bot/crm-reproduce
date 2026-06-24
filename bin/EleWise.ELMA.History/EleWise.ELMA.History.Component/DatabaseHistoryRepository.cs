using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.History.Constants;
using EleWise.ELMA.History.Enums;
using EleWise.ELMA.History.ExtensionPoints;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using NHibernate;
using NHibernate.Transform;
using NHibernate.Type;

namespace EleWise.ELMA.History.Components;

internal sealed class DatabaseHistoryRepository : IHistoryRepository
{
	private readonly ITransformationProvider transformationProvider;

	private readonly ISessionProvider sessionProvider;

	private readonly ITransformationProviderExtension transformationProviderExtension;

	private static readonly string UnitOfWorkUid = "UnitOfWorkUid";

	private static readonly string ActionDate = "ActionDate";

	private const string ObserverParentIndexName = "U_HISTOBJOBSERVER_PARENT";

	private const string ObserverChildIndexName = "U_HISTOBJOBSERVER_CHILD";

	private const string ObserverParentChildIndexName = "U_HISTOBJOBSERVER_P_C";

	private const string HistoryObjectKeyIndexName = "U_HISTORYOBJECT_KEY";

	private const string HistoryObjectUidIdIndexName = "IX_HO_ObjUid_ObjId";

	private const string HistoryObjectUidActUidIndexName = "IX_HO_ObjUidId_ActUid";

	private const string HistoryObjectObjActinDateIndexName = "IX_HO_ObjUId";

	private const string HistoryObjectObjUOWUIdActUidIndexName = "IX_HO_ObjUOWUId_ActUid";

	private const string HistoryObjectObjUOWUidIndexName = "IX_HO_UOWUid";

	private const string HistoryObjectObjActionDateIndexName = "IX_HO_ActionDate";

	private const string HistoryObjectObjIdIndexName = "IX_HO_Id";

	private const string HistoryObjectObjIsRelatedIndexName = "IX_HO_Id_IsRelated";

	private const string HistoryObjectObjIdIsRelatedIndexName = "IX_HO_Uid_IsRelated";

	public Guid Uid => HistoryConst.DatabaseRepositoryUid;

	public string Name => SR.T("База данных");

	public DatabaseHistoryRepository(ITransformationProvider transformationProvider, ISessionProvider sessionProvider, IEnumerable<ITransformationProviderExtension> transformationProviderExtensions)
	{
		this.transformationProvider = transformationProvider;
		this.sessionProvider = sessionProvider;
		transformationProviderExtension = transformationProviderExtensions.FirstOrDefault((ITransformationProviderExtension ext) => ext.CanUse);
	}

	public bool TableExists(string tableName)
	{
		return transformationProvider.TableExists(tableName);
	}

	public bool CreateTables()
	{
		if (transformationProvider.TableExists("HistoryObject"))
		{
			transformationProvider.RemoveTable("HistoryObject", removeSequence: false);
		}
		if (transformationProvider.TableExists("HistoryObjectObserver"))
		{
			transformationProvider.RemoveTable("HistoryObjectObserver", removeSequence: false);
		}
		transformationProvider.BeginTransaction();
		try
		{
			Table table = new Table
			{
				Sequence = false,
				Name = "HistoryObjectObserver",
				Columns = new List<Column>
				{
					new Column("Parent", new ColumnType(DbType.String, 70)),
					new Column("Child", new ColumnType(DbType.String, 70))
				}
			};
			transformationProvider.AddTable(table);
			transformationProvider.AddIndex(new Index
			{
				Name = "U_HISTOBJOBSERVER_PARENT",
				TableName = "HistoryObjectObserver",
				Columns = new List<string> { "Parent" }
			});
			transformationProvider.AddIndex(new Index
			{
				Name = "U_HISTOBJOBSERVER_CHILD",
				TableName = "HistoryObjectObserver",
				Columns = new List<string> { "Child" }
			});
			transformationProvider.AddIndex(new Index
			{
				Name = "U_HISTOBJOBSERVER_P_C",
				TableName = "HistoryObjectObserver",
				Columns = new List<string> { "Parent", "Child" }
			});
			transformationProvider.CommitTransaction();
		}
		catch (Exception exception)
		{
			transformationProvider.RollbackTransaction();
			Logger.Log.Error(exception, "InitializeHistoryObserverTable error");
			throw;
		}
		return true;
	}

	public void CheckEntityHistoryTable(string tablename)
	{
		if (transformationProvider.TableExists(tablename))
		{
			return;
		}
		transformationProvider.BeginTransaction();
		try
		{
			Table table = new Table
			{
				Sequence = false,
				Name = tablename,
				Columns = new List<Column>
				{
					new Column("Id", DbType.Int64),
					new Column("Uid", DbType.Guid),
					new Column("Object", new ColumnType(DbType.String, 70)),
					new Column("Model", new ColumnType(DbType.String, int.MaxValue)),
					new Column("ActionDate", DbType.DateTime),
					new Column("ActionTypeUid", DbType.Guid),
					new Column("CreationAuthor", DbType.Int64),
					new Column("EventArgsUid", DbType.Guid),
					new Column("SessionUid", DbType.Guid),
					new Column("UnitOfWorkUid", DbType.Guid),
					new Column("IsRelatedEvent", DbType.Boolean)
				}
			};
			transformationProvider.AddTable(table);
			transformationProvider.AddIndex(new Index
			{
				Name = "U_HISTORYOBJECT_KEY",
				TableName = tablename,
				Columns = new List<string> { "Object" }
			});
			transformationProvider.AddIndex(new Index
			{
				Name = "IX_HO_ObjUid_ObjId",
				TableName = tablename,
				Columns = new List<string> { "Object", "ActionDate", "UnitOfWorkUid" }
			});
			transformationProvider.AddIndex(new Index
			{
				Name = "IX_HO_ObjUidId_ActUid",
				TableName = tablename,
				Columns = new List<string> { "Object", "ActionTypeUid", "ActionDate" }
			});
			transformationProvider.AddIndex(new Index
			{
				Name = "IX_HO_ObjUId",
				TableName = tablename,
				Columns = new List<string> { "Object", "ActionDate" }
			});
			transformationProvider.AddIndex(new Index
			{
				Name = "IX_HO_ObjUOWUId_ActUid",
				TableName = tablename,
				Columns = new List<string> { "Object", "UnitOfWorkUid", "ActionTypeUid", "ActionDate" }
			});
			transformationProvider.AddIndex(new Index
			{
				Name = "IX_HO_UOWUid",
				TableName = tablename,
				Columns = new List<string> { "UnitOfWorkUid", "ActionDate" }
			});
			transformationProvider.AddIndex(new Index
			{
				Name = "IX_HO_ActionDate",
				TableName = tablename,
				Columns = new List<string> { "ActionDate" }
			});
			transformationProvider.AddIndex(new Index
			{
				Name = "IX_HO_Id",
				TableName = tablename,
				Columns = new List<string> { "ActionDate", "Id", "Object", "UnitOfWorkUid" }
			});
			transformationProvider.AddIndex(new Index
			{
				Name = "IX_HO_Id_IsRelated",
				TableName = tablename,
				Columns = new List<string> { "Id", "IsRelatedEvent", "Object", "UnitOfWorkUid" }
			});
			transformationProvider.AddIndex(new Index
			{
				Name = "IX_HO_Uid_IsRelated",
				TableName = tablename,
				Columns = new List<string> { "Uid", "IsRelatedEvent", "Object", "UnitOfWorkUid" }
			});
			transformationProvider.CommitTransaction();
		}
		catch (Exception exception)
		{
			transformationProvider.RollbackTransaction();
			Logger.Log.Error(exception, "InitializeHistoryTable error");
			throw;
		}
	}

	public bool DropTable(string tableName)
	{
		try
		{
			transformationProvider.RemoveTable(tableName);
		}
		catch (Exception message)
		{
			Logger.Log.Error(message);
			return false;
		}
		return true;
	}

	public bool OpenConnection()
	{
		return true;
	}

	public bool CloseConnection()
	{
		return true;
	}

	public bool CheckRepositoryStatus(IDictionary<string, string> checkSettings, out string info)
	{
		info = string.Empty;
		return true;
	}

	public bool GetRepositoryStatus()
	{
		return true;
	}

	public void InitRepository(HistoryProviderSettingsSection settingsSection)
	{
	}

	public void BulkInsertHistoryRelatedObjects(long objectId, Guid objectTypeUid, IEnumerable<KeyValuePair<long, Guid>> relatedObjects)
	{
		string format = "{0}_{1}";
		string text = string.Format(format, objectId, objectTypeUid);
		if (relatedObjects.Any())
		{
			DataTable dataTable = new DataTable("HistoryObjectObserver");
			dataTable.Columns.Add(new DataColumn("Parent", typeof(string)));
			dataTable.Columns.Add(new DataColumn("Child", typeof(string)));
			foreach (KeyValuePair<long, Guid> relatedObject in relatedObjects)
			{
				dataTable.Rows.Add(text, string.Format(format, relatedObject.Key, relatedObject.Value));
			}
			sessionProvider.GetSession(string.Empty).GetNamedQuery("HistoryObjectObserversUpsert").SetParameter("tvp", (object)dataTable, (IType)(object)transformationProviderExtension.HistoryObjectObserver)
				.CleanUpCache(cleanUpCache: false)
				.ExecuteUpdate();
		}
		else
		{
			transformationProviderExtension.InsertIfNotExists("HistoryObjectObserver", new Dictionary<string, object>
			{
				{ "Parent", text },
				{ "Child", text }
			}, isNeedInsertId: false, new string[2] { "Parent", "Child" });
		}
	}

	public IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> GetUnitOfWorks(long objectId, Guid objectTypeUid, int? maxResults, bool orderDesc, DateTime? lastActionDate, int packageIndex)
	{
		string tableName = "HistoryObject";
		string text = "pName";
		string text2 = transformationProvider.Dialect.QuoteIfNeeded("Id");
		Dictionary<string, KeyValuePair<object, IType>> dictionary = new Dictionary<string, KeyValuePair<object, IType>>();
		List<string> list = new List<string>();
		list.Add(string.Format("SELECT {0}, {1}, {2} FROM {3} WHERE {4} IN (SELECT :{5}0 UNION ALL SELECT {6} FROM {7} WHERE {8} = :{5}0 AND {6} != :{5}0)", transformationProvider.Dialect.QuoteIfNeeded("UnitOfWorkUid"), transformationProvider.Dialect.QuoteIfNeeded("ActionDate"), text2, transformationProvider.NoLockTableExpression(tableName, "ho"), transformationProvider.Dialect.QuoteIfNeeded("Object"), text, transformationProvider.Dialect.QuoteIfNeeded("Child"), transformationProvider.NoLockTableExpression("HistoryObjectObserver", "hoo"), transformationProvider.Dialect.QuoteIfNeeded("Parent")));
		dictionary.Add(text + "0", new KeyValuePair<object, IType>($"{objectId}_{objectTypeUid}", (IType)(object)NHibernateUtil.String));
		int num = 1;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(" ss.{1} {1}, max(ss.{2}) {2}, max(ss.{3}) {3} from ({0}) ss ", string.Join(" union all ", list), transformationProvider.Dialect.QuoteIfNeeded("UnitOfWorkUid"), transformationProvider.Dialect.QuoteIfNeeded("ActionDate"), text2);
		if (lastActionDate.HasValue)
		{
			stringBuilder.AppendFormat(" where ss.{3} {0} :{1}{2}", orderDesc ? "<=" : ">=", text, num, ActionDate);
			dictionary.Add(text + num++, new KeyValuePair<object, IType>(lastActionDate, (IType)(object)NHibernateUtil.DateTime));
		}
		stringBuilder.AppendFormat(" group by ss.{0} ", UnitOfWorkUid);
		FetchOptions fetchOptions = new FetchOptions();
		if (maxResults.HasValue)
		{
			fetchOptions.MaxResults = maxResults.Value;
			if (packageIndex > 0)
			{
				fetchOptions.FirstResult = packageIndex * maxResults.Value;
			}
		}
		fetchOptions.SortDirection = (orderDesc ? ListSortDirection.Descending : ListSortDirection.Ascending);
		fetchOptions.SortExpression = ActionDate;
		IQuery val = ((IQuery)(object)sessionProvider.GetSession(string.Empty).CreateSQLQuery(transformationProvider.SetupFetchOptions(stringBuilder.ToString(), fetchOptions))).CleanUpCache(cleanUpCache: false).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(RelatedEntityActionHistoryUnitOfWorkModel)));
		foreach (KeyValuePair<string, KeyValuePair<object, IType>> item in dictionary)
		{
			val.SetParameter(item.Key, item.Value.Key, item.Value.Value);
		}
		return val.List<RelatedEntityActionHistoryUnitOfWorkModel>();
	}

	public void ClearObserverTable(long objectId, Guid objectTypeUid)
	{
		string sql = string.Format("DELETE FROM {0} WHERE {1} = '{3}_{4}' OR {2} = '{3}_{4}';", "HistoryObjectObserver", transformationProvider.Dialect.QuoteIfNeeded("Parent"), transformationProvider.Dialect.QuoteIfNeeded("Child"), objectId, objectTypeUid);
		transformationProvider.ExecuteNonQuery(sql);
	}

	public IEnumerable<InverseRelatedEntityModel> ClearObserverTableByType(Guid objectTypeUid)
	{
		return sessionProvider.GetSession(string.Empty).GetNamedQuery("DeleteHistoryObserversByType").SetParameter("likeCondition", (object)$"%_{objectTypeUid}".ToLower(), (IType)(object)NHibernateUtil.String)
			.CleanUpCache(cleanUpCache: false)
			.List<string>()
			.Select(delegate(string k)
			{
				string[] array = k.Split('_');
				return new InverseRelatedEntityModel(long.Parse(array[0]), Guid.Parse(array[1]));
			});
	}

	public HistoryUpdatingStatus GetUpdatingStatus(long objectId, Guid objectTypeUid)
	{
		string sql = string.Format("SELECT COUNT(*) FROM {0} WHERE hoo.{1} = '{2}_{3}'", transformationProvider.NoLockTableExpression("HistoryObjectObserver", "hoo"), transformationProvider.Dialect.QuoteIfNeeded("Parent"), objectId, objectTypeUid);
		if (!Convert.ToBoolean(transformationProvider.ExecuteScalar(sql)))
		{
			return HistoryUpdatingStatus.NotStarted;
		}
		return HistoryUpdatingStatus.Finished;
	}

	public void CacheHistoryPart(string tableName, DataTable dataTable)
	{
		sessionProvider.GetSession(string.Empty).GetNamedQuery("HistoryObjectsUpsert").SetParameter("tableName", (object)transformationProvider.Dialect.QuoteIfNeeded(tableName), (IType)(object)NHibernateUtil.String)
			.SetParameter("tvp", (object)dataTable, (IType)(object)transformationProviderExtension.HistoryObject)
			.CleanUpCache(cleanUpCache: false)
			.ExecuteUpdate();
	}

	public IEnumerable<EntityActionEventTuple> LoadCachedHistory(long objectId, Guid objectTypeUid, IEnumerable<Guid> unitOfWorks, bool orderDesc)
	{
		string text = "pName";
		string tableName = "HistoryObject";
		string text2 = string.Format("SELECT {0}, {1}, {2} FROM {3} WHERE {4} AND {5} IN (SELECT :{6}0 UNION ALL SELECT {7} FROM {8} WHERE {9} = :{6}0 AND {7} != :{6}0) ORDER BY {10} {11}", transformationProvider.Dialect.QuoteIfNeeded("Uid"), transformationProvider.Dialect.QuoteIfNeeded("Model"), transformationProvider.Dialect.QuoteIfNeeded("IsRelatedEvent"), transformationProvider.NoLockTableExpression(tableName, "ho"), ElmaInExpression.ToString("UnitOfWorkUid", unitOfWorks.Select((Guid u) => transformationProvider.GuidQuerySintaxis(u)), DbType.Guid), transformationProvider.Dialect.QuoteIfNeeded("Object"), text, transformationProvider.Dialect.QuoteIfNeeded("Child"), transformationProvider.NoLockTableExpression("HistoryObjectObserver", "hoo"), transformationProvider.Dialect.QuoteIfNeeded("Parent"), transformationProvider.Dialect.QuoteIfNeeded("ActionDate"), orderDesc ? "DESC" : string.Empty);
		return ((IQuery)sessionProvider.GetSession(string.Empty).CreateSQLQuery(text2)).SetParameter(text + "0", (object)$"{objectId}_{objectTypeUid}", (IType)(object)NHibernateUtil.String).CleanUpCache(cleanUpCache: false).SetResultTransformer((IResultTransformer)(object)new HistoryModelResultTransformer())
			.List<EntityActionEventTuple>();
	}

	public void UpdateCachedHistoryObjects(long objectId, Guid oldObjectTypeUid, Guid newObjectTypeUid)
	{
		sessionProvider.GetSession(string.Empty).GetNamedQuery("UpdateCachedHistoryObjects").SetParameter("tableName", (object)transformationProvider.Dialect.QuoteIfNeeded("HistoryObject"), (IType)(object)NHibernateUtil.String)
			.SetParameter("oldObject", (object)$"{objectId}_{oldObjectTypeUid}", (IType)(object)NHibernateUtil.String)
			.SetParameter("newObject", (object)$"{objectId}_{newObjectTypeUid}", (IType)(object)NHibernateUtil.String)
			.ExecuteUpdate();
	}
}
