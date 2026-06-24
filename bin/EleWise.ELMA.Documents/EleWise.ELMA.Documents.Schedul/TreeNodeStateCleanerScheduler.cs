using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Services;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;

namespace EleWise.ELMA.Documents.Scheduling;

[Component(Type = ComponentType.WebServer)]
internal class TreeNodeStateCleanerScheduler : ISchedulerJobRepository
{
	private class CleanTreeNodeStateSchedulerJob : SchedulerJobBase
	{
		private const string TriggerIdStr = "AA6EF5A1-5F08-4BE8-AF1A-14E3D90C6502";

		private static Guid triggerId = new Guid("AA6EF5A1-5F08-4BE8-AF1A-14E3D90C6502");

		private readonly ITrigger trigger;

		private readonly ICollection<IJob> jobs;

		private readonly IProductionCalendarService productionCalendarService;

		private readonly IDmsObjectTreeNodeStateService dmsObjectTreeNodeStateService;

		public override ITrigger Trigger => trigger;

		public override ICollection<IJob> Jobs => jobs;

		internal CleanTreeNodeStateSchedulerJob(IProductionCalendarService productionCalendarService, IDmsObjectTreeNodeStateService dmsObjectTreeNodeStateService)
		{
			this.productionCalendarService = productionCalendarService;
			this.dmsObjectTreeNodeStateService = dmsObjectTreeNodeStateService;
			trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
			{
				ScheduleType = ScheduleType.Daily,
				DailySettings = new DailySettings
				{
					EveryDay = 1,
					OnlyWorkDays = false
				},
				StartDate = DateTime.Today.AddMinutes(15.0),
				OvertimeToRun = TimeSpan.FromDays(1.0)
			}, productionCalendarService.GetGlobalProductionSchedule())
			{
				Name = SR.T("Триггер автоматической очистки состояний временных деревьев папок документооборота"),
				Id = triggerId
			};
			jobs = new List<IJob>
			{
				new JobImpl(dmsObjectTreeNodeStateService)
			};
		}
	}

	private class JobImpl : IJob
	{
		private const string UID_S = "58C24BD2-9140-4DD2-A099-572A80D144ED";

		private static readonly Guid UID = new Guid("58C24BD2-9140-4DD2-A099-572A80D144ED");

		private const string TimeoutInDaysSetting = "EleWise.ELMA.Documents.Scheduling.TreeNodeStateCleaner.TimeoutInDays";

		private readonly IDmsObjectTreeNodeStateService dmsObjectTreeNodeStateService;

		public Guid Id => UID;

		public string Name => SR.T("Очистка временных состояний деревьев папок");

		public Image Icon => null;

		internal JobImpl(IDmsObjectTreeNodeStateService dmsObjectTreeNodeStateService)
		{
			this.dmsObjectTreeNodeStateService = dmsObjectTreeNodeStateService;
		}

		public JobResult Do(DateTime dateToRun)
		{
			DateTime dateTime = DateTime.UtcNow.AddDays(-SR.GetSetting("EleWise.ELMA.Documents.Scheduling.TreeNodeStateCleaner.TimeoutInDays", 7L));
			dmsObjectTreeNodeStateService.DeleteNodesBefore(dateTime);
			return new JobResult
			{
				Status = JobStatus.Success,
				Information = SR.T("Очистка выполнена успешно")
			};
		}
	}

	private readonly IProductionCalendarService productionCalendarService;

	private readonly IDmsObjectTreeNodeStateService dmsObjectTreeNodeStateService;

	public TreeNodeStateCleanerScheduler(IProductionCalendarService productionCalendarService, IDmsObjectTreeNodeStateService dmsObjectTreeNodeStateService)
	{
		this.productionCalendarService = productionCalendarService;
		this.dmsObjectTreeNodeStateService = dmsObjectTreeNodeStateService;
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new List<ISchedulerJob>
		{
			new CleanTreeNodeStateSchedulerJob(productionCalendarService, dmsObjectTreeNodeStateService)
		};
	}
}
