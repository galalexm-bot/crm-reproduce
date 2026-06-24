using System.Web.Routing;

namespace EleWise.ELMA.Web.Mvc.Util;

public static class RouteValuesUtility
{
	public static RouteValueDictionary ActionRoute(string actionName, string controllerName, RouteValueDictionary routeValues)
	{
		return new RouteValueDictionary(routeValues)
		{
			["action"] = actionName,
			["controller"] = controllerName
		};
	}
}
