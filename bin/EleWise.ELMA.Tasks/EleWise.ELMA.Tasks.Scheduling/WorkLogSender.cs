using System;
using System.Collections.Generic;
using System.Drawing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;

namespace EleWise.ELMA.Tasks.Scheduling;

[Component(Type = ComponentType.WebServer)]
public class WorkLogSender : ISchedulerJobRepository
{
	private class CheckStatisticsJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			public Guid Id => new Guid("{61C0DD7C-17A9-4579-9200-FD18836E3318}");

			public string Name => SR.T("Работа планировщика автоматической отправки трудозатрат");

			public Image Icon => null;

			public JobResult Do(DateTime dateToRun)
			{
				int num;
				try
				{
					num = WorkLogItemManager.Instance.AutomaticSendingOfWorkLog();
				}
				catch (Exception ex)
				{
					return new JobResult
					{
						Status = JobStatus.Errors,
						Information = SR.T("Не все трудозатраты были отправленны на согласование"),
						ErrorDescription = ex.Message
					};
				}
				JobResult jobResult = new JobResult();
				jobResult.Status = JobStatus.Success;
				jobResult.Information = SR.T("Трудозатраты отправлены на согласование.\r\nВсего отправлено: {0}", num);
				jobResult.NoSaveResult = num <= 0;
				return jobResult;
			}
		}

		private readonly ITrigger trigger;

		private readonly ICollection<IJob> jobs;

		private static WorkLogSettings settings = WorkLogSettingsHelper.GetSettings();

		public override ITrigger Trigger => trigger;

		public override ICollection<IJob> Jobs => jobs;

		public CheckStatisticsJob()
		{
			settings.PeriodicityAutomaticSendingWorkLog.OvertimeToRun = TimeSpan.FromHours(3.0);
			trigger = new NthIncludedDayTrigger(settings.PeriodicityAutomaticSendingWorkLog, Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule())
			{
				Name = SR.T("Отправка трудозатрат"),
				Id = workLogSenderGuid
			};
			jobs = new List<IJob>
			{
				new JobImpl()
			};
		}
	}

	private static readonly Guid workLogSenderGuid = new Guid("{589DDF58-06FF-4351-8681-07D8E759AA14}");

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		return new List<ISchedulerJob>
		{
			new CheckStatisticsJob()
		};
	}
}
