using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Projects.Models.Resources;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Calendar.Extensions;

[Component]
public class ProductionScheduleLink : IEntityLink
{
	public Type EntityType => InterfaceActivator.TypeOf<IResourceCalendar>();

	public Guid TypeUid => InterfaceActivator.UID<IResourceCalendar>();

	public string IdParam => "id";

	public bool LoadEntityIfNull => false;

	public string Area(IEntity entity)
	{
		return "EleWise.ELMA.BPM.Web.Calendar";
	}

	public string Action(IEntity entity)
	{
		return "Execute";
	}

	public string Controller(IEntity entity)
	{
		return "ProductionSchedule";
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
