using System;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Calendar.Export.Components;

[Component]
public class CalendarEventItemLink : IObjectLink
{
	public bool CheckType(Type type)
	{
		return typeof(ExternalCalendarItem).IsAssignableFrom(type);
	}

	public string Url(RequestContext context, object obj)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		UrlHelper val = new UrlHelper(context);
		ExternalCalendarItem externalCalendarItem = (ExternalCalendarItem)obj;
		return val.Action("ViewItem", "ExternalCalendar", (object)new
		{
			id = externalCalendarItem.SourceId,
			itemId = externalCalendarItem.Id,
			startDate = externalCalendarItem.StartDate.ToString(CultureInfo.CurrentCulture),
			endDate = externalCalendarItem.EndDate.ToString(CultureInfo.CurrentCulture),
			area = "EleWise.ELMA.BPM.Web.Calendar.Export"
		});
	}
}
