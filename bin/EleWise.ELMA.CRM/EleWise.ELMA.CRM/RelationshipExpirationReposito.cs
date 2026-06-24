using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM;

[Component(Type = ComponentType.WebServer)]
public class RelationshipExpirationRepository : ISchedulerJobRepository
{
	private class RelationsipExpirationJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			private RelationshipManager Manager => RelationshipManager.Instance;

			private ISecurityService SecurityService => Locator.GetService<ISecurityService>();

			public Guid Id => new Guid("EE0947A4-5E3F-468D-8D80-D6F309813902");

			public string Name => SR.T("Работа планировщика отправки уведомлений о просроченных взаимоотношениях");

			public Image Icon => null;

			public JobResult Do(DateTime dateToRun)
			{
				Manager.CheckRelationshipExpiration(dateToRun);
				return new JobResult
				{
					Status = JobStatus.Success,
					Information = SR.T("Отправка уведомлений о просроченных взаимоотношениях")
				};
			}
		}

		private readonly ITrigger _trigger;

		private ICollection<IJob> _jobs;

		public override ITrigger Trigger => _trigger;

		public override ICollection<IJob> Jobs => _jobs;

		public RelationsipExpirationJob()
		{
			_trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
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
				Name = SR.T("Триггер отправки уведомлений о просроченных взаимоотношениях"),
				Id = new Guid("760929A5-938A-40F2-8CCD-BFA845290D51")
			};
			_jobs = new List<IJob>
			{
				new JobImpl()
			};
		}
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new List<ISchedulerJob>
		{
			new RelationsipExpirationJob()
		};
	}
}
