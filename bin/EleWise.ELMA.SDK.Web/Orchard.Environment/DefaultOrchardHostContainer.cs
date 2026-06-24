using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Autofac;

namespace Orchard.Environment;

public class DefaultOrchardHostContainer : IOrchardHostContainer, IDependencyResolver
{
	private readonly IContainer _container;

	public DefaultOrchardHostContainer(IContainer container)
	{
		_container = container;
	}

	private static bool TryResolveAtScope(ILifetimeScope scope, string key, Type serviceType, out object value)
	{
		if (scope == null)
		{
			value = null;
			return false;
		}
		if (key != null)
		{
			return ResolutionExtensions.TryResolveKeyed((IComponentContext)(object)scope, (object)key, serviceType, ref value);
		}
		return ResolutionExtensions.TryResolve((IComponentContext)(object)scope, serviceType, ref value);
	}

	private bool TryResolve(string key, Type serviceType, out object value)
	{
		return TryResolveAtScope((ILifetimeScope)(object)_container, key, serviceType, out value);
	}

	private static object CreateInstance(Type t)
	{
		if (t.IsAbstract || t.IsInterface)
		{
			return null;
		}
		return Activator.CreateInstance(t);
	}

	private TService Resolve<TService>(Type serviceType, TService defaultValue = default(TService))
	{
		if (!TryResolve(null, serviceType, out var value))
		{
			return defaultValue;
		}
		return (TService)value;
	}

	private TService Resolve<TService>(Type serviceType, string key, TService defaultValue = default(TService))
	{
		if (!TryResolve(key, serviceType, out var value))
		{
			return defaultValue;
		}
		return (TService)value;
	}

	private TService Resolve<TService>(Type serviceType, Func<Type, TService> defaultFactory)
	{
		if (!TryResolve(null, serviceType, out var value))
		{
			return defaultFactory(serviceType);
		}
		return (TService)value;
	}

	private TService Resolve<TService>(Type serviceType, string key, Func<Type, TService> defaultFactory)
	{
		if (!TryResolve(key, serviceType, out var value))
		{
			return defaultFactory(serviceType);
		}
		return (TService)value;
	}

	TService IOrchardHostContainer.Resolve<TService>()
	{
		return Resolve<TService>(typeof(TService));
	}

	object IDependencyResolver.GetService(Type serviceType)
	{
		return Resolve<object>(serviceType);
	}

	IEnumerable<object> IDependencyResolver.GetServices(Type serviceType)
	{
		return Resolve(typeof(IEnumerable<>).MakeGenericType(serviceType), (IEnumerable)Enumerable.Empty<object>()).Cast<object>();
	}
}
