using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using NHibernate.Type;

namespace EleWise.ELMA.Common.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class EntityActionHistoryManager : EntityManager<IEntityActionHistory, long>, IEntityActionHistoryLoader
{
	private static readonly string ActionObjectId = LinqUtils.NameOf((Expression<Func<IEntityActionHistory, object>>)((IEntityActionHistory a) => a.ActionObjectId));

	private static readonly string ActionObjectUid = LinqUtils.NameOf((Expression<Func<IEntityActionHistory, object>>)((IEntityActionHistory a) => a.ActionObjectUid));

	private static readonly string UnitOfWorkUid = LinqUtils.NameOf((Expression<Func<IEntityActionHistory, object>>)((IEntityActionHistory a) => a.UnitOfWorkUid));

	private static readonly string ActionDate = LinqUtils.NameOf((Expression<Func<IEntityActionHistory, object>>)((IEntityActionHistory a) => a.ActionDate));

	private const string LoadHistoryRelatedUnitOfWorkDateTick = "LoadHistoryRelated_UnitOfWorkDateTick";

	private const string LoadHistoryRelatedPackage = "LoadHistoryRelated_Package";

	private const string LoadHistoryRelatedUnitOfWorkId = "LoadHistoryRelated_UnitOfWorkId";

	private const long sameActionTypeHistoryMaxCountDefault = 100L;

	internal const string ExtendedProperties_Id = "EntityActionHistory_Id";

	public const string ExtendedProperties_Uid = "EntityActionHistory_Uid";

	public const string ExtendedProperties_SessionUid = "EntityActionHistory_SessionUid";

	private long SameActionTypeHistoryMaxCount => SR.GetSetting("LoadHistoryRelated.MaxSameTypeActions", 100L);

	public static string LoadHistoryRelatedUnitOfWorkDateTickKey => "LoadHistoryRelated_UnitOfWorkDateTick";

	public static string LoadHistoryRelatedPackageKey => "LoadHistoryRelated_Package";

	public static string LoadHistoryRelatedUnitOfWorkIdKey => "LoadHistoryRelated_UnitOfWorkId";

	public IEntityActionHistoryEventService HistoryEventService { get; set; }

	public ITransformationProvider transformationProvider { get; set; }

	public IEntityHistoryRestrictionService entityHistoryRestrictionService { get; set; }

	public new static EntityActionHistoryManager Instance => Locator.GetServiceNotNull<EntityActionHistoryManager>();

	protected virtual ICriteria CreateCriteriaNoPermissions()
	{
		return base.Session.CreateCriteria(base.ImplementationType);
	}

	internal IList<EntityActionEventArgs> CreateFromHistoryList([NotNull] IList<IEntityActionHistory> historyList, bool withGrouping, long? id, Guid? typeUid)
	{
		if (historyList == null)
		{
			throw new ArgumentNullException("historyList");
		}
		bool selectByObject = id.HasValue && typeUid.HasValue;
		IEnumerable<IGrouping<Guid, IEntityActionHistory>> enumerable = from a in historyList
			group a by a.ActionObjectUid;
		List<EntityActionEventArgs> result = new List<EntityActionEventArgs>();
		foreach (IGrouping<Guid, IEntityActionHistory> objectType in enumerable)
		{
			Type type = null;
			try
			{
				type = base.MetadataRuntimeService.GetTypeByUid(objectType.Key);
			}
			catch (TypeNotFoundException message)
			{
				base.Logger.Error(message);
			}
			if (!(type != null))
			{
				continue;
			}
			IEntityManager manager = EntityHelper.GetEntityManager(type);
			base.SecurityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
			{
				var enumerable2 = from a in objectType
					group a by new { a.UnitOfWorkUid, a.ActionTypeUid };
				List<IEntity> list = new List<IEntity>();
				foreach (var item in enumerable2)
				{
					if (withGrouping && item.Count() > SameActionTypeHistoryMaxCount)
					{
						IEntityActionHistory actionHistory = null;
						if (selectByObject && typeUid == objectType.Key)
						{
							actionHistory = item.FirstOrDefault((IEntityActionHistory a) => a.ActionObjectId == id);
						}
						if (actionHistory == null)
						{
							actionHistory = item.FirstOrDefault();
						}
						if (actionHistory != null)
						{
							IEntity entity = list.FirstOrDefault((IEntity a) => a != null && (long?)a.GetId() == actionHistory.Id) ?? (manager.LoadOrNull(actionHistory.ActionObjectId) as IEntity);
							EntityActionEventArgs entityActionEventArgs = HistoryEventService.Create<EntityActionEventArgs>(entity, actionHistory.ActionObjectUid, actionHistory.ActionTypeUid, actionHistory.EventArgsUid);
							entityActionEventArgs.Multiple = true;
							AddActionToResult(entityActionEventArgs, result, actionHistory);
							continue;
						}
					}
					if (list.Count == 0)
					{
						list = manager.FindByIdArray(objectType.Select((IEntityActionHistory a) => a.ActionObjectId).Distinct().CastToArrayOrNull<object>()).Cast<IEntity>().ToList();
					}
					foreach (IEntityActionHistory history in item)
					{
						EntityActionEventArgs entityActionEventArgs2 = null;
						IEntityActionHistory entityActionHistory = history;
						IEntity entity2 = list.FirstOrDefault((IEntity a) => (long)a.GetId() == history.ActionObjectId);
						entityActionEventArgs2 = HistoryEventService.Create<EntityActionEventArgs>(entity2, entityActionHistory.ActionObjectUid, entityActionHistory.ActionTypeUid, entityActionHistory.EventArgsUid);
						AddActionToResult(entityActionEventArgs2, result, entityActionHistory);
					}
				}
			});
		}
		return result;
	}

	private void AddActionToResult(EntityActionEventArgs @event, List<EntityActionEventArgs> result, IEntityActionHistory actionHistory)
	{
		if (@event == null)
		{
			return;
		}
		if (@event.Action == null || @event.Object == null || (@event.Old ?? @event.New) == null)
		{
			@event = null;
			return;
		}
		@event.ActionDate = actionHistory.ActionDate;
		@event.UnitOfWorkUid = actionHistory.UnitOfWorkUid;
		@event.ActionAuthor = actionHistory.CreationAuthor;
		@event.SetAdditionalData(actionHistory.AdditionalData);
		@event.ExtendedProperties["EntityActionHistory_Id"] = actionHistory.Id;
		@event.ExtendedProperties["EntityActionHistory_Uid"] = actionHistory.Uid;
		@event.ExtendedProperties["EntityActionHistory_SessionUid"] = actionHistory.SessionUid;
		bool flag = false;
		foreach (EntityActionEventArgs item in result)
		{
			if (item.Equals(@event))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			result.Add(@event);
		}
	}

	[Auditable]
	public virtual IEntityActionHistory CreateFromEvent([NotNull] EntityActionEventArgs @event)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		if (!entityHistoryRestrictionService.IsSupported(@event.Object.Uid, @event.Action.Uid, 2))
		{
			return null;
		}
		IEntityActionHistory entityActionHistory = Create();
		entityActionHistory.SessionUid = base.Session.GetSessionImplementation().get_SessionId();
		entityActionHistory.UnitOfWorkUid = @event.UnitOfWorkUid;
		entityActionHistory.EventArgsUid = AttributeHelper<UidAttribute>.GetAttribute(@event.GetType(), inherited: false).Uid;
		entityActionHistory.ActionDate = @event.ActionDate;
		entityActionHistory.CreationAuthor = (@event.ActionAuthor as EleWise.ELMA.Security.Models.IUser) ?? base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>() ?? Locator.GetServiceNotNull<FormsAuthenticationService>().GetCurrentUserInactive<EleWise.ELMA.Security.Models.IUser>();
		entityActionHistory.ActionObjectUid = @event.Object.Uid;
		entityActionHistory.ActionTypeUid = @event.Action.Uid;
		entityActionHistory.ActionObjectId = (long?)(@event.New ?? @event.Old).GetId();
		entityActionHistory.AdditionalData = @event.GetAdditionalData();
		return entityActionHistory;
	}

	[Auditable]
	public virtual EntityActionEventArgs CreateFromHistory([NotNull] IEntityActionHistory history)
	{
		return CreateFromHistoryList(new List<IEntityActionHistory> { history }, withGrouping: true, null, null).FirstOrDefault();
	}

	[Auditable]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistory(IEntity<long> entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		return LoadHistory(InterfaceActivator.UID(entity.GetType()), entity.Id);
	}

	[Auditable]
	[Obsolete("Метод устарел и больше не используется", false)]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistoryRelated(Guid actionObject, long objectId, Guid relatedObjectType, Guid relatedActionType)
	{
		return LoadHistoryRelated(actionObject, Guid.Empty, objectId, relatedObjectType, relatedActionType, null);
	}

	[Auditable]
	[Obsolete("Метод устарел и больше не используется", false)]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistoryRelated(Guid actionObject, Guid actionType, long objectId, Guid relatedObjectType, Guid relatedActionType)
	{
		return LoadHistoryRelated(actionObject, actionType, objectId, relatedObjectType, relatedActionType, null);
	}

	[Auditable]
	[Obsolete("Метод устарел и больше не используется", false)]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistoryRelated(Guid actionObject, long objectId, IEnumerable<HistoryCollectorRelatedModel> relatedObjects)
	{
		return LoadHistoryRelated(actionObject, Guid.Empty, objectId, Guid.Empty, Guid.Empty, relatedObjects, null, null, orderDesc: false, null, 0);
	}

	[Auditable]
	[Obsolete("Метод устарел и больше не используется", false)]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistoryRelated(Guid actionObject, long objectId, IEnumerable<HistoryCollectorRelatedModel> relatedObjects, int? firstResult = null, int? maxResults = null)
	{
		return LoadHistoryRelated(actionObject, Guid.Empty, objectId, Guid.Empty, Guid.Empty, relatedObjects, firstResult, maxResults, orderDesc: false, null, 0);
	}

	[Auditable]
	[Obsolete("Метод устарел и больше не используется", false)]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistoryRelated(Guid actionObject, Guid actionType, long objectId, Guid relatedObjectType, Guid relatedActionType, IEnumerable<HistoryCollectorRelatedModel> relatedObjects, int? firstResult = null, int? maxResults = null)
	{
		return LoadHistoryRelated(actionObject, Guid.Empty, objectId, Guid.Empty, Guid.Empty, relatedObjects, firstResult, maxResults, orderDesc: false, null, 0);
	}

	[Auditable]
	[Obsolete("Метод устарел и больше не используется", false)]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistoryRelated(Guid actionObject, long objectId, IEnumerable<HistoryCollectorRelatedModel> relatedObjects, int? firstResult, int? maxResults, bool? orderDesc, long? lastActionDate, int? packageIndex)
	{
		return LoadHistoryRelated(actionObject, objectId, relatedObjects, firstResult, maxResults, orderDesc, lastActionDate, packageIndex, updatePackageInfo: false);
	}

	[Auditable]
	[Obsolete("Метод устарел и больше не используется", false)]
	internal virtual IEnumerable<EntityActionEventArgs> LoadHistoryRelated(Guid actionObject, long objectId, IEnumerable<HistoryCollectorRelatedModel> relatedObjects, int? firstResult, int? maxResults, bool? orderDesc, long? lastActionDate, int? packageIndex, bool updatePackageInfo)
	{
		DateTime? lastActionDate2 = null;
		if (lastActionDate.HasValue)
		{
			lastActionDate2 = new DateTime(lastActionDate.Value);
			if (orderDesc == true)
			{
				lastActionDate2 = lastActionDate2.Value.AddSeconds(1.0);
			}
		}
		return LoadHistoryRelated(actionObject, Guid.Empty, objectId, Guid.Empty, Guid.Empty, relatedObjects, firstResult, maxResults, orderDesc == true, lastActionDate2, packageIndex ?? 0, updatePackageInfo);
	}

	[Auditable]
	[Obsolete("Метод устарел и больше не используется", false)]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistoryRelated(Guid actionObject, Guid actionType, long objectId, Guid relatedObjectType, Guid relatedActionType, IEnumerable<HistoryCollectorRelatedModel> relatedObjects, int? firstResult, int? maxResults, bool orderDesc, DateTime? lastActionDate, int packageIndex)
	{
		return LoadHistoryRelated(actionObject, actionType, objectId, relatedObjectType, relatedActionType, relatedObjects, firstResult, maxResults, orderDesc, lastActionDate, packageIndex, updatePackageInfo: false);
	}

	[Obsolete("Метод устарел и больше не используется", false)]
	private IEnumerable<EntityActionEventArgs> LoadHistoryRelated(Guid actionObject, Guid actionType, long objectId, Guid relatedObjectType, Guid relatedActionType, IEnumerable<HistoryCollectorRelatedModel> relatedObjects, int? firstResult, int? maxResults, bool orderDesc, DateTime? lastActionDate, int packageIndex, bool updatePackageInfo)
	{
		IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> nextUnitOfWorks = GetNextUnitOfWorks(actionObject, objectId, relatedObjects, firstResult, maxResults, orderDesc, lastActionDate, updatePackageInfo, packageIndex);
		return LoadHistoryRelated(nextUnitOfWorks);
	}

	[Auditable]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistoryRelated(IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> unitOfWorks)
	{
		return LoadActionHistory(unitOfWorks, null, null);
	}

	[Auditable]
	public virtual IEnumerable<EntityActionEventArgs> LoadActionHistory(IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> unitOfWorks, long? id, Guid? typeUid)
	{
		List<IEntityActionHistory> list = new List<IEntityActionHistory>();
		if (unitOfWorks.Any())
		{
			list = (from e in CreateCriteria().Add((ICriterion)(object)Restrictions.In(LinqUtils.NameOf((Expression<Func<IEntityActionHistory, object>>)((IEntityActionHistory h) => h.UnitOfWorkUid)), (ICollection)unitOfWorks.Select((RelatedEntityActionHistoryUnitOfWorkModel a) => a.UnitOfWorkUid).ToArray())).SetCacheable(false).List<IEntityActionHistory>()
				where e != null
				select e).ToList();
			foreach (IGrouping<Guid, IEntityActionHistory> item in from a in list
				group a by a.UnitOfWorkUid)
			{
				IGrouping<Guid, IEntityActionHistory> historyItemLocal = item;
				RelatedEntityActionHistoryUnitOfWorkModel relatedEntityActionHistoryUnitOfWorkModel = unitOfWorks.FirstOrDefault((RelatedEntityActionHistoryUnitOfWorkModel a) => a.UnitOfWorkUid == historyItemLocal.Key);
				if (relatedEntityActionHistoryUnitOfWorkModel == null)
				{
					continue;
				}
				foreach (IEntityActionHistory item2 in historyItemLocal)
				{
					item2.ActionDate = relatedEntityActionHistoryUnitOfWorkModel.ActionDate;
				}
			}
		}
		return from e in CreateFromHistoryList(list, withGrouping: true, id, typeUid)
			orderby e.ActionDate
			select e;
	}

	public virtual IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> GetNextUnitOfWorks(Guid actionObject, long objectId, IEnumerable<HistoryCollectorRelatedModel> relatedObjects, int? firstResult, int? maxResults, bool? orderDesc, long? lastActionDate, int? packageIndex)
	{
		return GetNextUnitOfWorks(actionObject, objectId, relatedObjects, (long?)firstResult, maxResults, orderDesc, lastActionDate, packageIndex);
	}

	internal IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> GetNextUnitOfWorks(Guid actionObject, long objectId, IEnumerable<HistoryCollectorRelatedModel> relatedObjects, long? firstResult, int? maxResults, bool? orderDesc, long? lastActionDate, int? packageIndex)
	{
		DateTime? lastActionDate2 = null;
		if (lastActionDate.HasValue)
		{
			lastActionDate2 = new DateTime(lastActionDate.Value);
			lastActionDate2 = ((orderDesc != true) ? new DateTime?(lastActionDate2.Value.AddSeconds(-1.0)) : new DateTime?(lastActionDate2.Value.AddSeconds(1.0)));
		}
		return GetNextUnitOfWorks(actionObject, objectId, relatedObjects, firstResult, maxResults, orderDesc == true, lastActionDate2, updatePackageInfo: true, packageIndex ?? 0);
	}

	internal IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> GetNextUnitOfWorks(Guid actionObject, long objectId, IEnumerable<HistoryCollectorRelatedModel> relatedObjects, long? firstResult, int? maxResults, bool orderDesc, DateTime? lastActionDate, bool updatePackageInfo, int packageIndex = 0, bool disableApplicationServerFilter = false)
	{
		IList<RelatedEntityActionHistoryUnitOfWorkModel> unitOfWorks = GetUnitOfWorks(actionObject, objectId, relatedObjects, maxResults, orderDesc, lastActionDate, packageIndex);
		if (!firstResult.HasValue || disableApplicationServerFilter || unitOfWorks.Count == 0)
		{
			return unitOfWorks;
		}
		bool flag = false;
		List<RelatedEntityActionHistoryUnitOfWorkModel> list = new List<RelatedEntityActionHistoryUnitOfWorkModel>();
		foreach (RelatedEntityActionHistoryUnitOfWorkModel item in unitOfWorks)
		{
			if (flag)
			{
				list.Add(item);
			}
			if (item.Id == firstResult)
			{
				flag = true;
			}
		}
		if (list.Any() || unitOfWorks.Count < maxResults)
		{
			return list;
		}
		return GetNextUnitOfWorks(actionObject, objectId, relatedObjects, firstResult, maxResults, orderDesc, lastActionDate, updatePackageInfo, packageIndex + 1, flag);
	}

	internal IList<RelatedEntityActionHistoryUnitOfWorkModel> GetUnitOfWorks(Guid actionObject, long objectId, IEnumerable<HistoryCollectorRelatedModel> relatedObjects, int? maxResults, bool orderDesc, DateTime? lastActionDate, int packageIndex)
	{
		string text = "pName";
		string text2 = transformationProvider.Dialect.QuoteIfNeeded("Id");
		Dictionary<string, KeyValuePair<object, IType>> dictionary = new Dictionary<string, KeyValuePair<object, IType>>();
		List<string> list = new List<string>();
		list.Add(string.Format("select {0}, {1}, {2} from {3} where {4} = :{5}0 and {6} = :{5}1", UnitOfWorkUid, ActionDate, text2, transformationProvider.NoLockTableExpression("EntityActionHistory", "eah"), ActionObjectUid, text, ActionObjectId));
		dictionary.Add(text + "0", new KeyValuePair<object, IType>(actionObject, (IType)(object)NHibernateUtil.Guid));
		dictionary.Add(text + "1", new KeyValuePair<object, IType>(objectId, (IType)(object)NHibernateUtil.Int64));
		int num = 2;
		if (relatedObjects != null && relatedObjects.Any())
		{
			foreach (IGrouping<Guid, HistoryCollectorRelatedModel> item in from a in relatedObjects
				group a by a.EntityTypeUid)
			{
				list.Add(string.Format("select {0}, {1}, {2} \r\n  from {3} where {4} = :{5}{6} and {7} in (select cast(val as {8}) as {2} from {9})", UnitOfWorkUid, ActionDate, text2, transformationProvider.NoLockTableExpression("EntityActionHistory", "eah"), ActionObjectUid, text, num, ActionObjectId, transformationProvider.Dialect.GetTypeName(DbType.Int64), transformationProvider.TableFunction("SplitString", $":{text}{num + 1}, ','")));
				dictionary.Add(text + num++, new KeyValuePair<object, IType>(item.Key, (IType)(object)NHibernateUtil.Guid));
				dictionary.Add(text + num++, new KeyValuePair<object, IType>(string.Join(",", item.Select((HistoryCollectorRelatedModel a) => a.EntityId)), (IType)(object)NHibernateUtil.StringClob));
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(" ss.{1} {1}, max(ss.{2}) {2}, max(ss.{3}) {3} from ({0}) ss ", string.Join(" union all ", list), UnitOfWorkUid, ActionDate, text2);
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
		IQuery val = ((IQuery)(object)base.SessionProvider.GetSession(string.Empty).CreateSQLQuery(transformationProvider.SetupFetchOptions(stringBuilder.ToString(), fetchOptions))).CleanUpCache(cleanUpCache: false).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(RelatedEntityActionHistoryUnitOfWorkModel)));
		foreach (KeyValuePair<string, KeyValuePair<object, IType>> item2 in dictionary)
		{
			val.SetParameter(item2.Key, item2.Value.Key, item2.Value.Value);
		}
		return val.List<RelatedEntityActionHistoryUnitOfWorkModel>();
	}

	[Auditable]
	public virtual IEnumerable<EntityLastActionInfo> LoadLastEntityActionHistaryList(EleWise.ELMA.Security.Models.IUser creationAuthor, DateTime? from, DateTime? to, List<Guid> actionObjectUids, FetchOptions fetchOptions)
	{
		string text = LoadLastEntityActionHistaryQuery(creationAuthor, from, to, actionObjectUids, out var parameters);
		text = string.Format(" {0}, {1}, {2} FROM ({3}) {4}", transformationProvider.Dialect.QuoteIfNeeded("ActionDate"), transformationProvider.Dialect.QuoteIfNeeded("ObjectId"), transformationProvider.Dialect.QuoteIfNeeded("ObjectUid"), text, transformationProvider.Dialect.QuoteIfNeeded("t"));
		text = transformationProvider.SetupFetchOptions(text, fetchOptions);
		List<EntityLastActionInfo> list = new List<EntityLastActionInfo>();
		using IDataReader dataReader = transformationProvider.ExecuteQuery(text, parameters);
		while (dataReader.Read())
		{
			list.Add(new EntityLastActionInfo
			{
				ActionDate = (DateTime)dataReader["ActionDate"],
				ObjectId = Convert.ToInt64(dataReader["ObjectId"]),
				ObjectUid = transformationProvider.Dialect.GetGuid(dataReader["ObjectUid"])
			});
		}
		return list;
	}

	[Auditable]
	public virtual long LoadLastEntityActionHistaryCount(EleWise.ELMA.Security.Models.IUser creationAuthor, DateTime? from, DateTime? to, List<Guid> actionObjectUids)
	{
		string query = LoadLastEntityActionHistaryQuery(creationAuthor, from, to, actionObjectUids, out var parameters);
		query = transformationProvider.Count(query);
		return Convert.ToInt64(transformationProvider.ExecuteScalar(query, parameters));
	}

	private static string LoadLastEntityActionHistaryQuery(EleWise.ELMA.Security.Models.IUser creationAuthor, DateTime? from, DateTime? to, List<Guid> actionObjectUids, out Dictionary<string, object> parameters)
	{
		ITransformationProvider transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
		string text = string.Format("\r\nSELECT\r\n    MAX({0}) {1},\r\n    {2} {3},\r\n    {4} {5}\r\nFROM {6}", transformationProvider.Dialect.QuoteIfNeeded("ActionDate"), transformationProvider.Dialect.QuoteIfNeeded("ActionDate"), transformationProvider.Dialect.QuoteIfNeeded("ActionObjectId"), transformationProvider.Dialect.QuoteIfNeeded("ObjectId"), transformationProvider.Dialect.QuoteIfNeeded("ActionObjectUid"), transformationProvider.Dialect.QuoteIfNeeded("ObjectUid"), transformationProvider.Dialect.QuoteIfNeeded("EntityActionHistory"));
		parameters = new Dictionary<string, object>();
		string text2 = string.Format(" WHERE ({0} = {1})", transformationProvider.Dialect.QuoteIfNeeded("CreationAuthor"), creationAuthor.Id);
		if (actionObjectUids != null && actionObjectUids.Count > 0)
		{
			text2 += " AND";
			List<string> list = new List<string>();
			for (int i = 0; i < actionObjectUids.Count; i++)
			{
				string text3 = $"uid{i}";
				list.Add(text3);
				parameters.Add(text3, actionObjectUids[i]);
			}
			text2 += string.Format(" ({0} IN ({1}))", transformationProvider.Dialect.QuoteIfNeeded("ActionObjectUid"), string.Join(",", list.Select((string u) => transformationProvider.ParameterSeparator + u).ToArray()));
		}
		if (from.HasValue)
		{
			text2 += " AND";
			parameters.Add("fromActionDate", from.Value);
			text2 += string.Format(" ({0} >= {1}{2})", transformationProvider.Dialect.QuoteIfNeeded("ActionDate"), transformationProvider.ParameterSeparator, "fromActionDate");
		}
		if (to.HasValue)
		{
			text2 += " AND";
			parameters.Add("toActionDate", to.Value.AddDays(1.0));
			text2 += string.Format(" ({0} < {1}{2})", transformationProvider.Dialect.QuoteIfNeeded("ActionDate"), transformationProvider.ParameterSeparator, "toActionDate");
		}
		return text + text2 + string.Format(" group by {0}, {1}", transformationProvider.Dialect.QuoteIfNeeded("ActionObjectId"), transformationProvider.Dialect.QuoteIfNeeded("ActionObjectUid"));
	}

	[Auditable]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistory(Guid actionObject, long? objectId, Guid? actionType = null)
	{
		return LoadHistory(Guid.Empty, actionObject, actionType ?? Guid.Empty, objectId);
	}

	[Auditable]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid, Guid actionObject)
	{
		return LoadHistory(unitOfWorkUid, Guid.Empty, actionObject);
	}

	[Auditable]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid, Guid actionObject, Guid actionTypeUid)
	{
		return LoadHistory(unitOfWorkUid, actionObject, actionTypeUid, null);
	}

	[Auditable]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid, Guid actionObject, Guid actionTypeUid, long? objectId)
	{
		return LoadHistory(unitOfWorkUid, actionObject, actionTypeUid, objectId, withGrouping: false);
	}

	[Auditable]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid, Guid actionObject, Guid actionTypeUid, long? objectId, bool withGrouping)
	{
		ICriteria val = CreateCriteria();
		if (!unitOfWorkUid.Equals(Guid.Empty))
		{
			val.Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)ProjectionFor((IEntityActionHistory h) => h.UnitOfWorkUid), (object)unitOfWorkUid));
		}
		if (!actionTypeUid.Equals(Guid.Empty))
		{
			val.Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)ProjectionFor((IEntityActionHistory h) => h.ActionTypeUid), (object)actionTypeUid));
		}
		if (!actionObject.Equals(Guid.Empty))
		{
			val.Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)ProjectionFor((IEntityActionHistory h) => h.ActionObjectUid), (object)actionObject));
		}
		if (objectId.HasValue)
		{
			val.Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)ProjectionFor((IEntityActionHistory h) => h.ActionObjectId), (object)objectId));
		}
		return from e in CreateFromHistoryList((from e in val.AddOrder(Order.Desc((IProjection)(object)ProjectionFor((IEntityActionHistory h) => h.ActionDate))).SetCacheable(true).List<IEntityActionHistory>()
				where e != null
				select e).ToList(), withGrouping, null, null)
			orderby e.ActionDate
			select e;
	}

	[Auditable]
	public virtual IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid)
	{
		return LoadHistory(unitOfWorkUid, Guid.Empty, Guid.Empty);
	}

	[PublicApiMember]
	public override void Save([NotNull] IEntityActionHistory obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (!obj.IsNew())
		{
			throw new InvalidOperationException(SR.T("Невозможно обновление истории активности объекта. Тип {0}, Ид = {1}", obj.GetType().FullName, obj.GetId()));
		}
		base.Save(obj);
	}

	public override void Delete(IEntityActionHistory obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		throw new InvalidOperationException(SR.T("Невозможно удаление истории активности объекта. Тип {0}, Ид = {1}", obj.GetType().FullName, obj.GetId()));
	}

	public override void Delete(string query)
	{
		throw new InvalidOperationException(SR.T("Невозможно удаление истории активности объекта. Запрос = {0}", query));
	}

	public override void DeleteAll()
	{
		throw new InvalidOperationException(SR.T("Невозможно удаление истории активности объекта."));
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		if (filter is IEntityActionHistoryFilter entityActionHistoryFilter && entityActionHistoryFilter.ActionObjectUid.HasValue && filter.FilterByHierarchyParent)
		{
			Guid value = entityActionHistoryFilter.ActionObjectUid.Value;
			entityActionHistoryFilter.ActionObjectUid = null;
			entityActionHistoryFilter.FilterByHierarchyParent = false;
			base.SetupFilter(criteria, (IEntityFilter)entityActionHistoryFilter);
			if (MetadataLoader.LoadMetadata(value) is ClassMetadata classMetadata)
			{
				Guid[] array = (from c in MetadataLoader.GetChildClasses(classMetadata)
					select c.Uid).Union(new Guid[1] { classMetadata.Uid }).ToArray();
				criteria.Add((ICriterion)(object)Restrictions.In((IProjection)(object)ProjectionFor((IEntityActionHistory h) => h.ActionObjectUid), (ICollection)array));
			}
		}
		else
		{
			base.SetupFilter(criteria, filter);
		}
	}

	public ICriteria GetUpdateHistoryInSameUnitOfWorkWithType(long id, Guid actionObject, Guid targetType, Guid actionType)
	{
		ICriteria val = CreateCriteria();
		string sql = string.Format("{{{0}.{1}}} in (select hist.{1} from (select {1}, {2} from {3} where {4} =? and {5} =? ) tmp join {3} hist on hist.{2} = tmp.{2} where hist.{5} =? and hist.{6} =? )", val.get_Alias(), transformationProvider.Dialect.QuoteIfNeeded("Id"), transformationProvider.Dialect.QuoteIfNeeded("UnitOfWorkUid"), transformationProvider.Dialect.QuoteIfNeeded("EntityActionHistory"), transformationProvider.Dialect.QuoteIfNeeded("ActionObjectId"), transformationProvider.Dialect.QuoteIfNeeded("ActionObjectUid"), transformationProvider.Dialect.QuoteIfNeeded("ActionTypeUid"));
		return val.Add((ICriterion)(object)NHQueryExtensions.Sql(sql, new object[4] { id, actionObject, targetType, actionType }, (IType[])(object)new IType[4]
		{
			(IType)NHibernateUtil.Int64,
			(IType)NHibernateUtil.Guid,
			(IType)NHibernateUtil.Guid,
			(IType)NHibernateUtil.Guid
		}));
	}
}
