using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks;

[Component(Type = ComponentType.WebServer)]
public class TaskPeriodJobRepository : ISchedulerJobRepository
{
	private class TaskPeriodJob : SchedulerJobBase
	{
		private class JobImpl : IJob
		{
			private TaskManager Manager => TaskManager.Instance;

			private ISecurityService SecurityService => Locator.GetService<ISecurityService>();

			public Guid Id => new Guid("98B5E0D1-46A3-4A69-8F55-EB5537D75196");

			public string Name => SR.T("Создание периодических задач");

			public Image Icon => null;

			public JobResult Do(DateTime dateToRun)
			{
				InstanceOf<ITaskFilter> instanceOf = new InstanceOf<ITaskFilter>();
				instanceOf.New.Status = TaskBaseStatus.NewOrder;
				instanceOf.New.Periodical = true;
				instanceOf.New.IsTemplate = true;
				ITaskFilter filter = instanceOf.New;
				ICollection<ITask> tasks = new List<ITask>();
				SecurityService.RunWithElevatedPrivilegies(delegate
				{
					tasks = Manager.Find(filter, FetchOptions.All);
				});
				int num = tasks.Select((ITask task) => Manager.UpdatePeriodTask(task, continueLastPeriodTaskDate: true, retryCreateTaskOnDeadlock: true)).Count((bool ret) => ret);
				JobResult jobResult = new JobResult();
				jobResult.Status = JobStatus.Success;
				jobResult.Information = SR.T("Обновление периодических задач - всего: {0}, обновленно: {1}.", tasks.Count, num);
				return jobResult;
			}
		}

		private readonly ITrigger _trigger;

		private ICollection<IJob> _jobs;

		public override ITrigger Trigger => _trigger;

		public override ICollection<IJob> Jobs => _jobs;

		public TaskPeriodJob()
		{
			_trigger = new NthIncludedDayTrigger(new NthIncludedDaySettings
			{
				ScheduleType = ScheduleType.Daily,
				DailySettings = new DailySettings
				{
					EveryDay = 1,
					OnlyWorkDays = false
				},
				StartDate = DateTime.Today.AddMinutes(45.0),
				OvertimeToRun = TimeSpan.FromDays(1.0)
			}, Locator.GetServiceNotNull<IProductionCalendarService>().GetGlobalProductionSchedule())
			{
				Name = SR.T("Триггер создания периодических задач"),
				Id = new Guid("542AD478-5780-434B-969B-F4CF7AC80FD6")
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
			new TaskPeriodJob()
		};
	}
}
