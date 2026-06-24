using System;
using System.Collections.Generic;
using System.ComponentModel;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Common.Models;

[Serializable]
public class ScheduledRestart
{
	private DateTime serverTimeRestartDate;

	private DateTime serverTimeCreationDate;

	public Guid Id { get; set; }

	public string Reason { get; set; }

	public DateTime RestartDate
	{
		get
		{
			return serverTimeRestartDate.ToRuntimeDateTimeFromServer();
		}
		set
		{
			serverTimeRestartDate = value.ToServerDateTime();
		}
	}

	public DateTime CreationDate
	{
		get
		{
			return serverTimeCreationDate.ToRuntimeDateTimeFromServer();
		}
		set
		{
			serverTimeCreationDate = value.ToServerDateTime();
		}
	}

	public long Author { get; set; }

	public RestartState State { get; set; }

	public long ParentMessageId { get; set; }

	[DefaultValue(true)]
	public bool SendNotifications { get; set; }

	public IList<MachineRestart> MachineRestartStates { get; set; }

	public ScheduledRestart()
	{
		SendNotifications = true;
		MachineRestartStates = new List<MachineRestart>();
	}

	public bool IsParentMessageSent()
	{
		return ParentMessageId != 0;
	}

	public ScheduledRestart Clone()
	{
		return ClassSerializationHelper.CloneObject(this);
	}

	internal void AssignFrom(ScheduledRestart restart)
	{
		Id = restart.Id;
		Reason = restart.Reason;
		RestartDate = restart.RestartDate;
		CreationDate = restart.CreationDate;
		Author = restart.Author;
		State = restart.State;
		ParentMessageId = restart.ParentMessageId;
		SendNotifications = restart.SendNotifications;
	}
}
