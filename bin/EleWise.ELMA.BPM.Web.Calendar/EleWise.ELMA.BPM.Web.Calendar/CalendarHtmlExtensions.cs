using System;
using System.Web.Mvc;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

public static class CalendarHtmlExtensions
{
	public static MvcHtmlString RenderEventDatesForList(DateTime clientStartDateTime, DateTime clientEndDateTime)
	{
		if (clientStartDateTime.Date == clientEndDateTime.Date)
		{
			if (clientStartDateTime.TimeOfDay == new TimeSpan(0, 0, 0, 10) && clientEndDateTime.TimeOfDay == new TimeSpan(0, 23, 59, 50))
			{
				return MvcHtmlString.Create(string.Empty);
			}
			return MvcHtmlString.Create($"{clientStartDateTime.ToShortTimeString()}&nbsp;-&nbsp;{clientEndDateTime.ToShortTimeString()}");
		}
		string arg = ((clientStartDateTime.Year == clientEndDateTime.Year) ? SR.T("{0:dd MMMM HH:mm}", clientEndDateTime) : clientEndDateTime.ToString("f"));
		return MvcHtmlString.Create($"{clientStartDateTime.ToShortTimeString()}&nbsp;-&nbsp;{arg}");
	}

	public static string GetDayCaption(DateTime clientDateTime)
	{
		if (clientDateTime.IsCurrentClientDate())
		{
			return SR.T("{0}, {1:dd MMMM}", SR.T("Сегодня"), clientDateTime);
		}
		if (clientDateTime.Year != TZ.ClientDateTimeNow.Year)
		{
			return clientDateTime.ToString("D");
		}
		return SR.T("{0:dddd, dd MMMM}", clientDateTime);
	}

	public static string GetCalendarItemClasses(ICalendarItem item)
	{
		string text = "";
		if (CalendarEventManager.Instance.EventIdNeedConfirmParticipation(item))
		{
			text += " fc-event-need-confirm";
		}
		if (item.ToInform)
		{
			text += " fc-event-inform";
		}
		if (item.Completed)
		{
			text += " fc-event-completed";
		}
		if (item.MarkExpired && !item.Completed && item.EndDate.ToClientDateTime() < TZ.CurrentClientDate)
		{
			text += " fc-event-expired";
		}
		return text;
	}
}
