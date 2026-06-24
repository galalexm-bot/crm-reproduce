using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Components;

[Component(Type = ComponentType.WebServer)]
public class ReminderNotificationJobRepository : ISchedulerJobRepository
{
	private class ReminderNotificationJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			public Guid Id => new Guid("EC572FA1-CEC4-4B13-8CA1-41E64EC9D7B8");

			public string Name => SR.T("Отправка напоминаний");

			public Image Icon => null;

			public JobResult Do(DateTime dateToRun)
			{
				ICollection<IReminder> collection = ReminderManager.Instance.SendReminders(DateTime.Now);
				JobResult jobResult = new JobResult();
				jobResult.Status = JobStatus.Success;
				jobResult.Information = SR.T("Всего найдено напоминаний {0}, отправленно {1} напоминаний", collection.Count, collection.Count((IReminder r) => r.Posted));
				return jobResult;
			}
		}

		private readonly ITrigger trigger;

		private readonly ICollection<IJob> jobs;

		public override ITrigger Trigger => trigger;

		public override ICollection<IJob> Jobs => jobs;

		public ReminderNotificationJob()
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
					RepeatEvery = TimeSpan.FromMinutes(1.0),
					RepeatTo = TimeSpan.FromHours(24.0)
				},
				StartDate = DateTime.Today
			}, Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule())
			{
				Name = SR.T("Триггер отправки напоминаний"),
				Id = new Guid("39215EB3-030D-4362-8F0F-C1E928ECF701")
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
			new ReminderNotificationJob()
		};
	}
}
