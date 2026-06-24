using System;
using System.Linq;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Components;

[Component]
internal class ServerRestartHandler : ISweepHandler
{
	private readonly IScheduledRestartService restartService;

	private readonly ServerRestartSettingsModule settingsModule;

	public ServerRestartHandler(IScheduledRestartService restartService, ServerRestartSettingsModule settingsModule)
	{
		Contract.ArgumentNotNull(restartService, "restartService");
		Contract.ArgumentNotNull(settingsModule, "settingsModule");
		this.restartService = restartService;
		this.settingsModule = settingsModule;
	}

	public void Execute()
	{
		DateTime now = DateTime.Now;
		TimeSpan overtime = settingsModule.GetSettingsCopyThreadSafe().Overtime;
		foreach (ScheduledRestart restart in restartService.GetRestarts((ScheduledRestart r) => r.State != RestartState.Cancelled && r.State != RestartState.Finished && now >= r.RestartDate))
		{
			MachineRestart machineRestart = restart.MachineRestartStates.First((MachineRestart s) => s.MachineName == Environment.MachineName);
			if ((restart.State == RestartState.Waiting || restart.State == RestartState.Restarting) && machineRestart.State == MachineRestartState.Acknowledged)
			{
				if (restart.State == RestartState.Waiting && now >= restart.RestartDate + overtime)
				{
					restartService.TryUpdateMachineState(restart, MachineRestartState.CancelledOvertimeExceeded, null);
					Logger.Log.Error(SR.T("Перезапуск не произведен, так как превышено время ожидания перезагрузки (Id={0})", restart.Id));
				}
				else
				{
					restartService.TryUpdateMachineState(restart, MachineRestartState.Restarting, now);
					Logger.Log.Error(SR.T("Начало запланированного перезапуска сервера в {0} по серверному времени (Id={1})", now.ToServerDateTime(), restart.Id));
					Locator.GetServiceNotNull<IWebHostEnvironmentService>().RestartHost();
				}
			}
			else if ((restart.State == RestartState.Restarting || restart.State == RestartState.Finishing) && machineRestart.State == MachineRestartState.Restarting)
			{
				restartService.TryUpdateMachineState(restart, MachineRestartState.Restarted, now);
				Logger.Log.Error(SR.T("Запланированный перезапуск завершен успешно на машине \"{0}\" (Id={1})", Environment.MachineName, restart.Id));
			}
		}
	}
}
