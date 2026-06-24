using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class ApprovalTaskLink : IEntityLink
{
	public Type EntityType => null;

	public Guid TypeUid => InterfaceActivator.UID<IApprovalTask>();

	public string IdParam => "id";

	public bool LoadEntityIfNull => false;

	public string Area(IEntity entity)
	{
		return "EleWise.ELMA.BPM.Web.Tasks";
	}

	public string Action(IEntity entity)
	{
		return "Approve";
	}

	public string Controller(IEntity entity)
	{
		return "Task";
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
