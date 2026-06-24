using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Text;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.KPI.Models.Performance;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Audit;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Engine;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using NHibernate.Type;

namespace EleWise.ELMA.Tasks.Managers;

public class TaskBaseManager : TaskBaseManager<ITaskBase>
{
	[NotNull]
	public new static TaskBaseManager Instance => Locator.GetServiceNotNull<TaskBaseManager>();
}
[DeveloperApi(DeveloperApiType.Manager)]
public abstract class TaskBaseManager<T> : EntityManager<T, long>, ITaskBaseManager where T : class, ITaskBase
{
	private const string CanCompleteCacheKey = "TaskBaseManager_CanComplete";

	private static bool ignoreRedirectActionExecute;

	private const string CurrentTasksCountCacheKey = "TaskBaseManager.CurrentTasksCount:";

	private const string NewTasksCountCacheKey = "TaskBaseManager.NewTasksCount:";

	private const string CurrentTasksCoExecutorCountCacheKey = "TaskBaseManager.CurrentTasksCoExecutorCount:";

	[NotNull]
	public TaskWorkflowActions TaskWorkflowActions { get; set; }

	[NotNull]
	public UserManager UserManager { get; set; }

	[NotNull]
	public ICommentActionHandler CommentActionHandler { get; set; }

	public ICacheService CacheService { get; set; }

	public IContextBoundVariableService ContextBoundVariableService { get; set; }

	public IEnumerable<ITaskAttachmetSpecifiedHistoryExtension> TaskAttachmetSpecifiedExtensions { get; set; }

	protected internal static bool IgnoreRedirectActionExecute
	{
		get
		{
			return TaskBaseManager<ITaskBase>.ignoreRedirectActionExecute;
		}
		set
		{
			TaskBaseManager<ITaskBase>.ignoreRedirectActionExecute = value;
		}
	}

	[Transaction]
	[Auditable]
	public override void DeleteAll()
	{
		foreach (T item in Find(new Filter
		{
			DisableSecurity = true
		}, FetchOptions.All, cacheble: false))
		{
			Delete(item);
		}
	}

	public ITaskBaseManager GetImplManager(Type entityType)
	{
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(entityType) as EntityMetadata;
		return (ITaskBaseManager)ModelHelper.GetEntityManager(base.MetadataRuntimeService.GetTypeByUid(entityMetadata.ImplementationUid, loadImplementation: false));
	}

	public ITaskBaseManager GetImplManager(Guid typeUid)
	{
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(typeUid) as EntityMetadata;
		return (ITaskBaseManager)ModelHelper.GetEntityManager(base.MetadataRuntimeService.GetTypeByUid(entityMetadata.ImplementationUid, loadImplementation: false));
	}

	public static bool IsExecutor(T task, EleWise.ELMA.Security.Models.IUser user, bool checkSubordinateUser)
	{
		if (task.Executor != user && (!checkSubordinateUser || !UserManager.Instance.IsSubordinateUser(user, task.Executor)) && (!Locator.GetServiceNotNull<TasksSettingsModule>().Settings.InformToExecutor || !((ICollection<EleWise.ELMA.Security.Models.IUser>)task.InformTo).Contains(user)))
		{
			return TaskBaseManager<ITaskBase>.AccessToAllTasks(user);
		}
		return true;
	}

	public static bool IsCurrentExecutor(T task)
	{
		return task.Executor == EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
	}

	public virtual bool CanComplete(ITaskBase task, EleWise.ELMA.Security.Models.IUser user)
	{
		if (task == null || user == null || task.Executor == null)
		{
			return false;
		}
		string name = string.Concat("TaskBaseManager_CanComplete_T", task.Id, "_TS", task.Status, "_TE", task.Executor.Id, "_U", user.Id);
		if (ContextBoundVariableService != null && ContextBoundVariableService.TryGetValue<bool>(name, out var value))
		{
			return value;
		}
		bool flag = CanCompleteNonCache(task, user);
		if (ContextBoundVariableService != null)
		{
			ContextBoundVariableService.Set(name, flag);
		}
		return flag;
	}

	private bool CanCompleteNonCache(ITaskBase task, EleWise.ELMA.Security.Models.IUser user)
	{
		if (task == null || user == null)
		{
			return false;
		}
		if (task is ITask && ((ITask)task).IsTemplate)
		{
			return false;
		}
		if (SR.GetSetting("Task.CanCompleteApprovalExecutorTasks", defaultValue: false))
		{
			if (task.Status == TaskBaseStatus.OnApproval)
			{
				return false;
			}
		}
		else if (task.Status == TaskBaseStatus.OnApproval || task.Status == TaskBaseStatus.OnApprovalExecutor)
		{
			return false;
		}
		if (task.IsComplete())
		{
			return false;
		}
		if (!TaskBaseManager<ITaskBase>.IsExecutor(task, user, checkSubordinateUser: true))
		{
			return false;
		}
		return true;
	}

	[ActionMethod("76ba2808-a04c-4827-8ec1-0e762ae729de")]
	public virtual T ChangeDate(long taskId, DateTime startDate, DateTime endDate)
	{
		return ChangeDate(taskId, startDate, endDate, null);
	}

	[Transaction]
	public virtual T ChangeDate(long taskId, DateTime startDate, DateTime endDate, IComment comment)
	{
		T val = LoadOrNull(taskId);
		if (val != null && CanChangeDate(taskId, startDate, endDate))
		{
			AddComment(val, comment);
			ICommentActionModel actionModel = null;
			if (comment != null)
			{
				InstanceOf<ICommentActionModel> instanceOf = new InstanceOf<ICommentActionModel>();
				instanceOf.New.Comment = comment;
				actionModel = instanceOf.New;
			}
			val.StartDate = ((startDate == DateTime.MinValue) ? null : new DateTime?(startDate));
			val.EndDate = ((endDate == DateTime.MaxValue) ? null : new DateTime?(endDate));
			Save(val);
			base.ActionHandler.ActionExecuted(TryCreateCommentActionEventArgs(null, val, "76ba2808-a04c-4827-8ec1-0e762ae729de", actionModel));
		}
		return val;
	}

	[ActionCheck("76ba2808-a04c-4827-8ec1-0e762ae729de")]
	public virtual bool CanChangeDate(long taskId, DateTime startDate, DateTime endDate)
	{
		T val = LoadOrNull(taskId);
		if (val != null && startDate < endDate)
		{
			return TaskWorkflowActions.IsAvailableDateChange(val, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
		}
		return false;
	}

	[Transaction]
	protected internal virtual void CheckTaskExpiration(DateTime checkTime)
	{
		foreach (ITaskBase item in CreateCriteriaNoPermissions().Add((ICriterion)(object)Restrictions.In("Status", TaskBaseExtensions.ActiveTaskStatuses.CastToArrayOrNull<object>())).Add((ICriterion)(object)Restrictions.Le("EndDate", (object)checkTime)).Add((ICriterion)(object)Restrictions.Eq("ExpiredNotificationSent", (object)false))
			.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("NotShowInLists"), (ICriterion)(object)Restrictions.Eq("NotShowInLists", (object)false)))
			.List<ITaskBase>())
		{
			ITaskBase tt = item.CastAsRealType();
			base.ActionHandler.ActionExecuted(new EntityActionEventArgs(tt, tt, "0a37e597-3c2b-4a89-84fa-d8b0bd754fc3"));
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			((IQuery)base.Session.CreateSQLQuery(string.Format("update {0} set {1}=? where {2}=?", serviceNotNull.Dialect.QuoteIfNeeded("TaskBase"), serviceNotNull.Dialect.QuoteIfNeeded("ExpiredNotificationSent"), serviceNotNull.Dialect.QuoteIfNeeded("Id")))).SetParameter<bool>(0, true).SetParameter<long>(1, tt.Id).ExecuteUpdate(cleanUpCache: false);
			base.Session.CleanUpCache(tt);
			tt.Refresh();
			(from a in ComponentManager.Current.GetExtensionPoints<ITaskExpirationAction>()
				where a.CheckType(tt)
				select a).ForEach(delegate(ITaskExpirationAction a)
			{
				a.DoAction(tt, checkTime);
			});
		}
	}

	[Transaction]
	[ActionMethod("983b7725-7818-4aed-9367-bf6148e9518a")]
	public virtual T MarkRead(long taskId)
	{
		T val = LoadOrNull(taskId);
		if (val != null && CanMarkRead(taskId))
		{
			ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
			int num = ((IQuery)base.Session.CreateSQLQuery(string.Format("update {0} set {1}=? where {1}=? and {2}=?", serviceNotNull.Dialect.QuoteIfNeeded("TaskBase"), serviceNotNull.Dialect.QuoteIfNeeded("Status"), serviceNotNull.Dialect.QuoteIfNeeded("Id")))).SetParameter<Guid>(0, TaskBaseStatus.Read.Value).SetParameter<Guid>(1, TaskBaseStatus.NewOrder.Value).SetParameter<long>(2, taskId)
				.ExecuteUpdate(cleanUpCache: false);
			base.Session.CleanUpCache(val);
			if (num > 0)
			{
				val.Status = TaskBaseStatus.Read;
				EntityEntry entry = base.Session.GetSessionImplementation().get_PersistenceContext().GetEntry((object)val);
				if (entry != null && entry.get_Persister() != null && entry.get_LoadedState() != null)
				{
					int num2 = ((IList<string>)entry.get_Persister().get_PropertyNames()).IndexOf(LinqUtils.NameOf((Expression<Func<ITaskBase, object>>)((ITaskBase t) => t.Status)));
					if (num2 >= 0)
					{
						entry.get_LoadedState()[num2] = TaskBaseStatus.Read;
					}
				}
				base.ActionHandler.ActionExecuted(EntityActionEventArgs.TryCreate(null, val, TaskBaseActions.MarkReadGuid));
				ResetNewTasksCountCache(val.Executor.Id);
			}
		}
		return val;
	}

	[Transaction]
	[ActionMethod("525fb304-05ef-4741-9695-913d708db469")]
	public virtual void Terminate(T task, bool alert, ICommentActionModel actionModel = null)
	{
		if (actionModel == null)
		{
			actionModel = InterfaceActivator.Create<ICommentActionModel>();
		}
		ApplyCommentActionModel(task, actionModel);
		task.Status = TaskBaseStatus.WasClosed;
		Save(task);
		RaiseCommentActionEvent(null, task, "525fb304-05ef-4741-9695-913d708db469", actionModel, alert);
	}

	[ActionCheck("983b7725-7818-4aed-9367-bf6148e9518a")]
	public virtual bool CanMarkRead(long taskId)
	{
		T val = LoadOrNull(taskId);
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (val != null)
		{
			return TaskWorkflowActions.IsAvaliableMarkRead(val, currentUser);
		}
		return false;
	}

	[ActionMethod("e49a86f0-5c45-4db1-945a-6d0e20bde148")]
	[Transaction]
	public virtual T StartWork(long taskId, bool alertCoexecuters = true, ICommentActionModel actionModel = null)
	{
		T val = LoadOrNull(taskId);
		if (val != null && CanStartWork(taskId, alertCoexecuters, actionModel))
		{
			ApplyCommentActionModel(val, actionModel);
			val.Status = TaskBaseStatus.InProgress;
			Save(val);
			RaiseCommentActionEvent(null, val, "e49a86f0-5c45-4db1-945a-6d0e20bde148", actionModel, alertCoexecuters);
		}
		return val;
	}

	[ActionCheck("e49a86f0-5c45-4db1-945a-6d0e20bde148")]
	public virtual bool CanStartWork(long taskId, bool alertCoexecuters = true, ICommentActionModel actionModel = null)
	{
		T val = LoadOrNull(taskId);
		if (val != null)
		{
			return TaskWorkflowActions.IsAvailableStartWork(val, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
		}
		return false;
	}

	[Auditable]
	public virtual bool? CanStartReAssign(ITaskBase task, EleWise.ELMA.Security.Models.IUser userToStart)
	{
		if (task == null || userToStart == null || task.IsNew() || !task.IsActive())
		{
			return false;
		}
		if (task.CreationAuthor != userToStart && !TaskBaseManager<ITaskBase>.IsExecutor(task, userToStart, checkSubordinateUser: true) && !UserManager.Instance.IsSubordinateUser(userToStart, task.CreationAuthor))
		{
			return null;
		}
		return true;
	}

	[Auditable]
	public virtual bool? IsAvailableCopy(ITaskBase task)
	{
		return false;
	}

	[ActionCheck("9022bb4f-df58-4f4c-b0b1-f045e0ce293a")]
	public virtual bool CanReAssign(IReAssignActionModel reAssignModel)
	{
		if (IgnoreRedirectActionExecute)
		{
			return true;
		}
		T val = LoadOrNull(reAssignModel.TaskId);
		if (val == null || val.IsComplete())
		{
			return false;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (TaskWorkflowActions.IsAvailableReAssign(val, currentUser) && reAssignModel.Executor != null)
		{
			return reAssignModel.StartDate < reAssignModel.EndDate;
		}
		return false;
	}

	[Transaction]
	[ActionMethod("9022bb4f-df58-4f4c-b0b1-f045e0ce293a")]
	public virtual T ReAssign(IReAssignActionModel reAssignModel)
	{
		return InternalReAssign(reAssignModel);
	}

	[Auditable]
	protected virtual T InternalReAssign(IReAssignActionModel reAssignModel)
	{
		return InternalReAssignWork(reAssignModel);
	}

	protected virtual T InternalReAssignWork(IReAssignActionModel reAssignModel)
	{
		T val = LoadOrNull(reAssignModel.TaskId);
		if (val != null && CanReAssign(reAssignModel))
		{
			AddComment(val, reAssignModel.Comment);
			ICommentActionModel commentModel = null;
			if (reAssignModel.Comment != null)
			{
				InstanceOf<ICommentActionModel> instanceOf = new InstanceOf<ICommentActionModel>();
				instanceOf.New.Comment = reAssignModel.Comment;
				commentModel = instanceOf.New;
			}
			val.StartDate = ((reAssignModel.StartDate == DateTime.MinValue) ? null : new DateTime?(reAssignModel.StartDate));
			val.EndDate = ((reAssignModel.EndDate == DateTime.MaxValue) ? null : new DateTime?(reAssignModel.EndDate));
			val.Executor = reAssignModel.Executor;
			val.ExecutorReplaced = null;
			val.Priority = reAssignModel.Priority;
			val.Status = ((val.Status == TaskBaseStatus.OnApproval || val.Status == TaskBaseStatus.OnApprovalExecutor) ? val.Status : TaskBaseStatus.NewOrder);
			foreach (IReAssignActionHandler extensionPoint in ComponentManager.Current.GetExtensionPoints<IReAssignActionHandler>())
			{
				extensionPoint.BeforeCreateProcess(val, reAssignModel);
			}
			Save(val);
			RedirectActionExecute(val, commentModel);
		}
		return val;
	}

	protected void RedirectActionExecute(T task, ICommentActionModel commentModel = null)
	{
		if (!IgnoreRedirectActionExecute)
		{
			base.ActionHandler.ActionExecuted(TryCreateCommentActionEventArgs(null, task, "9022bb4f-df58-4f4c-b0b1-f045e0ce293a", commentModel));
		}
	}

	[ActionCheck("eda589f3-0d5d-4c9f-93cb-e0c28851ba04")]
	public virtual bool CanSchedule(long taskId, DateTime startDate, DateTime endDate, bool removeOther)
	{
		T task;
		try
		{
			task = LoadOrNull(taskId);
		}
		catch (SecurityException exception)
		{
			base.Logger.Debug(SR.T("Ошибка доступа к задаче"), exception);
			return false;
		}
		return CanSchedule(task, startDate, endDate);
	}

	[ContextCache]
	public virtual bool CanSchedule(T task, DateTime startDate, DateTime endDate)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (task != null && startDate < endDate)
		{
			return TaskWorkflowActions.IsAvailableSchedule(task, currentUser);
		}
		return false;
	}

	[Transaction]
	[ActionMethod("eda589f3-0d5d-4c9f-93cb-e0c28851ba04")]
	public virtual ITaskTimePlan Schedule(long taskId, DateTime startDate, DateTime endDate, bool removeOther)
	{
		ITaskTimePlan taskTimePlan = null;
		T val = LoadOrNull(taskId);
		if (val != null && CanSchedule(taskId, startDate, endDate, removeOther))
		{
			InstanceOf<ITaskTimePlan> instanceOf = new InstanceOf<ITaskTimePlan>();
			instanceOf.New.StartTime = startDate;
			instanceOf.New.EndTime = endDate;
			instanceOf.New.Task = val;
			taskTimePlan = instanceOf.New;
			if (removeOther)
			{
				((ICollection<ITaskTimePlan>)val.TimeSet).Clear();
			}
			val.TimeSet.Add(taskTimePlan);
			val.Save();
			base.ActionHandler.ActionExecuted(EntityActionEventArgs.TryCreate(null, val, "eda589f3-0d5d-4c9f-93cb-e0c28851ba04"));
		}
		return taskTimePlan;
	}

	[Transaction]
	[ActionMethod("5e7c9eb0-2f5a-4f59-b39d-053d054a1880")]
	public virtual T DoActivate(long taskId)
	{
		T val = LoadOrNull(taskId);
		if (val != null && CanDoActivate(taskId))
		{
			val.Status = TaskBaseStatus.NewOrder;
			Save(val);
			base.ActionHandler.ActionExecuted(EntityActionEventArgs.TryCreate(null, val, "5e7c9eb0-2f5a-4f59-b39d-053d054a1880"));
		}
		return val;
	}

	[ActionCheck("5e7c9eb0-2f5a-4f59-b39d-053d054a1880")]
	public virtual bool CanDoActivate(long taskId)
	{
		T val = LoadOrNull(taskId);
		if (val != null)
		{
			return val.Status == TaskBaseStatus.Prepared;
		}
		return false;
	}

	public virtual void SetProjections(ICriteria criteria, Type type, List<string> projections, FetchOptions fetchOptions = null)
	{
		if (projections != null && projections.Count > 0)
		{
			fetchOptions = fetchOptions ?? FetchOptions.All;
			fetchOptions.UseProjections = true;
			fetchOptions.SelectColumns = projections;
			SetupFetchOptions(criteria, fetchOptions, type);
		}
	}

	public long GetCurrentCount(EleWise.ELMA.Security.Models.IUser user)
	{
		string text = ((user != null) ? ("TaskBaseManager.CurrentTasksCount:" + user.Id) : null);
		if (text != null && CacheService != null && CacheService.TryGetValue<long>(text, out var value))
		{
			return value;
		}
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.NotShowInLists = false;
		taskBaseFilter.Executor = user;
		taskBaseFilter.CompleteStatus = TaskCompleteStatus.Active;
		value = Count(taskBaseFilter);
		if (text != null && CacheService != null)
		{
			CacheService.Insert(text, value);
		}
		return value;
	}

	public long GetNewTasksCount(EleWise.ELMA.Security.Models.IUser user)
	{
		string text = ((user != null) ? ("TaskBaseManager.NewTasksCount:" + user.Id) : null);
		if (text != null && CacheService != null && CacheService.TryGetValue<long>(text, out var value))
		{
			return value;
		}
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.NotShowInLists = false;
		taskBaseFilter.Executor = user;
		taskBaseFilter.Status = TaskBaseStatus.NewOrder;
		value = Count(taskBaseFilter);
		if (text != null && CacheService != null)
		{
			CacheService.Insert(text, value);
		}
		return value;
	}

	public long GetCurrentCoExecutorCount(EleWise.ELMA.Security.Models.IUser user)
	{
		string text = ((user != null) ? ("TaskBaseManager.CurrentTasksCoExecutorCount:" + user.Id) : null);
		if (text != null && CacheService != null && CacheService.TryGetValue<long>(text, out var value))
		{
			return value;
		}
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.NotShowInLists = false;
		taskBaseFilter.InformTo.Add(user);
		taskBaseFilter.CompleteStatus = TaskCompleteStatus.Active;
		value = Count(taskBaseFilter);
		if (text != null && CacheService != null)
		{
			CacheService.Insert(text, value);
		}
		return value;
	}

	public void ResetCurrentCountCache(long userId)
	{
		if (CacheService != null)
		{
			string key = "TaskBaseManager.CurrentTasksCount:" + userId;
			CacheService.Remove(key);
			CacheService.Remove("TaskBaseManager.CurrentTasksCoExecutorCount:" + userId);
		}
		ResetNewTasksCountCache(userId);
	}

	public long GetCurrentCountFrom(EleWise.ELMA.Security.Models.IUser user)
	{
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.NotShowInLists = false;
		taskBaseFilter.CompleteStatus = TaskCompleteStatus.Active;
		taskBaseFilter.CreationAuthor = user;
		return Count(taskBaseFilter);
	}

	public long GetExpiredCount(EleWise.ELMA.Security.Models.IUser user)
	{
		return GetExpiredCount(user, null);
	}

	public long GetExpiredCount(EleWise.ELMA.Security.Models.IUser user, List<Guid> typeUids)
	{
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.NotShowInLists = false;
		taskBaseFilter.CompleteStatus = TaskCompleteStatus.Expired;
		taskBaseFilter.CreationAuthor = user;
		taskBaseFilter.TypeUids = typeUids;
		return Count(taskBaseFilter);
	}

	public long GetInformToExpiredCount(EleWise.ELMA.Security.Models.IUser user)
	{
		return GetInformToExpiredCount(user, null);
	}

	public long GetInformToExpiredCount(EleWise.ELMA.Security.Models.IUser user, List<Guid> typeUids)
	{
		ITaskBaseFilter taskBaseFilter = InterfaceActivator.Create<ITaskBaseFilter>();
		taskBaseFilter.NotShowInLists = false;
		taskBaseFilter.CompleteStatus = TaskCompleteStatus.Expired;
		taskBaseFilter.InformTo.Add(user);
		if (typeUids != null)
		{
			taskBaseFilter.TypeUids = typeUids;
		}
		return Count(taskBaseFilter);
	}

	public PerformanceDiscipline GetPerformanceDiscipline(EleWise.ELMA.Security.Models.IUser user, DateTime periodStart, DateTime periodEnd, bool enableCache = true)
	{
		if (user != null)
		{
			string key = null;
			if (enableCache)
			{
				key = "TaskBaseManager.CurrentTasksCount:" + user.Id + periodStart.ToShortDateString() + periodEnd.ToShortDateString();
				if (CacheService != null && CacheService.TryGetValue<PerformanceDiscipline>(key, out var value))
				{
					return value;
				}
			}
			if (periodStart < DateTime.Now)
			{
				InstanceOf<ITaskBaseFilter> instanceOf = new InstanceOf<ITaskBaseFilter>();
				instanceOf.New.Query = user.GetDisciplineWellDoneQuery(periodStart, periodEnd);
				instanceOf.New.DisableSecurity = true;
				ITaskBaseFilter filterWellDone = instanceOf.New;
				int WellDoneTasks = 0;
				base.SecurityService.RunWithElevatedPrivilegies(delegate
				{
					WellDoneTasks = (int)Count(filterWellDone);
				});
				InstanceOf<ITaskBaseFilter> instanceOf2 = new InstanceOf<ITaskBaseFilter>();
				instanceOf2.New.Query = user.GetDisciplineProtractedQuery(periodStart, periodEnd);
				instanceOf2.New.DisableSecurity = true;
				ITaskBaseFilter filterProtracted = instanceOf2.New;
				int ProtractedTasks = 0;
				base.SecurityService.RunWithElevatedPrivilegies(delegate
				{
					ProtractedTasks = (int)Count(filterProtracted);
				});
				PerformanceDiscipline performanceDiscipline = new PerformanceDiscipline(WellDoneTasks, ProtractedTasks);
				if (enableCache && CacheService != null)
				{
					performanceDiscipline.ChangeDate = DateTime.Now;
					CacheService.Insert(key, performanceDiscipline);
				}
				return performanceDiscipline;
			}
		}
		return new PerformanceDiscipline();
	}

	public void UpdatePerformanceDiscipline(EleWise.ELMA.Security.Models.IUser user, DateTime periodStart, DateTime periodEnd)
	{
		if (CacheService != null)
		{
			string key = "TaskBaseManager.CurrentTasksCount:" + user.Id + periodStart.ToShortDateString() + periodEnd.ToShortDateString();
			CacheService.Remove(key);
		}
	}

	public List<ExecutorInfo> GetMyDepartmentCounts(ITaskBaseFilter filter, string groupProperty)
	{
		ICriteria val = CreateCriteria(filter);
		SetupFilter(val, filter);
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		Func<object[], ExecutorInfo> selector = (object[] a) => new ExecutorInfo
		{
			Executor = (EleWise.ELMA.Security.Models.IUser)a[0],
			Count = (int)a[1]
		};
		if (groupProperty == "InformTo")
		{
			ICriteria obj = val.CreateAlias("InformTo", "informUser", (JoinType)0);
			object[] values = new object[1] { currentUser.Id };
			IType[] types = (IType[])(object)new Int64Type[1] { NHibernateUtil.Int64 };
			obj.Add((ICriterion)(object)NHQueryExtensions.Sql("{informUser.Id} in (select s.SubordinateUserId from UserSecuritySetCache s where s.UserId = ?)", values, types));
			groupProperty = "informUser.Id";
			selector = (object[] a) => new ExecutorInfo
			{
				Executor = UserManager.Instance.Load((long)a[0]),
				Count = (int)a[1]
			};
		}
		else
		{
			string text = $"{{alias}}.{groupProperty} in (select s.SubordinateUserId from UserSecuritySetCache s where s.UserId = ?)";
			object[] obj2 = new object[1] { currentUser.Id };
			IType[] types = (IType[])(object)new Int64Type[1] { NHibernateUtil.Int64 };
			val.Add((ICriterion)(object)Expression.Sql(text, obj2, types));
		}
		return val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty(groupProperty), "Executor").Add((IProjection)(object)Projections.Count("Id"), "Count") }).List<object[]>().Select(selector)
			.ToList();
	}

	protected virtual ICriteria CreateCriteriaNoPermissions()
	{
		return base.Session.CreateCriteria(InterfaceActivator.TypeOf<ITaskBase>());
	}

	public static bool AccessToAllTasks(EleWise.ELMA.Security.Models.IUser user)
	{
		ISecurityService securityService = InterfaceActivator.Create<ISecurityService>();
		if (user != null && securityService.HasPermission(user, PermissionProvider.AccessToAllTasks))
		{
			return true;
		}
		return false;
	}

	public IEnumerable<CreateSubTaskHistoryInfoModel> GetSubTaskInfoForCreateAction(SubTaskCreateInfo info)
	{
		ICriteria obj = CreateCriteriaNoPermissions().SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Id(), "Id").Add((IProjection)(object)Projections.Property("Subject"), "Subject") });
		obj.Add((ICriterion)(object)Restrictions.In("Id", (ICollection)info.SubTasksIds.ToList()));
		return obj.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(CreateSubTaskHistoryInfoModel))).List<CreateSubTaskHistoryInfoModel>().ToList();
	}

	internal void UpdateAttachmentsSpecifiedHash(ITaskBase task, bool saveAttachments = false)
	{
		if (task == null || !NHibernateUtil.IsInitialized((object)task))
		{
			return;
		}
		string[] source = ((task.AttachmentSpecifiedHash != null) ? task.AttachmentSpecifiedHash.Split(';') : new string[0]);
		StringBuilder stringBuilder = new StringBuilder();
		foreach (ITaskAttachmetSpecifiedHistoryExtension extension in TaskAttachmetSpecifiedExtensions)
		{
			if (saveAttachments)
			{
				extension.SaveAttachments(task);
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(";");
			}
			bool flag = true;
			if (!extension.AttachmentsIdsInitialized(task))
			{
				string text = source.FirstOrDefault((string a) => a.Contains(extension.Name + ":"));
				if (text != null)
				{
					stringBuilder.Append(text);
					flag = false;
				}
			}
			if (flag)
			{
				stringBuilder.Append(string.Format("{0}:{1}", extension.Name, string.Join(",", (from id in extension.AttachmentsIds(task)
					orderby id
					select id).ToArray())));
			}
		}
		string text2 = stringBuilder.ToString();
		if (task.AttachmentSpecifiedHash != text2)
		{
			task.AttachmentSpecifiedHash = text2;
		}
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		ITaskBaseFilter taskBaseFilter = filter as ITaskBaseFilter;
		bool? notShowInLists = taskBaseFilter?.NotShowInLists;
		if (taskBaseFilter != null)
		{
			taskBaseFilter.NotShowInLists = null;
		}
		base.SetupFilter(criteria, filter);
		if (taskBaseFilter == null)
		{
			return;
		}
		taskBaseFilter.NotShowInLists = notShowInLists;
		if (taskBaseFilter.NotShowInLists.HasValue)
		{
			criteria.Add((ICriterion)(taskBaseFilter.NotShowInLists.Value ? ((object)Restrictions.Eq("NotShowInLists", (object)true)) : ((object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("NotShowInLists"), (ICriterion)(object)Restrictions.Eq("NotShowInLists", (object)false)))));
		}
		switch (taskBaseFilter.CompleteStatus)
		{
		case TaskCompleteStatus.Expired:
			criteria.Add((ICriterion)(object)Restrictions.Lt("EndDate", (object)DateTime.Now));
			goto case TaskCompleteStatus.Active;
		case TaskCompleteStatus.NotExpired:
			criteria.Add((ICriterion)(object)Restrictions.Ge("EndDate", (object)DateTime.Now));
			goto case TaskCompleteStatus.Active;
		case TaskCompleteStatus.Active:
		{
			object[] closeStatuses = TaskBaseExtensions.ActiveTaskStatuses;
			criteria.Add((ICriterion)(object)Restrictions.In("Status", closeStatuses));
			break;
		}
		case TaskCompleteStatus.Complete:
		{
			object[] closeStatuses = TaskBaseExtensions.CloseStatuses;
			criteria.Add((ICriterion)(object)Restrictions.In("Status", closeStatuses));
			break;
		}
		}
		if (taskBaseFilter.Statuses != null && taskBaseFilter.Statuses.Count > 0)
		{
			criteria.Add((ICriterion)(object)Restrictions.In("Status", (ICollection)taskBaseFilter.Statuses));
		}
		if (taskBaseFilter.IsPlanned.HasValue)
		{
			criteria.Add((ICriterion)(object)(taskBaseFilter.IsPlanned.Value ? Restrictions.IsNotEmpty("TimeSet") : Restrictions.IsEmpty("TimeSet")));
		}
		bool flag = taskBaseFilter.Executors != null && ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)taskBaseFilter.Executors).Any();
		bool flag2 = taskBaseFilter.CreationAuthors != null && ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)taskBaseFilter.CreationAuthors).Any();
		if (flag)
		{
			string alias = "executor";
			criteria.GetOrCreateAlias("Executor", (JoinType)0, ref alias).Add((ICriterion)(object)Restrictions.In($"{alias}.Id", (ICollection)((IEnumerable<EleWise.ELMA.Security.Models.IUser>)taskBaseFilter.Executors).Select((EleWise.ELMA.Security.Models.IUser e) => e.Id).ToArray()));
		}
		if (flag2)
		{
			string alias2 = "author";
			criteria.GetOrCreateAlias("CreationAuthor", (JoinType)0, ref alias2).Add((ICriterion)(object)Restrictions.In($"{alias2}.Id", (ICollection)((IEnumerable<EleWise.ELMA.Security.Models.IUser>)taskBaseFilter.CreationAuthors).Select((EleWise.ELMA.Security.Models.IUser e) => e.Id).ToArray()));
		}
		if (taskBaseFilter.OnlyForMyDepartment.HasValue && taskBaseFilter.OnlyForMyDepartment.Value && !flag)
		{
			EleWise.ELMA.Security.Models.IUser currentUser = EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			List<EleWise.ELMA.Security.Models.IUser> list = UserManager.Instance.GetSubordinateByUser(currentUser).ToList();
			list.Add(currentUser);
			taskBaseFilter.Executor = null;
			string alias3 = "executor";
			criteria.GetOrCreateAlias("Executor", (JoinType)0, ref alias3).Add((ICriterion)(object)Restrictions.In($"{alias3}.Id", (ICollection)list.Select((EleWise.ELMA.Security.Models.IUser e) => e.Id).ToArray()));
		}
		if (taskBaseFilter.OnlyFromMyDepartment.HasValue && taskBaseFilter.OnlyFromMyDepartment.Value && !flag2)
		{
			EleWise.ELMA.Security.Models.IUser currentUser2 = EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			List<EleWise.ELMA.Security.Models.IUser> list2 = UserManager.Instance.GetSubordinateByUser(currentUser2).ToList();
			list2.Add(currentUser2);
			taskBaseFilter.CreationAuthor = null;
			string alias4 = "author";
			criteria.GetOrCreateAlias("CreationAuthor", (JoinType)0, ref alias4).Add((ICriterion)(object)Restrictions.In($"{alias4}.Id", (ICollection)list2.Select((EleWise.ELMA.Security.Models.IUser e) => e.Id).ToArray()));
		}
		if (taskBaseFilter.DatePeriod.From.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Ge("EndDate", (object)taskBaseFilter.DatePeriod.From));
		}
		if (taskBaseFilter.DatePeriod.To.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Le("StartDate", (object)taskBaseFilter.DatePeriod.To));
		}
		if (taskBaseFilter.TypeUids != null && taskBaseFilter.TypeUids.Count > 0)
		{
			criteria.Add((ICriterion)(object)Restrictions.In(GetTypeUidPropertyName(filter), (ICollection)taskBaseFilter.TypeUids));
		}
		if (taskBaseFilter.ExcludedTypeUids != null && taskBaseFilter.ExcludedTypeUids.Count > 0)
		{
			criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.In(GetTypeUidPropertyName(filter), (ICollection)taskBaseFilter.ExcludedTypeUids)));
		}
	}

	protected virtual void AddComment(ITaskBase task, IComment comment)
	{
		if (task != null && comment != null && !string.IsNullOrEmpty(comment.Text))
		{
			task.Comments.Add(comment);
		}
	}

	[Auditable]
	protected virtual void ApplyCommentActionModel(ITaskBase task, ICommentActionModel actionModel)
	{
		CommentActionHandler.Process(task, actionModel);
	}

	[Auditable]
	protected virtual EntityActionEventArgs TryCreateCommentActionEventArgs(ITaskBase old, ITaskBase @new, string actionUidStr, ICommentActionModel actionModel)
	{
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(old, @new, actionUidStr);
		if (entityActionEventArgs != null)
		{
			CommentActionHandler.ProcessEventArgs(entityActionEventArgs, actionModel);
		}
		return entityActionEventArgs;
	}

	protected virtual void RaiseCommentActionEvent(ITaskBase old, ITaskBase @new, string actionUidStr, ICommentActionModel actionModel, bool? alertCoexecuters = null)
	{
		EntityActionEventArgs entityActionEventArgs = TryCreateCommentActionEventArgs(old, @new, actionUidStr, actionModel);
		if (entityActionEventArgs != null)
		{
			entityActionEventArgs.ExtendedProperties.Add("AlertCoexecuters", alertCoexecuters.HasValue && alertCoexecuters.Value);
			base.ActionHandler.ActionExecuted(entityActionEventArgs);
		}
	}

	[Transaction]
	public virtual void RaiseCompleteActionEvent(ITaskBase old, ITaskBase @new)
	{
		base.ActionHandler.ActionExecuted(EntityActionEventArgs.TryCreate(old, @new, "6c6b90f3-295f-4fd9-ab4c-0a80144b7bd8"));
	}

	[Transaction]
	public virtual void RaiseCreateSubTaskActionExecute(ITaskBase subTask)
	{
		base.ActionHandler.ActionExecuted(new SubTaskCreateActionEventArgs(subTask.ParentTask, subTask.ParentTask, TaskBaseActions.CreateSubTaskGuid, new SubTaskCreateInfo
		{
			SubTasksIds = new List<long> { subTask.Id }
		}));
	}

	[Transaction]
	public virtual void RaiseCreateSubTaskActionExecute(ITaskBase task, IEnumerable<long> subTasks)
	{
		base.ActionHandler.ActionExecuted(new SubTaskCreateActionEventArgs(task, task, TaskBaseActions.CreateSubTaskGuid, new SubTaskCreateInfo
		{
			SubTasksIds = subTasks
		}));
	}

	[Transaction]
	public virtual void RaiseReplacementActionIfHasExecutorReplaced(ITaskBase task)
	{
		if (task != null && task.Executor != null && task.ExecutorReplaced != null)
		{
			base.ActionHandler.ActionExecuted(ReplacementTaskActionEventArgs.TryCreate(null, task, task.Id, task.Executor.Id, task.ExecutorReplaced.Id));
		}
	}

	private void ResetNewTasksCountCache(long userId)
	{
		if (CacheService != null)
		{
			CacheService.Remove("TaskBaseManager.NewTasksCount:" + userId);
		}
	}

	[Transaction]
	[PublicApiMember]
	public virtual void AddComment(T task, string comment, IEnumerable<IAttachment> attachments)
	{
		if (task == null)
		{
			throw new NullReferenceException(SR.T("Задача не может быть null"));
		}
		IComment comment2 = InterfaceActivator.Create<IComment>();
		comment2.Text = comment;
		comment2.CreationDate = DateTime.Now;
		comment2.CreationAuthor = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		comment2.Save();
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = comment2;
		if (attachments != null)
		{
			commentActionModel.Attachments = new List<IAttachment>();
			foreach (IAttachment attachment in attachments)
			{
				IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
				EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, attachment, DefaultEntityActions.CreateGuid);
				if (entityActionEventArgs != null)
				{
					serviceNotNull.ActionExecuted(entityActionEventArgs);
				}
				commentActionModel.Attachments.Add(attachment);
			}
		}
		AddComment(task, commentActionModel);
	}

	[PublicApiMember]
	public virtual void AddComment(T task, string comment, EleWise.ELMA.Security.Models.IUser commentAuthor)
	{
		if (commentAuthor == null)
		{
			throw new NullReferenceException(SR.T("Автор комментария не может быть null"));
		}
		if (commentAuthor != base.AuthenticationService.GetCurrentUser())
		{
			base.SecurityService.RunByUser(commentAuthor, delegate
			{
				AddComment(task, comment);
			});
		}
		else
		{
			AddComment(task, comment);
		}
	}

	[Transaction]
	[PublicApiMember]
	public virtual void AddComment(T task, string comment)
	{
		AddComment(task, comment, (IEnumerable<IAttachment>)null);
	}

	[PublicApiMember]
	public virtual void AddComment(T task, ICommentActionModel model)
	{
		ICommentActionHandler serviceNotNull = Locator.GetServiceNotNull<ICommentActionHandler>();
		serviceNotNull.Process(task, model);
		task.Comments.Add(model.Comment);
		task.Save();
		IEntityActionHandler serviceNotNull2 = Locator.GetServiceNotNull<IEntityActionHandler>();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, task, TaskBaseActions.AddCommentGuid);
		if (entityActionEventArgs != null)
		{
			entityActionEventArgs.ActionAuthor = model.Comment.CreationAuthor;
			serviceNotNull.ProcessEventArgs(entityActionEventArgs, model);
			serviceNotNull2.ActionExecuted(entityActionEventArgs);
		}
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor)
	{
		ReAssign(taskId, newExecutor, (IComment)null);
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, string comment)
	{
		ReAssign(taskId, newExecutor, CreateComment(comment));
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, IComment comment)
	{
		T val = LoadOrNull(taskId);
		if (val == null)
		{
			throw new NullReferenceException(SR.T("Задача не может быть null"));
		}
		ReAssign(taskId, newExecutor, val.StartDate ?? DateTime.MinValue, val.EndDate ?? DateTime.MaxValue, val.Priority, comment);
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime endDate)
	{
		ReAssign(taskId, newExecutor, endDate, (IComment)null);
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime endDate, string comment)
	{
		ReAssign(taskId, newExecutor, endDate, CreateComment(comment));
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime endDate, IComment comment)
	{
		T val = LoadOrNull(taskId);
		if (val == null)
		{
			throw new NullReferenceException(SR.T("Задача не может быть null"));
		}
		ReAssign(taskId, newExecutor, val.StartDate ?? DateTime.MinValue, endDate, val.Priority, comment);
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate)
	{
		ReAssign(taskId, newExecutor, startDate, endDate, (IComment)null);
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate, string comment)
	{
		ReAssign(taskId, newExecutor, startDate, endDate, CreateComment(comment));
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate, IComment comment)
	{
		T val = LoadOrNull(taskId);
		if (val == null)
		{
			throw new NullReferenceException(SR.T("Задача не может быть null"));
		}
		ReAssign(taskId, newExecutor, startDate, endDate, val.Priority, comment);
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate, TaskPriority priority)
	{
		ReAssign(taskId, newExecutor, startDate, endDate, priority, (IComment)null);
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate, TaskPriority priority, string comment)
	{
		ReAssign(taskId, newExecutor, startDate, endDate, priority, CreateComment(comment));
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, TaskPriority priority, string comment)
	{
		T val = LoadOrNull(taskId);
		if (val == null)
		{
			throw new NullReferenceException(SR.T("Задача не может быть null"));
		}
		ReAssign(taskId, newExecutor, startDate, val.EndDate ?? DateTime.MaxValue, priority, CreateComment(comment));
	}

	[PublicApiMember]
	public void ReAssign(long taskId, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate, TaskPriority priority, IComment comment)
	{
		T val = LoadOrNull(taskId);
		if (val == null)
		{
			throw new NullReferenceException(SR.T("Задача не может быть null"));
		}
		if (newExecutor == null)
		{
			throw new NullReferenceException(SR.T("Исполнитель не может быть null"));
		}
		IReAssignActionModel reAssignActionModel = InterfaceActivator.Create<IReAssignActionModel>();
		reAssignActionModel.TaskId = val.Id;
		reAssignActionModel.StartDate = startDate;
		reAssignActionModel.EndDate = endDate;
		reAssignActionModel.Executor = newExecutor;
		reAssignActionModel.Priority = priority;
		reAssignActionModel.Comment = comment;
		ReAssign(reAssignActionModel);
	}

	private IComment CreateComment(string comment)
	{
		IComment comment2 = InterfaceActivator.Create<IComment>();
		comment2.Text = comment;
		comment2.CreationAuthor = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		comment2.CreationDate = DateTime.Now;
		comment2.Save();
		return comment2;
	}

	[PublicApiMember]
	public void SetTaskEndDate(long taskId, DateTime newEndDate)
	{
		T val = Load(taskId);
		if (val == null)
		{
			throw new NullReferenceException(SR.T("Задача не может быть null"));
		}
		val.EndDate = newEndDate;
		val.Save();
		IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, val, TaskBaseActions.ChangeEndDateGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ActionExecuted(entityActionEventArgs);
		}
	}

	[PublicApiMember]
	public void SetFactWorkLog(long taskId, long minutes, DateTime startDate, string comment)
	{
		T val = LoadOrNull(taskId);
		if (val == null)
		{
			throw new NullReferenceException(SR.T("Задача не может быть null"));
		}
		if (minutes <= 0)
		{
			throw new ArgumentException(SR.T("Время должно отличаться от нуля и не должно быть отрицательным"));
		}
		IWorkLog workLog = InterfaceActivator.Create<IWorkLog>();
		workLog.WorkMinutes = new WorkTime
		{
			Value = minutes
		};
		workLog.Worker = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		workLog.StartDate = startDate;
		workLog.Comment = comment;
		workLog.TaskBase = val;
		workLog.Save();
	}

	[PublicApiMember]
	public void SetFactWorkLog(long taskId, long minutes, string comment)
	{
		SetFactWorkLog(taskId, minutes, DateTime.Now, comment);
	}

	[PublicApiMember]
	public void SetFactWorkLog(long taskId, long minutes, DateTime startDate)
	{
		SetFactWorkLog(taskId, minutes, startDate, null);
	}

	[PublicApiMember]
	public void SetFactWorkLog(long taskId, long minutes)
	{
		SetFactWorkLog(taskId, minutes, DateTime.Now, null);
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogHours(long taskId, long hours, DateTime startDate)
	{
		long minutes = hours * 60;
		SetFactWorkLog(taskId, minutes, startDate, null);
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogHours(long taskId, long hours, string comment)
	{
		long minutes = hours * 60;
		SetFactWorkLog(taskId, minutes, DateTime.Now, comment);
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogHours(long taskId, long hours)
	{
		long minutes = hours * 60;
		SetFactWorkLog(taskId, minutes, DateTime.Now, null);
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogHours(long taskId, long hours, DateTime startDate, string comment)
	{
		long minutes = hours * 60;
		SetFactWorkLog(taskId, minutes, startDate, comment);
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogDays(long taskId, long days, DateTime startDate)
	{
		long minutes = days * InterfaceActivator.Create<ProductionCalendarService>().GetWorkTimeInDay().Hours * 60;
		SetFactWorkLog(taskId, minutes, startDate, null);
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogDays(long taskId, long days, string comment)
	{
		long minutes = days * InterfaceActivator.Create<ProductionCalendarService>().GetWorkTimeInDay().Hours * 60;
		SetFactWorkLog(taskId, minutes, DateTime.Now, comment);
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogDays(long taskId, long days)
	{
		long minutes = days * InterfaceActivator.Create<ProductionCalendarService>().GetWorkTimeInDay().Hours * 60;
		SetFactWorkLog(taskId, minutes, DateTime.Now, null);
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogDays(long taskId, long days, DateTime startDate, string comment)
	{
		long minutes = days * InterfaceActivator.Create<ProductionCalendarService>().GetWorkTimeInDay().Hours * 60;
		SetFactWorkLog(taskId, minutes, startDate, comment);
	}

	[Transaction]
	[PublicApiMember]
	[PublicApiNodeIgnore(new string[] { "PublicAPI.Projects.ProjectTask", "WorkflowTaskProcessesApi", "TasksProjectsApi" })]
	public virtual void CompleteTask(long taskId, CompleteTaskModel model)
	{
		T val = LoadOrNull(taskId);
		if (val != null)
		{
			if (model.worklogMinutes.HasValue)
			{
				IWorkLog workLog = InterfaceActivator.Create<IWorkLog>();
				workLog.WorkMinutes = new WorkTime
				{
					Value = model.worklogMinutes.Value
				};
				workLog.StartDate = (model.startDate.HasValue ? model.startDate : new DateTime?(DateTime.Now));
				workLog.Worker = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				workLog.TaskBase = val;
				workLog.Save();
			}
			TaskManager.Instance.DoCompleted(val.Id, model.alertCoexecuters, model.actionModel);
		}
	}
}
