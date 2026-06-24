using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Extensions;

[Component]
internal class CatalogEditTaskLink : IEntityLink
{
	public Type EntityType => typeof(ICatalogEditTask);

	public Guid TypeUid => InterfaceActivator.UID<ICatalogEditTask>();

	public string IdParam => "Id";

	public bool LoadEntityIfNull => false;

	public string Area(IEntity entity)
	{
		return "EleWise.ELMA.Workflow.Web";
	}

	public string Action(IEntity entity)
	{
		return "CatalogEdit";
	}

	public string Controller(IEntity entity)
	{
		return "WorkflowTask";
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
