using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using Autofac;

namespace Orchard.WebApi;

public class AutofacWebApiDependencyScope : IDependencyScope, IDisposable
{
	private readonly ILifetimeScope _lifetimeScope;

	public AutofacWebApiDependencyScope(ILifetimeScope lifetimeScope)
	{
		_lifetimeScope = lifetimeScope;
	}

	public object GetService(Type serviceType)
	{
		return ResolutionExtensions.ResolveOptional((IComponentContext)(object)_lifetimeScope, serviceType);
	}

	public IEnumerable<object> GetServices(Type serviceType)
	{
		if (!ResolutionExtensions.IsRegistered((IComponentContext)(object)_lifetimeScope, serviceType))
		{
			return Enumerable.Empty<object>();
		}
		Type type = typeof(IEnumerable<>).MakeGenericType(serviceType);
		return (IEnumerable<object>)ResolutionExtensions.Resolve((IComponentContext)(object)_lifetimeScope, type);
	}

	public void Dispose()
	{
		if (_lifetimeScope != null)
		{
			((IDisposable)_lifetimeScope).Dispose();
		}
	}
}
