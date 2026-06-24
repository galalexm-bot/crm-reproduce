using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component]
public class FilterLinkExtensions : IEntityLink
{
	public Type EntityType => null;

	public Guid TypeUid => InterfaceActivator.UID<IFilter>();

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
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		IFilter filter = (IFilter)entity;
		FilterMenuProvider serviceNotNull = Locator.GetServiceNotNull<FilterMenuProvider>();
		FilterMenuItem filterMenuItem = serviceNotNull.FilterMenuItemByTypeUidandCode(filter.ObjectsType.TypeUid, filter.Code);
		if (filterMenuItem == null)
		{
			filterMenuItem = serviceNotNull.FilterMenuItemByTypeUidandCode(filter.ObjectsType.TypeUid, null);
		}
		ActionRoute routes = filterMenuItem.Routes;
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
		foreach (KeyValuePair<string, object> route in routes.Routes)
		{
			routeValueDictionary.Add(route.Key, route.Value);
		}
		routeValueDictionary.Add(filterMenuItem.FilterIdParameter, filter.Id);
		return new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext).Action(routes.Action, routes.Controller, routeValueDictionary);
	}
}
