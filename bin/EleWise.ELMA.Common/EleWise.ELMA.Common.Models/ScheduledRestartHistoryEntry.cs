using System;

namespace EleWise.ELMA.Common.Models;

[Serializable]
public class ScheduledRestartHistoryEntry
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

	public ScheduledRestartResult Result { get; set; }

	public string Information { get; set; }

	public ScheduledRestartHistoryEntry()
	{
	}

	public ScheduledRestartHistoryEntry(ScheduledRestart restart, ScheduledRestartResult result, string information)
	{
		Contract.ArgumentNotNull(restart, "restart");
		Contract.ArgumentNotNull(information, "information");
		Id = restart.Id;
		Reason = restart.Reason;
		RestartDate = restart.RestartDate;
		CreationDate = restart.CreationDate;
		Author = restart.Author;
		Result = result;
		Information = information;
	}
}
