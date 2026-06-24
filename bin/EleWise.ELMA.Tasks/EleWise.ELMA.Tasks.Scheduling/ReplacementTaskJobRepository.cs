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
public class ReplacementTaskJobRepository : ISchedulerJobRepository
{
	private class ReplacementTaskExpirationJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			private static ISecurityService SecurityService => Locator.GetService<ISecurityService>();

			public Guid Id => new Guid("{A1D25BF8-14C5-4906-B48F-3869D7659C77}");

			public string Name => SR.T("Работа планировщика активации задач \"Переназначение активных задач\"");

			public Image Icon => null;

			public JobResult Do(DateTime dateToRun)
			{
				SecurityService.RunBySystemUser(delegate
				{
					ReplacementTaskManager.Instance.ActivateTasks(dateToRun);
				});
				return new JobResult
				{
					Status = JobStatus.Success,
					Information = SR.T("Активация задач \"Переназначение активных задач\"")
				};
			}
		}

		private readonly ITrigger _trigger;

		private ICollection<IJob> _jobs;

		public override ITrigger Trigger => _trigger;

		public override ICollection<IJob> Jobs => _jobs;

		public ReplacementTaskExpirationJob()
		{
			_trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
			{
				ScheduleType = ScheduleType.Daily,
				DailySettings = new DailySettings
				{
					EveryDay = 1,
					OnlyWorkDays = false
				},
				StartDate = DateTime.Today.AddMinutes(20.0),
				OvertimeToRun = TimeSpan.FromDays(1.0)
			}, Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule())
			{
				Name = SR.T("Триггер активации задач \"Переназначение активных задач\" при наступлении замещения"),
				Id = new Guid("{3E51859C-A731-4F44-BA15-4736F08A67BE}")
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
			new ReplacementTaskExpirationJob()
		};
	}
}
