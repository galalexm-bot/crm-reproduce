using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Environment;
using Orchard.Environment.Configuration;

namespace Orchard.Mvc.Routes;

public class HubRoute : RouteBase, IRouteWithArea, IComparable<HubRoute>
{
	private readonly IRunningShellTable _runningShellTable;

	private readonly ConcurrentDictionary<string, IList<RouteBase>> _routesByShell = new ConcurrentDictionary<string, IList<RouteBase>>();

	public string Name { get; private set; }

	public string Area { get; private set; }

	public int Priority { get; private set; }

	public HubRoute(string name, string area, int priority, IRunningShellTable runningShellTable)
	{
		Priority = priority;
		Area = area;
		Name = name;
		_runningShellTable = runningShellTable;
	}

	public void ReleaseShell(ShellSettings shellSettings)
	{
		_routesByShell.TryRemove(shellSettings.Name, out var _);
	}

	public void Add(RouteBase route, ShellSettings shellSettings)
	{
		_routesByShell.GetOrAdd(shellSettings.Name, (string key) => new List<RouteBase>()).Add(route);
	}

	public override RouteData GetRouteData(HttpContextBase httpContext)
	{
		ShellSettings shellSettings = _runningShellTable.Match(httpContext);
		if (shellSettings == null)
		{
			return null;
		}
		if (!_routesByShell.TryGetValue(shellSettings.Name, out var value))
		{
			return null;
		}
		foreach (RouteBase item in value)
		{
			RouteData routeData = item.GetRouteData(httpContext);
			if (routeData != null)
			{
				return routeData;
			}
		}
		return null;
	}

	public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
	{
		ShellSettings shellSettings = _runningShellTable.Match(requestContext.HttpContext);
		if (shellSettings == null)
		{
			return null;
		}
		if (!_routesByShell.TryGetValue(shellSettings.Name, out var value))
		{
			return null;
		}
		foreach (RouteBase item in value)
		{
			VirtualPathData virtualPath = item.GetVirtualPath(requestContext, values);
			if (virtualPath != null)
			{
				return virtualPath;
			}
		}
		return null;
	}

	public int CompareTo(HubRoute other)
	{
		if (other == null)
		{
			return -1;
		}
		if (other == this)
		{
			return 0;
		}
		if ((string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(other.Name)) || Name == other.Name)
		{
			return 0;
		}
		if (!string.Equals(other.Area, Area, StringComparison.OrdinalIgnoreCase))
		{
			return StringComparer.OrdinalIgnoreCase.Compare(other.Area, Area);
		}
		if (other.Priority == Priority)
		{
			return StringComparer.OrdinalIgnoreCase.Compare(other.Area, Area);
		}
		return Priority.CompareTo(other.Priority);
	}
}
