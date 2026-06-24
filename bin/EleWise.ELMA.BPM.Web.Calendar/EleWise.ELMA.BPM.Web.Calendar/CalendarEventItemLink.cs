using System;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

[Component]
public class CalendarEventItemLink : IObjectLink
{
	public bool CheckType(Type type)
	{
		return typeof(CalendarEventItem).IsAssignableFrom(type);
	}

	public string Url(RequestContext context, object obj)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new UrlHelper(context).Action("View", "Event", (object)new
		{
			id = ((CalendarEventItem)obj).Id,
			area = "EleWise.ELMA.BPM.Web.Calendar"
		});
	}
}
