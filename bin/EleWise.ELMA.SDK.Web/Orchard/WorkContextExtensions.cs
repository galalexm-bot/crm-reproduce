using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;

namespace Orchard;

public static class WorkContextExtensions
{
	public static WorkContext GetContext(this IWorkContextAccessor workContextAccessor, ControllerContext controllerContext)
	{
		return workContextAccessor.GetContext(controllerContext.get_RequestContext().HttpContext);
	}

	public static WorkContext GetLogicalContext(this IWorkContextAccessor workContextAccessor)
	{
		if (!(workContextAccessor is ILogicalWorkContextAccessor logicalWorkContextAccessor))
		{
			return null;
		}
		return logicalWorkContextAccessor.GetLogicalContext();
	}

	public static WorkContext GetWorkContext(this RequestContext requestContext)
	{
		if (requestContext == null)
		{
			return null;
		}
		RouteData routeData = requestContext.RouteData;
		if (routeData == null || routeData.DataTokens == null)
		{
			return null;
		}
		if (!routeData.DataTokens.TryGetValue("IWorkContextAccessor", out var value))
		{
			value = FindWorkContextInParent(routeData);
		}
		if (!(value is IWorkContextAccessor))
		{
			return null;
		}
		return ((IWorkContextAccessor)value).GetContext(requestContext.HttpContext);
	}

	public static WorkContext GetWorkContext(this HttpControllerContext controllerContext)
	{
		if (controllerContext == null)
		{
			return null;
		}
		IHttpRouteData routeData = controllerContext.get_RouteData();
		if (routeData == null || routeData.get_Values() == null)
		{
			return null;
		}
		if (!routeData.get_Values().TryGetValue("IWorkContextAccessor", out var value))
		{
			return null;
		}
		if (value == null || !(value is IWorkContextAccessor))
		{
			return null;
		}
		return ((IWorkContextAccessor)value).GetContext();
	}

	private static object FindWorkContextInParent(RouteData routeData)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (!routeData.DataTokens.TryGetValue("ParentActionViewContext", out var value) || !(value is ViewContext))
		{
			return null;
		}
		RouteData routeData2 = ((ControllerContext)(ViewContext)value).get_RouteData();
		if (routeData2 == null || routeData2.DataTokens == null)
		{
			return null;
		}
		if (!routeData2.DataTokens.TryGetValue("IWorkContextAccessor", out var value2))
		{
			return FindWorkContextInParent(routeData2);
		}
		return value2;
	}

	public static WorkContext GetWorkContext(this ControllerContext controllerContext)
	{
		if (controllerContext == null)
		{
			return null;
		}
		return controllerContext.get_RequestContext().GetWorkContext();
	}

	public static IWorkContextScope CreateWorkContextScope(this ILifetimeScope lifetimeScope, HttpContextBase httpContext)
	{
		return ResolutionExtensions.Resolve<IWorkContextAccessor>((IComponentContext)(object)lifetimeScope).CreateWorkContextScope(httpContext);
	}

	public static IWorkContextScope CreateWorkContextScope(this ILifetimeScope lifetimeScope)
	{
		return ResolutionExtensions.Resolve<IWorkContextAccessor>((IComponentContext)(object)lifetimeScope).CreateWorkContextScope();
	}
}
