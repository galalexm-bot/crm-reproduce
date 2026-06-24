using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Scheduling;

[Component(Type = ComponentType.WebServer)]
internal class RestartSchedulerRepository : ISchedulerJobRepository
{
	private class ExactTimeTrigger : ITrigger
	{
		private DateTime[] runTimes;

		public Guid Id { get; private set; }

		public string Name { get; private set; }

		public TimeSpan OvertimeToRun => TimeSpan.FromDays(30.0);

		public ExactTimeTrigger(Guid id, string name, DateTime[] runTimes)
		{
			this.runTimes = runTimes;
			Array.Sort(this.runTimes);
			Id = id;
			Name = name;
		}

		public DateTime? GetNextTimeAfter(DateTime? dateTime, DateTime now)
		{
			if (runTimes.Length == 0)
			{
				return null;
			}
			if (!dateTime.HasValue)
			{
				return runTimes[0];
			}
			DateTime value = dateTime.Value;
			DateTime[] array = runTimes;
			foreach (DateTime dateTime2 in array)
			{
				if (dateTime2 > value)
				{
					return dateTime2;
				}
			}
			return null;
		}
	}

	private class NotificationSchedulerJob : ISchedulerJob
	{
		private static readonly Guid TriggerGuid = new Guid("1F27DCF1-B29B-4646-B100-5A3718886FCB");

		public ICollection<IJob> Jobs { get; private set; }

		public Guid? OwnerUid => null;

		public ITrigger Trigger { get; private set; }

		public NotificationSchedulerJob(RestartSchedulerRepository repository, IEnumerable<ScheduledRestart> restarts, ServerRestartSettings settings)
		{
			Contract.ArgumentNotNull(repository, "repository");
			Contract.ArgumentNotNull(restarts, "restarts");
			Contract.ArgumentNotNull(settings, "settings");
			List<Tuple<DateTime, ScheduledRestart>> list = new List<Tuple<DateTime, ScheduledRestart>>();
			DateTime now = DateTime.Now;
			foreach (ScheduledRestart restart in restarts)
			{
				if (!restart.SendNotifications)
				{
					continue;
				}
				if (!restart.IsParentMessageSent())
				{
					DateTime item = restart.CreationDate + settings.FirstNotificationDelay;
					list.Add(new Tuple<DateTime, ScheduledRestart>(item, restart));
				}
				foreach (TimeSpan notificationTimeSpan in settings.NotificationTimeSpans)
				{
					DateTime dateTime = restart.RestartDate - notificationTimeSpan;
					if (dateTime >= now.AddMinutes(-1.0))
					{
						list.Add(new Tuple<DateTime, ScheduledRestart>(dateTime, restart));
					}
				}
			}
			Trigger = new ExactTimeTrigger(TriggerGuid, SR.T("Триггер отправки уведомлений о запланированном перезапуске сервера"), (list.Count != 0) ? list.Select((Tuple<DateTime, ScheduledRestart> tuple) => tuple.Item1).ToArray() : EleWise.ELMA.Helpers.EmptyArray<DateTime>.Instance);
			Jobs = new IJob[1]
			{
				new NotificationJobImpl(repository, list)
			};
		}
	}

	private class NotificationJobImpl : IJob
	{
		private static readonly Guid JobGuid = new Guid("7A34BAD5-EF1F-4A11-8E45-A148214A0785");

		private RestartSchedulerRepository repository;

		private List<Tuple<DateTime, ScheduledRestart>> runTimes;

		public Image Icon => null;

		public Guid Id => JobGuid;

		public string Name => SR.T("Отправка уведомлений о запланированном перезапуске сервера");

		public NotificationJobImpl(RestartSchedulerRepository repository, List<Tuple<DateTime, ScheduledRestart>> runTimes)
		{
			Contract.ArgumentNotNull(repository, "repository");
			Contract.ArgumentNotNull(runTimes, "runTimes");
			this.repository = repository;
			this.runTimes = runTimes;
		}

		public JobResult Do(DateTime dateToRun)
		{
			foreach (Tuple<DateTime, ScheduledRestart> runTime in runTimes)
			{
				if (runTime.Item1 == dateToRun)
				{
					return DoForRestart(runTime.Item2);
				}
			}
			return new JobResult
			{
				Status = JobStatus.Errors,
				Information = SR.T("Неверная дата отправки сообщения.")
			};
		}

		private JobResult DoForRestart(ScheduledRestart restart)
		{
			Locator.GetService<ISecurityService>().RunWithElevatedPrivilegies(delegate
			{
				repository.SendFeedMessage(restart);
			});
			return new JobResult
			{
				Status = JobStatus.Success,
				NoSaveResult = true
			};
		}
	}

	private class RestartSchedulerJob : ISchedulerJob
	{
		private static readonly Guid TriggerGuid = new Guid("0043F077-2FB1-4D0D-8333-963F2F313685");

		public ICollection<IJob> Jobs { get; private set; }

		public Guid? OwnerUid => null;

		public ITrigger Trigger { get; private set; }

		public RestartSchedulerJob(IScheduledRestartService restartService, IServerRestartMessageService messageService, IProductionSchedule productionSchedule, ServerRestartSettings settings)
		{
			NthIncludedDaySettings nthIncludedDaySettings = new NthIncludedDaySettings
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
					RepeatEvery = TimeSpan.FromSeconds(30.0),
					RepeatTo = TimeSpan.FromDays(1.0)
				},
				StartDate = DateTime.Today
			};
			Trigger = new NthIncludedDayTrigger(nthIncludedDaySettings, productionSchedule)
			{
				Name = SR.T("Триггер обновления состояния запланированных перезапусков"),
				Id = TriggerGuid
			};
			Jobs = new IJob[1]
			{
				new RestartJobImpl(restartService, messageService, settings)
			};
		}
	}

	private class RestartJobImpl : IJob
	{
		private enum Status
		{
			Succeeded = 1,
			Cancelled,
			OvertimeExceeded,
			ClusterWaitTimeExceeded,
			NotAllMachinesRestartedSuccessfully
		}

		private static readonly Guid JobGuid = new Guid("8F1A148F-8113-4C3D-BB7F-814AE49A08CE");

		private readonly IScheduledRestartService restartService;

		private readonly IServerRestartMessageService messageService;

		private readonly ServerRestartSettings settings;

		public Image Icon => null;

		public Guid Id => JobGuid;

		public string Name => SR.T("Обновление состояния запланированных перезапусков сервера");

		public RestartJobImpl(IScheduledRestartService restartService, IServerRestartMessageService messageService, ServerRestartSettings settings)
		{
			this.restartService = restartService;
			this.messageService = messageService;
			this.settings = settings;
		}

		public JobResult Do(DateTime dateToRun)
		{
			DateTime now = DateTime.Now;
			TimeSpan overtime = settings.Overtime;
			foreach (ScheduledRestart restart in restartService.GetRestarts((ScheduledRestart r) => now >= r.RestartDate || r.State == RestartState.Cancelled))
			{
				Status status;
				switch (restart.State)
				{
				case RestartState.Waiting:
					if (!(now >= restart.RestartDate + overtime))
					{
						continue;
					}
					status = Status.OvertimeExceeded;
					break;
				case RestartState.Restarting:
					if (!(now >= GetMaxClusterWaitTime(restart)))
					{
						continue;
					}
					status = Status.ClusterWaitTimeExceeded;
					break;
				case RestartState.Finishing:
					if (restart.MachineRestartStates.All((MachineRestart s) => s.State == MachineRestartState.Restarted))
					{
						status = Status.Succeeded;
						break;
					}
					if (!(now >= GetMaxClusterWaitTime(restart)))
					{
						continue;
					}
					status = Status.NotAllMachinesRestartedSuccessfully;
					break;
				case RestartState.Cancelled:
					status = Status.Cancelled;
					break;
				default:
					throw new InvalidOperationException($"RestartSchedulerRepository.RestartJobImpl.Do(): Unexpected RestartState \"{restart.State}\" (Id={restart.Id})");
				}
				restart.State = RestartState.Finished;
				if (!restartService.TryUpdate(restart))
				{
					Logger.Log.Error(SR.T("Ошибка обновления состояния запланированного перезапуска (Id={0})", restart.Id));
					continue;
				}
				switch (status)
				{
				case Status.Succeeded:
					Finalize(restart, ScheduledRestartResult.Succeeded, logMachineStates: false, SR.T("Перезапуск завершен."), SR.T("Перезапуск завершен успешно."));
					break;
				case Status.Cancelled:
					Finalize(restart, ScheduledRestartResult.Cancelled, logMachineStates: false, SR.T("Перезапуск отменен."), SR.T("Перезапуск отменен пользователем."));
					break;
				case Status.OvertimeExceeded:
					Finalize(restart, ScheduledRestartResult.Failed, logMachineStates: true, SR.T("Перезапуск отменен."), SR.T("Перезапуск отменен из-за того, что ни один сервер не перезапустился за допустимый промежуток времени."));
					break;
				case Status.ClusterWaitTimeExceeded:
					Finalize(restart, ScheduledRestartResult.Failed, logMachineStates: true, SR.T("Перезапуск завершен с ошибками."), SR.T("Перезапуск отменен из-за того, что один или более сервер слишком долго перезагружался или не отвечал."));
					break;
				case Status.NotAllMachinesRestartedSuccessfully:
					Finalize(restart, ScheduledRestartResult.Failed, logMachineStates: true, SR.T("Перезапуск завершен с ошибками."), SR.T("Перезапуск завершен с ошибками на одном или нескольких серверах."));
					break;
				default:
					throw new InvalidOperationException($"RestartSchedulerRepository.RestartJobImpl.Do(): Unexpected Status \"{status}\"");
				}
			}
			return new JobResult
			{
				Status = JobStatus.Success,
				NoSaveResult = true
			};
		}

		private DateTime GetMaxClusterWaitTime(ScheduledRestart restart)
		{
			DateTime[] array = (from s in restart.MachineRestartStates
				where s.State == MachineRestartState.Restarted
				select s.RestartDate.Value).ToArray();
			if (array.Length == 0)
			{
				return restart.RestartDate + settings.ClusterWaitTime;
			}
			return array.Min() + settings.ClusterWaitTime;
		}

		private void Finalize(ScheduledRestart restart, ScheduledRestartResult result, bool logMachineStates, string feedMessage, string logMessage)
		{
			string text = logMessage;
			if (logMachineStates)
			{
				IList<MachineRestart> machineRestartStates = restart.MachineRestartStates;
				if (machineRestartStates.Count > 0)
				{
					IEnumerable<string> values = machineRestartStates.Select((MachineRestart s) => SR.T("* Сервер \"{0}\", состояние \"{1}\"", s.MachineName, s.State));
					text = SR.T("{0}{1}Состояние серверов в кластере:{2}{3}", logMessage, Environment.NewLine, Environment.NewLine, string.Join(Environment.NewLine, values));
				}
			}
			restartService.AddToHistory(new ScheduledRestartHistoryEntry(restart, result, text));
			Logger.Log.Error($"(Id={restart.Id}) {text}");
			if (settings.NotificationEnabled && settings.NotificationChannels.Count > 0 && restart.SendNotifications && restart.IsParentMessageSent())
			{
				messageService.SendMessage(settings.NotificationChannels, restart.Author, settings.NotificationSubject, feedMessage, restart);
			}
		}
	}

	private IScheduledRestartService scheduledRestartService;

	private IProductionCalendarService calendarService;

	private IServerRestartService serverRestartService;

	private IServerRestartMessageService messageService;

	private ServerRestartSettingsModule settingsModule;

	private IServerRestartService ServerRestartService => serverRestartService ?? (serverRestartService = Locator.GetService<IServerRestartService>());

	private IServerRestartMessageService MessageService => messageService ?? (messageService = Locator.GetService<IServerRestartMessageService>());

	private ServerRestartSettingsModule SettingsModule => settingsModule ?? (settingsModule = Locator.GetService<ServerRestartSettingsModule>());

	public RestartSchedulerRepository(IScheduledRestartService scheduledRestartService, IProductionCalendarService calendarService)
	{
		Contract.ArgumentNotNull(scheduledRestartService, "scheduledRestartService");
		Contract.ArgumentNotNull(calendarService, "calendarService");
		this.scheduledRestartService = scheduledRestartService;
		this.calendarService = calendarService;
	}

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		ScheduledRestart[] restarts = EleWise.ELMA.Helpers.EmptyArray<ScheduledRestart>.Instance;
		if (ServerRestartService != null && MessageService != null && SettingsModule != null)
		{
			restarts = scheduledRestartService.GetRestarts((ScheduledRestart r) => r.State == RestartState.Waiting || r.State == RestartState.Restarting).ToArray();
		}
		ServerRestartSettings settingsCopyThreadSafe = SettingsModule.GetSettingsCopyThreadSafe();
		return new ISchedulerJob[2]
		{
			new NotificationSchedulerJob(this, restarts, settingsCopyThreadSafe),
			new RestartSchedulerJob(scheduledRestartService, MessageService, calendarService.GetGlobalProductionSchedule(), settingsCopyThreadSafe)
		};
	}

	private void SendFeedMessage(ScheduledRestart restart)
	{
		ServerRestartSettings settingsCopyThreadSafe = SettingsModule.GetSettingsCopyThreadSafe();
		if (!settingsCopyThreadSafe.NotificationEnabled || settingsCopyThreadSafe.NotificationChannels.Count() <= 0 || !restart.SendNotifications || (restart.State != RestartState.Waiting && restart.State != RestartState.Restarting))
		{
			return;
		}
		string text = (restart.IsParentMessageSent() ? settingsCopyThreadSafe.NotificationCommentMessage : settingsCopyThreadSafe.NotificationMessage);
		if (text != null)
		{
			long? num = MessageService.SendMessage(settingsCopyThreadSafe.NotificationChannels, restart.Author, settingsCopyThreadSafe.NotificationSubject, text, restart);
			if (!restart.IsParentMessageSent() && num.HasValue)
			{
				restart.ParentMessageId = num.Value;
				scheduledRestartService.TryUpdate(restart);
			}
		}
	}
}
