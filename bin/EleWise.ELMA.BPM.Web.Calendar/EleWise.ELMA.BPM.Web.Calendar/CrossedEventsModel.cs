using System.Collections.Generic;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Models;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class CrossedEventsModel
{
	public Dictionary<ISchedule, List<ICalendarItem>> CrossedEvents { get; set; }

	public long[] UserIds { get; set; }
}
