using System;
using System.Collections.Generic;
using Autofac;
using Autofac.Core;
using Autofac.Core.Lifetime;
using Autofac.Core.Resolving;

namespace Orchard.Environment.AutofacUtil;

public class LifetimeScopeContainer : IContainer, ILifetimeScope, IComponentContext, IDisposable
{
	private readonly ILifetimeScope _lifetimeScope;

	public IComponentRegistry ComponentRegistry => ((IComponentContext)_lifetimeScope).get_ComponentRegistry();

	public IDisposer Disposer => _lifetimeScope.get_Disposer();

	public object Tag => _lifetimeScope.get_Tag();

	event EventHandler<LifetimeScopeBeginningEventArgs> ChildLifetimeScopeBeginning
	{
		add
		{
			_lifetimeScope.add_ChildLifetimeScopeBeginning(value);
		}
		remove
		{
			_lifetimeScope.remove_ChildLifetimeScopeBeginning(value);
		}
	}

	event EventHandler<LifetimeScopeEndingEventArgs> CurrentScopeEnding
	{
		add
		{
			_lifetimeScope.add_CurrentScopeEnding(value);
		}
		remove
		{
			_lifetimeScope.remove_CurrentScopeEnding(value);
		}
	}

	event EventHandler<ResolveOperationBeginningEventArgs> ResolveOperationBeginning
	{
		add
		{
			_lifetimeScope.add_ResolveOperationBeginning(value);
		}
		remove
		{
			_lifetimeScope.remove_ResolveOperationBeginning(value);
		}
	}

	public LifetimeScopeContainer(ILifetimeScope lifetimeScope)
	{
		_lifetimeScope = lifetimeScope;
	}

	public object ResolveComponent(IComponentRegistration registration, IEnumerable<Parameter> parameters)
	{
		return ((IComponentContext)_lifetimeScope).ResolveComponent(registration, parameters);
	}

	public void Dispose()
	{
	}

	public ILifetimeScope BeginLifetimeScope()
	{
		return _lifetimeScope.BeginLifetimeScope();
	}

	public ILifetimeScope BeginLifetimeScope(object tag)
	{
		return _lifetimeScope.BeginLifetimeScope(tag);
	}

	public ILifetimeScope BeginLifetimeScope(Action<ContainerBuilder> configurationAction)
	{
		return _lifetimeScope.BeginLifetimeScope(configurationAction);
	}

	public ILifetimeScope BeginLifetimeScope(object tag, Action<ContainerBuilder> configurationAction)
	{
		return _lifetimeScope.BeginLifetimeScope(tag, configurationAction);
	}
}
