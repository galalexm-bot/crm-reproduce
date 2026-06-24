using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.Calendar.Models;

internal sealed class ResourceCalendarWrapper
{
	public Dictionary<int, List<TimeSlot>> WeekTimeSlots { get; set; }

	public List<TimeSlot> ExceptionalSlots { get; set; }

	public ResourceCalendarWrapper(ITimeSlotsCalculationService timeSlotsCalculationService, IResourceCalendar resourceCalendar)
	{
		if (resourceCalendar == null)
		{
			return;
		}
		IEnumerable<IGrouping<int?, IWorkTimeInterval>> enumerable = from interval in (IEnumerable<IWorkTimeInterval>)resourceCalendar.WorkIntervals
			group interval by interval.DayOfWeek;
		ExceptionalSlots = new List<TimeSlot>();
		WeekTimeSlots = new Dictionary<int, List<TimeSlot>>();
		foreach (IGrouping<int?, IWorkTimeInterval> item in enumerable)
		{
			if (item.Key.HasValue)
			{
				WeekTimeSlots[item.Key.Value] = (from interval in item
					select new TimeSlot(TransformToMinDate(interval.Start), TransformToMinDate(interval.Finish)) into x
					orderby x.StartDate
					select x).ToList();
			}
		}
	}

	public IList<TimeSlot> GetOnTimeSlot(TimeSlot timeSlot)
	{
		List<TimeSlot> list = new List<TimeSlot>();
		DateTime date;
		for (date = timeSlot.StartDate.Date; date <= timeSlot.EndDate; date += TimeSpan.FromDays(1.0))
		{
			if (WeekTimeSlots != null && WeekTimeSlots.TryGetValue(date.DayOfWeek.GetWorkTimeIntervalDayOfWeek(), out var value))
			{
				list.AddRange(value.Select((TimeSlot interval) => new TimeSlot(TransformToDate(date, interval.StartDate), TransformToDate(date, interval.EndDate))));
			}
		}
		return list;
	}

	private DateTime TransformToMinDate(DateTime timePart)
	{
		return TransformToDate(DateTime.MinValue, timePart);
	}

	private DateTime TransformToDate(DateTime datePart, DateTime timePart)
	{
		return datePart.Date + timePart.TimeOfDay;
	}
}
