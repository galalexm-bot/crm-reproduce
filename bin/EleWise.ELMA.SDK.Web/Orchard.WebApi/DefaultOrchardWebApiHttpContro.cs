using System;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;
using Autofac;
using Autofac.Core;
using Autofac.Features.Metadata;
using Orchard.WebApi.Extensions;

namespace Orchard.WebApi;

public class DefaultOrchardWebApiHttpControllerSelector : DefaultHttpControllerSelector, IHttpControllerSelector
{
	private readonly HttpConfiguration _configuration;

	public DefaultOrchardWebApiHttpControllerSelector(HttpConfiguration configuration)
		: base(configuration)
	{
		_configuration = configuration;
	}

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

	public override HttpControllerDescriptor SelectController(HttpRequestMessage request)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		IHttpRouteData routeData = HttpRequestMessageExtensions.GetRouteData(request);
		string areaName = routeData.GetAreaName();
		string controllerName = ((DefaultHttpControllerSelector)this).GetControllerName(request);
		string serviceKey = (areaName + "/" + controllerName).ToLowerInvariant();
		WorkContext workContext = WorkContextExtensions.GetWorkContext(new HttpControllerContext(_configuration, routeData, request));
		if (TryResolve<Meta<Lazy<IHttpController>>>(workContext, serviceKey, out var instance))
		{
			Type type = (Type)instance.get_Metadata()["ControllerType"];
			return new HttpControllerDescriptor(_configuration, controllerName, type);
		}
		return null;
	}
}
public class DefaultOrchardWebApiHttpControllerActivator : IHttpControllerActivator
{
	private readonly HttpConfiguration _configuration;

	public DefaultOrchardWebApiHttpControllerActivator(HttpConfiguration configuration)
	{
		_configuration = configuration;
	}

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

	public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		IHttpRouteData routeData = HttpRequestMessageExtensions.GetRouteData(request);
		HttpControllerContext val = new HttpControllerContext(_configuration, routeData, request);
		string serviceKey = (routeData.GetAreaName() + "/" + controllerDescriptor.get_ControllerName()).ToLowerInvariant();
		WorkContext workContext = val.GetWorkContext();
		if (TryResolve<Meta<Lazy<IHttpController>>>(workContext, serviceKey, out var instance))
		{
			val.set_ControllerDescriptor(new HttpControllerDescriptor(_configuration, controllerDescriptor.get_ControllerName(), controllerType));
			IHttpController value = instance.get_Value().Value;
			val.set_Controller(value);
			return value;
		}
		return null;
	}
}
