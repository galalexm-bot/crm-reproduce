using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

[Component]
public class CalendarEventAddAction : IEventAddAction
{
	public string Uid => "add-calendar-event";

	public string Name => SR.T("Событие");

	public dynamic WindowSettings => null;

	public string Icon => "#add_event.svg";

	public int Order => 10;

	public bool AllowInShared => true;

	public string Url(RequestContext context)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new UrlHelper(context).Action("Create", "Event", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Calendar",
			start = "{0}",
			end = "{1}",
			schedule = "{2}"
		});
	}
}
