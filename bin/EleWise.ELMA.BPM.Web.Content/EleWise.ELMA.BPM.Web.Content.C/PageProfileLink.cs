using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
public class PageProfileLink : IEntityLink
{
	public Type EntityType => typeof(IPageProfile);

	public Guid TypeUid => Guid.Empty;

	public string IdParam => "id";

	public bool LoadEntityIfNull => false;

	public string Area(IEntity entity)
	{
		return "EleWise.ELMA.BPM.Web.Content";
	}

	public string Action(IEntity entity)
	{
		return "View";
	}

	public string Controller(IEntity entity)
	{
		return "PageProfile";
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
