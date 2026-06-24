using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using EleWise.ELMA.Extensions;
using Orchard.Environment;
using Orchard.Environment.Configuration;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;

namespace Orchard.Mvc.Routes;

public class RoutePublisher : IRoutePublisher, IDependency
{
	private readonly RouteCollection _routeCollection;

	private readonly ShellSettings _shellSettings;

	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly IRunningShellTable _runningShellTable;

	private readonly IExtensionManager _extensionManager;

	public RoutePublisher(RouteCollection routeCollection, ShellSettings shellSettings, IWorkContextAccessor workContextAccessor, IRunningShellTable runningShellTable, IExtensionManager extensionManager)
	{
		_routeCollection = routeCollection;
		_shellSettings = shellSettings;
		_workContextAccessor = workContextAccessor;
		_runningShellTable = runningShellTable;
		_extensionManager = extensionManager;
	}

	public void Publish(IEnumerable<RouteDescriptor> routes, Func<IDictionary<string, object>, Task> env)
	{
		RouteDescriptor[] array = routes.OrderByDescending((RouteDescriptor r) => r.Priority).ToArray();
		RouteCollection routeCollection = new RouteCollection();
		RouteDescriptor[] array2 = array;
		foreach (RouteDescriptor routeDescriptor2 in array2)
		{
			if (routeDescriptor2 is HttpRouteDescriptor httpRouteDescriptor)
			{
				RouteCollection routeCollection2 = new RouteCollection();
				RouteCollectionExtensions.MapHttpRoute(routeCollection2, httpRouteDescriptor.Name, httpRouteDescriptor.RouteTemplate, httpRouteDescriptor.Defaults, httpRouteDescriptor.Constraints);
				routeDescriptor2.Route = routeCollection2.First();
			}
			routeCollection.Add(routeDescriptor2.Name, routeDescriptor2.Route);
		}
		using (_routeCollection.GetWriteLock())
		{
			_routeCollection.OfType<HubRoute>().ForEach(delegate(HubRoute x)
			{
				x.ReleaseShell(_shellSettings);
			});
			Dictionary<string, RouteBase> dictionary = (Dictionary<string, RouteBase>)typeof(RouteCollection).GetField("_namedMap", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(_routeCollection);
			array2 = array;
			foreach (RouteDescriptor routeDescriptor in array2)
			{
				SessionStateBehavior result = SessionStateBehavior.Default;
				ExtensionDescriptor extensionDescriptor = null;
				if (routeDescriptor.Route is Route)
				{
					Route route = routeDescriptor.Route as Route;
					if ((route.DataTokens != null && route.DataTokens.TryGetValue("area", out var value)) || (route.Defaults != null && route.Defaults.TryGetValue("area", out value)))
					{
						extensionDescriptor = _extensionManager.GetExtension(value.ToString());
					}
				}
				else if (routeDescriptor.Route is IRouteWithArea)
				{
					RouteBase route2 = routeDescriptor.Route;
					IRouteWithArea val = (IRouteWithArea)(object)((route2 is IRouteWithArea) ? route2 : null);
					extensionDescriptor = _extensionManager.GetExtension(val.get_Area());
				}
				if (extensionDescriptor != null && routeDescriptor.SessionState == SessionStateBehavior.Default)
				{
					Enum.TryParse<SessionStateBehavior>(extensionDescriptor.SessionState, ignoreCase: true, out result);
				}
				SessionStateBehavior sessionState = ((routeDescriptor.SessionState == SessionStateBehavior.Default) ? result : routeDescriptor.SessionState);
				ShellRoute route3 = new ShellRoute(routeDescriptor.Route, _shellSettings, _workContextAccessor, _runningShellTable, env)
				{
					IsHttpRoute = (routeDescriptor is HttpRouteDescriptor),
					SessionState = sessionState
				};
				string area = ((extensionDescriptor == null) ? "" : extensionDescriptor.Id);
				HubRoute hubRoute = _routeCollection.FirstOrDefault(delegate(RouteBase x)
				{
					if (!(x is HubRoute hubRoute3))
					{
						return false;
					}
					return routeDescriptor.Priority == hubRoute3.Priority && hubRoute3.Area.Equals(area, StringComparison.OrdinalIgnoreCase) && hubRoute3.Name == routeDescriptor.Name;
				}) as HubRoute;
				if (hubRoute == null)
				{
					hubRoute = new HubRoute(routeDescriptor.Name, area, routeDescriptor.Priority, _runningShellTable);
					int j;
					for (j = 0; j < _routeCollection.Count && (!(_routeCollection[j] is HubRoute hubRoute2) || hubRoute2.Priority >= hubRoute.Priority); j++)
					{
					}
					_routeCollection.Insert(j, hubRoute);
					if (!string.IsNullOrEmpty(hubRoute.Name) && !dictionary.ContainsKey(hubRoute.Name))
					{
						dictionary[hubRoute.Name] = hubRoute;
					}
				}
				hubRoute.Add(route3, _shellSettings);
			}
		}
	}
}
