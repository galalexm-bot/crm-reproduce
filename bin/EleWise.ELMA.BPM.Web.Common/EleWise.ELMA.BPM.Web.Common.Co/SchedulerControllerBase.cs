using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Impl;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public abstract class SchedulerControllerBase : BPMController<ISchedulerJobRunInfo, long>
{
	public static readonly string ActualStartDate = LinqUtils.NameOf((Expression<Func<ISchedulerJobRunInfo, object>>)((ISchedulerJobRunInfo i) => i.ActualStartDate));

	public IEnumerable<ISchedulerJobRepository> SchedulerJobRepositories { get; set; }

	public SchedulerJobRunInfoManager SchedulerJobRunInfoReposotory { get; set; }

	[HttpGet]
	public virtual ActionResult Index()
	{
		List<ISchedulerJob> source = (from j in SchedulerJobRepositories.SelectMany((ISchedulerJobRepository r) => r.GetSchedulerJobs())
			where !(j.Trigger is NthIncludedDayTrigger) || !(j is IHiddenSchedulerJob) || !(j as IHiddenSchedulerJob).Hidden
			select j).ToList();
		SchedulerViewModel schedulerViewModel = new SchedulerViewModel();
		IEnumerable<ISchedulerTaskOwner> owners = ComponentManager.Current.GetExtensionPoints<ISchedulerTaskOwner>();
		DateTime now = DateTime.Now;
		Dictionary<string, List<SchedulerJobInfoViewModel>> dictionary2 = (schedulerViewModel.Items = (from i in (from sj in source.Select(delegate(ISchedulerJob sj)
				{
					DateTime? lastRun = SchedulerJobRunInfoReposotory.GetLastRun(sj.Trigger);
					List<Pair<IJob, ISchedulerJobRunInfo>> jobsInfo = sj.Jobs.Select(delegate(IJob j)
					{
						DateTime? lastRun2 = SchedulerJobRunInfoReposotory.GetLastRun(sj.Trigger, j.Id);
						ISchedulerJobRunInfo second = (lastRun2.HasValue ? SchedulerJobRunInfoReposotory.Get(sj.Trigger, j, lastRun2.Value) : null);
						return new Pair<IJob, ISchedulerJobRunInfo>(j, second);
					}).ToList();
					return new SchedulerJobInfoViewModel
					{
						SchedulerJob = sj,
						LatestRunDate = lastRun,
						NextRunDate = sj.Trigger.GetNextTimeAfter((lastRun > now) ? lastRun : new DateTime?(now), now),
						JobsInfo = jobsInfo
					};
				})
				where sj.JobsInfo.Any()
				orderby (sj.SchedulerJob.Trigger == null) ? "" : sj.SchedulerJob.Trigger.Name
				select sj).ToList().GroupBy(delegate(SchedulerJobInfoViewModel i)
			{
				ISchedulerTaskOwner schedulerTaskOwner = (i.SchedulerJob.OwnerUid.HasValue ? owners.FirstOrDefault((ISchedulerTaskOwner o) => o.Uid == i.SchedulerJob.OwnerUid.Value) : null);
				return (schedulerTaskOwner == null) ? SR.T("Системные") : schedulerTaskOwner.Name;
			})
			orderby i.Key
			select i).ToDictionary((IGrouping<string, SchedulerJobInfoViewModel> i) => i.Key, (IGrouping<string, SchedulerJobInfoViewModel> i) => i.ToList()));
		return (ActionResult)(object)((Controller)this).View((object)schedulerViewModel);
	}

	public ActionResult History(Guid? triggerId, Guid? jobId)
	{
		SchedulerHistoryViewModel schedulerHistoryViewModel = new SchedulerHistoryViewModel
		{
			TriggerId = triggerId,
			JobId = jobId
		};
		if (jobId.HasValue && triggerId.HasValue)
		{
			IJob job = (from j in SchedulerJobRepositories.SelectMany((ISchedulerJobRepository r) => r.GetSchedulerJobs())
				where j.Trigger != null && j.Trigger.Id == triggerId.Value
				select j).SelectMany((ISchedulerJob j) => j.Jobs).FirstOrDefault((IJob j) => j.Id == jobId.Value);
			if (job != null)
			{
				schedulerHistoryViewModel.Title = job.Name;
			}
		}
		else if (triggerId.HasValue)
		{
			ISchedulerJob schedulerJob = SchedulerJobRepositories.SelectMany((ISchedulerJobRepository r) => r.GetSchedulerJobs()).FirstOrDefault((ISchedulerJob j) => j.Trigger != null && j.Trigger.Id == triggerId.Value);
			if (schedulerJob != null)
			{
				schedulerHistoryViewModel.Title = schedulerJob.Trigger.Name;
			}
		}
		return (ActionResult)(object)((Controller)this).View((object)schedulerHistoryViewModel);
	}

	[CustomGridAction]
	public ActionResult HistoryGrid(GridCommand command, [Bind(Prefix = "DataFilter")] ISchedulerJobRunInfoFilter filter)
	{
		GridData<ISchedulerJobRunInfo, ISchedulerJobRunInfoFilter> gridData = CreateGridData(command, filter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	public ActionResult Info(long id)
	{
		ISchedulerJobRunInfo schedulerJobRunInfo = AbstractNHEntityManager<ISchedulerJobRunInfo, long>.Instance.Load(id);
		return (ActionResult)(object)((Controller)this).View((object)schedulerJobRunInfo);
	}

	public ActionResult Run(Guid id, Guid triggerId)
	{
		var anon = SchedulerJobRepositories.SelectMany((ISchedulerJobRepository r) => r.GetSchedulerJobs()).SelectMany((ISchedulerJob j) => j.Jobs.Select((IJob item) => new
		{
			SchedulerJob = j,
			Job = item
		})).FirstOrDefault(j => j.Job.Id == id && j.SchedulerJob.Trigger != null && j.SchedulerJob.Trigger.Id == triggerId);
		if (anon == null)
		{
			throw new InvalidOperationException(SR.T("Не найдена работа задачи планировщика с идентификатором {0} в триггере {1}", id, triggerId));
		}
		DateTime now = DateTime.Now;
		ISchedulerJobRunInfo schedulerJobRunInfo = Locator.GetServiceNotNull<StepScheduler>().ForceRunJob(anon.SchedulerJob, anon.Job, now);
		if (schedulerJobRunInfo == null)
		{
			throw new InvalidOperationException(SR.T("Не удалось запустить работу"));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Info", new RouteValueDictionary { { "id", schedulerJobRunInfo.Id } });
	}
}
