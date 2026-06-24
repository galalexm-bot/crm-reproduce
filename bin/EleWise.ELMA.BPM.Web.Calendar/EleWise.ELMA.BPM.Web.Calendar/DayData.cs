using System;
using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class DayData
{
	private DateTime date_;

	public DateTime Date
	{
		get
		{
			return date_;
		}
		set
		{
			date_ = value.Date;
		}
	}

	public bool IsToday => date_ == DateTime.Today;

	public Dictionary<string, string> Dates { get; set; }

	public List<CalendarRenderEvent> Events { get; set; }

	public List<CalendarRenderEvent> LongEvents { get; set; }

	public string GetCaption()
	{
		if (date_ == DateTime.MinValue)
		{
			return SR.T("Просроченные");
		}
		if (date_ == DateTime.Today)
		{
			return SR.Today;
		}
		if (date_.Year == DateTime.Today.Year)
		{
			return SR.WeekMonthDay(date_);
		}
		return SR.WeekYearMonthDay(date_);
	}
}
