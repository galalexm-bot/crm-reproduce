using System;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public sealed class AvailableTimeSearch
{
	public DateTime StartDate { get; set; }

	public long[] UserIds { get; set; }

	public bool InCrossingEvents { get; set; }

	public DateTime StartDateToPaging { get; set; }

	public long[] ScheduleIds { get; set; }
}
