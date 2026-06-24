using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Documents.Web.Extensions.Links;

[Component(Order = 80)]
public class FilterDocumentFolderLink : IEntityLink
{
	public Type EntityType => typeof(IFilterDocumentFolder);

	public Guid TypeUid => Guid.Empty;

	public string IdParam => "FilterId";

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
		return "FilterDocument";
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
