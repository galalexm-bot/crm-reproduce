using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Events.Audit;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Audit;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.ExtensionPoints.WorkLog;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Impl;
using NHibernate.Type;

namespace EleWise.ELMA.Tasks.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class WorkLogItemManager : EntityManager<IWorkLogItem, long>
{
	private const string IsAutomaticSendKey = "EleWise.ELMA.Task.WorkLogItem.AutomaticSend";

	private readonly IUnitOfWorkManager unitOfWorkManager;

	private readonly UserManager userManager;

	private IAuditEventProvider auditEventProvider;

	private static readonly ConcurrentDictionary<int, EntityActionsMetadata> LoadedDefaultActions = new ConcurrentDictionary<int, EntityActionsMetadata>();

	private IAuditEventProvider AuditEventProvider => auditEventProvider ?? (auditEventProvider = Locator.GetServiceNotNull<IAuditEventProvider>());

	public new static WorkLogItemManager Instance => Locator.GetServiceNotNull<WorkLogItemManager>();

	public ITransformationProvider TransformationProvider { get; set; }

	protected EleWise.ELMA.Security.Models.IUser CurrentUser => base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

	[NotNull]
	public ICommentActionHandler CommentActionHandler { get; set; }

	public WorkLogItemManager(IUnitOfWorkManager unitOfWorkManager, UserManager userManager)
	{
		this.unitOfWorkManager = unitOfWorkManager;
		this.userManager = userManager;
	}

	protected static WorkLogSettings Settings()
	{
		return Locator.GetServiceNotNull<WorkLogSettingsModule>().Settings;
	}

	public long LoadObjectCount(IWorkLogObjectSearchFilter filter)
	{
		ISQLQuery val = new WorkLogItemSearchQueryBuilder(base.Session, filter, new WorkLogCountSearchProvider()).CreateObjectQuery<WorkLogObjectCountModel>();
		if (val == null)
		{
			return 0L;
		}
		return Convert.ToInt64(((IQuery)val).UniqueResult<WorkLogObjectCountModel>().RowsCount);
	}

	public List<IEntity<long>> LoadObjectList(IWorkLogObjectSearchFilter filter, FetchOptions fetchOptions)
	{
		ISQLQuery val = new WorkLogItemSearchQueryBuilder(base.Session, filter, new WorkLogObjectListSearchProvider(fetchOptions)).CreateObjectQuery<WorkLogObjectModel>();
		if (val == null)
		{
			return new List<IEntity<long>>();
		}
		return (from m in ((IQuery)val).List<WorkLogObjectModel>()
			select (IEntity<long>)WorkLogExtensionHelper.LoadObject(Convert.ToInt64(m.ObjectId), new Guid(m.ObjectUid))).ToList();
	}

	public long LoadLastWorkLogItemObjectCount(EleWise.ELMA.Security.Models.IUser creationAuthor, List<Guid> actionObjectUids)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string query = LoadLastWorkLogItemObjectQuery(creationAuthor, actionObjectUids, out var parameters);
		query = serviceNotNull.Count(query);
		return Convert.ToInt64(serviceNotNull.ExecuteScalar(query, parameters));
	}

	public IEnumerable<EntityLastActionInfo> LoadLastWorkLogItemObjectList(EleWise.ELMA.Security.Models.IUser creationAuthor, List<Guid> actionObjectUids, FetchOptions fetchOptions)
	{
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		string text = LoadLastWorkLogItemObjectQuery(creationAuthor, actionObjectUids, out var parameters);
		text = string.Format(" {0}, {1}, {2} FROM ({3}) {4}", serviceNotNull.Dialect.QuoteIfNeeded("CreationDate"), serviceNotNull.Dialect.QuoteIfNeeded("ObjectId"), serviceNotNull.Dialect.QuoteIfNeeded("ObjectUID"), text, serviceNotNull.Dialect.QuoteIfNeeded("t"));
		text = serviceNotNull.SetupFetchOptions(text, fetchOptions);
		List<EntityLastActionInfo> list = new List<EntityLastActionInfo>();
		using IDataReader dataReader = serviceNotNull.ExecuteQuery(text, parameters);
		while (dataReader.Read())
		{
			list.Add(new EntityLastActionInfo
			{
				ActionDate = (DateTime)dataReader["CreationDate"],
				ObjectId = Convert.ToInt64(dataReader["ObjectId"]),
				ObjectUid = serviceNotNull.Dialect.GetGuid(dataReader["ObjectUID"])
			});
		}
		return list;
	}

	public virtual List<WorkLogItemModel> LoadWorkLogItemModelList(IWorkLogItemFilter filter, FetchOptions fetchOptions = null)
	{
		return (from w in Find(filter, fetchOptions)
			group w by w.ObjectUID).SelectMany(delegate(IGrouping<Guid, IWorkLogItem> g)
		{
			Type typeByUidOrNull = base.MetadataRuntimeService.GetTypeByUidOrNull(g.Key);
			List<IEntity> objects = null;
			if (typeByUidOrNull != null)
			{
				IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUidOrNull);
				objects = entityManager.FindByIdArray(((IEnumerable<IWorkLogItem>)g).Select((Func<IWorkLogItem, object>)((IWorkLogItem w) => w.ObjectId)).ToArray()).Cast<IEntity>().ToList();
			}
			return g.Select((IWorkLogItem w) => new WorkLogItemModel
			{
				WorkLogItem = w,
				WorkLogObject = ((objects != null) ? objects.FirstOrDefault((IEntity o) => w.ObjectId.Equals(o.GetId())) : null)
			});
		}).ToList();
	}

	private static string LoadLastWorkLogItemObjectQuery(EleWise.ELMA.Security.Models.IUser creationAuthor, List<Guid> actionObjectUids, out Dictionary<string, object> parameters)
	{
		DateTime dateTime = DateTime.Now.AddDays(-30.0);
		DateTime now = DateTime.Now;
		ITransformationProvider transformationProvider = Locator.GetServiceNotNull<ITransformationProvider>();
		string text = string.Format("\r\nSELECT\r\n    Max({0}) {0}, {1} {1}, {2} {2}\r\nFROM {3}", transformationProvider.Dialect.QuoteIfNeeded("CreationDate"), transformationProvider.Dialect.QuoteIfNeeded("ObjectId"), transformationProvider.Dialect.QuoteIfNeeded("ObjectUID"), transformationProvider.Dialect.QuoteIfNeeded("WorkLogItem"));
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
			text2 += string.Format(" ({0} IN ({1}))", transformationProvider.Dialect.QuoteIfNeeded("ObjectUID"), string.Join(",", list.Select((string u) => transformationProvider.ParameterSeparator + u).ToArray()));
		}
		text2 += " AND";
		string text4 = "fromActionDate";
		parameters.Add(text4, dateTime);
		text2 += string.Format(" ({0} >= {1}{2})", transformationProvider.Dialect.QuoteIfNeeded("CreationDate"), transformationProvider.ParameterSeparator, text4);
		text2 += " AND";
		string text5 = "toActionDate";
		parameters.Add(text5, now.AddDays(1.0));
		text2 += string.Format(" ({0} < {1}{2})", transformationProvider.Dialect.QuoteIfNeeded("CreationDate"), transformationProvider.ParameterSeparator, text5);
		return text + text2 + string.Format(" group by {0}, {1}", transformationProvider.Dialect.QuoteIfNeeded("ObjectId"), transformationProvider.Dialect.QuoteIfNeeded("ObjectUID"));
	}

	public long LoadWorkLogItemCount(IWorkLogObjectSearchFilter filter)
	{
		ISQLQuery val = new WorkLogItemSearchQueryBuilder(base.Session, filter, new WorkLogItemCountSearchProvider()).CreateObjectQuery<WorkLogObjectCountModel>(isObjectSearch: false);
		if (val == null)
		{
			return 0L;
		}
		return Convert.ToInt64(((IQuery)val).UniqueResult<WorkLogObjectCountModel>().RowsCount);
	}

	public virtual List<IWorkLogItem> LoadWorkLogItemList(IWorkLogObjectSearchFilter filter, FetchOptions fetchOptions = null)
	{
		ICriteria val = CreateWorkLogItemCriteria(filter, fetchOptions);
		if (val == null)
		{
			return new List<IWorkLogItem>();
		}
		return val.List<IWorkLogItem>().ToList();
	}

	public virtual Dictionary<TKey, WorkTime> LoadWorkLogItemsSumGroupBy<TKey>(Expression<Func<IWorkLogItem, TKey>> expression, IWorkLogObjectSearchFilter filter, FetchOptions fetchOptions = null)
	{
		ICriteria val = CreateWorkLogItemCriteria(filter, fetchOptions);
		if (val == null)
		{
			return new Dictionary<TKey, WorkTime>();
		}
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)ProjectionsExtensions.Group(expression)).Add(CreateWorkLogItemsSumProjection()) });
		return val.List<object[]>().ToDictionary((object[] k) => (TKey)k[0], (object[] v) => (WorkTime)v[1]);
	}

	public virtual List<WorkLogItemsWeeklyActivityInfo> LoadWorkLogItemsSumGroupByWeekActivity(IWorkLogObjectSearchFilter filter, FetchOptions fetchOptions = null)
	{
		ICriteria val = CreateWorkLogItemCriteria(filter, fetchOptions);
		if (val == null)
		{
			return new List<WorkLogItemsWeeklyActivityInfo>();
		}
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Group<IWorkLogItem>((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem w) => w.WorkLogActivity))).Add((IProjection)(object)Projections.Group<IWorkLogItem>((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem w) => w.Date)))
			.Add(CreateWorkLogItemsSumProjection()) });
		return (from o in val.List<object[]>()
			select new
			{
				Activity = (IWorkLogActivity)o[0],
				Date = WorkLogHelper.StartDateOfWeek((DateTime)o[1]),
				Sum = (WorkTime)o[2]
			} into o
			group o by new { o.Date, o.Activity } into g
			select new WorkLogItemsWeeklyActivityInfo
			{
				Week = new DateTimeRange(g.Key.Date, g.Key.Date.AddDays(7.0).AddSeconds(-1.0)),
				Activity = g.Key.Activity,
				TotalWorkTime = g.Sum(w => w.Sum)
			}).ToList();
	}

	private IProjection CreateWorkLogItemsSumProjection()
	{
		return (IProjection)(object)Projections.Sum(Projections.Conditional((ICriterion)(object)Restrictions.Eq((IProjection)(object)Projections.Property<IWorkLogItem>((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem w) => w.Status)), (object)WorkLogItemStatus.Confirm), (IProjection)(object)Projections.Property<IWorkLogItem>((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem x) => x.ApprovalWorkTime)), (IProjection)(object)Projections.Property<IWorkLogItem>((Expression<Func<IWorkLogItem, object>>)((IWorkLogItem x) => x.FactWorkTime))));
	}

	public virtual bool CanView(IWorkLogItem workLogItem)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = CurrentUser;
		if (workLogItem.CreationAuthor.Id == currentUser.Id)
		{
			return true;
		}
		if (workLogItem.Harmonizator.Id == currentUser.Id)
		{
			return true;
		}
		if (userManager.IsSubordinateUser(currentUser, workLogItem.CreationAuthor))
		{
			return true;
		}
		if (base.SecurityService.HasPermission(PermissionProvider.AdminWorklogPermission))
		{
			return true;
		}
		return false;
	}

	public virtual bool CanEdit(IWorkLogItem workLogItem)
	{
		if (workLogItem.IsDeleted)
		{
			return false;
		}
		if (workLogItem.Status == WorkLogItemStatus.Confirm || workLogItem.Status == WorkLogItemStatus.Unconfirm)
		{
			return false;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = CurrentUser;
		if (workLogItem.CreationAuthor.Id == currentUser.Id)
		{
			return true;
		}
		if (userManager.IsSubordinateUser(currentUser, workLogItem.CreationAuthor))
		{
			return true;
		}
		if (base.SecurityService.HasPermission(PermissionProvider.AdminWorklogPermission))
		{
			return true;
		}
		return false;
	}

	public virtual bool CanSaveDraft(IWorkLogItem workLogItem)
	{
		if (workLogItem.Status != WorkLogItemStatus.Draft)
		{
			return false;
		}
		if (workLogItem.CreationAuthor.Id != CurrentUser.Id)
		{
			return false;
		}
		return true;
	}

	public virtual bool CanReAssign(IWorkLogItem workLogItem)
	{
		return IsCanReAssign(workLogItem, null, null);
	}

	[ActionCheck("823cc9ce-1ca4-4ee2-a7a0-872054d4f986")]
	protected virtual bool IsCanReAssign(IWorkLogItem workLogItem, EleWise.ELMA.Security.Models.IUser harmonizator, ICommentActionModel actionModel)
	{
		if (workLogItem.Status != WorkLogItemStatus.New)
		{
			return false;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = CurrentUser;
		if (workLogItem.CreationAuthor.Id == currentUser.Id)
		{
			return true;
		}
		if (workLogItem.Harmonizator.Id == currentUser.Id)
		{
			return true;
		}
		if (userManager.IsSubordinateUser(currentUser, workLogItem.CreationAuthor))
		{
			return true;
		}
		if (base.SecurityService.HasPermission(PermissionProvider.AdminWorklogPermission))
		{
			return true;
		}
		return false;
	}

	public virtual bool CanChangeStatus(IWorkLogItem workLogItem, WorkLogItemStatus status)
	{
		return IsCanChangeStatus(workLogItem, status);
	}

	[ActionCheck("e71c3a9e-e121-4c1b-a7b7-93e90eac242d")]
	protected virtual bool IsCanChangeStatus(IWorkLogItem workLogItem, WorkLogItemStatus status)
	{
		if (workLogItem.Status == status)
		{
			return false;
		}
		if (workLogItem.Status != WorkLogItemStatus.Confirm && workLogItem.Status != WorkLogItemStatus.Unconfirm)
		{
			return false;
		}
		if (!base.SecurityService.HasPermission(PermissionProvider.AdminWorklogPermission))
		{
			return false;
		}
		return true;
	}

	public new virtual bool CanDelete(IWorkLogItem workLogItem)
	{
		if (workLogItem.Status == WorkLogItemStatus.Confirm || workLogItem.Status == WorkLogItemStatus.Unconfirm)
		{
			return false;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = CurrentUser;
		if (workLogItem.CreationAuthor.Id == currentUser.Id)
		{
			return true;
		}
		if (userManager.IsSubordinateUser(currentUser, workLogItem.CreationAuthor))
		{
			return true;
		}
		if (base.SecurityService.HasPermission(PermissionProvider.AdminWorklogPermission))
		{
			return true;
		}
		return false;
	}

	public virtual bool CanAutoApproveMyWorklog()
	{
		return base.SecurityService.HasPermission(PermissionProvider.AutoApproveMyWorklogPermission);
	}

	public virtual bool CanApprove(IWorkLogItem workLogItem)
	{
		if (workLogItem.Status != WorkLogItemStatus.New)
		{
			return false;
		}
		if (GetValueIsAutomaticSend())
		{
			return true;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = CurrentUser;
		if (workLogItem.Harmonizator.Id == currentUser.Id)
		{
			return true;
		}
		return false;
	}

	protected void RaiseActionEvent(IWorkLogItem old, IWorkLogItem @new, string actionUidStr)
	{
		RaiseCommentActionEvent(old, @new, actionUidStr, null);
	}

	protected void RaiseActionEvent(IWorkLogItem old, IWorkLogItem @new, string actionUidStr, Action<EntityActionEventArgs> evArgsFunc)
	{
		RaiseCommentActionEvent(old, @new, actionUidStr, null, evArgsFunc);
	}

	protected void RaiseCommentActionEvent(IWorkLogItem old, IWorkLogItem @new, string actionUidStr, ICommentActionModel actionModel)
	{
		RaiseCommentActionEvent(old, @new, actionUidStr, actionModel, null);
	}

	protected void RaiseCommentActionEvent(IWorkLogItem old, IWorkLogItem @new, string actionUidStr, ICommentActionModel actionModel, Action<EntityActionEventArgs> evArgsFunc)
	{
		EntityActionEventArgs entityActionEventArgs = TryCreateCommentActionEventArgs(old, @new, actionUidStr, actionModel);
		evArgsFunc?.Invoke(entityActionEventArgs);
		base.ActionHandler.ActionExecuted(entityActionEventArgs);
	}

	[Auditable]
	protected virtual EntityActionEventArgs TryCreateCommentActionEventArgs(IWorkLogItem old, IWorkLogItem @new, string actionUidStr, ICommentActionModel actionModel)
	{
		WorkLogItemActionEventArgs workLogItemActionEventArgs = WorkLogItemActionEventArgs.TryCreate(old, @new, new Guid(actionUidStr), new List<WorkLogItemInfo>());
		if (workLogItemActionEventArgs != null && actionModel != null)
		{
			workLogItemActionEventArgs.Infos.Add(new WorkLogItemInfo
			{
				Comment = actionModel.Comment.Text
			});
			CommentActionHandler.ProcessEventArgs(workLogItemActionEventArgs, actionModel);
		}
		return workLogItemActionEventArgs;
	}

	public bool CanCreateWorkLogForObjectType(Guid typUid)
	{
		return WorkLogExtensionHelper.FindExtensionByObjectUid(typUid, enabled: true) != null;
	}

	public virtual List<WorkLogReportObject> WorkLogReportObjectsTree()
	{
		List<WorkLogReportObject> result = new List<WorkLogReportObject>();
		foreach (Guid item in WorkLogExtensionHelper.ObjectsUidEnabledList())
		{
			Type entityType = ModelHelper.GetEntityType(item);
			string text = ((InterfaceActivator.LoadMetadata(entityType) is ClassMetadata classMetadata) ? classMetadata.DisplayName : "");
			if (!string.IsNullOrEmpty(text))
			{
				result.Add(new WorkLogReportObject
				{
					ObjectTypeUid = item,
					ObjectTypeName = text,
					ObjectType = entityType,
					Items = new List<WorkLogReportObject>()
				});
			}
		}
		foreach (WorkLogReportObject item2 in result)
		{
			Guid baseClassUid = GetChildBasesClassesUids(item2.ObjectTypeUid).FirstOrDefault((Guid u) => result.Any((WorkLogReportObject w) => w.ObjectTypeUid == u));
			WorkLogReportObject workLogReportObject = result.FirstOrDefault((WorkLogReportObject w) => w.ObjectTypeUid == baseClassUid);
			if (workLogReportObject != null)
			{
				item2.Parent = workLogReportObject;
				workLogReportObject.Items.Add(item2);
			}
		}
		return result;
	}

	private static List<Guid> GetChildBasesClassesUids(Guid entityTypeUid)
	{
		return (from m in MetadataLoader.GetBaseClasses(InterfaceActivator.LoadMetadata(ModelHelper.GetEntityType(entityTypeUid)) as ClassMetadata)
			select m.Uid).ToList();
	}

	public virtual IEnumerable<IWorkLog> GetWorkLogList(IEntity entity = null, bool isNew = false, DateTime? dateStart = null, DateTime? dateEnd = null)
	{
		ITaskBase taskBase = entity as ITaskBase;
		List<Guid> list = new List<Guid>();
		if (taskBase != null)
		{
			if (WorkLogExtensionHelper.FindExtensionByObjectUid(taskBase.TypeUid) != null)
			{
				list.Add(taskBase.TypeUid);
			}
		}
		else
		{
			list = WorkLogExtensionHelper.ObjectsUidEnabledList();
		}
		if (list.Count <= 0)
		{
			return new List<IWorkLog>();
		}
		return WorkLogManager.Instance.GetWorkLogReportCriteria(list, taskBase?.Id, isNew, dateStart, dateEnd).List<IWorkLog>();
	}

	[PublicApiMember]
	public override void Save(IWorkLogItem obj)
	{
		if (obj.Status != WorkLogItemStatus.Draft)
		{
			if (obj.Harmonizator == null)
			{
				throw new InvalidOperationException(SR.T("Не указан согласующий."));
			}
			if (obj.WorkLogActivity == null)
			{
				throw new InvalidOperationException(SR.T("Не указан вид трудозатрат."));
			}
			if (!obj.FactWorkTime.HasValue || obj.FactWorkTime.Value.TotalMinutes <= 0)
			{
				throw new InvalidOperationException(SR.T("Не указаны часы трудозатрат."));
			}
		}
		else if (!obj.FactWorkTime.HasValue || obj.FactWorkTime.Value.TotalMinutes < 0)
		{
			throw new InvalidOperationException(SR.T("Часы трудозатрат должны быть положительным числом."));
		}
		base.Save(obj);
	}

	[PublicApiMember]
	public override void Delete(IWorkLogItem obj)
	{
		RaiseActionEvent(null, obj, "f5d56c0f-95af-48d5-89a0-ea4e9a336429", delegate(EntityActionEventArgs e)
		{
			e.ExtendedProperties.Add("ReportNotificationsChangeEnabled", Settings().ReportNotificationsChangeEnabled);
		});
		base.Delete(obj);
	}

	public virtual long ForObjectCount(Guid objectUid, long objectId)
	{
		bool flag = ComponentManager.Current.GetExtensionPoints<IWorklogItemAccess>().Any((IWorklogItemAccess p) => p.HasPermission(objectUid, objectId));
		return Count(FilterForObject(flag ? null : new List<EleWise.ELMA.Security.Models.IUser> { CurrentUser }, objectUid, objectId));
	}

	public virtual bool ForObjectExists(Guid objectUid, long objectId)
	{
		bool flag = ComponentManager.Current.GetExtensionPoints<IWorklogItemAccess>().Any((IWorklogItemAccess p) => p.HasPermission(objectUid, objectId));
		return Exists(FilterForObject(flag ? null : new List<EleWise.ELMA.Security.Models.IUser> { CurrentUser }, objectUid, objectId));
	}

	public virtual long ForObjectCount(ITaskBase task)
	{
		return ForObjectCount(task.TypeUid, task.Id);
	}

	public virtual IWorkLogItemFilter FilterForObject(List<EleWise.ELMA.Security.Models.IUser> users, Guid? objectUid = null, long? objectId = null, DateTime? dateStart = null, DateTime? dateEnd = null, bool showDraft = false)
	{
		return FilterForObject(users, null, null, objectUid, objectId, dateStart, dateEnd, showDraft);
	}

	public virtual IWorkLogItemFilter FilterForObject(List<EleWise.ELMA.Security.Models.IUser> users, WorkLogItemStatus? status, long? activityId, Guid? objectUid = null, long? objectId = null, DateTime? dateStart = null, DateTime? dateEnd = null, bool showDraft = false)
	{
		IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
		if (objectUid.HasValue && objectId.HasValue)
		{
			workLogItemFilter.DisableSecurity = ComponentManager.Current.GetExtensionPoints<IWorklogItemAccess>().Any((IWorklogItemAccess p) => p.HasPermission(objectUid.Value, objectId.Value));
		}
		workLogItemFilter.ObjectUID = objectUid;
		workLogItemFilter.ObjectId = (objectId.HasValue ? new Int64Range
		{
			From = objectId,
			To = objectId
		} : default(Int64Range));
		if (users != null)
		{
			((ISet<EleWise.ELMA.Security.Models.IUser>)workLogItemFilter.CreationAuthors).AddAll(users.Where((EleWise.ELMA.Security.Models.IUser u) => u != null));
		}
		workLogItemFilter.Date = new DateTimeRange(dateStart, dateEnd);
		if (status.HasValue)
		{
			workLogItemFilter.Status = status;
		}
		if (activityId.HasValue)
		{
			workLogItemFilter.WorkLogActivity = EntityManager<IWorkLogActivity>.Instance.LoadOrNull(activityId);
		}
		return workLogItemFilter;
	}

	[ContextCache]
	public virtual List<EntityLastActionInfo> WorkLogHistoryObjectsList(DateTime? dateStart, DateTime? dateEnd)
	{
		int count = 50;
		FetchOptions fetchOptions = new FetchOptions
		{
			FirstResult = 0,
			SortDirection = ListSortDirection.Descending,
			SortExpression = "ActionDate"
		};
		List<Guid> actionObjectUids = WorkLogExtensionHelper.ObjectsUidEnabledList();
		IEnumerable<EntityLastActionInfo> source = EntityActionHistoryManager.Instance.LoadLastEntityActionHistaryList(CurrentUser, dateStart, dateEnd, actionObjectUids, fetchOptions);
		List<IWorkLogHistoryObjectExtension> extPoints = ComponentManager.Current.GetExtensionPoints<IWorkLogHistoryObjectExtension>().ToList();
		return source.Where(delegate(EntityLastActionInfo i)
		{
			bool flag = !i.IsDeleted() && i.Entity != null;
			return (!flag || !extPoints.Any((IWorkLogHistoryObjectExtension e) => e.CanHandle(i.Entity) && !e.Visible(i))) && flag;
		}).Take(count).ToList();
	}

	public virtual void SendNotifications(List<IWorkLogItem> workLogItemList)
	{
		SendNotifications(workLogItemList, isAutomatic: false);
	}

	[Transaction]
	public virtual void AddApprovalComment(IWorkLogItem workLogItem, WorkLogItemStatus status, ICommentActionModel actionModel = null)
	{
		AddApprovalComment(new List<IWorkLogItem> { workLogItem }, status, actionModel);
	}

	[Transaction]
	public virtual void AddApprovalComment(List<IWorkLogItem> workLogItemList, WorkLogItemStatus status, ICommentActionModel actionModel = null)
	{
		AddApprovalComment(workLogItemList, null, status, actionModel);
	}

	[Transaction]
	public virtual void AddApprovalComment(List<IWorkLogItem> workLogItemList, List<IWorkLogItem> workLogItemListUnConfirm, WorkLogItemStatus status, ICommentActionModel actionModel = null)
	{
		Dictionary<EleWise.ELMA.Security.Models.IUser, List<IWorkLogItem>> dictionary = (from key in workLogItemList
			group key by key.CreationAuthor).ToDictionary((IGrouping<EleWise.ELMA.Security.Models.IUser, IWorkLogItem> key) => key.Key, (IGrouping<EleWise.ELMA.Security.Models.IUser, IWorkLogItem> value) => value.ToList());
		Dictionary<EleWise.ELMA.Security.Models.IUser, List<IWorkLogItem>> dictionary2 = workLogItemListUnConfirm?.GroupBy((IWorkLogItem key) => key.CreationAuthor).ToDictionary((IGrouping<EleWise.ELMA.Security.Models.IUser, IWorkLogItem> key) => key.Key, (IGrouping<EleWise.ELMA.Security.Models.IUser, IWorkLogItem> value) => value.ToList());
		foreach (EleWise.ELMA.Security.Models.IUser key in dictionary.Keys)
		{
			List<IWorkLogItem> list = dictionary[key];
			if (key == null || list.Count == 0)
			{
				continue;
			}
			string value2 = "";
			AuditEventArgs auditEventArgs = new AuditEventArgs();
			if (actionModel != null && actionModel.Comment != null)
			{
				value2 = actionModel.Comment.Text ?? "";
				foreach (IWorkLogItem item in list)
				{
					ICommentActionModel commentModel = CloneHelperBuilder.Create(actionModel).Restrictions(delegate(RestrictionsBuilder<ICommentActionModel> m)
					{
						m.Rule().ForPropertyName((ICommentActionModel d) => d.Comment).Clone();
					}).Clone();
					CommentActionHandler.Process(item, commentModel);
				}
				if (dictionary2 != null)
				{
					List<IWorkLogItem> list2 = dictionary2[key];
					foreach (IWorkLogItem item2 in list2)
					{
						ICommentActionModel commentModel2 = CloneHelperBuilder.Create(actionModel).Restrictions(delegate(RestrictionsBuilder<ICommentActionModel> m)
						{
							m.Rule().ForPropertyName((ICommentActionModel d) => d.Comment).Clone();
						}).Clone();
						CommentActionHandler.Process(item2, commentModel2);
					}
					auditEventArgs.ExtendedProperties["WorkLogObjectListUnConfirm"] = list2.ToList();
					auditEventArgs.ExtendedProperties["WorkLogObjectSumUnConfirm"] = new WorkTime(list2.Sum((IWorkLogItem m) => m.FactWorkTime ?? ((WorkTime)0L)));
				}
			}
			auditEventArgs.ExtendedProperties["ReportNotificationsApprovalEnabled"] = Settings().ReportNotificationsApprovalEnabled;
			auditEventArgs.ExtendedProperties["WorkLogItemAuthor"] = key;
			auditEventArgs.ExtendedProperties["WorkLogObjectList"] = list.ToList();
			auditEventArgs.ExtendedProperties["Comment"] = value2;
			auditEventArgs.ExtendedProperties["WorkLogObjectSum"] = new WorkTime(list.Sum((IWorkLogItem m) => m.FactWorkTime ?? ((WorkTime)0L)));
			auditEventArgs.ExtendedProperties["WorkLogObjectApproveSum"] = new WorkTime(list.Sum((IWorkLogItem m) => m.ApprovalWorkTime ?? ((WorkTime)0L)));
			auditEventArgs.Action = EntityAuditAction((dictionary2 != null || status == WorkLogItemStatus.Confirm) ? WorkLogItemActions.ConfirmApprovalGuid : WorkLogItemActions.RefuseApprovalGuid);
			auditEventArgs.Object = new EntityAuditObject((EntityMetadata)InterfaceActivator.LoadMetadata<IWorkLogItem>());
			AuditEventProvider.Notify((dictionary2 != null || status == WorkLogItemStatus.Confirm) ? "EleWise.ELMA.Tasks.WorkLogItem.ReportApprovalConfirm" : "EleWise.ELMA.Tasks.WorkLogItem.ReportApprovalUnconfirm", auditEventArgs);
		}
	}

	private static EntityAuditAction EntityAuditAction(Guid actionUid)
	{
		EntityActionsMetadata entityActionsMetadata = new EntityActionsMetadata();
		entityActionsMetadata.LoadFromType(typeof(WorkLogItemActions));
		EnumValueMetadata enumValueMetadata = entityActionsMetadata.Values.FirstOrDefault((EnumValueMetadata a) => a.Uid == actionUid);
		return new EntityAuditAction(enumValueMetadata.Uid, enumValueMetadata.Name, (EntityAuditAction a) => GetDefaultLocalizedMetadata(a.Uid), enumValueMetadata.DefaultImage);
	}

	private static EnumValueMetadata GetDefaultLocalizedMetadata(Guid valueUid)
	{
		int key = ((CultureInfo.CurrentCulture != null) ? CultureInfo.CurrentCulture.LCID : 0);
		if (!LoadedDefaultActions.TryGetValue(key, out var value))
		{
			value = new EntityActionsMetadata();
			value.LoadFromType(typeof(DefaultEntityActions));
			LoadedDefaultActions[key] = value;
		}
		return value.Values.FirstOrDefault((EnumValueMetadata v) => v.Uid == valueUid);
	}

	public virtual void ApprovalConfirm(IWorkLogItem workLogItem)
	{
		ApprovalConfirm(workLogItem, workLogItem.FactWorkTime ?? new WorkTime(0));
	}

	public virtual void ApprovalConfirm(IWorkLogItem workLogItem, WorkTime approvalWorkTime)
	{
		ApprovalConfirm(workLogItem, approvalWorkTime, null);
	}

	public virtual void ApprovalConfirm(IWorkLogItem workLogItem, WorkTime approvalWorkTime, ICommentActionModel actionModel)
	{
		if (CanApprove(workLogItem))
		{
			workLogItem.ApprovalWorkTime = approvalWorkTime;
			workLogItem.Status = WorkLogItemStatus.Confirm;
			workLogItem.Save();
			if (WorkLogManager.Instance.Find((IWorkLog w) => w.WorkLogItem == workLogItem).Count == 0 && WorkLogExtensionHelper.LoadObject(workLogItem.ObjectId, workLogItem.ObjectUID) is ITaskBase taskBase)
			{
				IWorkLog workLog = InterfaceActivator.Create<IWorkLog>();
				workLog.WorkMinutes = workLogItem.ApprovalWorkTime;
				workLog.Status = WorkLogStatus.New;
				workLog.Comment = workLogItem.Comment;
				workLog.CreationAuthor = CurrentUser;
				workLog.Worker = workLogItem.CreationAuthor;
				workLog.TaskBase = taskBase;
				workLog.StartDate = workLogItem.Date;
				workLog.WorkLogItem = workLogItem;
				Locator.GetService<ISecurityService>()?.RunWithElevatedPrivilegies(workLog.Save);
			}
			RaiseCommentActionEvent(null, workLogItem, "24dc1527-088d-4fec-abcb-be4005ca7cc4", actionModel, delegate(EntityActionEventArgs e)
			{
				e.ExtendedProperties.Add("ReportNotificationsApprovalEnabled", Settings().ReportNotificationsApprovalEnabled);
				e.Action = EntityAuditAction(WorkLogItemActions.ConfirmApprovalGuid);
				e.Object = new EntityAuditObject((EntityMetadata)InterfaceActivator.LoadMetadata<IWorkLogItem>());
			});
		}
	}

	public virtual void ApprovalUnConfirm(IWorkLogItem workLogItem)
	{
		if (CanApprove(workLogItem))
		{
			workLogItem.Status = WorkLogItemStatus.Unconfirm;
			workLogItem.Save();
			RaiseActionEvent(null, workLogItem, "1b533763-6cb3-46e4-9695-952d48433fbf", delegate(EntityActionEventArgs e)
			{
				e.ExtendedProperties.Add("ReportNotificationsApprovalEnabled", Settings().ReportNotificationsApprovalEnabled);
				e.Action = EntityAuditAction(WorkLogItemActions.RefuseApprovalGuid);
				e.Object = new EntityAuditObject((EntityMetadata)InterfaceActivator.LoadMetadata<IWorkLogItem>());
			});
		}
	}

	[ActionMethod("823cc9ce-1ca4-4ee2-a7a0-872054d4f986")]
	public virtual void ReAssign(IWorkLogItem workLogItem, EleWise.ELMA.Security.Models.IUser harmonizator, ICommentActionModel actionModel)
	{
		if (workLogItem == null)
		{
			throw new InvalidOperationException(SR.T("Не указаны трудозатраты"));
		}
		if (harmonizator == null)
		{
			throw new InvalidOperationException(SR.T("Не указан согласующий"));
		}
		workLogItem.Harmonizator = harmonizator;
		Save(workLogItem);
	}

	[ActionMethod("e71c3a9e-e121-4c1b-a7b7-93e90eac242d")]
	[Transaction]
	public virtual void ChangeStatus(IWorkLogItem workLogItem, WorkLogItemStatus status)
	{
		workLogItem.Status = status;
		switch (status)
		{
		case WorkLogItemStatus.Unconfirm:
			workLogItem.ApprovalWorkTime = null;
			break;
		case WorkLogItemStatus.Confirm:
			if (!workLogItem.ApprovalWorkTime.HasValue || workLogItem.ApprovalWorkTime.Value.Value == 0L)
			{
				workLogItem.ApprovalWorkTime = workLogItem.FactWorkTime;
			}
			break;
		}
		workLogItem.Save();
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (!(filter is IWorkLogItemFilter workLogItemFilter))
		{
			return;
		}
		if (workLogItemFilter.CreationAuthors != null && ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)workLogItemFilter.CreationAuthors).Any())
		{
			object[] array = ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)workLogItemFilter.CreationAuthors).ToArray();
			criteria.Add((ICriterion)(object)Restrictions.In("CreationAuthor", array));
		}
		if (!workLogItemFilter.ShowDraft.HasValue || !workLogItemFilter.ShowDraft.Value)
		{
			criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Status", (object)WorkLogItemStatus.Draft)));
		}
		if (workLogItemFilter.Statuses != null && workLogItemFilter.Statuses.Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Status", (ICollection)workLogItemFilter.Statuses));
		}
		if (!workLogItemFilter.ObjectUids.HasItems())
		{
			workLogItemFilter.ObjectUids = new List<Guid>();
			foreach (List<Guid> item in from e in WorkLogExtensionHelper.ExtensionList()
				select e.EnabledObjectTypes())
			{
				workLogItemFilter.ObjectUids.AddRange(item);
			}
		}
		if (workLogItemFilter.EmptyObjectUid == true)
		{
			workLogItemFilter.ObjectUids.Add(Guid.Empty);
		}
		if (workLogItemFilter.ObjectUids.Any())
		{
			criteria.Add((ICriterion)(object)Restrictions.In("ObjectUID", (ICollection)workLogItemFilter.ObjectUids));
		}
		if (workLogItemFilter.ExcludeIds != null && workLogItemFilter.ExcludeIds.Count > 0)
		{
			criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.In("Id", (ICollection)workLogItemFilter.ExcludeIds)));
		}
		if (workLogItemFilter.ObjectIds != null && workLogItemFilter.ObjectIds.Count > 0)
		{
			criteria.Add((ICriterion)(object)Restrictions.In("ObjectId", (ICollection)workLogItemFilter.ObjectIds));
		}
		if (workLogItemFilter.Ids != null && workLogItemFilter.Ids.Count > 0)
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Id", (ICollection)workLogItemFilter.Ids));
		}
		if (workLogItemFilter.Uids != null && workLogItemFilter.Uids.Count > 0)
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Uid", (ICollection)workLogItemFilter.Uids));
		}
	}

	public virtual Dictionary<DateTime?, long> GetDraftReportMinutes(DateTime dateStart, DateTime dateEnd)
	{
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("CreationAuthor", (object)base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>())).Add((ICriterion)(object)Restrictions.Eq("Status", (object)WorkLogItemStatus.Draft)).Add((ICriterion)(object)Restrictions.Ge("Date", (object)new DateTime(dateStart.Year, dateStart.Month, dateStart.Day)))
			.Add((ICriterion)(object)Restrictions.Lt("Date", (object)new DateTime(dateEnd.Year, dateEnd.Month, dateEnd.Day).AddDays(1.0)))
			.Add((ICriterion)(object)((Junction)Restrictions.Disjunction()).Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.IsNotNull("ObjectUID"), (ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("ObjectUID", (object)Guid.Empty)))).Add((ICriterion)(object)Restrictions.Gt("FactWorkTime", (object)new WorkTime(0))).Add((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.IsNotNull("Comment"), (ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Comment", (object)"")))));
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty((IProjection)(object)ProjectionFor((IWorkLogItem b) => b.Date))).Add((IProjection)(object)Projections.Sum((IProjection)(object)ProjectionFor((IWorkLogItem b) => b.FactWorkTime))) });
		return val.List().Cast<object[]>().ToDictionary((object[] k) => (DateTime?)k[0], (object[] v) => ((WorkTime)v[1]).TotalMinutes);
	}

	[Transaction]
	public virtual void DraftForWeekIgnore(DateTime date, bool deleteWorkLog = false)
	{
		if (deleteWorkLog)
		{
			List<Guid> objectsUid = WorkLogExtensionHelper.ObjectsUidEnabledList();
			WorkLogManager.Instance.FreeHoursForWeekIgnore(objectsUid, date);
		}
		DateTime value = date.Date.AddDays(-WorkLogHelper.DayOfWeekNumber(date));
		DateTime dateTime = value.Date.AddDays(7.0);
		IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
		workLogItemFilter.Date = new DateTimeRange(value, dateTime.AddSeconds(-1.0));
		workLogItemFilter.CreationAuthors.Add(CurrentUser);
		workLogItemFilter.ShowDraft = true;
		workLogItemFilter.Status = WorkLogItemStatus.Draft;
		workLogItemFilter.EmptyObjectUid = true;
		foreach (IWorkLogItem item in Find(workLogItemFilter, null))
		{
			item.HardDelete = true;
			item.Delete();
		}
	}

	public virtual WorkTime GetFactWorkLogAll(IWorkLogItem workLogItem, bool excludeCurrent = false)
	{
		List<long> list = new List<long>();
		if (excludeCurrent)
		{
			list.Add(workLogItem.Id);
		}
		if (workLogItem != null)
		{
			return GetFactWorkLogAll(workLogItem.ObjectId, workLogItem.ObjectUID, list);
		}
		return new WorkTime(0);
	}

	[ContextCache]
	public virtual WorkTime GetFactWorkLogAll(long objectId, Guid objectUID, List<long> excludeIds = null)
	{
		if (objectId == 0L)
		{
			return 0L;
		}
		IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
		workLogItemFilter.DisableSecurity = true;
		workLogItemFilter.ObjectId = new Int64Range
		{
			From = objectId,
			To = objectId
		};
		workLogItemFilter.ObjectUID = objectUID;
		workLogItemFilter.Statuses = new List<WorkLogItemStatus>
		{
			WorkLogItemStatus.Confirm,
			WorkLogItemStatus.New
		};
		workLogItemFilter.ExcludeIds = excludeIds;
		return GetFactWorkLog(objectId, objectUID, workLogItemFilter);
	}

	public virtual WorkTime GetFactWorkLogAll(IEntity<long> entity, List<long> excludeIds = null)
	{
		long id = entity.Id;
		Guid uid = InterfaceActivator.LoadMetadata(entity.GetType()).Uid;
		return GetFactWorkLogAll(id, uid, excludeIds);
	}

	[ContextCache]
	public virtual WorkTime GetFactDraftWorkLog(long objectId, Guid objectUid, DateTimeRange date, List<long> selectedIds)
	{
		IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
		workLogItemFilter.ObjectId = new Int64Range
		{
			From = objectId,
			To = objectId
		};
		workLogItemFilter.ObjectUID = objectUid;
		workLogItemFilter.CreationAuthors.Add(CurrentUser);
		workLogItemFilter.Status = WorkLogItemStatus.Draft;
		workLogItemFilter.ShowDraft = true;
		if (selectedIds != null && selectedIds.Any())
		{
			workLogItemFilter.Ids = selectedIds;
		}
		workLogItemFilter.Date = date;
		return GetFactWorkLog(objectId, objectUid, workLogItemFilter);
	}

	public virtual WorkTime GetFactWorkLog(long objectId, Guid objectUID, IWorkLogItemFilter filter)
	{
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IWorkLogItemFilter>();
		}
		return new WorkTime(Find(filter, null).Sum(delegate(IWorkLogItem m)
		{
			if (m.Status == WorkLogItemStatus.Confirm)
			{
				if (!m.ApprovalWorkTime.HasValue)
				{
					return 0L;
				}
				return m.ApprovalWorkTime.Value.Value;
			}
			return (!m.FactWorkTime.HasValue) ? 0 : m.FactWorkTime.Value.Value;
		}));
	}

	public virtual WorkTime GetApprovalWorkLog(long objectId, Guid objectUID)
	{
		IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
		workLogItemFilter.ObjectId = new Int64Range
		{
			From = objectId,
			To = objectId
		};
		workLogItemFilter.ObjectUID = objectUID;
		workLogItemFilter.CreationAuthors.Add(CurrentUser);
		workLogItemFilter.Statuses = new List<WorkLogItemStatus> { WorkLogItemStatus.Confirm };
		return new WorkTime(Find(workLogItemFilter, null).Sum((IWorkLogItem m) => (!m.ApprovalWorkTime.HasValue) ? 0 : m.ApprovalWorkTime.Value.Value));
	}

	[Transaction]
	public virtual void CopyForPreviousWeek(DateTime dayForWeek, ICollection<long> copyItems)
	{
		DateTime dateTime = WorkLogHelper.StartDateOfWeek(dayForWeek);
		IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
		workLogItemFilter.CreationAuthors.Add(CurrentUser);
		workLogItemFilter.Ids = copyItems.ToList();
		workLogItemFilter.ShowDraft = true;
		workLogItemFilter.Statuses = new List<WorkLogItemStatus>
		{
			WorkLogItemStatus.Draft,
			WorkLogItemStatus.New,
			WorkLogItemStatus.Confirm
		};
		workLogItemFilter.EmptyObjectUid = true;
		foreach (IWorkLogItem item in Find(workLogItemFilter, null))
		{
			DateTime dateTime2 = WorkLogHelper.StartDateOfWeek(item.Date);
			int days = (dateTime - dateTime2).Days;
			IWorkLogItem workLogItem = CloneHelperBuilder.Create(item).Clone();
			workLogItem.CreationDate = DateTime.Now;
			workLogItem.ApprovalWorkTime = null;
			workLogItem.Date = item.Date.AddDays(days);
			workLogItem.Status = WorkLogItemStatus.Draft;
			workLogItem.Save();
		}
	}

	[Transaction]
	public virtual Pair<IWorkLogItem, IWorkLogItem> Divide(IWorkLogItem workLogItem, WorkTime workTime)
	{
		IWorkLogItem workLogItem2 = CloneHelperBuilder.Create(workLogItem).Clone();
		workLogItem2.FactWorkTime -= workTime;
		workLogItem2.Save();
		workLogItem.FactWorkTime = workTime;
		workLogItem.Save();
		return new Pair<IWorkLogItem, IWorkLogItem>(workLogItem, workLogItem2);
	}

	internal virtual bool CanAutoApproveMyWorklog(EleWise.ELMA.Security.Models.IUser user)
	{
		return base.SecurityService.HasPermission(user, PermissionProvider.AutoApproveMyWorklogPermission);
	}

	internal int AutomaticSendingOfWorkLog()
	{
		int num = 0;
		List<EleWise.ELMA.Security.Models.IUser> list = GetUsersWithAutomaticWorkLogInput().ToList();
		List<WorkLogItemModel> list2 = new List<WorkLogItemModel>();
		List<WorkLogItemModel> list3 = new List<WorkLogItemModel>();
		while (list.Any())
		{
			IWorkLogItemFilter workLogItemFilter = InterfaceActivator.Create<IWorkLogItemFilter>();
			workLogItemFilter.ShowDraft = true;
			workLogItemFilter.Status = WorkLogItemStatus.Draft;
			workLogItemFilter.Date = new DateTimeRange(null, DateTime.Now.AddDays(-1.0));
			((ISet<EleWise.ELMA.Security.Models.IUser>)workLogItemFilter.CreationAuthors).AddAll(list.Take(500));
			List<WorkLogItemModel> list4 = (from w in Find(workLogItemFilter, null)
				select new WorkLogItemModel(w)).ToList();
			if (list4 != null && list4.Any())
			{
				using IUnitOfWork unitOfWork = unitOfWorkManager.Create(string.Empty, transactional: true);
				try
				{
					ValidationWorkLogItems(list4, list3);
					IEntityActionHandler entityActionHandler = InterfaceActivator.Create<IEntityActionHandler>();
					foreach (WorkLogItemModel item in list4)
					{
						IWorkLogItem workLogItem = item.WorkLogItem;
						if (workLogItem.Harmonizator.Id != workLogItem.CreationAuthor.Id || CanAutoApproveMyWorklog(workLogItem.CreationAuthor))
						{
							workLogItem.Status = WorkLogItemStatus.New;
							workLogItem.Save();
							if (CanAutoApproveMyWorklog(workLogItem.CreationAuthor))
							{
								SetValueIsAutomaticSend(value: true);
								ApprovalConfirm(workLogItem);
							}
							list2.Add(item);
						}
						else
						{
							entityActionHandler.ActionExecuted(EntityActionEventArgs.TryCreate(null, workLogItem, "2a7a7985-796f-4eac-a1aa-4d81234ac405"));
							list3.Add(item);
						}
					}
					List<IWorkLogItem> list5 = list2.Select((WorkLogItemModel m) => m.WorkLogItem).ToList();
					num += list5.Count;
					SendNotifications(list5, isAutomatic: true);
					SendNotificationsAboutAutomaticallyWorkLog(list5, isSent: true);
					SendNotificationsAboutAutomaticallyWorkLog(list3.Select((WorkLogItemModel m) => m.WorkLogItem).ToList(), isSent: false);
					list2.Clear();
					list3.Clear();
				}
				catch (Exception ex)
				{
					string message = SR.T("Ошибка при автоматической отправке трудозатрат.\r\nОписание ошибки: {0}", ex.Message);
					EleWise.ELMA.Logging.Logger.Log.Error(message);
					unitOfWork.Rollback();
					SendErrorNotifications(list4.Select((WorkLogItemModel m) => m.WorkLogItem).ToList());
					throw;
				}
				unitOfWork.Commit();
			}
			list.RemoveRange(0, (list.Count > 500) ? 500 : list.Count);
		}
		return num;
	}

	private void ValidationWorkLogItems(List<WorkLogItemModel> workLogItemModels, List<WorkLogItemModel> workLogItemModelsListNotSent)
	{
		List<WorkLogItemModel> inValidWorkLogItemModels = new List<WorkLogItemModel>();
		if (WorkLogSettingsHelper.GetSettings().DisableOvertime)
		{
			foreach (IGrouping<EleWise.ELMA.Security.Models.IUser, WorkLogItemModel> item in from w in workLogItemModels
				group w by w.WorkLogItem.CreationAuthor)
			{
				inValidWorkLogItemModels.AddRange((from i in WorkLogHelper.IsWorkLogItemDraftOvertime(item.Select((WorkLogItemModel w) => w).ToList())
					where i.Value.Any()
					select i into m
					select m.Key).ToList());
			}
		}
		inValidWorkLogItemModels.AddRange(workLogItemModels.Where((WorkLogItemModel workLogItemModel) => workLogItemModel.WorkLogItem.WorkLogActivity == null || workLogItemModel.WorkLogItem.FactWorkTime.Value.Value == 0));
		if (inValidWorkLogItemModels.Any())
		{
			workLogItemModelsListNotSent.AddRange(inValidWorkLogItemModels);
			workLogItemModels.RemoveAll((WorkLogItemModel w) => inValidWorkLogItemModels.Contains(w));
		}
	}

	private IEnumerable<EleWise.ELMA.Security.Models.IUser> GetUsersWithAutomaticWorkLogInput()
	{
		List<long> userIds = WorkLogManager.Instance.GetAutoSaveWorkLogsUsers().UserIds;
		if (userIds.Any())
		{
			return base.Session.CreateCriteria(InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>()).Add((ICriterion)(object)Restrictions.In("Id", (ICollection)userIds)).List<EleWise.ELMA.Security.Models.IUser>();
		}
		return Enumerable.Empty<EleWise.ELMA.Security.Models.IUser>();
	}

	private ICriteria CreateWorkLogItemCriteria(IWorkLogObjectSearchFilter filter, FetchOptions fetchOptions)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		ISQLQuery val = new WorkLogItemSearchQueryBuilder(base.Session, filter, new WorkLogItemSearchProvider()).CreateObjectQuery<IWorkLogItem>(isObjectSearch: false);
		if (val == null)
		{
			return null;
		}
		Type type = InterfaceActivator.TypeOf<IWorkLogItem>();
		ICriteria obj = CreateCriteria(fetchOptions, type, "wli");
		AbstractQueryImpl val2 = (AbstractQueryImpl)val;
		object[] array = val2.ValueArray();
		IType[] array2 = val2.TypeArray();
		obj.Add((ICriterion)(object)Expression.Sql(string.Format("{{alias}}.{0} in ({1})", TransformationProvider.Dialect.QuoteIfNeeded("Id"), ((object)val).ToString()), array, array2));
		return obj;
	}

	private bool GetValueIsAutomaticSend()
	{
		ContextVars.TryGetValue<bool>("EleWise.ELMA.Task.WorkLogItem.AutomaticSend", out var value);
		return value;
	}

	private void SetValueIsAutomaticSend(bool value)
	{
		ContextVars.Set("EleWise.ELMA.Task.WorkLogItem.AutomaticSend", value);
	}

	private void SendNotifications(List<IWorkLogItem> workLogItemList, bool isAutomatic)
	{
		Dictionary<EleWise.ELMA.Security.Models.IUser, List<IWorkLogItem>> dictionary = (from key in workLogItemList
			group key by key.Harmonizator).ToDictionary((IGrouping<EleWise.ELMA.Security.Models.IUser, IWorkLogItem> key) => key.Key, (IGrouping<EleWise.ELMA.Security.Models.IUser, IWorkLogItem> value) => value.ToList());
		WorkLogSettings workLogSettings = Settings();
		foreach (EleWise.ELMA.Security.Models.IUser key in dictionary.Keys)
		{
			List<IWorkLogItem> list = dictionary[key];
			Dictionary<EleWise.ELMA.Security.Models.IUser, List<IWorkLogItem>> dictionary2 = (from key in list
				group key by key.CreationAuthor).ToDictionary((IGrouping<EleWise.ELMA.Security.Models.IUser, IWorkLogItem> key) => key.Key, (IGrouping<EleWise.ELMA.Security.Models.IUser, IWorkLogItem> value) => value.ToList());
			if (key == null || list.Count == 0)
			{
				continue;
			}
			foreach (EleWise.ELMA.Security.Models.IUser key2 in dictionary2.Keys)
			{
				List<IWorkLogItem> source = dictionary2[key2];
				AuditEventArgs auditEventArgs = new AuditEventArgs();
				auditEventArgs.ExtendedProperties["ReportNotificationsEnabled"] = workLogSettings.ReportNotificationsEnabled;
				auditEventArgs.ExtendedProperties["Harmonizator"] = key;
				auditEventArgs.ExtendedProperties["WorkLogObjectList"] = source.ToList();
				auditEventArgs.ExtendedProperties["WorkLogObjectSum"] = new WorkTime(source.Sum((IWorkLogItem m) => m.FactWorkTime ?? ((WorkTime)0L)));
				auditEventArgs.ExtendedProperties["IsAutomatic"] = isAutomatic;
				auditEventArgs.Action = EntityAuditAction(WorkLogItemActions.SendToApproveGuid);
				auditEventArgs.Object = new EntityAuditObject((EntityMetadata)InterfaceActivator.LoadMetadata<IWorkLogItem>());
				AuditEventProvider.Notify("EleWise.ELMA.Tasks.WorkLogItem.Report", auditEventArgs);
			}
		}
	}

	private void SendNotificationsAboutAutomaticallyWorkLog(List<IWorkLogItem> workLogItemList, bool isSent)
	{
		Dictionary<EleWise.ELMA.Security.Models.IUser, List<IWorkLogItem>> dictionary = (from key in workLogItemList
			group key by key.CreationAuthor).ToDictionary((IGrouping<EleWise.ELMA.Security.Models.IUser, IWorkLogItem> key) => key.Key, (IGrouping<EleWise.ELMA.Security.Models.IUser, IWorkLogItem> value) => value.ToList());
		foreach (EleWise.ELMA.Security.Models.IUser key in dictionary.Keys)
		{
			List<IWorkLogItem> list = dictionary[key];
			if (key != null && list.Count != 0)
			{
				AuditEventArgs auditEventArgs = new AuditEventArgs();
				auditEventArgs.ExtendedProperties["CreationAuthor"] = key;
				auditEventArgs.ExtendedProperties["WorkLogObjectList"] = list.ToList();
				auditEventArgs.ExtendedProperties["WorkLogObjectSum"] = new WorkTime(list.Sum((IWorkLogItem m) => m.FactWorkTime ?? ((WorkTime)0L)));
				auditEventArgs.ExtendedProperties["IsSent"] = isSent;
				auditEventArgs.Action = EntityAuditAction(WorkLogItemActions.SendToApproveGuid);
				auditEventArgs.Object = new EntityAuditObject((EntityMetadata)InterfaceActivator.LoadMetadata<IWorkLogItem>());
				AuditEventProvider.Notify("EleWise.ELMA.Tasks.WorkLogItem.AutomaticSendReport", auditEventArgs);
			}
		}
	}

	private void SendErrorNotifications(List<IWorkLogItem> workLogItemList)
	{
		WorkLogSettings settings = WorkLogSettingsHelper.GetSettings();
		List<EleWise.ELMA.Security.Models.IUser> value = WorkLogHelper.GetUsersByAllKindId(settings.UsersNotificationErrorAutoWorkLogIds, settings.GroupNotificationErrorAutoWorkLogIds, settings.OrganizationItemNotificationErrorAutoWorkLogIds).ToList();
		AuditEventArgs auditEventArgs = new AuditEventArgs();
		auditEventArgs.ExtendedProperties["UsersNotificationErrorAutoWorkLog"] = value;
		auditEventArgs.ExtendedProperties["WorkLogObjectList"] = workLogItemList;
		auditEventArgs.Action = EntityAuditAction(WorkLogItemActions.SendToApproveGuid);
		auditEventArgs.Object = new EntityAuditObject((EntityMetadata)InterfaceActivator.LoadMetadata<IWorkLogItem>());
		AuditEventProvider.Notify("EleWise.ELMA.Tasks.WorkLogItem.ErrorAtAutomaticSendReport", auditEventArgs);
	}
}
