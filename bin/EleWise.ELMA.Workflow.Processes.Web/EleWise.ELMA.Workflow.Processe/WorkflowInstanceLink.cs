using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

[Component(Order = 100)]
public class WorkflowInstanceLink : IEntityLink
{
	public Type EntityType => typeof(IWorkflowInstance);

	public Guid TypeUid => Guid.Empty;

	public string IdParam => "id";

	public bool LoadEntityIfNull => false;

	public string Area(IEntity entity)
	{
		return "EleWise.ELMA.Workflow.Processes.Web";
	}

	public string Action(IEntity entity)
	{
		return "Info";
	}

	public string Controller(IEntity entity)
	{
		return "WorkflowInstance";
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
