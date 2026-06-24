using System;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class CalendarRelationshipItemLink : IObjectLink
{
	public bool CheckType(Type type)
	{
		return typeof(RelationshipCalendarItem).IsAssignableFrom(type);
	}

	public string Url(RequestContext context, object obj)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		UrlHelper val = new UrlHelper(context);
		RelationshipCalendarItem relationshipCalendarItem = (RelationshipCalendarItem)obj;
		if (relationshipCalendarItem.Relationship is IRelationshipCall)
		{
			return val.Action("Details", "RelationshipCall", (object)new
			{
				id = relationshipCalendarItem.Id,
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		if (relationshipCalendarItem.Relationship is IRelationshipMeeting)
		{
			return val.Action("Details", "RelationshipMeeting", (object)new
			{
				id = relationshipCalendarItem.Id,
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		if (relationshipCalendarItem.Relationship is IRelationshipMail)
		{
			return val.Action("Details", "RelationshipMail", (object)new
			{
				id = relationshipCalendarItem.Id,
				area = "EleWise.ELMA.CRM.Web"
			});
		}
		return null;
	}
}
