using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Calendar.Components;

[Component]
internal class CalendarContentActionCurrentMatcher : IContentActionCurrentMatcher
{
	private const string schedulerController = "Scheduler";

	private const string eventController = "Event";

	public int MatchCurrent(string area, ActionRoute routes, RequestContext requestContext)
	{
		if (routes.Area == "EleWise.ELMA.BPM.Web.Calendar" && routes.Controller.Equals("Scheduler") && requestContext.RouteData.Values["controller"].Equals("Event") && requestContext.RouteData.Values["area"].Equals("EleWise.ELMA.BPM.Web.Calendar"))
		{
			return 6;
		}
		return 0;
	}

	public int MatchCurrent(Uri contentItemUri, Uri requestUri)
	{
		return 0;
	}
}
