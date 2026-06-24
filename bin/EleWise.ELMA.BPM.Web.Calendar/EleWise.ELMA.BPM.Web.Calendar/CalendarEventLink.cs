using System;
using System.Web.Routing;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

[Component]
public class CalendarEventLink : IEntityLink
{
	public Type EntityType => InterfaceActivator.TypeOf<ICalendarEvent>();

	public Guid TypeUid => InterfaceActivator.UID<ICalendarEvent>();

	public string IdParam => "id";

	public bool LoadEntityIfNull => false;

	public string Area(IEntity entity)
	{
		return "EleWise.ELMA.BPM.Web.Calendar";
	}

	public string Action(IEntity entity)
	{
		return "View";
	}

	public string Controller(IEntity entity)
	{
		return "Event";
	}

	public RouteValueDictionary GetParams(IEntity entity)
	{
		return null;
	}

	public string Href(RequestContext html, IEntity entity)
	{
		return null;
	}
}
