using System;
using System.Web.Mvc;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

[Component]
public class CalendarEventItemIcon : IObjectIcon
{
	public bool CheckType(Type type)
	{
		if (!typeof(CalendarEventItem).IsAssignableFrom(type))
		{
			return InterfaceActivator.UID(type) == InterfaceActivator.UID<ICalendarEvent>();
		}
		return true;
	}

	public string Icon(UrlHelper url, ObjectIconFormat format, object obj)
	{
		return "#calendar.svg";
	}
}
