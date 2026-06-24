using System;
using System.Collections.Generic;
using System.Web.Routing;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Content;

[Serializable]
public class ActionRoute
{
	private readonly string action;

	private readonly string controller;

	private readonly object routes;

	private object cachedRoutes;

	private RouteValueDictionary cachedRoutesDict;

	public string Action => action;

	public string Controller => controller;

	public string Area => (string)Routes["area"];

	public RouteValueDictionary Routes => GetRoutesDictionary();

	public ActionRoute(string action, string controller, object routes)
	{
		this.action = action;
		this.controller = controller;
		this.routes = routes;
	}

	public bool Equals(ActionRoute other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		return CreateRoutes().EqualsTo(other.CreateRoutes());
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != typeof(ActionRoute))
		{
			return false;
		}
		return Equals((ActionRoute)obj);
	}

	public override int GetHashCode()
	{
		return (((((action != null) ? action.GetHashCode() : 0) * 397) ^ ((controller != null) ? controller.GetHashCode() : 0)) * 397) ^ ((Routes != null) ? Routes.GetHashCode() : 0);
	}

	public bool EqualsTo(RouteValueDictionary routeValues)
	{
		if (routeValues == null)
		{
			return false;
		}
		return CreateRoutes().EqualsTo(routeValues);
	}

	public RouteValueDictionary CreateRoutes()
	{
		return new RouteValueDictionary(GetRoutesDictionary())
		{
			["action"] = Action,
			["controller"] = Controller
		};
	}

	public override string ToString()
	{
		return $"Action: {action}, Controller: {controller}, Routes: {Routes}";
	}

	private RouteValueDictionary GetRoutesDictionary()
	{
		if (cachedRoutes != routes)
		{
			IDictionary<string, object> dictionary = routes as IDictionary<string, object>;
			cachedRoutesDict = ((dictionary != null) ? new RouteValueDictionary(dictionary) : new RouteValueDictionary(routes));
			cachedRoutes = routes;
		}
		return cachedRoutesDict;
	}
}
