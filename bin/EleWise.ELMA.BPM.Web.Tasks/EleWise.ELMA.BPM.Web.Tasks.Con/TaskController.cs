using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using EleWise.ELMA.Actions;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Web.Mvc.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[Permission("76EC51E5-E826-4876-8B8A-BFED9D2CF6CF")]
[RouteArea("EleWise.ELMA.BPM.Web.Tasks")]
[ActiveMenuItem("tasks-threads-tree")]
public class TaskController : BPMController<ITask, long>
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
	public new TaskManager Manager => (TaskManager)base.Manager;

	[NotNull]
	public TaskBaseManager TaskBaseManager { get; set; }

	[NotNull]
	public ICommentActionHandler CommentActionHandler { get; set; }

	[NotNull]
	public ICommentActionWebHandler CommentActionWebHandler { get; set; }

	[NotNull]
	public ICreateSubtaskActionHandler CreateSubtaskActionHandler { get; set; }

	[NotNull]
	public IAuditManager AuditManager { get; set; }

	[NotNull]
	public IProductionCalendarService ProductionCalendarService { get; set; }

	public ActionResult Index()
	{
		base.ViewTitle = SR.T("Задачи");
		return (ActionResult)(object)((Controller)this).RedirectToAction("Incoming", "AllTasks", (object)new
		{
			FilterId = 0
		});
	}

	[ContentItem(Name = "SR.M('Задача')", Id = "tasks-create", Image24 = "#add_task.svg")]
	[ActiveMenuItem("tasks-threads-tree")]
	public ActionResult Create(bool? period, string start = null, string end = null, long[] idUsers = null, ICreateSubtaskActionModel subtask = null, bool forAll = false, bool forDepartment = false, [Bind(Prefix = "Entity")] Dictionary<string, string> entity = null, long? schedule = null, bool isAjax = false)
	{
		if (period == true)
		{
			base.ActiveMenuItem = "period-Current";
		}
		TaskModel taskModel = new TaskModel();
		if (entity != null)
		{
			new EntityJsonSerializer().ConvertFromSerializable(taskModel.Entity, entity);
			taskModel.SingleExecutor = taskModel.Entity.Executor != null;
		}
		else
		{
			taskModel.Entity.Period = ((period.HasValue && period.Value) ? CalendarEventPeriod.Weekly : CalendarEventPeriod.Once);
		}
		return CreateGet(taskModel, TZ.ToRuntimeDateTimeFromClient(start), TZ.ToRuntimeDateTimeFromClient(end), idUsers, subtask, forAll, forDepartment, schedule, isAjax);
	}

	private ActionResult CreateGet(TaskModel model, string start = null, string end = null, long[] idUsers = null, ICreateSubtaskActionModel subtask = null, bool forAll = false, bool forDepartment = false, long? schedule = null, bool isAjax = false)
	{
		model.Entity.ControlUser = model.Entity.ControlUser ?? base.AuthenticationService.GetCurrentUser<IUser>();
		model.PeriodTask = model.Entity.Period != CalendarEventPeriod.Once;
		model.CurrentUserId = model.Entity.ControlUser.Id;
		if (!string.IsNullOrEmpty(start) && !string.IsNullOrEmpty(end))
		{
			model.ScheduleId = schedule;
			DateTime startDate = DateTime.Parse(start);
			DateTime endDate = DateTime.Parse(end);
			model.StartDate = startDate;
			model.EndDate = endDate;
			model.ReturnUrl = ((Controller)this).get_Url().Action("Index", "Scheduler", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Calendar"
			});
			((ControllerBase)this).get_ViewData().set_Item("EnableLessOldValue", (object)false);
		}
		if (forAll || forDepartment)
		{
			IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
			userFilter.ShowBlock = false;
			userFilter.ShowOnlySubordinateAndSelf = forDepartment;
			foreach (IUser item in UserManager.Find(userFilter, FetchOptions.All))
			{
				try
				{
					((Set<IUser>)(object)model.Executors).Add(item);
				}
				catch
				{
				}
			}
		}
		else if (idUsers != null && idUsers.Length != 0)
		{
			try
			{
				foreach (long id in idUsers)
				{
					((Set<IUser>)(object)model.Executors).Add(UserManager.Load(id));
				}
			}
			catch
			{
			}
		}
		if (subtask != null && subtask.ParentId > 0)
		{
			model.SubTaskModel = subtask;
			model.FormId = "SubTaskForm_" + Guid.NewGuid().ToString("N");
			model.Entity.ParentTask = TaskBaseManager.Load(subtask.ParentId);
			CreateSubtaskActionHandler.ProcessBeforeCreate(model.Entity.ParentTask, model.Entity, subtask);
			model.NormalizeDates();
			model.ReturnUrl = subtask.RedirectUrl;
			if (model.Entity.EndDate < DateTime.Now)
			{
				((ControllerBase)this).get_ViewData().set_Item("EnableLessOldValue", (object)false);
			}
		}
		Locator.GetService<ITemporaryAuthenticationService>()?.GetFromContext(((Controller)this).get_HttpContext())?.ApplyTemplate(model.Entity);
		foreach (ICommentActionWebHandler extensionPoint in ComponentManager.Current.GetExtensionPoints<ICommentActionWebHandler>())
		{
			extensionPoint.BeforeCreateProcess(((ControllerBase)this).get_ValueProvider(), model);
		}
		if (((IEnumerable<IAttachment>)model.Entity.Attachments).Any())
		{
			if (model.CommentActionModel.Attachments == null)
			{
				model.CommentActionModel.Attachments = new List<IAttachment>();
			}
			((IEnumerable<IAttachment>)model.Entity.Attachments).ForEach(delegate(IAttachment a)
			{
				model.CommentActionModel.Attachments.Add(a);
			});
		}
		((Controller)this).TryUpdateModel<TaskModel>(model, "Model");
		if (isAjax)
		{
			model.AjaxPopup = true;
			return (ActionResult)(object)((Controller)this).PartialView("CreatePopup", (object)model);
		}
		return (ActionResult)(object)((Controller)this).View((object)model);
	}

	[ContentItem(Name = "SR.M('Создать периодическую задачу')", Image24 = "#add.svg")]
	public ActionResult CreatePeriod()
	{
		return (ActionResult)(object)((Controller)this).RedirectToAction("Create", "Task", (object)new
		{
			period = true
		});
	}

	protected virtual void NotifyTaskAction(ITaskBase task, string actionThemeFormat)
	{
		TaskBaseController.NotifyTaskAction(this, task, actionThemeFormat);
	}

	private static IEnumerable<ITask> CloneTaskRecursive(IList<IEnumerable<Action<ITask>>> allActions, Func<ITask> createFunction, int index = 0, Action<ITask>[] doActions = null)
	{
		while (index < allActions.Count && (allActions[index] == null || !allActions[index].Any()))
		{
			index++;
		}
		if (index >= allActions.Count)
		{
			ITask task = createFunction();
			if (doActions != null)
			{
				for (int i = 0; i < doActions.Length; i++)
				{
					doActions[i](task);
				}
			}
			return new ITask[1] { task };
		}
		List<ITask> list = new List<ITask>();
		foreach (Action<ITask> item in allActions[index])
		{
			list.AddRange(CloneTaskRecursive(allActions, createFunction, index + 1, (doActions ?? new Action<ITask>[0]).Union(new Action<ITask>[1] { item }).ToArray()));
		}
		return list;
	}

	private IList<ITask> CloneTask(TaskModel model)
	{
		IList<IEnumerable<Action<ITask>>> list = (from ct in ComponentManager.Current.GetExtensionPoints<ICloneTaskExtendedModel>()
			select ct.UpdateActions(model.CreateTaskExtendedModel)).ToList();
		Func<ITask> createFunction;
		if (!model.SingleExecutor)
		{
			list = list.Union(new IEnumerable<Action<ITask>>[1] { ((IEnumerable<IUser>)model.Executors).Select((Func<IUser, Action<ITask>>)((IUser e) => delegate(ITask t)
			{
				t.Executor = e;
			})) }).ToList();
			createFunction = delegate
			{
				TaskModel taskModel = new TaskModel();
				((Controller)this).TryUpdateModel<TaskModel>(taskModel);
				return InitializeTask(taskModel);
			};
		}
		else
		{
			createFunction = () => InitializeTask(model);
		}
		return CloneTaskRecursive(list, createFunction).ToList();
	}

	public static IApprovalTask CreateApprovalTask(ITask task, IUser author, DateTime? endDate = null, DateTime? startDate = null)
	{
		return CreateApprovalTask(task, author, null, endDate, startDate);
	}

	public static IApprovalTask CreateApprovalTask(ITask task, IUser author, Action<IApprovalTask> createExecutor, DateTime? endDate = null, DateTime? startDate = null)
	{
		if (task.Harmonizator != null && !((IEnumerable<ITaskBase>)task.ChildTasks).Any((ITaskBase t) => t is IApprovalTask && ((IApprovalTask)t).ApprovalStatus == ApprovalStatus.None))
		{
			IApprovalTask hTask = new InstanceOf<IApprovalTask>().New;
			hTask.ParentStatus = task.Status;
			hTask.ParentTask = task;
			hTask.Executor = task.Harmonizator;
			hTask.Status = TaskBaseStatus.NewOrder;
			hTask.Subject = task.Subject;
			hTask.StartDate = startDate ?? task.StartDate;
			hTask.EndDate = endDate ?? task.EndDate;
			hTask.CreationAuthor = author;
			hTask.CreationDate = DateTime.Now;
			hTask.Priority = task.Priority;
			hTask.Attachments = task.Attachments;
			(from p in ComponentManager.Current.GetExtensionPoints<IObjectAttachmentExtension>()
				where p.EntityType(InterfaceActivator.UID<ITaskBase>())
				select p).ForEach(delegate(IObjectAttachmentExtension x)
			{
				x.Copy(task, hTask);
			});
			createExecutor?.Invoke(hTask);
			task.Status = TaskBaseStatus.OnApproval;
			return hTask;
		}
		return null;
	}

	[NotNull]
	private ITask InitializeTask(TaskModel model)
	{
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		if (model.Entity == null)
		{
			throw new ArgumentException("model.Entity");
		}
		ITask entity = model.Entity;
		if (entity.IsNew() || model.SubTask)
		{
			entity.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
			entity.CreationDate = DateTime.Now;
		}
		entity.StartDate = model.StartDate.NormalizeStartDate(model.StartDate.IsStartDamperTimeBySeconds());
		entity.EndDate = model.EndDate.NormalizeEndDate(model.EndDate.IsEndDamperTimeBySeconds());
		CorrectTaskDates(entity, model.DateCorrection);
		if (!model.HasHarmonizator)
		{
			entity.Harmonizator = null;
		}
		if (!model.HasInformTo && entity.InformTo != null)
		{
			((ICollection<IUser>)entity.InformTo).Clear();
		}
		if (!model.PeriodTask)
		{
			entity.Period = CalendarEventPeriod.Once;
		}
		if (!model.UntilPeriodTask)
		{
			entity.UntilDate = null;
		}
		if (!entity.UnderControl)
		{
			entity.ControlUser = null;
		}
		if (entity.UntilDate.HasValue)
		{
			entity.UntilDate = new DateTime(entity.UntilDate.Value.Year, entity.UntilDate.Value.Month, entity.UntilDate.Value.Day, 23, 59, 50);
		}
		CommentActionHandler.Process(entity, model.CommentActionModel);
		if (model.Entity.ParentTask != null && entity != null && entity.IsNew())
		{
			CreateSubtaskActionHandler.ProcessBeforeSave(model.Entity.ParentTask, entity, model.SubTaskModel);
		}
		return entity;
	}

	private void CorrectTaskDates(ITask task, TaskDateCorrection correctionType)
	{
		if (!task.StartDate.HasValue || !task.EndDate.HasValue)
		{
			return;
		}
		IProductionSchedule globalProductionSchedule = ProductionCalendarService.GetGlobalProductionSchedule();
		if (globalProductionSchedule == null)
		{
			base.Logger.Log(LogLevel.Warning, null, "Не удалось получить вычислитель глобального производственного календаря при корректировке сроков задачи");
			return;
		}
		DateTime value = task.StartDate.Value;
		DateTime value2 = task.EndDate.Value;
		int num;
		DateTime dateTime;
		switch (correctionType)
		{
		case TaskDateCorrection.FirstAvailable:
			value = globalProductionSchedule.CheckWorkDay(value);
			value2 = globalProductionSchedule.CheckWorkDay(value2);
			task.StartDate = value;
			task.EndDate = value2;
			break;
		case TaskDateCorrection.KeepDuration:
			if (!value.IsStartDamperTimeBySeconds())
			{
				num = ((!value2.IsEndDamperTimeBySeconds()) ? 1 : 0);
				if (num != 0)
				{
					dateTime = globalProductionSchedule.CheckWorkDay(value);
					goto IL_00c9;
				}
			}
			else
			{
				num = 0;
			}
			dateTime = globalProductionSchedule.GetNextWorkTime(value);
			goto IL_00c9;
		case TaskDateCorrection.None:
			break;
			IL_00c9:
			value = dateTime;
			value2 += value - task.StartDate.Value;
			if (num != 0)
			{
				int num2 = (value2.Date - value.Date).Days + 1 - globalProductionSchedule.GetWorkDays(value, value2);
				if (!globalProductionSchedule.IsWorkDay(value2))
				{
					num2--;
				}
				value2 = globalProductionSchedule.AddDays(value2, num2).Date + value2.TimeOfDay;
			}
			else
			{
				double num3 = 0.0 - globalProductionSchedule.EvalWorkTimeHoursDifference(value, value2);
				TimeSpan workTimeInDay = globalProductionSchedule.GetWorkTimeInDay();
				DateTime dateTime2 = value.Date;
				while (dateTime2 <= value2.Date)
				{
					num3 = ((dateTime2 == value.Date && dateTime2 == value2.Date) ? (num3 + Math.Max(globalProductionSchedule.GetBaseWorkTimeStartDifference(value2.TimeOfDay) + globalProductionSchedule.GetBaseWorkTimeEndDifference(value.TimeOfDay) - workTimeInDay.TotalHours, 0.0)) : ((!(dateTime2 == value.Date)) ? ((!(dateTime2 == value2.Date)) ? (num3 + workTimeInDay.TotalHours) : (num3 + globalProductionSchedule.GetBaseWorkTimeStartDifference(value2.TimeOfDay))) : (num3 + globalProductionSchedule.GetBaseWorkTimeEndDifference(value.TimeOfDay))));
					dateTime2 = dateTime2.AddDays(1.0);
				}
				value2 = globalProductionSchedule.EvalTargetTime(value2, num3);
			}
			task.StartDate = value;
			task.EndDate = value2;
			break;
		}
	}

	public ActionResult FastCreate(string popupId, string scriptCallback, string dateString, bool workLogPartEnabled = false)
	{
		DateTime? dateTime = ParseDate(dateString);
		FastTaskModel fastTaskModel = new FastTaskModel
		{
			CallbackScript = scriptCallback,
			StartDate = (dateTime.HasValue ? dateTime.Value : DateTime.Now),
			EndDate = (dateTime.HasValue ? dateTime.Value : DateTime.Now),
			CreateDate = (dateTime.HasValue ? dateTime.Value : DateTime.Today),
			Id = popupId + "_Form",
			Entity = InterfaceActivator.Create<ITask>(),
			WorkLogItemPartEnabled = workLogPartEnabled,
			WorkLogItemHarmonizator = (WorkLogExtensionHelper.DefaultHarmonizator() ?? CurrentUser)
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)fastTaskModel);
	}

	private static DateTime? ParseDate(string dateString)
	{
		if (string.IsNullOrEmpty(dateString))
		{
			return null;
		}
		if (DateTime.TryParse(dateString, out var result))
		{
			return result.ToRuntimeDateTimeFromClient();
		}
		return null;
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult FastCreate(FastTaskModel model)
	{
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		try
		{
			if (model.EndDate < model.StartDate)
			{
				model.EndDate = model.StartDate;
			}
			ITask entity = model.Entity;
			entity.Period = CalendarEventPeriod.Once;
			entity.Executor = CurrentUser;
			entity.ControlUser = CurrentUser;
			entity.StartDate = model.StartDate.NormalizeStartDate(model.StartDate.IsStartDamperTimeBySeconds());
			entity.EndDate = model.EndDate.NormalizeEndDate(model.EndDate.IsEndDamperTimeBySeconds());
			entity.Status = ((model.Status == FastTaskStatusSave.Completed) ? TaskBaseStatus.Complete : ((model.Status == FastTaskStatusSave.InCompleted) ? TaskBaseStatus.Incomplete : TaskBaseStatus.InProgress));
			ContextVars.Set("DisableSetTaskWorkDate", value: true);
			if (entity.IsComplete())
			{
				entity.StartWorkDate = entity.StartDate;
				entity.EndWorkDate = entity.EndDate;
			}
			entity.Save();
			long num = 0L;
			if (model.WorkMinutes.HasValue && model.WorkMinutes.Value.Value != 0L)
			{
				IWorkLog workLog = InterfaceActivator.Create<IWorkLog>();
				IUser user2 = (workLog.CreationAuthor = (workLog.Worker = CurrentUser));
				workLog.TaskBase = entity;
				workLog.Comment = SR.T(entity.Description);
				workLog.WorkMinutes = model.WorkMinutes;
				workLog.StartDate = (entity.StartDate.HasValue ? entity.StartDate : new DateTime?(model.CreateDate));
				WorkLogManager.Instance.Save(workLog);
				num = workLog.Id;
			}
			JsonResult val;
			if (num == 0L)
			{
				val = new JsonResult();
				val.set_Data((object)new { entity.Id });
			}
			else
			{
				val = new JsonResult();
				val.set_Data((object)new
				{
					Id = entity.Id,
					WorkLogId = num
				});
			}
			return (ActionResult)val;
		}
		catch (Exception ex)
		{
			JsonResult val2 = new JsonResult();
			val2.set_Data((object)new
			{
				Error = ex.Message
			});
			return (ActionResult)val2;
		}
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Create(TaskModel model)
	{
		if (model.SingleExecutor ? (model.Entity.Executor == null) : ((Set<IUser>)(object)model.Executors).get_IsEmpty())
		{
			base.Notifier.Error(SR.T("Заполните поле {0}", InterfaceActivator.LoadPropertyMetadata((ITaskBase t) => t.Executor).DisplayName));
			return (ActionResult)(object)((Controller)this).View((object)model);
		}
		IList<ITask> list = CloneTask(model);
		if (list != null)
		{
			foreach (ITask task in list)
			{
				if (task == null)
				{
					continue;
				}
				CreateApprovalTask(task, base.AuthenticationService.GetCurrentUser<IUser>())?.Save();
				task.Save();
				if (model.Watchers != null && ((IEnumerable<IUser>)model.Watchers).Any())
				{
					ITask task2 = task;
					((IEnumerable<IUser>)model.Watchers).ForEach(delegate(IUser wu)
					{
						WatchManager.Instance.CreateWatchByUser(task2.TypeUid, task2.Id, wu);
					});
					ComponentManager.Current.GetExtensionPoints<IWatchNotifier>().FirstOrDefault((IWatchNotifier p) => p.IsAvailable(task.TypeUid))?.Notify(task.Id, ((IEnumerable<IUser>)model.Watchers).Where((IUser u) => u.Id != CurrentUser.Id), null);
				}
				Manager.UpdatePeriodTask(task);
				NotifyTaskAction(task, (task.Period != 0) ? (model.IsCopy ? SR.T("Создана копия периодической задачи") : SR.T("Создана новая периодическая задача")) : (model.IsCopy ? SR.T("Создана копия задачи") : SR.T("Создана новая задача")));
				ITask scheduleTask = task;
				if (!model.ScheduleId.HasValue || !scheduleTask.StartDate.HasValue || !scheduleTask.EndDate.HasValue)
				{
					continue;
				}
				ISchedule schedule = ScheduleManager.Instance.LoadOrNull(model.ScheduleId.Value);
				if (schedule != null && schedule.Owner == CurrentUser)
				{
					base.SecurityService.RunWithElevatedPrivilegies(delegate
					{
						Manager.Schedule(scheduleTask.Id, scheduleTask.StartDate.Value, scheduleTask.EndDate.Value, removeOther: false);
					});
				}
			}
			if (model.Entity != null && model.Entity.ParentTask != null)
			{
				ITaskBase parentTask = model.Entity.ParentTask;
				TaskBaseManager.RaiseCreateSubTaskActionExecute(parentTask, list.Select((ITask a) => a.Id).ToList());
			}
		}
		if (model.AjaxPopup)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true
			});
		}
		if (!string.IsNullOrEmpty(model.ReturnUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.ReturnUrl);
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	[ActiveMenuItem("tasks-threads-tree")]
	public ActionResult Copy(ITask task)
	{
		if (!TaskWorkflowActions.IsAvailableCopy(task))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Create");
		}
		TaskModel model = new TaskModel((task != null) ? TaskManager.Clone(task) : InterfaceActivator.Create<ITask>())
		{
			SingleExecutor = true,
			IsCopy = true
		};
		return CreateGet(model);
	}

	public ActionResult CheckOrganizationItems(IUser[] executors)
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		return (ActionResult)(object)((Controller)this).Json((object)((IEnumerable<IUser>)executors).All((Func<IUser, bool>)currentUser.CheckOrganizationItem), (JsonRequestBehavior)0);
	}

	public ActionResult GetTaskOnControlEnums()
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		EnumMetadata enumMetadata = MetadataLoader.LoadMetadata(typeof(TaskControlType)) as EnumMetadata;
		if (enumMetadata == null)
		{
			Type type = typeof(TaskControlType).GetGenericArguments().FirstOrDefault();
			enumMetadata = ((type != null) ? (MetadataLoader.LoadMetadata(type) as EnumMetadata) : null);
		}
		List<SelectListItem> list = new List<SelectListItem>();
		if (enumMetadata != null)
		{
			foreach (EnumValueMetadata value in enumMetadata.Values)
			{
				if (value.Visibility == Visibility.Visible)
				{
					SelectListItem val = new SelectListItem();
					val.set_Value(value.Name);
					val.set_Text(value.DisplayName);
					val.set_Selected(false);
					SelectListItem item = val;
					list.Add(item);
				}
			}
		}
		string enums = new JavaScriptSerializer().Serialize(list);
		return (ActionResult)(object)((Controller)this).Json((object)new { enums }, (JsonRequestBehavior)0);
	}

	private TaskViewModel CreateTaskViewModel(long taskId)
	{
		ITask task = TaskManager.Instance.Load(taskId);
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		return new TaskViewModel
		{
			Entity = task,
			IsAvailableEdit = TaskWorkflowActions.IsAvailableEdit(task, currentUser),
			IsAvailableCreateSubtask = TaskWorkflowActions.IsAvailableCreateSubtask(task, CurrentUser),
			IsAvailableCreateApproval = TaskWorkflowActions.IsAvailableCreateApproval(task, currentUser),
			IsAvailableStartWork = TaskWorkflowActions.IsAvailableStartWork(task, currentUser),
			IsAvailableCompleted = TaskWorkflowActions.IsAvailableCompleted(task, currentUser),
			IsAvailableInCompleted = TaskWorkflowActions.IsAvailableInCompleted(task, currentUser),
			IsAvailableControlledAction = TaskWorkflowActions.IsAvailableControlledAction(task, currentUser),
			IsAvailableReAssign = TaskWorkflowActions.IsAvailableReAssign(task, currentUser),
			IsAvailableClose = TaskWorkflowActions.IsAvailableClose(task, currentUser),
			IsAvailableDateChange = TaskWorkflowActions.IsAvailableDateChange(task, currentUser),
			IsAvailableChangeControl = TaskWorkflowActions.IsAvailableChangeControl(task, currentUser),
			IsAvailableCopy = TaskWorkflowActions.IsAvailableCopy(task),
			IsAvailableTakeCurrentControl = TaskWorkflowActions.IsAvailableTakeCurrentControl(task, currentUser),
			IsAvailableBreakCurrentControl = TaskWorkflowActions.IsAvailableBreakCurrentControl(task, currentUser),
			IsAvailableDeleteWatches = TaskWorkflowActions.IsAvailableDeleteWatches(task, currentUser),
			IsAvailableWorkLog = TaskWorkflowActions.IsAvailableWorkLog(task, currentUser),
			IsEmulation = task.IsEmulation,
			ExecutorIsEmulation = task.ExecutorIsEmulation
		};
	}

	public ActionResult ReOpen(ITask task)
	{
		if (!TaskWorkflowActions.IsAvailableControlledAction(task, base.AuthenticationService.GetCurrentUser<IUser>()))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", "Task", (object)new
			{
				id = task.Id
			});
		}
		string returnUrl = ((Controller)this).get_Request().Params["ReturnUrl"];
		TaskModel taskModel = new TaskModel(task)
		{
			CurrentUserId = base.AuthenticationService.GetCurrentUser<IUser>().Id,
			ReOpen = true,
			ReturnUrl = returnUrl
		};
		return (ActionResult)(object)((Controller)this).View((object)taskModel);
	}

	public ActionResult Edit(ITask task)
	{
		if (!TaskWorkflowActions.IsAvailableEdit(task, base.AuthenticationService.GetCurrentUser<IUser>()))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", "Task", (object)new
			{
				id = task.Id
			});
		}
		if (task.IsTemplate)
		{
			base.ActiveMenuItem = "period-Current";
		}
		string returnUrl = ((Controller)this).get_Request().Params["ReturnUrl"];
		TaskModel taskModel = new TaskModel(task)
		{
			CurrentUserId = base.AuthenticationService.GetCurrentUser<IUser>().Id,
			ReturnUrl = returnUrl
		};
		return (ActionResult)(object)((Controller)this).View((object)taskModel);
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult Save(TaskModel model)
	{
		ITask task;
		if (TaskWorkflowActions.IsAvailableControlledAction(model.Entity, base.AuthenticationService.GetCurrentUser<IUser>()) || TaskWorkflowActions.IsAvailableEdit(model.Entity, base.AuthenticationService.GetCurrentUser<IUser>()))
		{
			if (model.ShowPlanWorkLog && WorkLogControllerHelper.SaveTaskPlanWorkLogOvertime(this, model.Entity))
			{
				return (ActionResult)(object)((Controller)this).View("Edit", (object)model);
			}
			task = InitializeTask(model);
			task.Status = TaskBaseStatus.NewOrder;
			if (task.IsNew())
			{
				CreateApprovalTask(task, base.AuthenticationService.GetCurrentUser<IUser>())?.Save();
			}
			task.Save();
			if (!task.IsTemplate)
			{
				goto IL_017f;
			}
			if (task.Period == model.OldPeriod)
			{
				DateTime? startDate = task.StartDate;
				DateTime? oldStartDate = model.OldStartDate;
				if (startDate.HasValue == oldStartDate.HasValue && (!startDate.HasValue || !(startDate.GetValueOrDefault() != oldStartDate.GetValueOrDefault())) && !(task.EndDate != model.OldEndDate))
				{
					goto IL_017f;
				}
			}
			Manager.TemplateChangeDateOrPeriod(task);
			goto IL_0196;
		}
		if (base.UnitOfWorkManager != null)
		{
			base.UnitOfWorkManager.RollbackCurrent(string.Empty);
		}
		goto IL_0312;
		IL_0312:
		return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", "Task", (object)new
		{
			id = model.Entity.Id,
			ReturnUrl = model.ReturnUrl
		});
		IL_017f:
		Manager.UpdatePeriodTask(task);
		goto IL_0196;
		IL_0196:
		EntityActionEventArgs e = (model.ReOpen ? new EntityActionEventArgs(null, task, "d9f5a312-270b-4709-b7c8-5789545c4a4c") : new EntityActionEventArgs(null, task, "ef34b63c-a9f6-4136-8e80-505a8e728baa"));
		CommentActionHandler.ProcessEventArgs(e, model.CommentActionModel);
		EntityActionHandler.ActionExecuted(e);
		List<IUser> list = (string.IsNullOrEmpty(model.OldInformTo) ? new List<IUser>() : (from s in model.OldInformTo.Split(',')
			select UserManager.Load(long.Parse(s))).ToList());
		CollectionExtensions.DelegateComparer<IUser> comparer = new CollectionExtensions.DelegateComparer<IUser>((IUser f, IUser s) => f.Id == s.Id, (IUser u) => u.Id.GetHashCode());
		if (list != null)
		{
			List<IUser> list2 = ((IEnumerable<IUser>)task.InformTo).Except(list, comparer).ToList();
			List<IUser> list3 = list.Except((IEnumerable<IUser>)task.InformTo, comparer).ToList();
			if (list2.Any())
			{
				EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(null, task, "ba0d7c62-8671-4232-ac35-d5006e23dff7");
				entityActionEventArgs.ExtendedProperties.Add("AddMembers", list2);
				EntityActionHandler.ActionExecuted(entityActionEventArgs);
			}
			if (list3.Any())
			{
				EntityActionEventArgs entityActionEventArgs2 = new EntityActionEventArgs(null, task, "0361b9d5-c125-4e77-b0c2-8609d42a6bdd");
				entityActionEventArgs2.ExtendedProperties.Add("DeleteMembers", list3);
				EntityActionHandler.ActionExecuted(entityActionEventArgs2);
			}
		}
		goto IL_0312;
	}

	public ActionResult SubTaskType(long parentId, Guid? type = null, string returnUrl = null, bool isAjax = false)
	{
		ITaskBase parentTask = TaskBaseManager.Load(parentId);
		type = type ?? parentTask.TypeUid;
		ICreateSubtaskExtension createSubtaskExtension = (from e in ComponentManager.Current.GetExtensionPoints<ICreateSubtaskExtension>()
			where e.CanCreateSubtaskFrom(parentTask)
			select e).FirstOrDefault((ICreateSubtaskExtension e) => e.SubTaskTypeUid == type.Value);
		ICreateSubtaskActionModel createSubtaskActionModel;
		if (createSubtaskExtension == null)
		{
			InstanceOf<ICreateSimpleSubtaskActionModel> instanceOf = new InstanceOf<ICreateSimpleSubtaskActionModel>();
			instanceOf.New.ParentId = parentTask.Id;
			instanceOf.New.SubTaskTypeUid = InterfaceActivator.UID<ITask>();
			instanceOf.New.CreateSubTaskAction = "Create";
			instanceOf.New.CreateSubTaskController = "Task";
			instanceOf.New.CreateSubTaskArea = "EleWise.ELMA.BPM.Web.Tasks";
			ICreateSubtaskActionModel @new = instanceOf.New;
			createSubtaskActionModel = @new;
		}
		else
		{
			createSubtaskActionModel = createSubtaskExtension.CreateSettings(parentTask);
		}
		ICreateSubtaskActionModel createSubtaskActionModel2 = createSubtaskActionModel;
		createSubtaskActionModel2.RedirectUrl = returnUrl;
		((ControllerBase)this).get_ViewData().Add("IsAjax", (object)isAjax);
		return (ActionResult)(object)((Controller)this).PartialView("Task/Partial/SubTaskPopupPartial", (object)createSubtaskActionModel2);
	}

	public ActionResult SubTaskPopup(long parentId, string returnUrl = null, string popupId = null, bool isAjax = false)
	{
		TaskBaseManager.Load(parentId);
		SubTaskPopupModel subTaskPopupModel = new SubTaskPopupModel
		{
			ParentId = parentId,
			PopupId = popupId,
			ReturnUrl = returnUrl,
			IsAjax = isAjax
		};
		return (ActionResult)(object)((Controller)this).PartialView("Task/SubTaskPopup", (object)subTaskPopupModel);
	}

	[ClearRegisterContent(Zone = "Toolbar", Key = "ToolbarContentDefaultActionsToolbar")]
	[ClearRegisterContent(Zone = "Toolbar", Key = "ToolbarRenderScriptDefaultActionsToolbar")]
	public ActionResult CreateSubTask(bool checkReplacement = true)
	{
		TaskModel taskModel = new TaskModel
		{
			PeriodTask = false,
			SingleExecutor = false,
			SubTask = true,
			FormId = "SubTaskForm_" + Guid.NewGuid().ToString("N"),
			CheckReplacement = checkReplacement
		};
		taskModel.Entity.ControlUser = base.AuthenticationService.GetCurrentUser<IUser>();
		return (ActionResult)(object)((Controller)this).PartialView("TaskEditor", (object)taskModel);
	}

	[HttpPost]
	public ActionResult SubTask(TaskModel model)
	{
		IList<ITask> list = CloneTask(model);
		foreach (ITask item in list)
		{
			item.Period = CalendarEventPeriod.Once;
			if (item.ParentTask != null && item.ParentTask.Id > 0)
			{
				item.Save();
			}
		}
		EntityJsonSerializer @object = new EntityJsonSerializer();
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			list = list.Select(@object.Serialize),
			index = model.SubTaskIndex
		}, "text/html", (JsonRequestBehavior)0);
	}

	[ClearRegisterContent(Zone = "Toolbar", Key = "ToolbarContentDefaultActionsToolbar")]
	[ClearRegisterContent(Zone = "Toolbar", Key = "ToolbarRenderScriptDefaultActionsToolbar")]
	public ActionResult EditSubTask(string subTaskJson, int subTaskIndex)
	{
		ITask task = new EntityJsonSerializer().Deserialize(subTaskJson, InterfaceActivator.TypeOf<ITask>(), loadEntityIfExists: false) as ITask;
		TaskModel taskModel = new TaskModel(task)
		{
			SubTask = true,
			FormId = "SubTaskForm_" + Guid.NewGuid().ToString("N"),
			PeriodTask = false,
			SingleExecutor = true,
			SubTaskIndex = subTaskIndex,
			ShowPlanWorkLog = (task != null && task.PlanWorkLog.HasValue && task.PlanWorkLog.Value > 0L)
		};
		return (ActionResult)(object)((Controller)this).PartialView("TaskEditor", (object)taskModel);
	}

	public ActionResult HasActiveSubTasks(long taskId)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		ITaskBase taskBase = TaskBaseManager.LoadOrNull(taskId);
		if (taskBase == null)
		{
			JsonResult val = new JsonResult();
			val.set_Data((object)new
			{
				activeSubTasks = false
			});
			val.set_JsonRequestBehavior((JsonRequestBehavior)0);
			return (ActionResult)val;
		}
		if (!taskBase.IsActive())
		{
			JsonResult val2 = new JsonResult();
			val2.set_Data((object)new
			{
				activeSubTasks = false
			});
			val2.set_JsonRequestBehavior((JsonRequestBehavior)0);
			return (ActionResult)val2;
		}
		JsonResult val3 = new JsonResult();
		val3.set_Data((object)new
		{
			activeSubTasks = ((IEnumerable<ITaskBase>)taskBase.ChildTasks).Any((ITaskBase t) => t.IsActive())
		});
		val3.set_JsonRequestBehavior((JsonRequestBehavior)0);
		return (ActionResult)val3;
	}

	[EntityLink]
	public ActionResult Approve(IApprovalTask task)
	{
		TaskViewModel taskViewModel = new TaskViewModel
		{
			Entity = task,
			IsAvailableApproval = TaskWorkflowActions.IsAvailableApproval(task, base.AuthenticationService.GetCurrentUser<IUser>())
		};
		return (ActionResult)(object)((Controller)this).View((object)taskViewModel);
	}

	private ITaskBase DoApprove(CommentWithAttachments commentModel, bool confirm)
	{
		if (commentModel == null)
		{
			throw new ArgumentNullException("commentModel");
		}
		if (!confirm)
		{
			return Manager.DoRefuseApprove(commentModel.ObjectId, commentModel.ActionModel);
		}
		return Manager.DoConfirmApprove(commentModel.ObjectId, commentModel.ActionModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult CreateApproval(CreateApprovalModel model)
	{
		ITask task = model.Task;
		if (TaskWorkflowActions.IsAvailableCreateApproval(task, base.AuthenticationService.GetCurrentUser<IUser>()) && model.Harmonizator != null)
		{
			task.Harmonizator = model.Harmonizator;
			IComment comment = null;
			if (!string.IsNullOrEmpty(model.Comment))
			{
				InstanceOf<IComment> instanceOf = new InstanceOf<IComment>();
				instanceOf.New.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
				instanceOf.New.CreationDate = DateTime.Now;
				instanceOf.New.Text = model.Comment;
				comment = instanceOf.New;
				task.Comments.Add(comment);
			}
			DateTime value = model.HarmonizatorStartDate.NormalizeStartDate(model.HarmonizatorStartDate.IsStartDamperTimeBySeconds());
			DateTime value2 = model.HarmonizatorEndDate.NormalizeEndDate(model.HarmonizatorEndDate.IsEndDamperTimeBySeconds());
			IApprovalTask approvalTask = CreateApprovalTask(task, base.AuthenticationService.GetCurrentUser<IUser>(), value2, value);
			task.Status = TaskBaseStatus.OnApprovalExecutor;
			if (approvalTask != null)
			{
				if (comment != null)
				{
					approvalTask.Comments.Add(comment);
				}
				approvalTask.Save();
			}
			task.Save();
			return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", "Task", (object)new
			{
				id = task.Id,
				ReturnUrl = model.RedirectUrl
			});
		}
		if (base.UnitOfWorkManager != null)
		{
			base.UnitOfWorkManager.RollbackCurrent(string.Empty);
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult ApprovalConfirm(CommentWithAttachments model)
	{
		if (model == null)
		{
			throw new ArgumentNullException("commentModel");
		}
		ITaskBase taskBase = DoApprove(model, confirm: true);
		NotifyTaskAction(taskBase.ParentTask, SR.T("Задача {0} согласована"));
		if (!model.RedirectUrl.IsNullOrWhiteSpace())
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", "Task", (object)new
		{
			id = taskBase.ParentTask.Id
		});
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult ApprovalRefuse(CommentWithAttachments model)
	{
		if (model == null)
		{
			throw new ArgumentNullException("commentModel");
		}
		ITaskBase taskBase = DoApprove(model, confirm: false);
		NotifyTaskAction(taskBase.ParentTask, SR.T("Задача {0} не согласована"));
		if (!model.RedirectUrl.IsNullOrWhiteSpace())
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", "Task", (object)new
		{
			id = taskBase.ParentTask.Id
		});
	}

	[HttpGet]
	public ActionResult GeneralInfo(long id, bool? needApproval, bool? needHistory, bool? needParentRef, bool? needComment)
	{
		ITaskBase entity = TaskBaseManager.Load(id);
		return (ActionResult)(object)((Controller)this).PartialView((object)new TaskViewModel
		{
			Entity = entity,
			NeedApproval = (needApproval ?? true),
			NeedHistory = (needHistory ?? true),
			NeedParentRef = (needParentRef ?? false),
			NeedComment = (needComment ?? true)
		});
	}

	[EntityLink]
	[ActiveMenuItem("tasks-threads-tree")]
	public ActionResult Execute(ITask task)
	{
		base.ViewTitle = SR.T(task.Subject);
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		TaskViewModel taskViewModel;
		if (task.IsTemplate)
		{
			taskViewModel = new TaskViewModel
			{
				Entity = task,
				IsAvailableEdit = TaskWorkflowActions.IsAvailableEdit(task, currentUser),
				IsAvailableControlledAction = (task.Status == TaskBaseStatus.WasClosed && (task.CreationAuthor == currentUser || UserManager.Instance.IsSubordinateUser(currentUser, task.CreationAuthor))),
				IsAvailableClose = TaskWorkflowActions.IsAvailableClose(task, currentUser),
				IsAvailableDeleteWatches = TaskWorkflowActions.IsAvailableDeleteWatches(task, currentUser),
				IsEmulation = task.IsEmulation,
				ExecutorIsEmulation = task.ExecutorIsEmulation
			};
			base.ActiveMenuItem = "period-Current";
			return (ActionResult)(object)((Controller)this).View("PeriodTemplateExecute", (object)taskViewModel);
		}
		taskViewModel = CreateTaskViewModel(task.Id);
		SetAsReadForFeed(task);
		return (ActionResult)(object)((Controller)this).View((object)taskViewModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult MarkRead(long id)
	{
		bool flag = TaskBaseManager.CanMarkRead(id);
		if (flag)
		{
			TaskBaseManager.MarkRead(id);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = flag
		});
	}

	[HttpGet]
	public ActionResult ChangeControl(long id, string returnUrl)
	{
		ChangeControlModel changeControlModel = new ChangeControlModel(Manager.Load(id))
		{
			RedirectUrl = returnUrl
		};
		return (ActionResult)(object)((Controller)this).PartialView("Partial/ChangeControlForm", (object)changeControlModel);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult ChangeControl(ChangeControlModel model)
	{
		ITask task = Manager.ChangeControl(model.Task.Id, model.UnderControl, model.ControlUser, model.ControlType, model.Comment);
		NotifyTaskAction(task, SR.T("Изменен контролер в задаче {0}"));
		if (!string.IsNullOrEmpty(model.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	[HttpPost]
	public virtual ActionResult ReAssign([NotNull] ReAssignTaskViewModel model)
	{
		Contract.ArgumentNotNull(model, "model");
		if (model.Task != null && model.Task.IsComplete())
		{
			Type type = model.Task.GetType();
			IAuditObject @object = AuditManager.GetObject(InterfaceActivator.UID(type));
			Contract.CheckWithMessage<ArgumentException>(@object != null, SR.T("Невозможно найти зарегистрированный тип объекта для типа {0}", type));
			throw new ElmaInvalidOperationException($"Переназначение задачи не может быть выполнено, т.к. задача закрыта. Объект = '{@object.DisplayName}'");
		}
		DateTime startDate = (model.ReAssignStartDate.HasValue ? model.ReAssignStartDate.Value.NormalizeStartDate(model.ReAssignStartDate.HasValue && model.ReAssignStartDate.Value.IsStartDamperTimeBySeconds()) : DateTime.MinValue);
		DateTime endDate = (model.ReAssignEndDate.HasValue ? model.ReAssignEndDate.Value.NormalizeEndDate(model.ReAssignEndDate.HasValue && model.ReAssignEndDate.Value.IsEndDamperTimeBySeconds()) : DateTime.MaxValue);
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
		if (model.SetMeControler && ReAssignTaskViewModel.EnabledSetMeControler(model.Task))
		{
			reAssignActionModel.SetMeControler = true;
		}
		else if (model.SetMeParticipant && ReAssignTaskViewModel.EnabledSetMeParticipant(model.Task))
		{
			reAssignActionModel.SetMeParticipant = true;
		}
		if (model.TakeCurrentControl && ReAssignTaskViewModel.EnabledTakeCurrentControl(model.Task))
		{
			reAssignActionModel.TakeCurrentControl = true;
		}
		using (IUnitOfWork unitOfWork = base.UnitOfWorkManager.Create(string.Empty, transactional: true))
		{
			try
			{
				TaskBaseManager.InvokeAction((TaskBaseManager m) => m.ReAssign(reAssignActionModel), model.Task.GetType());
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
		ITask task = Manager.InvokeAction((TaskManager m) => m.StartWork(commentModel.ObjectId, commentModel.AlertInform, commentModel.ActionModel), commentModel.Object.GetType());
		NotifyTaskAction(task, SR.T("Начата работа над задачей {0}"));
		return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", "Task", (object)new
		{
			id = task.Id
		});
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult DoCompleted([Bind(Prefix = "DoCompleted")] TaskCommentModel commentModel)
	{
		if (commentModel == null)
		{
			throw new ArgumentNullException("commentModel");
		}
		ITask task = Manager.DoCompleted(commentModel.ObjectId, commentModel.AlertInform, commentModel.ActionModel);
		NotifyTaskAction(task, SR.T("Задача {0} отмечена как выполненная"));
		if (commentModel.ShowWorkLog && commentModel.WorkLog != null && commentModel.WorkLog.WorkMinutes.HasValue && commentModel.WorkLog.WorkMinutes > 0L)
		{
			ITaskBase taskBase = task;
			if (taskBase != null)
			{
				IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
				IUser user3 = (commentModel.WorkLog.CreationAuthor = (commentModel.WorkLog.Worker = currentUser));
				commentModel.WorkLog.TaskBase = taskBase;
				commentModel.WorkLog.Comment = commentModel.ActionModel.Comment.Text;
				WorkLogManager.Instance.Save(commentModel.WorkLog);
			}
		}
		if (task.Status == TaskBaseStatus.CompleteControlled && GoToParentTask(CurrentUser, task.ParentTask))
		{
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().Entity(task.ParentTask));
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
		ITask task = Manager.InvokeAction((TaskManager m) => m.Close(commentModel.ObjectId, commentModel.AlertInform, commentModel.ActionModel), typeByUid);
		NotifyTaskAction(task, SR.T("Задача {0} закрыта"));
		if (GoToParentTask(CurrentUser, task.ParentTask))
		{
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().Entity(task.ParentTask));
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	[HttpPost]
	[TransactionAction]
	public virtual ActionResult DateChange([NotNull] TaskBaseModel model)
	{
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		TaskBaseManager taskBaseManager = TaskBaseManager;
		long id = model.Entity.Id;
		DateTime startDate = (model.StartDate.HasValue ? model.StartDate.Value.NormalizeStartDate(model.StartDate.Value.IsStartDamperTimeBySeconds()) : DateTime.MinValue);
		DateTime endDate = (model.EndDate.HasValue ? model.EndDate.Value.NormalizeEndDate(model.EndDate.Value.IsEndDamperTimeBySeconds()) : DateTime.MaxValue);
		object comment;
		if (!model.Comment.IsNullOrEmpty())
		{
			InstanceOf<IComment> instanceOf = new InstanceOf<IComment>();
			instanceOf.New.Text = model.Comment;
			instanceOf.New.CreationAuthor = base.AuthenticationService.GetCurrentUser<IUser>();
			instanceOf.New.CreationDate = DateTime.Now;
			comment = instanceOf.New;
		}
		else
		{
			comment = null;
		}
		taskBaseManager.ChangeDate(id, startDate, endDate, (IComment)comment);
		NotifyTaskAction(model.Entity, SR.T("Изменен срок задачи {0}"));
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
		ITask task = Manager.DoIncompleted(commentModel.ObjectId, commentModel.AlertInform, commentModel.ActionModel);
		NotifyTaskAction(task, SR.T("Задачу {0} невозможно выполнить"));
		if (commentModel.ShowWorkLog && commentModel.WorkLog != null && commentModel.WorkLog.WorkMinutes.HasValue && commentModel.WorkLog.WorkMinutes > 0L)
		{
			ITaskBase taskBase = task;
			if (taskBase != null)
			{
				IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
				IUser user3 = (commentModel.WorkLog.CreationAuthor = (commentModel.WorkLog.Worker = currentUser));
				commentModel.WorkLog.TaskBase = taskBase;
				commentModel.WorkLog.Comment = commentModel.ActionModel.Comment.Text;
				WorkLogManager.Instance.Save(commentModel.WorkLog);
			}
		}
		if (task.Status == TaskBaseStatus.IncompleteControlled && GoToParentTask(CurrentUser, task.ParentTask))
		{
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().Entity(task.ParentTask));
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult Controlled([NotNull][Bind(Prefix = "Controlled")] CommentWithAttachments commentModel)
	{
		if (commentModel == null)
		{
			throw new ArgumentNullException("commentModel");
		}
		ITask task = Manager.DoControlComplete(commentModel.ObjectId, commentModel.ActionModel);
		NotifyTaskAction(task, SR.T("Задача {0} проконтролирована"));
		if (GoToParentTask(CurrentUser, task.ParentTask))
		{
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().Entity(task.ParentTask));
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: true));
	}

	private bool GoToParentTask(IUser currentUser, ITaskBase parentTask)
	{
		if (parentTask == null || currentUser == null || !Locator.GetServiceNotNull<TasksSettingsModule>().Settings.RedirectToParentTask)
		{
			return false;
		}
		if (parentTask.Executor.Id == currentUser.Id)
		{
			return true;
		}
		if (parentTask is ITask task && task.UnderControl && task.ControlUser.Id == currentUser.Id)
		{
			return true;
		}
		return false;
	}

	public ActionResult ControlledSelected(long[] Tasks)
	{
		foreach (long taskId in Tasks)
		{
			ITask task = Manager.DoControlComplete(taskId);
			NotifyTaskAction(task, SR.T("Задача {0} проконтролирована"));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("ExecutionControl", "AllTasks", (object)new
		{
			FilterId = 0
		});
	}

	public ActionResult ClosePeriodTask(ITask task, bool? closeTasks, bool redirectToTask = false)
	{
		if (!closeTasks.HasValue)
		{
			((ControllerBase)this).get_ViewData().Add("RedirectToTask", (object)redirectToTask);
			return (ActionResult)(object)((Controller)this).PartialView((object)task);
		}
		Manager.ClosePeriodTask(task, closeTasks ?? false);
		if (!redirectToTask)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("PeriodClosed", "AllTasks", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			});
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Execute", "Task", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			Id = task.Id
		});
	}

	public ActionResult TaskComment(TaskCommentModel model)
	{
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(model.HtmlPrefix);
		return (ActionResult)(object)((Controller)this).PartialView("Task/Partial/TaskComment", (object)model);
	}

	public ActionResult ReAssignTaskForm(long taskId, ReAssignTaskViewModel model)
	{
		((Controller)this).get_ModelState().Clear();
		model.Init(TaskBaseManager.Load(taskId));
		return (ActionResult)(object)((Controller)this).PartialView("ReAssignTaskForm", (object)model);
	}

	public ActionResult ApprovalPopup(long taskId, string popupId, string redirectUrl)
	{
		ITask task = TaskManager.Instance.Load(taskId);
		CreateApprovalModel createApprovalModel = new CreateApprovalModel(task)
		{
			Harmonizator = task.Harmonizator,
			PopupId = popupId,
			RedirectUrl = redirectUrl
		};
		return (ActionResult)(object)((Controller)this).PartialView("Partial/ApprovalPopup", (object)createApprovalModel);
	}

	public ActionResult TaskDateChange(long taskId, string popupId, string redirectUrl, bool requiredStartDate = true, bool requiredEndDate = true, bool hideStartDate = false)
	{
		TaskBaseModel taskBaseModel = new TaskBaseModel(TaskBaseManager.Load(taskId))
		{
			ReturnUrl = redirectUrl,
			RequiredStartDate = requiredStartDate,
			RequiredEndDate = requiredEndDate,
			HideStartDate = hideStartDate
		};
		return (ActionResult)(object)((Controller)this).PartialView("Partial/TaskDateChange", (object)taskBaseModel);
	}

	public ActionResult ChangeControlForm(long taskId, string popupId, string redirectUrl)
	{
		ChangeControlModel changeControlModel = new ChangeControlModel(TaskManager.Instance.Load(taskId))
		{
			RedirectUrl = redirectUrl
		};
		return (ActionResult)(object)((Controller)this).PartialView("Partial/ChangeControlForm", (object)changeControlModel);
	}
}
