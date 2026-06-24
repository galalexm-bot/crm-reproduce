using System;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public sealed class CalendarEventAddInfo
{
	public bool NeedConfirmParticipation { get; set; }

	public DateTime? StartDate { get; set; }
}
