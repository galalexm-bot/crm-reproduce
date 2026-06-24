using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class TaskModel : EntityModel<ITask>
{
	internal const string DefaultFormId = "TaskForm";

	private bool? showUnderControl;

	private bool? showPlanWorkLog;

	public int? SubTaskIndex { get; set; }

	public bool SingleExecutor { get; set; }

	public bool PeriodTask { get; set; }

	public CalendarEventPeriod? OldPeriod { get; set; }

	public DateTime? OldStartDate { get; set; }

	public DateTime? OldEndDate { get; set; }

	public bool SubTask { get; set; }

	public bool UntilPeriodTask { get; set; }

	public bool HasHarmonizator { get; set; }

	public bool HasInformTo { get; set; }

	public string OldInformTo { get; set; }

	[Required(true)]
	[RequiredField]
	public HashedSet<IUser> Executors { get; set; }

	[Required(true)]
	[RequiredField]
	public DateTime StartDate { get; set; }

	[Required(true)]
	[RequiredField]
	public DateTime EndDate { get; set; }

	[Obsolete("Не использовать", true)]
	public bool StartDateDamper { get; set; }

	[Obsolete("Не использовать", true)]
	public bool EndDateDamper { get; set; }

	[DisplayName("SR.M('Корректировка сроков')")]
	public TaskDateCorrection DateCorrection { get; set; }

	public long CurrentUserId { get; set; }

	public bool ReOpen { get; set; }

	public bool IsCopy { get; set; }

	public bool IsCreating { get; set; }

	public ICreateSubtaskActionModel SubTaskModel { get; set; }

	public ICreateTaskExtendedModel CreateTaskExtendedModel { get; set; }

	public ICommentActionModel CommentActionModel { get; set; }

	public string FormId { get; set; }

	public bool ShowPeriodRows
	{
		get
		{
			if (PeriodTask)
			{
				return base.Entity.Period != CalendarEventPeriod.Once;
			}
			return false;
		}
	}

	public bool ShowInformTo
	{
		get
		{
			if (HasInformTo)
			{
				return ((IEnumerable<IUser>)base.Entity.InformTo).Any();
			}
			return false;
		}
	}

	public bool ForceShowInformTo { get; set; }

	public bool ShowHarmonizator
	{
		get
		{
			if (HasHarmonizator)
			{
				return base.Entity.Harmonizator != null;
			}
			return false;
		}
	}

	public string ReturnUrl { get; set; }

	public bool ShowUnderControl
	{
		get
		{
			bool? flag = showUnderControl;
			if (!flag.HasValue)
			{
				if (base.Entity.UnderControl && base.Entity.ControlUser != null)
				{
					return !base.Entity.IsNew();
				}
				return false;
			}
			return flag.GetValueOrDefault();
		}
		set
		{
			showUnderControl = value;
		}
	}

	public bool ShowPlanWorkLog
	{
		get
		{
			if (WorkLogSettingsHelper.WorkLogEnabled())
			{
				bool? flag = showPlanWorkLog;
				if (!flag.HasValue)
				{
					if (base.Entity.PlanWorkLog.HasValue && base.Entity.PlanWorkLog.Value > 0L)
					{
						return !base.Entity.IsNew();
					}
					return false;
				}
				return flag.GetValueOrDefault();
			}
			return false;
		}
		set
		{
			showPlanWorkLog = value;
		}
	}

	public bool CheckReplacement { get; set; }

	public HashedSet<IUser> Watchers { get; set; }

	public long? ScheduleId { get; set; }

	public bool AjaxPopup { get; set; }

	public TaskModel(ITask task)
	{
		SetDefaultValues();
		base.Entity = task;
		PeriodTask = task.IsTemplate;
		OldPeriod = base.Entity.Period;
		OldStartDate = base.Entity.StartDate;
		OldEndDate = base.Entity.EndDate;
		if (task.Executor != null)
		{
			((Set<IUser>)(object)Executors).Add(task.Executor);
		}
		NormalizeDates();
		UntilPeriodTask = PeriodTask && task.UntilDate.HasValue;
		SingleExecutor = !base.Entity.IsNew();
		ShowPlanWorkLog = base.Entity.PlanWorkLog.HasValue && base.Entity.PlanWorkLog.Value > 0L && !base.Entity.IsNew();
	}

	public TaskModel()
	{
		SetDefaultValues();
		IsCreating = true;
	}

	private void SetDefaultValues()
	{
		TasksSettings tasksSettings = Locator.GetService<TasksSettingsModule>()?.Settings;
		Executors = new HashedSet<IUser>();
		Watchers = new HashedSet<IUser>();
		base.Entity = TaskManager.Instance.Create();
		SingleExecutor = false;
		base.Entity.StartDate = null;
		NormalizeDates();
		UntilPeriodTask = true;
		HasHarmonizator = true;
		HasInformTo = true;
		PeriodTask = true;
		CommentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		CreateTaskExtendedModel = InterfaceActivator.Create<ICreateTaskExtendedModel>();
		CheckReplacement = true;
		ShowPlanWorkLog = false;
		FormId = "TaskForm";
		DateCorrection = tasksSettings?.DefaultDateCorrection ?? TaskDateCorrection.None;
	}

	public static void ToEditTaskDates(ITaskBase task, out DateTime? startDate, out bool startDateDamper, out DateTime? endDate, out bool endDateDamper)
	{
		startDate = task.StartDate;
		startDateDamper = startDate.HasValue && startDate.Value.IsStartDamperTime();
		endDate = task.EndDate;
		endDateDamper = endDate.HasValue && endDate.Value.IsEndDamperTime();
	}

	public void NormalizeDates()
	{
		ToEditTaskDates(base.Entity, out var startDate, out var _, out var endDate, out var _);
		StartDate = startDate ?? DateTime.Now;
		EndDate = endDate ?? DateTime.Now.AddMinutes(15.0);
	}
}
