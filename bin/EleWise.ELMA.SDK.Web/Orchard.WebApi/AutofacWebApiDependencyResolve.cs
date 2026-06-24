using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Autofac;

namespace Orchard.WebApi;

public class AutofacWebApiDependencyResolver : IDependencyResolver, IDependencyScope, IDisposable
{
	private readonly ILifetimeScope _container;

	private readonly IDependencyScope _rootDependencyScope;

	public ILifetimeScope Container => _container;

	public AutofacWebApiDependencyResolver(ILifetimeScope container)
	{
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		_container = container;
		_rootDependencyScope = (IDependencyScope)(object)new AutofacWebApiDependencyScope(container);
	}

	public object GetService(Type serviceType)
	{
		return _rootDependencyScope.GetService(serviceType);
	}

	public IEnumerable<object> GetServices(Type serviceType)
	{
		return _rootDependencyScope.GetServices(serviceType);
	}

	public IDependencyScope BeginScope()
	{
		return (IDependencyScope)(object)new AutofacWebApiDependencyScope(_container.BeginLifetimeScope());
	}

	public void Dispose()
	{
		((IDisposable)_rootDependencyScope).Dispose();
	}
}
