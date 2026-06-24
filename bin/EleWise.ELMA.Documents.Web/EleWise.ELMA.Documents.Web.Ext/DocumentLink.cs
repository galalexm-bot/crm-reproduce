using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Extensions.Links;

[Component(Order = 100)]
public class DocumentLink : IEntityLink
{
	public Type EntityType => typeof(IDocument);

	public Guid TypeUid => Guid.Empty;

	public string IdParam => "id";

	public bool LoadEntityIfNull => false;

	public string Area(IEntity entity)
	{
		return "EleWise.ELMA.Documents.Web";
	}

	public string Action(IEntity entity)
	{
		return "View";
	}

	public string Controller(IEntity entity)
	{
		return "Document";
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
