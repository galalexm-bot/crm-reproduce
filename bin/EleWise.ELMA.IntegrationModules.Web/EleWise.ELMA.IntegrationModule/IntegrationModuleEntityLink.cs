using System;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.IntegrationModules.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.IntegrationModules.Web.Components;

[Component]
internal class IntegrationModuleEntityLink : IEntityLink
{
	public Type EntityType => typeof(IIntegrationModule);

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
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if (entity == null)
		{
			return null;
		}
		Guid uid = InterfaceActivator.UID(entity.GetType().GetTypeWithoutProxy());
		return new UrlHelper(html).Action("ViewItem", "IntegrationModules", (object)new
		{
			area = "EleWise.ELMA.IntegrationModules.Web",
			uid = uid,
			id = entity.GetId()
		});
	}
}
