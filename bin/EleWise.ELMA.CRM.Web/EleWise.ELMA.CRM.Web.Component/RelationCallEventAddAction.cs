using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class RelationCallEventAddAction : IEventAddAction
{
	public string Uid => "add-calendar-relation-call";

	public string Name => SR.T("Звонок");

	public dynamic WindowSettings => null;

	public string Icon => "#add_call.svg";

	public int Order => 30;

	public bool AllowInShared => false;

	public string Url(RequestContext context)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new UrlHelper(context).Action("Create", "RelationshipCall", (object)new
		{
			area = "EleWise.ELMA.CRM.Web",
			start = "{0}",
			end = "{1}"
		});
	}
}
