using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Builder;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;
using Castle.DynamicProxy;

namespace Orchard.Environment.AutofacUtil.DynamicProxy2;

public class DynamicProxyContext
{
	private const string ProxyContextKey = "Orchard.Environment.AutofacUtil.DynamicProxy2.DynamicProxyContext.ProxyContextKey";

	private const string InterceptorServicesKey = "Orchard.Environment.AutofacUtil.DynamicProxy2.DynamicProxyContext.InterceptorServicesKey";

	private readonly IProxyBuilder _proxyBuilder = (IProxyBuilder)new DefaultProxyBuilder();

	private readonly IDictionary<Type, Type> _cache = new Dictionary<Type, Type>();

	public static DynamicProxyContext From(IComponentRegistration registration)
	{
		if (registration.get_Metadata().TryGetValue("Orchard.Environment.AutofacUtil.DynamicProxy2.DynamicProxyContext.ProxyContextKey", out var value))
		{
			return value as DynamicProxyContext;
		}
		return null;
	}

	public void EnableDynamicProxy<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle>(IRegistrationBuilder<TLimit, TConcreteReflectionActivatorData, TRegistrationStyle> registrationBuilder) where TConcreteReflectionActivatorData : ConcreteReflectionActivatorData
	{
		registrationBuilder.WithMetadata("Orchard.Environment.AutofacUtil.DynamicProxy2.DynamicProxyContext.ProxyContextKey", (object)this);
		((ReflectionActivatorData)(object)registrationBuilder.get_ActivatorData()).set_ConstructorFinder((IConstructorFinder)(object)new ConstructorFinderWrapper(((ReflectionActivatorData)(object)registrationBuilder.get_ActivatorData()).get_ConstructorFinder(), this));
		registrationBuilder.OnPreparing((Action<PreparingEventArgs>)delegate(PreparingEventArgs e)
		{
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			if (e.get_Component().get_Metadata().TryGetValue("Orchard.Environment.AutofacUtil.DynamicProxy2.DynamicProxyContext.InterceptorServicesKey", out var value))
			{
				IInterceptor[] array = ((IEnumerable<Service>)value).Select((Service service) => ResolutionExtensions.ResolveService(e.get_Context(), service)).Cast<IInterceptor>().ToArray();
				PositionalParameter val = new PositionalParameter(0, (object)array);
				e.set_Parameters((IEnumerable<Parameter>)((IEnumerable<Parameter>)(object)new PositionalParameter[1] { val }).Concat(e.get_Parameters()).ToArray());
			}
		});
	}

	public void AddInterceptorService(IComponentRegistration registration, Service service)
	{
		AddProxy(registration.get_Activator().get_LimitType());
		IEnumerable<Service> first = Enumerable.Empty<Service>();
		if (registration.get_Metadata().TryGetValue("Orchard.Environment.AutofacUtil.DynamicProxy2.DynamicProxyContext.InterceptorServicesKey", out var value))
		{
			first = (IEnumerable<Service>)value;
		}
		registration.get_Metadata()["Orchard.Environment.AutofacUtil.DynamicProxy2.DynamicProxyContext.InterceptorServicesKey"] = first.Concat((IEnumerable<Service>)(object)new Service[1] { service }).Distinct().ToArray();
	}

	public void AddProxy(Type type)
	{
		if (_cache.TryGetValue(type, out var value))
		{
			return;
		}
		lock (_cache)
		{
			if (!_cache.TryGetValue(type, out value))
			{
				_cache[type] = _proxyBuilder.CreateClassProxyType(type, new Type[0], ProxyGenerationOptions.Default);
			}
		}
	}

	public bool TryGetProxy(Type type, out Type proxyType)
	{
		return _cache.TryGetValue(type, out proxyType);
	}
}
