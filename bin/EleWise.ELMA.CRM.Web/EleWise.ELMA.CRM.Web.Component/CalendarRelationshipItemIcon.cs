using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class CalendarRelationshipItemIcon : IObjectIcon
{
	public bool CheckType(Type type)
	{
		return typeof(RelationshipCalendarItem).IsAssignableFrom(type);
	}

	public string Icon(UrlHelper url, ObjectIconFormat format, object obj)
	{
		RelationshipCalendarItem relationshipCalendarItem = (RelationshipCalendarItem)obj;
		if (relationshipCalendarItem.Relationship is IRelationshipCall)
		{
			return "#phone.svg";
		}
		if (relationshipCalendarItem.Relationship is IRelationshipMeeting)
		{
			return "#users.svg";
		}
		if (relationshipCalendarItem.Relationship is IRelationshipMail)
		{
			return "#messages.svg";
		}
		return "#calendar.svg";
	}
}
