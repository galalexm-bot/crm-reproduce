using System;
using System.Collections.Generic;
using System.Security;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Actions;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[Permission("76EC51E5-E826-4876-8B8A-BFED9D2CF6CF")]
[RouteArea("EleWise.ELMA.BPM.Web.Tasks")]
[ActiveMenuItem("tasks-threads-tree")]
public class ReplacementTaskController : BPMController<IReplacementTask, long>
{
	public const string UpdatePrefix = "Model";

	protected IUser CurrentUser => base.AuthenticationService.GetCurrentUser<IUser>();

	[NotNull]
	public UserManager UserManager { get; set; }

	[NotNull]
	public TaskWorkflowActions TaskWorkflowActions { get; set; }

	[NotNull]
	public IEntityActionHandler EntityActionHandler { get; set; }

	[NotNull]
	public new ReplacementTaskManager Manager => (ReplacementTaskManager)base.Manager;

	[NotNull]
	public ICommentActionHandler CommentActionHandler { get; set; }

	[NotNull]
	public ICommentActionWebHandler CommentActionWebHandler { get; set; }

	[NotNull]
	public ICreateSubtaskActionHandler CreateSubtaskActionHandler { get; set; }

	protected virtual void NotifyTaskAction(ITaskBase task, string actionThemeFormat)
	{
		TaskBaseController.NotifyTaskAction(this, task, actionThemeFormat);
	}

	public ActionResult Index()
	{
		base.ViewTitle = SR.T("Задачи");
		return (ActionResult)(object)((Controller)this).RedirectToAction("Incoming", "AllTasks", (object)new
		{
			FilterId = 0
		});
	}

	[HttpGet]
	public ActionResult GeneralInfo(long id, bool? needHistory)
	{
		ITaskBase entity = TaskBaseManager.Instance.Load(id);
		return (ActionResult)(object)((Controller)this).PartialView((object)new TaskViewModel
		{
			Entity = entity,
			NeedHistory = (!needHistory.HasValue || needHistory.Value)
		});
	}

	[EntityLink]
	[ActiveMenuItem("tasks-threads-tree")]
	public ActionResult Execute(IReplacementTask task)
	{
		if (!base.SecurityService.HasPermission(PermissionProvider.ViewTaskPermission, task))
		{
			throw new SecurityException(SR.T("Нет доступа к задаче"));
		}
		base.ViewTitle = task.Subject;
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		TaskViewModel taskViewModel = new TaskViewModel
		{
			Entity = task,
			IsAvailableStartWork = TaskWorkflowActions.IsAvailableStartWork(task, currentUser),
			IsAvailableCompleted = TaskWorkflowActions.IsAvailableCompleted(task, currentUser),
			IsAvailableInCompleted = TaskWorkflowActions.IsAvailableInCompleted(task, currentUser),
			IsAvailableReAssign = TaskWorkflowActions.IsAvailableReAssign(task, currentUser),
			IsAvailableClose = TaskWorkflowActions.IsAvailableClose(task, currentUser),
			IsAvailableWorkLog = TaskWorkflowActions.IsAvailableWorkLog(task, currentUser),
			IsEmulation = task.IsEmulation,
			ExecutorIsEmulation = task.ExecutorIsEmulation
		};
		SetAsReadForFeed(task);
		return (ActionResult)(object)((Controller)this).View((object)taskViewModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult MarkRead(long id)
	{
		TaskBaseManager.Instance.MarkRead(id);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		});
	}

	public ActionResult CreateBlockUserReplacementTask(long? id)
	{
		if (!id.HasValue)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List", "User", new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Security" } });
		}
		IUser user = UserManager.Instance.LoadOrNull(id.Value);
		if (user == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List", "User", new RouteValueDictionary { { "area", "EleWise.ELMA.BPM.Web.Security" } });
		}
		if (user == null)
		{
			throw new ArgumentException("Пользователь не найден", "id");
		}
		IReplacementTask replacementTask = Manager.Create();
		replacementTask.Executor = CurrentUser;
		replacementTask.BlockedUser = user;
		replacementTask.StartDate = DateTime.Now;
		replacementTask.EndDate = DateTime.Now;
		CreateBlockReplacementTaskModel createBlockReplacementTaskModel = new CreateBlockReplacementTaskModel();
		createBlockReplacementTaskModel.ReplacementTask = replacementTask;
		return (ActionResult)(object)((Controller)this).PartialView((object)createBlockReplacementTaskModel);
	}

	[HttpPost]
	[Permission("2C44BA05-91A6-49E4-89C1-84AC5B371B7F")]
	[TransactionAction]
	public ActionResult CreateBlockUserReplacementTask(CreateBlockReplacementTaskModel model)
	{
		IUser blockedUser = model.ReplacementTask.BlockedUser;
		if (blockedUser.Status == UserStatus.Blocked)
		{
			if (ModelStateIsValid(model))
			{
				IReplacementTask replacementTask = model.ReplacementTask;
				replacementTask.Status = TaskBaseStatus.NewOrder;
				replacementTask.NotShowInLists = false;
				replacementTask.CreationAuthor = CurrentUser;
				replacementTask.Subject = SR.T("Переназначить активные задачи блокированного пользователя ({0})", blockedUser.FullName);
				replacementTask.Save();
			}
			else
			{
				base.Notifier.Error(SR.T("Ошибка создания задачи назначения заместителей"));
			}
		}
		else
		{
			base.Notifier.Error(SR.T("Данный пользователь не заблокирован"));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Profile", "User", new RouteValueDictionary
		{
			{ "area", "EleWise.ELMA.BPM.Web.Security" },
			{ "id", blockedUser.Id }
		});
	}

	private bool ModelStateIsValid(CreateBlockReplacementTaskModel model)
	{
		IReplacementTask replacementTask = model.ReplacementTask;
		if (replacementTask.Executor != null && replacementTask.BlockedUser != null)
		{
			return replacementTask.Executor != replacementTask.BlockedUser;
		}
		return false;
	}

	[HttpPost]
	public virtual ActionResult ReAssign([NotNull] ReAssignTaskViewModel model)
	{
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		DateTime startDate = (model.ReAssignStartDate.HasValue ? model.ReAssignStartDate.Value.NormalizeStartDate(model.ReAssignStartDate.Value.IsStartDamperTimeBySeconds()) : DateTime.MinValue);
		DateTime endDate = (model.ReAssignEndDate.HasValue ? model.ReAssignEndDate.Value.NormalizeEndDate(model.ReAssignEndDate.Value.IsEndDamperTimeBySeconds()) : DateTime.MaxValue);
		IComment comment = null;
		if (!string.IsNullOrEmpty(model.Comment) && !string.IsNullOrEmpty(model.Comment.Trim()))
		{
			InstanceOf<IComment> instanceOf = new InstanceOf<IComment>();
			instanceOf.New.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
			instanceOf.New.CreationDate = DateTime.Now;
			instanceOf.New.Text = model.Comment.Trim();
			comment = instanceOf.New;
		}
		IReAssignTaskActionModel reAssignActionModel = InterfaceActivator.Create<IReAssignTaskActionModel>();
		reAssignActionModel.TaskId = model.Task.Id;
		reAssignActionModel.StartDate = startDate;
		reAssignActionModel.EndDate = endDate;
		reAssignActionModel.Executor = model.Executor;
		reAssignActionModel.Priority = model.ReAssignTaskPriority;
		reAssignActionModel.Comment = comment;
		if (model.SetMeParticipant && ReAssignTaskViewModel.EnabledSetMeParticipant(model.Task))
		{
			reAssignActionModel.SetMeParticipant = true;
		}
		using (IUnitOfWork unitOfWork = base.UnitOfWorkManager.Create(string.Empty, transactional: true))
		{
			try
			{
				TaskBaseManager.Instance.InvokeAction((TaskBaseManager m) => m.ReAssign(reAssignActionModel), model.Task.GetType());
			}
			catch (Exception)
			{
				unitOfWork.Rollback();
				throw;
			}
			NotifyTaskAction(model.Task, SR.T("Задача {0} переназначена"));
			unitOfWork.Commit();
		}
		if (!string.IsNullOrEmpty(model.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		bool flag = base.SecurityService.HasPermission(PermissionProvider.ViewTaskPermission, model.Task);
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true, "", !flag));
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult StartWork([NotNull][Bind(Prefix = "StartWork")] TaskCommentModel commentModel)
	{
		if (commentModel == null)
		{
			throw new ArgumentNullException("commentModel");
		}
		IReplacementTask task = Manager.InvokeAction((ReplacementTaskManager m) => m.StartWork(commentModel.ObjectId, commentModel.AlertInform, commentModel.ActionModel), commentModel.Object.GetType());
		NotifyTaskAction(task, SR.T("Начата работа над задачей {0}"));
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Request().UrlReferrer.PathAndQuery);
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult DoCompleted([Bind(Prefix = "DoCompleted")] TaskCommentModel commentModel)
	{
		if (commentModel == null)
		{
			throw new ArgumentNullException("commentModel");
		}
		IReplacementTask replacementTask = Manager.DoCompleted(commentModel.ObjectId, commentModel.AlertInform, commentModel.ActionModel);
		NotifyTaskAction(replacementTask, SR.T("Задача {0} отмечена как выполненная"));
		if (commentModel.ShowWorkLog && commentModel.WorkLog != null && commentModel.WorkLog.WorkMinutes.HasValue && commentModel.WorkLog.WorkMinutes > 0L)
		{
			ITaskBase taskBase = replacementTask;
			if (taskBase != null)
			{
				IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
				IUser user3 = (commentModel.WorkLog.CreationAuthor = (commentModel.WorkLog.Worker = currentUser));
				commentModel.WorkLog.TaskBase = taskBase;
				commentModel.WorkLog.Comment = commentModel.ActionModel.Comment.Text;
				WorkLogManager.Instance.Save(commentModel.WorkLog);
			}
		}
		return (ActionResult)(object)((Controller)this).Redirect((!string.IsNullOrEmpty(commentModel.RedirectUrl)) ? commentModel.RedirectUrl : ((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult DoClose([Bind(Prefix = "DoClose")] TaskCommentModel commentModel)
	{
		if (commentModel == null)
		{
			throw new ArgumentNullException("commentModel");
		}
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(commentModel.ObjectTypeUid);
		IReplacementTask task = Manager.InvokeAction((ReplacementTaskManager m) => m.Close(commentModel.ObjectId, commentModel.AlertInform, commentModel.ActionModel), typeByUid);
		NotifyTaskAction(task, SR.T("Задача {0} закрыта"));
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult DoInCompleted([NotNull][Bind(Prefix = "DoInCompleted")] TaskCommentModel commentModel)
	{
		if (commentModel == null)
		{
			throw new ArgumentNullException("commentModel");
		}
		IReplacementTask replacementTask = Manager.DoIncompleted(commentModel.ObjectId, commentModel.AlertInform, commentModel.ActionModel);
		NotifyTaskAction(replacementTask, SR.T("Задачу {0} невозможно выполнить"));
		if (commentModel.ShowWorkLog && commentModel.WorkLog != null && commentModel.WorkLog.WorkMinutes.HasValue && commentModel.WorkLog.WorkMinutes > 0L)
		{
			ITaskBase taskBase = replacementTask;
			if (taskBase != null)
			{
				IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
				IUser user3 = (commentModel.WorkLog.CreationAuthor = (commentModel.WorkLog.Worker = currentUser));
				commentModel.WorkLog.TaskBase = taskBase;
				commentModel.WorkLog.Comment = commentModel.ActionModel.Comment.Text;
				WorkLogManager.Instance.Save(commentModel.WorkLog);
			}
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	public ActionResult TaskComment(TaskCommentModel model)
	{
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(model.HtmlPrefix);
		return (ActionResult)(object)((Controller)this).PartialView("ReplacementTask/Partial/TaskComment", (object)model);
	}

	public ActionResult ReAssignTaskForm(long taskId, ReAssignTaskViewModel model)
	{
		((Controller)this).get_ModelState().Clear();
		model.Init(TaskBaseManager.Instance.Load(taskId));
		return (ActionResult)(object)((Controller)this).PartialView("ReAssignTaskForm", (object)model);
	}

	public ActionResult TaskDateChange(long taskId, string popupId, string redirectUrl)
	{
		TaskBaseModel taskBaseModel = new TaskBaseModel(TaskBaseManager.Instance.Load(taskId))
		{
			ReturnUrl = redirectUrl
		};
		return (ActionResult)(object)((Controller)this).PartialView("Partial/TaskDateChange", (object)taskBaseModel);
	}

	[CustomGridAction]
	public ActionResult ReplacementActiveTasksGrid(GridCommand command, long replacementTaskId)
	{
		((ControllerBase)this).get_ViewData().set_Item("replacementTaskId", (object)replacementTaskId);
		GridData<ITaskBase> gridData = new GridData<ITaskBase>
		{
			Command = command
		};
		gridData.SetCount((GridData<ITaskBase> d, FetchOptions f) => ReplacementTaskManager.Instance.ActiveTasksCount(replacementTaskId));
		gridData.SetData((IGridData d, FetchOptions f) => ReplacementTaskManager.Instance.ActiveTasksCount(replacementTaskId), (IGridData d, FetchOptions f) => (d.Count <= 0) ? new List<ITaskBase>() : ReplacementTaskManager.Instance.ActiveTasksList(replacementTaskId, f));
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[CustomGridAction]
	public ActionResult ReplacementPeriodicTaskTemplatesGrid(GridCommand command, long replacementTaskId)
	{
		((ControllerBase)this).get_ViewData().set_Item("replacementTaskId", (object)replacementTaskId);
		GridData<ITask> gridData = new GridData<ITask>
		{
			Command = command
		};
		gridData.SetCount((GridData<ITask> d, FetchOptions f) => ReplacementTaskManager.Instance.PeriodicTaskTemplatesCount(replacementTaskId));
		gridData.SetData((IGridData d, FetchOptions f) => ReplacementTaskManager.Instance.PeriodicTaskTemplatesCount(replacementTaskId), (IGridData d, FetchOptions f) => (d.Count <= 0) ? new List<ITask>() : ReplacementTaskManager.Instance.PeriodicTaskTemplatesList(replacementTaskId, f));
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	public ActionResult Assign(long replacementTaskId, long objectId, Guid objectTypeUid, Guid propertyUid, long userId)
	{
		IReplacementTask task = ReplacementTaskManager.Instance.LoadOrNull(replacementTaskId);
		if (task == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false
			}, (JsonRequestBehavior)0);
		}
		task.SetAssignmentValue(new ReferenceOnEntity(objectId, objectTypeUid), propertyUid, userId.ToString(), delegate(ReferenceOnEntity e, Guid p)
		{
			IUser planedAssignment = task.GetPlanedAssignment(e, p);
			return (planedAssignment == null) ? string.Empty : planedAssignment.Id.ToString();
		});
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		}, (JsonRequestBehavior)0);
	}
}
