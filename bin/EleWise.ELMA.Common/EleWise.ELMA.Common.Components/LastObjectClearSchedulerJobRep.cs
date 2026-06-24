using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;

namespace EleWise.ELMA.Common.Components;

[Component]
internal class LastObjectClearSchedulerJobRepository : ISchedulerJobRepository
{
	private class SchedulerJob : SchedulerJobBase
	{
		private class Job : IJob
		{
			private readonly LastObjectInfoManager lastObjectInfoManager;

			public Guid Id { get; } = new Guid("a27c0a11-cba3-4209-8803-319b10ce295a");


			public string Name { get; } = SR.T("Чистка последней активности");


			public Image Icon => null;

			public Job(LastObjectInfoManager lastObjectInfoManager)
			{
				this.lastObjectInfoManager = lastObjectInfoManager;
			}

			public JobResult Do(DateTime dateToRun)
			{
				lastObjectInfoManager.ClearHistory();
				return new JobResult
				{
					Status = JobStatus.Success,
					NoSaveResult = true,
					Information = SR.T("Чистка последней активности выполнена.")
				};
			}
		}

		public override ITrigger Trigger { get; }

		public override ICollection<IJob> Jobs { get; }

		public SchedulerJob(IProductionCalendarService productionCalendarService, LastObjectInfoManager lastObjectInfoManager)
		{
			Trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
			{
				ScheduleType = ScheduleType.Daily,
				DailySettings = new DailySettings
				{
					EveryDay = 1,
					OnlyWorkDays = false
				},
				StartDate = DateTime.Today.AddHours(4.0),
				OvertimeToRun = TimeSpan.FromDays(1.0)
			}, productionCalendarService.GetGlobalProductionSchedule())
			{
				Id = new Guid("ccb3a91e-cd2b-42c2-80ce-03a6b30e350d"),
				Name = SR.T("Триггер чистки последней активности")
			};
			Jobs = new Job[1]
			{
				new Job(lastObjectInfoManager)
			};
		}
	}

	private readonly IProductionCalendarService productionCalendarService;

	private readonly LastObjectInfoManager lastObjectInfoManager;

	public LastObjectClearSchedulerJobRepository(IProductionCalendarService productionCalendarService, LastObjectInfoManager lastObjectInfoManager)
	{
		this.productionCalendarService = productionCalendarService;
		this.lastObjectInfoManager = lastObjectInfoManager;
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new SchedulerJob[1]
		{
			new SchedulerJob(productionCalendarService, lastObjectInfoManager)
		};
	}
}
