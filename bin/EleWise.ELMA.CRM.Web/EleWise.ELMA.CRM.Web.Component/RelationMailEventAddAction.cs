using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class RelationMailEventAddAction : IEventAddAction
{
	public string Uid => "add-calendar-relation-mail";

	public string Name => SR.T("Письмо");

	public dynamic WindowSettings => null;

	public string Icon => "#add_message.svg";

	public int Order => 40;

	public bool AllowInShared => false;

	public string Url(RequestContext context)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new UrlHelper(context).Action("Create", "RelationshipMail", (object)new
		{
			area = "EleWise.ELMA.CRM.Web",
			start = "{0}",
			end = "{1}"
		});
	}
}
