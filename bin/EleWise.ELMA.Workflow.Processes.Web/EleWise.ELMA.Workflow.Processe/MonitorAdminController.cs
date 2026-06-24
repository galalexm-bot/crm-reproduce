using System;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Processes.Web.Models;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Workflow.Processes.Web.Controllers;

[Permission("7B520A7D-6F69-4E31-AF7F-663F5ACEDB10")]
public class MonitorAdminController : BPMController<IMonitorUpdateActionQueueItem, long>
{
	public WorkflowMonitorSettingsModule SettingsModule { get; set; }

	[ContentItem(Name = "Монитор процессов", Image24 = "#computer.svg")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, [Bind(Prefix = "DataFilter")] IMonitorUpdateActionQueueItemFilter filter)
	{
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IMonitorUpdateActionQueueItemFilter>();
		}
		MonitorUpdateActionQueueItemGrid model = new MonitorUpdateActionQueueItemGrid
		{
			Data = CreateGridData(command, filter)
		};
		return ExportExcel(model.Data, InterfaceActivator.TypeOf<IMonitorUpdateActionQueueItem>(), () => (ActionResult)(object)((Controller)this).PartialView("Grid", (object)model));
	}

	[TransactionAction]
	[HttpPost]
	public ActionResult OptimizeQueue()
	{
		ProcessesWorkflowInstanceManager.Instance.RunOptimizeMonitorCacheJob();
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	[TransactionAction]
	[HttpPost]
	public ActionResult RefreshCache()
	{
		if (ProcessesWorkflowInstanceManager.Instance.GlobalRecreateCacheSchedulerTaskActived())
		{
			base.Notifier.Error(SR.T("Полный пересчет кэша монитора процессов уже запущен"));
		}
		else
		{
			ProcessesWorkflowInstanceManager.Instance.RunRecreateCacheSchedulerJob();
		}
		return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
	}

	public ActionResult CurrentRecreateCacheSchedulerTaskInfo()
	{
		IRecreateMonitorCacheJob job = AbstractNHEntityManager<IRecreateMonitorCacheJob, long>.Instance.LoadOrNull(WorkflowConstants.RecreateCacheJobId);
		CurrentSchedulerTaskInfoModel currentSchedulerTaskInfoModel = new CurrentSchedulerTaskInfoModel
		{
			Job = job,
			CurrentOperationFormatText = SR.T("Выполняется пересчет кэша монитора процессов..."),
			NoOperationFormatText = SR.T("Последняя дата пересчета кэша монитора процессов <b>{0}</b>")
		};
		return (ActionResult)(object)((Controller)this).PartialView("CurrentSchedulerTaskInfo", (object)currentSchedulerTaskInfoModel);
	}

	public ActionResult CurrentOptimizeCacheSchedulerTaskInfo()
	{
		IOptimizeMonitorCacheJob job = AbstractNHEntityManager<IOptimizeMonitorCacheJob, long>.Instance.Find(new Filter(), new FetchOptions(0, 1, ListSortDirection.Descending, "Id")).FirstOrDefault();
		CurrentSchedulerTaskInfoModel currentSchedulerTaskInfoModel = new CurrentSchedulerTaskInfoModel
		{
			Job = job,
			CurrentOperationFormatText = SR.T("Выполняется оптимизация действий по пересчету кэша монитора процессов..."),
			NoOperationFormatText = SR.T("Последняя дата оптимизации <b>{0}</b>")
		};
		return (ActionResult)(object)((Controller)this).PartialView("CurrentSchedulerTaskInfo", (object)currentSchedulerTaskInfoModel);
	}

	[HttpGet]
	public ActionResult EditSettings()
	{
		if (SettingsModule.Settings.DateTimeUpdateSettings == null)
		{
			SettingsModule.Settings.DateTimeUpdateSettings = new NthIncludedDaySettings
			{
				DailySettings = new DailySettings(),
				MonthlySettings = new MonthlySettings
				{
					Months = MonthlySettings.AllMonths
				},
				WeeklySettings = new WeeklySettings
				{
					DaysFoWeek = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>().ToList()
				},
				RepeatSettings = new RepeatSettings()
			};
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)SettingsModule.Settings);
	}

	[HttpGet]
	public ActionResult DisplaySettings()
	{
		if (SettingsModule.Settings.DateTimeUpdateSettings == null)
		{
			SettingsModule.Settings.DateTimeUpdateSettings = new NthIncludedDaySettings
			{
				DailySettings = new DailySettings(),
				MonthlySettings = new MonthlySettings(),
				WeeklySettings = new WeeklySettings(),
				RepeatSettings = new RepeatSettings()
			};
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)SettingsModule.Settings);
	}
}
