using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class RelationMeetingEventAddAction : IEventAddAction
{
	public string Uid => "add-calendar-relation-meeting";

	public string Name => SR.T("Встречу");

	public dynamic WindowSettings => null;

	public string Icon => "#user_add.svg";

	public int Order => 50;

	public bool AllowInShared => false;

	public string Url(RequestContext context)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new UrlHelper(context).Action("Create", "RelationshipMeeting", (object)new
		{
			area = "EleWise.ELMA.CRM.Web",
			start = "{0}",
			end = "{1}",
			schedule = "{2}"
		});
	}
}
