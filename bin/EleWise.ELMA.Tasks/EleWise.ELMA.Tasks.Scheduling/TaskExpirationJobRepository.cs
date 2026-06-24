using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;

namespace EleWise.ELMA.Tasks.Scheduling;

[Component(Type = ComponentType.WebServer)]
public class TaskExpirationJobRepository : ISchedulerJobRepository
{
	private class TaskExpirationJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			private static ISecurityService SecurityService => Locator.GetService<ISecurityService>();

			public Guid Id => new Guid("EF0AD313-29C7-4C28-AE21-C8EBD3C64AB0");

			public string Name => SR.T("Работа планировщика отправки уведомлений о просроченных задачах");

			public Image Icon => null;

			public JobResult Do(DateTime dateToRun)
			{
				SecurityService.RunBySystemUser(delegate
				{
					TaskBaseManager.Instance.CheckTaskExpiration(dateToRun);
				});
				return new JobResult
				{
					Status = JobStatus.Success,
					Information = SR.T("Отправка уведомлений о просроченных задачах")
				};
			}
		}

		private readonly ITrigger trigger;

		private readonly ICollection<IJob> jobs;

		public override ITrigger Trigger => trigger;

		public override ICollection<IJob> Jobs => jobs;

		public TaskExpirationJob()
		{
			trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
			{
				ScheduleType = ScheduleType.Daily,
				DailySettings = new DailySettings
				{
					EveryDay = 1,
					OnlyWorkDays = false
				},
				RepeatSettings = new RepeatSettings
				{
					Enabled = true,
					RepeatEvery = TimeSpan.FromMinutes(30.0),
					RepeatTo = TimeSpan.FromHours(24.0)
				},
				StartDate = DateTime.Today
			}, Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule())
			{
				Name = SR.T("Триггер отправки уведомлений о просроченных задачах"),
				Id = new Guid("7E004C94-8AC4-40E3-9146-4559BFC9BE55")
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
			new TaskExpirationJob()
		};
	}
}
