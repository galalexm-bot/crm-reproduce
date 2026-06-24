using System;
using EleWise.ELMA.Common.Enums;

namespace EleWise.ELMA.Common.Models;

[Serializable]
public class MachineRestart
{
	private DateTime? serverTimeRestartDate;

	public string MachineName { get; set; }

	public MachineRestartState State { get; set; }

	public DateTime? RestartDate
	{
		get
		{
			if (!serverTimeRestartDate.HasValue)
			{
				return null;
			}
			return serverTimeRestartDate.Value.ToRuntimeDateTimeFromServer();
		}
		set
		{
			serverTimeRestartDate = (value.HasValue ? new DateTime?(value.Value.ToServerDateTime()) : null);
		}
	}
}
