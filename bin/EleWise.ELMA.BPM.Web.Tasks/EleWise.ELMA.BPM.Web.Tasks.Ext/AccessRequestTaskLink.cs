using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class AccessRequestTaskLink : IEntityLink
{
	public Type EntityType => InterfaceActivator.TypeOf<IAccessRequestTask>();

	public Guid TypeUid => InterfaceActivator.UID<IAccessRequestTask>();

	public string IdParam => "id";

	public bool LoadEntityIfNull => false;

	public string Area(IEntity entity)
	{
		return "EleWise.ELMA.BPM.Web.Tasks";
	}

	public string Action(IEntity entity)
	{
		return "Execute";
	}

	public string Controller(IEntity entity)
	{
		return "AccessRequestTask";
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
