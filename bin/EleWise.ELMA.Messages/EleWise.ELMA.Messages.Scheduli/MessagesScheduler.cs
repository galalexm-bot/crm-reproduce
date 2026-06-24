using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Scheduling;

[Component(Type = ComponentType.WebServer)]
public class MessagesScheduler : ISchedulerJobRepository
{
	private class MessagesSchedulerJob : SchedulerJobBase
	{
		private class FeedToArchiveScheduler : IJob
		{
			private FeedManager Manager => FeedManager.Instance;

			public Guid Id => new Guid("{C172106D-8AA0-4B42-B79F-98999F137618}");

			public string Name => SR.T("Архивирование старых сообщений ленты");

			public Image Icon => null;

			public JobResult Do(DateTime dateToRun)
			{
				long userId = 0L;
				Locator.GetServiceNotNull<ISecurityService>().RunBySystemUser(delegate
				{
					Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
					{
						userId = Manager.FeedToArchive();
					});
				});
				JobResult jobResult = new JobResult();
				jobResult.Status = JobStatus.Success;
				jobResult.NoSaveResult = true;
				jobResult.Information = ((userId != 0L) ? SR.T("Обработана лента сообщений пользователя с идентификатором Id={0}", userId) : SR.T("Сообщений, для переноса в архив, не найдено"));
				return jobResult;
			}
		}

		private readonly ITrigger trigger;

		private readonly ICollection<IJob> jobs;

		public override ITrigger Trigger => trigger;

		public override ICollection<IJob> Jobs => jobs;

		public override Guid? OwnerUid => MessagesSchedulerTaskOwner.UID;

		public MessagesSchedulerJob()
		{
			trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
			{
				ScheduleType = ScheduleType.Daily,
				DailySettings = new DailySettings
				{
					EveryDay = 1,
					OnlyWorkDays = false
				},
				StartDate = DateTime.Today,
				RepeatSettings = new RepeatSettings
				{
					Enabled = true,
					RepeatEvery = TimeSpan.FromSeconds(SR.GetSetting("MessageManager.FeedArchiveInterval", 300)),
					RepeatTo = TimeSpan.FromHours(24.0)
				}
			}, Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule())
			{
				Name = SR.T("Триггер системных задач по обслуживанию модуля Сообщения"),
				Id = TriggerGuid
			};
			jobs = new List<IJob>
			{
				new FeedToArchiveScheduler()
			};
		}
	}

	public static readonly Guid TriggerGuid = new Guid("{1EA22943-FAF7-47BD-A64B-871EF8390909}");

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new ISchedulerJob[1]
		{
			new MessagesSchedulerJob()
		};
	}
}
