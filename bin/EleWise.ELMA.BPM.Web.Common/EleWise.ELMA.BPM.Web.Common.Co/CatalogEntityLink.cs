using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(Order = 1000000000)]
public class CatalogEntityLink : IEntityLink
{
	public Type EntityType => typeof(IEntity);

	public Guid TypeUid => Guid.Empty;

	public string IdParam => null;

	public bool LoadEntityIfNull => true;

	public string Area(IEntity entity)
	{
		return null;
	}

	public string Action(IEntity entity)
	{
		return null;
	}

	public string Controller(IEntity entity)
	{
		return null;
	}

	public RouteValueDictionary GetParams(IEntity entity)
	{
		return null;
	}

	public string Href(RequestContext html, IEntity entity)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (entity == null)
		{
			return null;
		}
		Guid uid = InterfaceActivator.UID(entity.GetType().GetTypeWithoutProxy());
		if (CatalogsController.EntityList.OfType<EntityMetadata>().All((EntityMetadata c) => c.ImplementationUid != uid))
		{
			return null;
		}
		return new UrlHelper(html).Action("ViewItem", "Catalogs", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			uid = uid,
			id = entity.GetId().ToString()
		});
	}
}
