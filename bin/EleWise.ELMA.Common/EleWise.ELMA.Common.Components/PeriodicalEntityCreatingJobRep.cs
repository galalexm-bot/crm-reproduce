using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Components;

[Component(Type = ComponentType.WebServer)]
public class PeriodicalEntityCreatingJobRepository : ISchedulerJobRepository
{
	private class PeriodicalEntityCreatingJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			private ISecurityService SecurityService => Locator.GetService<ISecurityService>();

			public Guid Id => new Guid("AFA33DEC-5478-4084-9CEF-1EAF4B66D280");

			public string Name => SR.T("Создание периодических сущностей");

			public Image Icon => null;

			public JobResult Do(DateTime dateToRun)
			{
				IEnumerable<IPeriodicalEntityManager> extensionPoints = ComponentManager.Current.GetExtensionPoints<IPeriodicalEntityManager>();
				ICollection<IPeriodicalEntity> entityes = new List<IPeriodicalEntity>();
				foreach (IPeriodicalEntityManager item in extensionPoints)
				{
					IPeriodicalEntityManager manager1 = item;
					SecurityService.RunWithElevatedPrivilegies(delegate
					{
						entityes = manager1.FindActive();
					});
					foreach (IPeriodicalEntity item2 in entityes)
					{
						item.CreatingPeriodicEntities(item2, continueFromLastDate: true);
					}
				}
				return new JobResult
				{
					Status = JobStatus.Success,
					Information = SR.T("Обновление периодических сущностей")
				};
			}
		}

		private readonly ITrigger trigger;

		private readonly ICollection<IJob> jobs;

		public override ITrigger Trigger => trigger;

		public override ICollection<IJob> Jobs => jobs;

		public PeriodicalEntityCreatingJob()
		{
			trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
			{
				ScheduleType = ScheduleType.Daily,
				DailySettings = new DailySettings
				{
					EveryDay = 1,
					OnlyWorkDays = false
				},
				StartDate = DateTime.Today.AddMinutes(10.0),
				OvertimeToRun = TimeSpan.FromDays(1.0)
			}, Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule())
			{
				Name = SR.T("Триггер создания периодических сущностей"),
				Id = new Guid("269E89BC-E4F3-4B77-B132-3EBA1174E93A")
			};
			jobs = new List<IJob>
			{
				new JobImpl()
			};
		}
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new List<ISchedulerJob>
		{
			new PeriodicalEntityCreatingJob()
		};
	}
}
