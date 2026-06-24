using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

public static class CalendarExtensions
{
	public static List<DateTime> GetDates(DateTime start, DateTime end)
	{
		List<DateTime> list = new List<DateTime>();
		DateTime dateTime = new DateTime(start.Year, start.Month, start.Day);
		end = new DateTime(end.Year, end.Month, end.Day);
		while (dateTime <= end)
		{
			list.Add(new DateTime(dateTime.Year, dateTime.Month, dateTime.Day));
			dateTime = dateTime.AddDays(1.0);
		}
		return list;
	}

	public static List<DateTime> DatesList(ISchedule schedule, DateTime startDate, DateTime endDate)
	{
		return ComponentManager.Current.GetExtensionPoints<ICalendarItemProvider>().SelectMany((ICalendarItemProvider p) => p.GetItems(schedule, startDate, endDate, checkPermission: false)).ToList()
			.SelectMany((ICalendarItem d) => GetDates(d.StartDate.Date, d.EndDate.Date))
			.Distinct()
			.ToList();
	}

	public static string CalendarTitle(DateTime date, int delta, ScheduleMode mode)
	{
		CalendarDateRange(date, delta, mode, out var start, out var end);
		switch (mode)
		{
		case ScheduleMode.Month:
			return SR.T("{0:MMMM yyyy} г.", start);
		case ScheduleMode.WorkWeek:
		case ScheduleMode.Week:
		case ScheduleMode.ThreeDays:
			if (end.Year != start.Year)
			{
				return SR.T("{0:dd MMMM yyyy} - {1:dd MMMM yyyy} г.", start, end);
			}
			if (end.Month != start.Month)
			{
				return SR.T("{0:dd MMMM} - {1:dd MMMM yyyy} г.", start, end);
			}
			return SR.T("{0:dd} - {1:dd MMMM yyyy} г.", start, end);
		default:
			return SR.T("{0:dd MMMM yyyy} г.", start);
		}
	}

	public static void CalendarDateRange(DateTime date, int delta, ScheduleMode mode, out DateTime start, out DateTime end)
	{
		switch (mode)
		{
		case ScheduleMode.Month:
			start = new DateTime(date.Year, date.Month, 1);
			start = start.AddMonths(delta);
			end = start.AddMonths(1).AddDays(-1.0);
			break;
		case ScheduleMode.WorkWeek:
		case ScheduleMode.Week:
			start = date.AddDays(0 - (date.DayOfWeek - 1)).AddDays(delta * 7);
			end = start.AddDays((mode == ScheduleMode.Week) ? 6 : 4);
			break;
		case ScheduleMode.ThreeDays:
			start = date.AddDays(delta * 3);
			end = start.AddDays(2.0);
			break;
		default:
			start = date.AddDays(delta);
			end = start;
			break;
		}
		start = new DateTime(start.Year, start.Month, start.Day, 0, 0, 0);
		end = new DateTime(end.Year, end.Month, end.Day, 23, 59, 59);
	}
}
