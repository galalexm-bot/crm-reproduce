using System;
using System.Web.Routing;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

internal class WorkLogItemLink : IEntityLink
{
	public Type EntityType => null;

	public Guid TypeUid => InterfaceActivator.UID<IWorkLogItem>();

	public string IdParam => "id";

	public bool LoadEntityIfNull => false;

	public string Area(IEntity entity)
	{
		return "EleWise.ELMA.BPM.Web.Tasks";
	}

	public string Action(IEntity entity)
	{
		return "Index";
	}

	public string Controller(IEntity entity)
	{
		return "WorkLogItem";
	}

	public RouteValueDictionary GetParams(IEntity entity)
	{
		return new RouteValueDictionary { 
		{
			"id",
			entity.GetId()
		} };
	}

	public string Href(RequestContext html, IEntity entity)
	{
		return null;
	}
}
