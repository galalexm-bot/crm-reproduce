using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class TaskManager : TaskBaseManager<ITask>
{
	internal const string ChangedTemplatesContextVarName = "PeriodTaskTemplate_ChangedTemplates";

	public new ISecurityService SecurityService => Locator.GetService<ISecurityService>();

	[NotNull]
	public IEntityManager<IApprovalTask, long> ApprovalTaskManager { get; set; }

	[NotNull]
	public IProductionCalendarService ProductionCalendar { get; set; }

	[NotNull]
	public ICurrentControllersFilterService CurrentControllersFilterService { get; set; }

	[NotNull]
	public IEnumerable<ILinkedTaskCloseChecker> LinkedTaskCloseCheckers { get; set; }

	[NotNull]
	public new static TaskManager Instance => Locator.GetServiceNotNull<TaskManager>();

	[PublicApiMember]
	public override ITask Create()
	{
		ITask task = base.Create();
		task.UnderControl = TaskControlSettingsHelper.SetControl();
		task.ControlType = TaskControlSettingsHelper.DefaultControlType();
		task.Period = CalendarEventPeriod.Once;
		return task;
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (!(filter is ITaskFilter taskFilter))
		{
			return;
		}
		if (taskFilter.Periodical.HasValue)
		{
			if (taskFilter.Periodical.Value)
			{
				criteria.Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq("Period", (object)CalendarEventPeriod.Once)));
			}
			else
			{
				criteria.Add((ICriterion)(object)Restrictions.Eq("Period", (object)CalendarEventPeriod.Once));
			}
		}
		if (taskFilter.ControlStatus.HasValue)
		{
			switch (taskFilter.ControlStatus.Value)
			{
			case TaskControlStatus.ExecutionAll:
			{
				object[] currentControlStatuses = TaskBaseExtensions.ControlAllStatuses;
				criteria.Add((ICriterion)(object)Restrictions.In("Status", currentControlStatuses));
				break;
			}
			case TaskControlStatus.ExecutionActive:
			{
				object[] currentControlStatuses = TaskBaseExtensions.ControlStatuses;
				criteria.Add((ICriterion)(object)Restrictions.In("Status", currentControlStatuses));
				break;
			}
			case TaskControlStatus.Current:
			{
				object[] currentControlStatuses = TaskBaseExtensions.CurrentControlStatuses;
				criteria.Add((ICriterion)(object)Restrictions.In("Status", currentControlStatuses));
				break;
			}
			}
		}
		CurrentControllersFilterService.SetupCurrentControllersFilter(criteria, taskFilter.UnderControl, taskFilter.ControlType, taskFilter.ControlUser, taskFilter.CurrentControllers, "Task", "M_Task_CurrentControllers", "TaskId", "UserId");
	}

	public long GetCurrentControlCount(EleWise.ELMA.Security.Models.IUser user)
	{
		return GetCurrentControlCount(user, null);
	}

	public long GetCurrentControlCount(EleWise.ELMA.Security.Models.IUser user, List<Guid> types)
	{
		ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
		taskFilter.NotShowInLists = false;
		taskFilter.UnderControl = true;
		taskFilter.CurrentControllers.Add(user);
		taskFilter.ControlStatus = TaskControlStatus.Current;
		if (types != null)
		{
			taskFilter.TypeUids = types;
		}
		return Count(taskFilter);
	}

	public long GetExecutionControlCount(EleWise.ELMA.Security.Models.IUser user)
	{
		return GetExecutionControlCount(user, null);
	}

	public long GetExecutionControlCount(EleWise.ELMA.Security.Models.IUser user, List<Guid> types)
	{
		ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
		taskFilter.NotShowInLists = false;
		taskFilter.UnderControl = true;
		taskFilter.ControlUser = user;
		taskFilter.ControlType = TaskControlType.Execution;
		taskFilter.Statuses = TaskBaseExtensions.ControlStatuses.ToList();
		if (types != null)
		{
			taskFilter.TypeUids = types;
		}
		return Count(taskFilter);
	}

	public override bool? CanStartReAssign(ITaskBase task, EleWise.ELMA.Security.Models.IUser userToStart)
	{
		if (!(task is ITask task2))
		{
			return false;
		}
		if (task2.IsTemplate)
		{
			return false;
		}
		bool? flag = base.CanStartReAssign(task, userToStart);
		if (flag.HasValue)
		{
			return flag.Value;
		}
		if (!CanStartReassignInternal(userToStart, task2))
		{
			return null;
		}
		return true;
	}

	public override bool? IsAvailableCopy(ITaskBase task)
	{
		return true;
	}

	private bool CanStartReassignInternal(EleWise.ELMA.Security.Models.IUser userToStart, ITask task1)
	{
		if (task1 != null && userToStart != null)
		{
			return IsUserControlsTask(userToStart, task1);
		}
		return false;
	}

	[ActionMethod("2053dfab-43ec-41a3-8069-47de16f75be2")]
	[Transaction]
	public virtual ITask Close(long taskId, bool alert, ICommentActionModel actionModel = null)
	{
		ITask task = LoadOrNull(taskId);
		if (task != null && CanClose(taskId, alert, actionModel))
		{
			IApprovalTask approvalTask = (IApprovalTask)((IEnumerable<ITaskBase>)task.ChildTasks).LastOrDefault((ITaskBase t) => t is IApprovalTask && ((IApprovalTask)t).ApprovalStatus == ApprovalStatus.None);
			if (approvalTask != null)
			{
				approvalTask.ApprovalStatus = ApprovalStatus.Terminated;
				approvalTask.Status = TaskBaseStatus.WasClosed;
				approvalTask.Save();
				RaiseCommentActionEvent(null, approvalTask, "a56477d4-cace-4545-9f1e-a318d89f0c54", actionModel, alert);
			}
			ApplyCommentActionModel(task, actionModel);
			task.Status = TaskBaseStatus.WasClosed;
			Save(task);
			RaiseCommentActionEvent(null, task, "2053dfab-43ec-41a3-8069-47de16f75be2", actionModel, alert);
		}
		return task;
	}

	public ITaskFilter PeriodicalTasksForCloseFilter(ITask task, bool disableSecurity = false)
	{
		InstanceOf<ITaskFilter> instanceOf = new InstanceOf<ITaskFilter>();
		instanceOf.New.PeriodTemplate = task;
		instanceOf.New.CompleteStatus = TaskCompleteStatus.Active;
		instanceOf.New.DisableSecurity = disableSecurity;
		return instanceOf.New;
	}

	[Transaction]
	public virtual void ClosePeriodTask(ITask task, bool closeInstances)
	{
		if (closeInstances)
		{
			foreach (ITask item in Find(PeriodicalTasksForCloseFilter(task, disableSecurity: true), FetchOptions.All))
			{
				Close(item.Id, alert: true);
			}
			task.LastPeriodTaskDate = null;
		}
		Close(task.Id, alert: true);
	}

	[ActionCheck("2053dfab-43ec-41a3-8069-47de16f75be2")]
	public virtual bool CanClose(long taskId, bool alert, ICommentActionModel actionModel = null)
	{
		if (ContextVars.TryGetValue<bool>("DisableActionCheck", out var value) && value)
		{
			return true;
		}
		ITask task = LoadOrNull(taskId);
		if (task != null)
		{
			return base.TaskWorkflowActions.IsAvailableClose(task, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
		}
		return false;
	}

	[Transaction]
	[ActionMethod("ca7e4640-b9c8-4849-aa55-a9316ce9006a")]
	public virtual ITask DoControlComplete(long taskId, ICommentActionModel actionModel = null)
	{
		ITask task = LoadOrNull(taskId);
		if (task != null && CanControlComplete(taskId, actionModel))
		{
			ApplyCommentActionModel(task, actionModel);
			task.Status = ((task.Status == TaskBaseStatus.CompleteNeedControl) ? TaskBaseStatus.CompleteControlled : TaskBaseStatus.IncompleteControlled);
			Save(task);
			RaiseCommentActionEvent(null, task, "ca7e4640-b9c8-4849-aa55-a9316ce9006a", actionModel);
		}
		return task;
	}

	[ActionCheck("ca7e4640-b9c8-4849-aa55-a9316ce9006a")]
	public virtual bool CanControlComplete(long taskId, ICommentActionModel actionModel = null)
	{
		ITask task = LoadOrNull(taskId);
		if (task == null)
		{
			return false;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		string text = "";
		if (task.Status != TaskBaseStatus.CompleteNeedControl && task.Status != TaskBaseStatus.IncompleteNeedControl && task.Status != TaskBaseStatus.RefuseApproval)
		{
			text = SR.T("Нельзя проконтролировать выполнение задачи \"{0}\"", task.Subject);
		}
		else if (!IsUserControlsTask(currentUser, task))
		{
			text = SR.T("Вы не можете контролировать выполнение задачу \"{0}\"", task.Subject);
		}
		else if (task.Status == TaskBaseStatus.CompleteControlled)
		{
			text = SR.T("Задача \"{1}\" проконтролирована {0:dd MMMM yyyy} в {0:HH:mm}", task.EndWorkDate, task.Subject);
		}
		if (!string.IsNullOrEmpty(text))
		{
			throw new ElmaInvalidOperationException(text);
		}
		return base.TaskWorkflowActions.IsAvailableControlledAction(task, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
	}

	[Transaction]
	[ActionMethod("059dad1d-bae3-4698-8846-3538711ef82a")]
	public virtual ITaskBase DoConfirmApprove(long taskId, ICommentActionModel actionModel = null)
	{
		IApprovalTask approvalTask = ApprovalTaskManager.LoadOrNull(taskId);
		if (approvalTask != null && CanConfirmApprove(taskId, actionModel))
		{
			ApplyCommentActionModel(approvalTask, actionModel);
			ApplyCommentActionModel(approvalTask.ParentTask, actionModel);
			approvalTask.Status = TaskBaseStatus.CompleteControlled;
			approvalTask.ApprovalStatus = ApprovalStatus.Confirm;
			if (actionModel != null)
			{
				approvalTask.ApprovalComment = actionModel.Comment;
			}
			approvalTask.ParentTask.Status = ((approvalTask.ParentStatus == TaskBaseStatus.RefuseApproval || approvalTask.ParentStatus == TaskBaseStatus.RefuseApprovalExecutor) ? TaskBaseStatus.NewOrder : approvalTask.ParentStatus);
			approvalTask.Save();
			approvalTask.ParentTask.Save();
			RaiseCommentActionEvent(null, approvalTask, "6c6b90f3-295f-4fd9-ab4c-0a80144b7bd8", actionModel);
			RaiseCommentActionEvent(null, approvalTask.ParentTask, "059dad1d-bae3-4698-8846-3538711ef82a", actionModel);
		}
		return approvalTask;
	}

	[ActionCheck("059dad1d-bae3-4698-8846-3538711ef82a")]
	public virtual bool CanConfirmApprove(long taskId, ICommentActionModel actionModel = null)
	{
		IApprovalTask approvalTask = ApprovalTaskManager.LoadOrNull(taskId);
		if (approvalTask != null)
		{
			return base.TaskWorkflowActions.IsAvailableApproval(approvalTask, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
		}
		return false;
	}

	[Transaction]
	[ActionMethod("1c82621a-1f00-4598-861a-5d824891fde4")]
	public virtual ITaskBase DoRefuseApprove(long taskId, ICommentActionModel actionModel = null)
	{
		IApprovalTask approvalTask = ApprovalTaskManager.LoadOrNull(taskId);
		if (approvalTask != null && CanRefuseApprove(taskId, actionModel))
		{
			ApplyCommentActionModel(approvalTask, actionModel);
			ApplyCommentActionModel(approvalTask.ParentTask, actionModel);
			approvalTask.Status = TaskBaseStatus.IncompleteControlled;
			approvalTask.ApprovalStatus = ApprovalStatus.Unconfirm;
			if (actionModel != null)
			{
				approvalTask.ApprovalComment = actionModel.Comment;
			}
			approvalTask.ParentTask.Status = ((approvalTask.ParentTask.Status == TaskBaseStatus.OnApproval) ? TaskBaseStatus.RefuseApproval : TaskBaseStatus.RefuseApprovalExecutor);
			approvalTask.Save();
			approvalTask.ParentTask.Save();
			RaiseCommentActionEvent(null, approvalTask, "9a8806b0-8e5a-4f46-868f-9a1604d4ebce", actionModel);
			RaiseCommentActionEvent(null, approvalTask.ParentTask, "1c82621a-1f00-4598-861a-5d824891fde4", actionModel);
		}
		return approvalTask;
	}

	[ActionCheck("1c82621a-1f00-4598-861a-5d824891fde4")]
	public virtual bool CanRefuseApprove(long taskId, ICommentActionModel actionModel = null)
	{
		IApprovalTask approvalTask = ApprovalTaskManager.LoadOrNull(taskId);
		if (approvalTask != null)
		{
			return base.TaskWorkflowActions.IsAvailableApproval(approvalTask, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
		}
		return false;
	}

	[Transaction]
	[ActionMethod("6c6b90f3-295f-4fd9-ab4c-0a80144b7bd8")]
	public virtual ITask DoCompleted(long taskId, bool alertCoexecuters, ICommentActionModel actionModel = null)
	{
		ITask task = LoadOrNull(taskId);
		if (task != null && CanDoCompleted(taskId, alertCoexecuters, actionModel))
		{
			ApplyCommentActionModel(task, actionModel);
			task.Status = ((task.UnderControl && task.ControlUser != null && task.ControlType != 0) ? TaskBaseStatus.CompleteNeedControl : TaskBaseStatus.Complete);
			if (task.ControlType == TaskControlType.Current)
			{
				task.ControlType = TaskControlType.Execution;
			}
			if (task.IsEmulation)
			{
				task.ControlUser = task.Executor;
				task.ControlUserReplaced = task.ControlUser;
			}
			Save(task);
			RaiseCommentActionEvent(null, task, "6c6b90f3-295f-4fd9-ab4c-0a80144b7bd8", actionModel, alertCoexecuters);
			CloseLinkedTaskIfNeed(task);
		}
		return task;
	}

	[ActionCheck("6c6b90f3-295f-4fd9-ab4c-0a80144b7bd8")]
	public virtual bool CanDoCompleted(long taskId, bool alertCoexecuters, ICommentActionModel actionModel = null)
	{
		ITask task = LoadOrNull(taskId);
		if (task == null)
		{
			return false;
		}
		if (task.IsEmulation)
		{
			task.ControlUser = task.Executor;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		string text = "";
		if (!task.EndWorkDate.HasValue && !TaskBaseManager<ITaskBase>.IsExecutor(task, currentUser, checkSubordinateUser: true))
		{
			text = SR.T("Задача \"{1}\" назначена на: {0}", task.Executor.GetShortName(), task.Subject);
		}
		else if (task.EndWorkDate.HasValue && task.IsComplete())
		{
			text = SR.T("Задача \"{1}\" выполнена {0:dd MMMM yyyy} в {0:HH:mm}", task.EndWorkDate, task.Subject);
		}
		if (!string.IsNullOrEmpty(text))
		{
			throw new ElmaInvalidOperationException(text);
		}
		return base.TaskWorkflowActions.IsAvailableCompleted(task, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
	}

	[Transaction]
	[ActionMethod("9a8806b0-8e5a-4f46-868f-9a1604d4ebce")]
	public virtual ITask DoIncompleted(long taskId, bool alertCoexecuters, ICommentActionModel actionModel = null)
	{
		ITask task = LoadOrNull(taskId);
		if (task != null && CanDoIncompleted(taskId, alertCoexecuters, actionModel))
		{
			ApplyCommentActionModel(task, actionModel);
			task.Status = ((task.UnderControl && task.ControlUser != null && task.ControlType != 0) ? TaskBaseStatus.IncompleteNeedControl : TaskBaseStatus.Incomplete);
			if (task.ControlType == TaskControlType.Current)
			{
				task.ControlType = TaskControlType.Execution;
			}
			Save(task);
			RaiseCommentActionEvent(null, task, "9a8806b0-8e5a-4f46-868f-9a1604d4ebce", actionModel, alertCoexecuters);
		}
		return task;
	}

	[ActionCheck("9a8806b0-8e5a-4f46-868f-9a1604d4ebce")]
	public virtual bool CanDoIncompleted(long taskId, bool alertCoexecuters, ICommentActionModel actionModel = null)
	{
		ITask task = LoadOrNull(taskId);
		if (task == null)
		{
			return false;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		string text = "";
		if (!task.EndWorkDate.HasValue && !TaskBaseManager<ITaskBase>.IsExecutor(task, currentUser, checkSubordinateUser: true))
		{
			text = SR.T("Задача \"{1}\" назначена на: {0}", task.Executor.GetShortName(), task.Subject);
		}
		else if (task.EndWorkDate.HasValue && task.IsComplete())
		{
			text = SR.T("Задача \"{1}\" завершена {0:dd MMMM yyyy} в {0:HH:mm}", task.EndWorkDate, task.Subject);
		}
		if (!string.IsNullOrEmpty(text))
		{
			throw new ElmaInvalidOperationException(text);
		}
		return base.TaskWorkflowActions.IsAvailableInCompleted(task, base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
	}

	[ActionMethod("3a9f7c34-4493-42bd-919d-62bf1f2bbcdb")]
	[Transaction]
	public virtual ITask ChangeControl(long taskId, bool underControl, EleWise.ELMA.Security.Models.IUser controlUser, TaskControlType controlType, IComment comment)
	{
		ITask task = LoadOrNull(taskId);
		if (task != null && CanChangeControl(taskId, underControl, controlUser, controlType, comment))
		{
			if (underControl && controlUser != null)
			{
				task.UnderControl = true;
				task.ControlUser = controlUser;
				task.ControlType = controlType;
			}
			else
			{
				task.UnderControl = false;
				task.ControlUser = null;
			}
			AddComment(task, comment);
			Save(task);
			ICommentActionModel actionModel = null;
			if (comment != null)
			{
				InstanceOf<ICommentActionModel> instanceOf = new InstanceOf<ICommentActionModel>();
				instanceOf.New.Comment = comment;
				actionModel = instanceOf.New;
			}
			base.ActionHandler.ActionExecuted(TryCreateCommentActionEventArgs(null, task, "3a9f7c34-4493-42bd-919d-62bf1f2bbcdb", actionModel));
		}
		return task;
	}

	[ActionCheck("3a9f7c34-4493-42bd-919d-62bf1f2bbcdb")]
	public virtual bool CanChangeControl(long taskId, bool underControl, EleWise.ELMA.Security.Models.IUser controlUser, TaskControlType controlType, IComment comment)
	{
		ITask task = LoadOrNull(taskId);
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		if (task != null)
		{
			return base.TaskWorkflowActions.IsAvailableChangeControl(task, currentUser);
		}
		return false;
	}

	public static ITask Clone(ITask task)
	{
		return CloneHelperBuilder.Create(task).Restrictions(delegate(RestrictionsBuilder<ITask> m)
		{
			m.Rule().ForPropertyName((ITask t) => t.Comments).Ignore();
			m.Rule().ForPropertyName((ITask t) => t.CreationDate).Ignore();
		}).Clone();
	}

	[PublicApiMember]
	public override void Save(ITask obj)
	{
		if (obj.Period != 0)
		{
			obj.IsTemplate = true;
			obj.NotShowInLists = true;
		}
		if (obj.UnderControl && obj.ControlUser != null && obj.ControlType != 0)
		{
			if (obj.Status == TaskBaseStatus.Complete)
			{
				obj.Status = TaskBaseStatus.CompleteNeedControl;
			}
			else if (obj.Status == TaskBaseStatus.Incomplete)
			{
				obj.Status = TaskBaseStatus.IncompleteNeedControl;
			}
		}
		base.Save(obj);
	}

	[PublicApiMember]
	[Transaction]
	public virtual void AddQuestion(ITask task, EleWise.ELMA.Security.Models.IUser recipient, string description, bool showAll, IEnumerable<IAttachment> attachments = null)
	{
		IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
		IQuestion question = InterfaceActivator.Create<IQuestion>();
		question.RefObject = new ReferenceOnEntity
		{
			Object = task
		};
		question.Subject = task.Subject;
		question.Executor = recipient;
		question.Description = description;
		question.ShowAll = showAll;
		question.Status = TaskBaseStatus.NewOrder;
		if (attachments != null)
		{
			IList<IAttachment> list = (attachments as IList<IAttachment>) ?? attachments.ToList();
			if (list != null && list.Any())
			{
				foreach (IAttachment item in list)
				{
					question.Attachments.Add(item);
				}
			}
		}
		question.Save();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, task, TaskBaseActions.AddQuestionGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ActionExecuted(entityActionEventArgs);
		}
	}

	[PublicApiMember]
	[Transaction]
	public virtual void AddQuestion(ITask task, EleWise.ELMA.Security.Models.IUser recipient, string description, bool showAll)
	{
		AddQuestion(task, recipient, description, showAll, null);
	}

	[PublicApiMember]
	[Transaction]
	public virtual void AddQuestion(ITask task, IQuestion question)
	{
		IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
		question.Subject = question.Subject ?? task.Subject;
		question.RefObject = new ReferenceOnEntity
		{
			Object = task
		};
		question.Save();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, task, TaskBaseActions.AddQuestionGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ActionExecuted(entityActionEventArgs);
		}
	}

	public bool UpdatePeriodTask(ITask template, DateTime? startDay = null)
	{
		return UpdatePeriodTask(template, continueLastPeriodTaskDate: false);
	}

	public bool UpdatePeriodTask(ITask template, bool continueLastPeriodTaskDate)
	{
		return UpdatePeriodTask(template, continueLastPeriodTaskDate, retryCreateTaskOnDeadlock: false);
	}

	internal bool UpdatePeriodTask(ITask template, bool continueLastPeriodTaskDate, bool retryCreateTaskOnDeadlock)
	{
		if (template == null || !template.IsTemplate || template.Status == TaskBaseStatus.WasClosed || !template.StartDate.HasValue || !template.EndDate.HasValue)
		{
			return false;
		}
		DateTime value = template.StartDate.Value;
		DateTime value2 = template.EndDate.Value;
		TimeSpan timeSpan = ((template.Period == CalendarEventPeriod.Daily) ? (value2 - value) : ProductionCalendar.EvalWorkTimeSpanDifference(value, value2));
		DateTime startTime2;
		if (template.LastPeriodTaskDate.HasValue)
		{
			CalculateStartTime(template, timeSpan, template.LastPeriodTaskDate.Value.AddTicks(1L), out startTime2);
		}
		else
		{
			startTime2 = value;
		}
		if (template.UntilDate.HasValue && template.LastPeriodTaskDate.HasValue && startTime2.Date > template.UntilDate.Value.Date)
		{
			if (template.UntilDate < DateTime.Today)
			{
				template.Status = TaskBaseStatus.WasClosed;
				template.Save();
			}
			return false;
		}
		if (Locator.GetServiceNotNull<IUnitOfWorkManager>().HasActiveTransaction(string.Empty))
		{
			PeriodTaskPostCommitListener.AddUpdatePeriodTask(template, continueLastPeriodTaskDate);
			return false;
		}
		DateTime dateTime = DateTime.Today;
		InstanceOf<ITaskFilter> instanceOf = new InstanceOf<ITaskFilter>();
		instanceOf.New.PeriodTemplate = template;
		instanceOf.New.StartDate = new DateTimeRange
		{
			From = dateTime
		};
		instanceOf.New.CompleteStatus = TaskCompleteStatus.Active;
		instanceOf.New.DisableSecurity = true;
		long num = Count(instanceOf.New);
		if (num >= template.NextTasksCreationCount && (template.NextTasksCreationCount != 0 || !(startTime2.Date <= dateTime)))
		{
			return false;
		}
		if (value.Date > dateTime)
		{
			dateTime = value.Date;
		}
		DateTime startTime;
		DateTime endTime;
		if (continueLastPeriodTaskDate)
		{
			if (template.LastPeriodTaskDate.HasValue)
			{
				startTime = template.LastPeriodTaskDate.Value;
				endTime = ((template.Period == CalendarEventPeriod.Daily) ? (startTime + timeSpan) : ProductionCalendar.EvalTargetTime(startTime, timeSpan)).NormalizeEndDate(value2.IsEndDamperTimeBySeconds());
			}
			else
			{
				startTime = value;
				endTime = value2;
			}
		}
		else
		{
			CalculateStartEndTime(template, timeSpan, dateTime, out startTime, out endTime);
		}
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		base.AuthenticationService.SetAuthenticatedUserForRequest(template.CreationAuthor);
		ICollection<IReminder> collection;
		if (!template.IsNew())
		{
			collection = ReminderManager.Instance.Find((IReminder f) => f.RefObject == ReferenceOnEntity.Create(template));
		}
		else
		{
			ICollection<IReminder> collection2 = new List<IReminder>();
			collection = collection2;
		}
		ICollection<IReminder> reminders = collection;
		DateTime lastPeriodTaskDate = template.LastPeriodTaskDate ?? value.Date.AddTicks(-1L);
		while ((num < template.NextTasksCreationCount || (template.NextTasksCreationCount == 0 && lastPeriodTaskDate < dateTime)) && (!template.UntilDate.HasValue || !(startTime.Date > template.UntilDate.Value.Date)))
		{
			if (startTime > lastPeriodTaskDate)
			{
				if (retryCreateTaskOnDeadlock)
				{
					bool firstTry = true;
					base.Transformation.RetryOnDeadlock(delegate
					{
						try
						{
							if (!firstTry)
							{
								base.Session.Clear();
								base.Session.Refresh((object)template);
								reminders.ForEach(delegate(IReminder r)
								{
									base.Session.Refresh((object)r);
								});
							}
							lastPeriodTaskDate = CreateTaskItem(template, startTime, endTime, reminders);
						}
						finally
						{
							firstTry = false;
						}
					});
				}
				else
				{
					lastPeriodTaskDate = CreateTaskItem(template, startTime, endTime, reminders);
				}
				if (startTime >= dateTime)
				{
					num++;
				}
			}
			endTime = CalendarEventManager.GetNextDate(template.Period, value2, endTime, moveBeforeHoliday: true);
			startTime = ((template.Period == CalendarEventPeriod.Daily) ? (endTime - timeSpan) : ProductionCalendar.EvalTargetTime(endTime, -timeSpan)).NormalizeStartDate(value.IsStartDamperTimeBySeconds());
		}
		if (template.UntilDate.HasValue && template.UntilDate < dateTime)
		{
			template.Status = TaskBaseStatus.WasClosed;
			template.Save();
		}
		if (currentUser != null)
		{
			base.AuthenticationService.SetAuthenticatedUserForRequest(currentUser);
		}
		else
		{
			base.AuthenticationService.SignOut();
		}
		return true;
	}

	[Transaction]
	protected virtual DateTime CreateTaskItem(ITask template, DateTime startTime, DateTime endTime, ICollection<IReminder> reminders)
	{
		if (template.Executor.Status != UserStatus.Blocked)
		{
			ITask task = Clone(template);
			task.PeriodTemplate = template;
			task.StartDate = startTime;
			task.EndDate = endTime;
			task.NotShowInLists = false;
			task.IsTemplate = false;
			task.Period = CalendarEventPeriod.Once;
			task.LastPeriodTaskDate = null;
			base.Save(task);
			if (reminders.Any())
			{
				foreach (IReminder item in from reminder in reminders
					select ReminderManager.Instance.CreateByTemplate(reminder, task) into r
					where r != null
					select r)
				{
					item.Save();
				}
			}
			List<IWatch> watches = WatchManager.Instance.GetWatches(template.TypeUid, template.Id, onlyForEntity: true);
			if (watches != null && watches.Any())
			{
				watches.ForEach(delegate(IWatch wu)
				{
					WatchManager.Instance.CreateWatchByUser(task.TypeUid, task.Id, wu.User);
				});
			}
		}
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		((IQuery)base.Session.CreateSQLQuery(string.Format("update {0} set {1}=? where {2}=?", serviceNotNull.Dialect.QuoteIfNeeded("Task"), serviceNotNull.Dialect.QuoteIfNeeded("LastPeriodTaskDate"), serviceNotNull.Dialect.QuoteIfNeeded("Id")))).SetParameter<DateTime>(0, startTime).SetParameter<long>(1, template.Id).ExecuteUpdate(cleanUpCache: false);
		base.Session.CleanUpCache(template);
		return startTime;
	}

	[Transaction]
	public virtual void TemplateChangeDateOrPeriod(ITask template)
	{
		if (template.IsNew() || !template.IsTemplate || template.Status == TaskBaseStatus.WasClosed)
		{
			return;
		}
		DateTime dateTime = DateTime.Now;
		InstanceOf<ITaskFilter> instanceOf = new InstanceOf<ITaskFilter>();
		instanceOf.New.PeriodTemplate = template;
		instanceOf.New.StartDate = new DateTimeRange
		{
			From = dateTime
		};
		instanceOf.New.CompleteStatus = TaskCompleteStatus.Active;
		instanceOf.New.DisableSecurity = true;
		ICollection<ITask> collection = Find(instanceOf.New, FetchOptions.All);
		DateTime value = template.StartDate.Value;
		DateTime value2 = template.EndDate.Value;
		if (value > dateTime)
		{
			dateTime = value;
		}
		TimeSpan timeSpan = ((template.Period == CalendarEventPeriod.Daily) ? (value2 - value) : ProductionCalendar.EvalWorkTimeSpanDifference(value, value2));
		CalculateStartEndTime(template, timeSpan, dateTime, out var startTime, out var endTime);
		foreach (ITask item in collection)
		{
			if (!template.UntilDate.HasValue || startTime.Date <= template.UntilDate.Value.Date)
			{
				item.StartDate = startTime;
				item.EndDate = endTime;
				template.LastPeriodTaskDate = startTime;
			}
			else
			{
				item.Status = TaskBaseStatus.WasClosed;
			}
			item.Save();
			endTime = CalendarEventManager.GetNextDate(template.Period, value2, endTime, moveBeforeHoliday: true);
			startTime = ((template.Period == CalendarEventPeriod.Daily) ? (endTime - timeSpan) : ProductionCalendar.EvalTargetTime(endTime, -timeSpan)).NormalizeStartDate(value.IsStartDamperTimeBySeconds());
		}
		ContextVars.GetOrAdd("PeriodTaskTemplate_ChangedTemplates", () => new List<long>()).Add(template.Id);
		template.Save();
		UpdatePeriodTask(template, continueLastPeriodTaskDate: true);
	}

	private void CalculateStartTime(ITask template, TimeSpan workTimeSpanDifference, DateTime from, out DateTime startTime)
	{
		CalculateStartEndTime(template, workTimeSpanDifference, from, out startTime, out var _);
	}

	private void CalculateStartEndTime(ITask template, TimeSpan workTimeSpanDifference, DateTime from, out DateTime startTime, out DateTime endTime)
	{
		startTime = from.AddDays(-1.0);
		endTime = startTime + workTimeSpanDifference;
		while (startTime < from)
		{
			endTime = CalendarEventManager.GetNextDate(template.Period, template.EndDate.Value, endTime, moveBeforeHoliday: true);
			startTime = ((template.Period == CalendarEventPeriod.Daily) ? (endTime - workTimeSpanDifference) : ProductionCalendar.EvalTargetTime(endTime, -workTimeSpanDifference)).NormalizeStartDate(template.StartDate.HasValue && template.StartDate.Value.IsStartDamperTimeBySeconds());
		}
	}

	private void CloseLinkedTaskIfNeed(ITask task)
	{
		IEnumerable<ILinkedTaskCloseChecker> enumerable = LinkedTaskCloseCheckers.Where((ILinkedTaskCloseChecker c) => c.CanUse(task));
		IEnumerable<ITask> enumerable2 = new List<ITask>();
		foreach (ILinkedTaskCloseChecker item in enumerable)
		{
			enumerable2 = enumerable2.Union(item.GetTasksForClose(task));
		}
		enumerable2 = enumerable2.Distinct((ITask t1, ITask t2) => t1.Id == t2.Id);
		foreach (ITask taskToClose in enumerable2)
		{
			SecurityService.RunWithElevatedPrivilegies(delegate
			{
				Close(taskToClose.Id, alert: true);
			});
		}
	}

	public static bool IsUserControlsTask(EleWise.ELMA.Security.Models.IUser user, ITask task, bool checkCreateAuthor = false)
	{
		if (!task.UnderControl || task.ControlUser == null || (task.ControlUser != user && !UserManager.Instance.IsSubordinateUser(user, task.ControlUser) && !TaskBaseManager<ITaskBase>.AccessToAllTasks(user)))
		{
			if (checkCreateAuthor)
			{
				if (task.CreationAuthor != user && !UserManager.Instance.IsSubordinateUser(user, task.CreationAuthor))
				{
					return TaskBaseManager<ITaskBase>.AccessToAllTasks(user);
				}
				return true;
			}
			return false;
		}
		return true;
	}
}
