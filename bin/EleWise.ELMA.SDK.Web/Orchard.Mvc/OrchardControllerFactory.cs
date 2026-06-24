using System;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Core;
using Autofac.Features.Metadata;
using Orchard.Mvc.Extensions;

namespace Orchard.Mvc;

public class OrchardControllerFactory : DefaultControllerFactory
{
	protected bool TryResolve<T>(WorkContext workContext, object serviceKey, out T instance)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		if (workContext != null && serviceKey != null)
		{
			KeyedService val = new KeyedService(serviceKey, typeof(T));
			object obj = default(object);
			if (ResolutionExtensions.TryResolveService((IComponentContext)(object)workContext.Resolve<ILifetimeScope>(), (Service)(object)val, ref obj))
			{
				instance = (T)obj;
				return true;
			}
		}
		instance = default(T);
		return false;
	}

	protected override Type GetControllerType(RequestContext requestContext, string controllerName)
	{
		string serviceKey = (requestContext.RouteData.GetAreaName() + "/" + controllerName).ToLowerInvariant();
		WorkContext workContext = requestContext.GetWorkContext();
		if (TryResolve<Meta<Lazy<IController>>>(workContext, serviceKey, out var instance))
		{
			return (Type)instance.get_Metadata()["ControllerType"];
		}
		return null;
	}

	protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
	{
		WorkContext workContext = requestContext.GetWorkContext();
		if (TryResolve<IController>(workContext, controllerType, out var instance))
		{
			return instance;
		}
		return ((DefaultControllerFactory)this).GetControllerInstance(requestContext, controllerType);
	}
}
