using System.Web.Http.Routing;
using System.Web.Mvc;
using System.Web.Routing;

namespace Orchard.WebApi.Extensions;

public static class RouteExtension
{
	public static string GetAreaName(this IHttpRoute route)
	{
		IRouteWithArea val = (IRouteWithArea)(object)((route is IRouteWithArea) ? route : null);
		if (val != null)
		{
			return val.get_Area();
		}
		if (route is Route route2 && route2.DataTokens != null)
		{
			return route2.DataTokens["area"] as string;
		}
		return null;
	}

	public static string GetAreaName(this IHttpRouteData routeData)
	{
		if (routeData.get_Route().get_Defaults().TryGetValue("area", out var value))
		{
			return value as string;
		}
		return routeData.get_Route().GetAreaName();
	}
}
