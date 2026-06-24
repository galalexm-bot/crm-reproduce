using System;
using EleWise.ELMA.Common.Components;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Services;

[Service(Scope = ServiceScope.Shell, Type = ComponentType.WebServer)]
internal class ServerRestartService : IServerRestartService
{
	private IScheduledRestartService restartService;

	private ServerRestartSettingsModule settingsModule;

	public ServerRestartService(IScheduledRestartService restartService, ServerRestartSettingsModule settingsModule)
	{
		Contract.ArgumentNotNull(restartService, "restartService");
		Contract.ArgumentNotNull(settingsModule, "settingsModule");
		this.restartService = restartService;
		this.settingsModule = settingsModule;
	}

	public Guid Schedule(IUser user, DateTime restartDate, string reason, bool sendNotifications)
	{
		Contract.ArgumentNotNull(user, "user");
		DateTime now = DateTime.Now;
		ServerRestartSettings settingsCopyThreadSafe = settingsModule.GetSettingsCopyThreadSafe();
		DateTime dateTime = now + settingsCopyThreadSafe.MinimumRestartTime;
		DateTime dateTime2 = now + settingsCopyThreadSafe.MaximumRestartTime;
		if (restartDate <= dateTime || restartDate <= now)
		{
			throw new ServerRestartScheduleException(SR.T("Невозможно запланировать перезапуск, так как дата перезапуска находится слишком близко к настоящему моменту времени. Минимальная дата: {0}", dateTime.ToClientDateTime()));
		}
		if (restartDate >= dateTime2)
		{
			throw new ServerRestartScheduleException(SR.T("Невозможно запланировать перезапуск, так как дата перезапуска находится слишком далеко в будущем. Максимальная дата: {0}.", dateTime2.ToClientDateTime()));
		}
		return restartService.Create(restartDate, user.Id, reason, sendNotifications);
	}

	public Guid Schedule(long userId, DateTime restartDate, string reason, bool sendNotifications)
	{
		return Schedule(UserManager.Instance.Load(userId), restartDate, reason, sendNotifications);
	}

	public void CancelRestart(Guid restartId)
	{
		ScheduledRestart scheduledRestart = restartService.LoadOrNull(restartId);
		if (scheduledRestart == null)
		{
			throw new ServerRestartCancellationException(restartId, SR.T("Перезапуск не найден."));
		}
		switch (scheduledRestart.State)
		{
		case RestartState.Waiting:
			scheduledRestart.State = RestartState.Cancelled;
			if (!restartService.TryUpdate(scheduledRestart))
			{
				throw new ServerRestartCancellationException(restartId, SR.T("Перезапуск не найден."));
			}
			break;
		case RestartState.Cancelled:
			break;
		case RestartState.Restarting:
		case RestartState.Finishing:
		case RestartState.Finished:
			throw new ServerRestartCancellationException(restartId, SR.T("Сервер уже находится в процессе перезапуска."));
		default:
			throw new ServerRestartCancellationException(restartId, SR.T("Неверное состояние перезапуска."));
		}
	}

	public TimeSpan GetMinimumRestartTime()
	{
		return settingsModule.GetSettingsCopyThreadSafe().MinimumRestartTime;
	}
}
