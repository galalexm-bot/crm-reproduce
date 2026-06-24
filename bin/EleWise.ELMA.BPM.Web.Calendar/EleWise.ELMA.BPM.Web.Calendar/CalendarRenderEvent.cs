using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class CalendarRenderEvent
{
	public string Style => $"top:{Top.ToString()}px;left:{Left.ToString()}%;width:{Width.ToString()}%;";

	public int Top { get; set; }

	public int Left { get; set; }

	public int Width { get; set; }

	public int Height { get; set; }

	public string Text { get; set; }

	public string Subject { get; set; }

	public ICalendarEvent CalendarEvent { get; set; }

	public string SkinId { get; set; }

	public string Time { get; set; }

	public int Column { get; set; }

	public int Crossing { get; set; }

	public bool IsNotOne { get; set; }

	public bool ToInform { get; set; }

	public CalendarRenderEvent(ICalendarEvent ddi, IUser user, ScheduleMode scheduleMode)
	{
		string text = ((ddi.StartDate != ddi.EndDate) ? $"{ddi.StartDate.ToShortTimeString()}&nbsp;-&nbsp;{ddi.EndDate.ToShortTimeString()}" : ddi.StartDate.ToShortTimeString());
		text = ((ddi.StartDate.Date != ddi.EndDate.Date) ? "" : text);
		if (scheduleMode != ScheduleMode.Month)
		{
			if ((ddi.EndDate - ddi.StartDate).TotalMinutes > 30.0)
			{
				Height = (int)Math.Round((ddi.EndDate - ddi.StartDate).TotalMinutes / 5.0 * 4.0);
			}
			else
			{
				Height = 24;
			}
			Top = (int)ddi.StartDate.TimeOfDay.TotalMinutes / 5 * 4;
		}
		else
		{
			Width = (int)(100.0 * Math.Ceiling((ddi.EndDate - ddi.StartDate).TotalDays) / 7.0) - 1;
			Height = 22;
			Top = 18;
			int num = (ddi.StartDate.DayOfWeek - DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek + 7) % 7;
			Left = 1 + num * 100 / 7;
		}
		CalendarEvent = ddi;
		Time = (ddi.Completed ? ("<del>" + text + "</del>") : text);
		Subject = (ddi.Completed ? ("<del>" + ddi.Subject + "</del>") : ddi.Subject);
		ICalendarEventUser calendarEventUser = ((((IEnumerable<ICalendarEventUser>)ddi.EventUsers).Where((ICalendarEventUser s) => s.User == user).Count() > 0) ? ((IEnumerable<ICalendarEventUser>)ddi.EventUsers).Where((ICalendarEventUser s) => s.User == user).First() : null);
		ToInform = calendarEventUser != null && calendarEventUser.Status == CalendarEventUserStatus.InfromTo;
		Text = string.Format("<b>{0}</b><br>{1}{2}", text, ddi.Subject, (!string.IsNullOrEmpty(ddi.Description)) ? ("<br><i>" + ddi.Description.Replace("'", "&#39;").Replace("\r", "").Replace("\n", "<br/>") + "</i>") : "");
	}
}
