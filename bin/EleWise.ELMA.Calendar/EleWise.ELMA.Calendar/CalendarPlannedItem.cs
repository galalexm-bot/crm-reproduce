using System;

namespace EleWise.ELMA.Calendar;

[Serializable]
public struct CalendarPlannedItem : ICalendarPlannedItem
{
	public string Id { get; set; }

	public string Theme { get; set; }

	public string Description { get; set; }
}
