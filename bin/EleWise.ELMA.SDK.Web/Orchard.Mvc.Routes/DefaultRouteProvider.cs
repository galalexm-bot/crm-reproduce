using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Orchard.Mvc.Routes;

public class DefaultRouteProvider : IRouteProvider, IDependency
{
	public class HomeOrAccount : IRouteConstraint
	{
		public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
		{
			if (values.TryGetValue(parameterName, out var value))
			{
				string a = Convert.ToString(value);
				if (!string.Equals(a, "home", StringComparison.OrdinalIgnoreCase))
				{
					return string.Equals(a, "account", StringComparison.OrdinalIgnoreCase);
				}
				return true;
			}
			return false;
		}
	}

	public IEnumerable<RouteDescriptor> GetRoutes()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		return new RouteDescriptor[1]
		{
			new RouteDescriptor
			{
				Priority = -20,
				Route = new Route("{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "controller", "home" },
					{ "action", "index" },
					{ "id", "" }
				}, new RouteValueDictionary { 
				{
					"controller",
					new HomeOrAccount()
				} }, (IRouteHandler)new MvcRouteHandler())
			}
		};
	}

	public void GetRoutes(ICollection<RouteDescriptor> routes)
	{
		foreach (RouteDescriptor route in GetRoutes())
		{
			routes.Add(route);
		}
	}
}
