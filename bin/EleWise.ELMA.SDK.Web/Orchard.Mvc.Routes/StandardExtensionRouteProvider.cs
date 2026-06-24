using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Orchard.Environment.Extensions.Models;
using Orchard.Environment.ShellBuilders.Models;

namespace Orchard.Mvc.Routes;

public class StandardExtensionRouteProvider : IRouteProvider, IDependency
{
	private readonly ShellBlueprint _blueprint;

	public StandardExtensionRouteProvider(ShellBlueprint blueprint)
	{
		_blueprint = blueprint;
	}

	public IEnumerable<RouteDescriptor> GetRoutes()
	{
		IEnumerable<IGrouping<string, ExtensionDescriptor>> enumerable = from x in _blueprint.Controllers
			group x.Feature.Descriptor.Extension by x.AreaName;
		foreach (IGrouping<string, ExtensionDescriptor> item in enumerable)
		{
			string areaName = item.Key;
			ExtensionDescriptor extensionDescriptor = item.Distinct().Single();
			string displayPath = extensionDescriptor.Path;
			Enum.TryParse<SessionStateBehavior>(extensionDescriptor.SessionState, ignoreCase: true, out var defaultSessionState);
			yield return new RouteDescriptor
			{
				Priority = -10,
				SessionState = defaultSessionState,
				Route = new Route("Admin/" + displayPath + "/{action}/{id}", new RouteValueDictionary
				{
					{ "area", areaName },
					{ "controller", "admin" },
					{ "action", "index" },
					{ "id", "" }
				}, new RouteValueDictionary(), new RouteValueDictionary { { "area", areaName } }, (IRouteHandler)new MvcRouteHandler())
			};
			yield return new RouteDescriptor
			{
				Priority = -10,
				SessionState = defaultSessionState,
				Route = new Route(displayPath + "/{controller}/{action}/{id}", new RouteValueDictionary
				{
					{ "area", areaName },
					{ "controller", "home" },
					{ "action", "index" },
					{ "id", "" }
				}, new RouteValueDictionary(), new RouteValueDictionary { { "area", areaName } }, (IRouteHandler)new MvcRouteHandler())
			};
		}
	}

	public void GetRoutes(ICollection<RouteDescriptor> routes)
	{
		foreach (RouteDescriptor route in GetRoutes())
		{
			routes.Add(route);
		}
	}
}
