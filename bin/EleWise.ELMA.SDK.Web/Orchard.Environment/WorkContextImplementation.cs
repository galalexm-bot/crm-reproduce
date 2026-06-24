using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Autofac;

namespace Orchard.Environment;

internal class WorkContextImplementation : WorkContext
{
	private readonly IComponentContext _componentContext;

	private readonly ConcurrentDictionary<string, Func<object>> _stateResolvers = new ConcurrentDictionary<string, Func<object>>();

	private readonly IEnumerable<Lazy<IWorkContextStateProvider>> _workContextStateProviders;

	public WorkContextImplementation(IComponentContext componentContext)
	{
		_componentContext = componentContext;
		_workContextStateProviders = ResolutionExtensions.Resolve<IEnumerable<Lazy<IWorkContextStateProvider>>>(componentContext);
		SetDefaultValues();
	}

	private void SetDefaultValues()
	{
		base.CurrentCulture = Thread.CurrentThread.CurrentCulture.Name;
		base.CurrentTimeZone = TimeZoneInfo.Local;
		base.CurrentCalendar = "";
	}

	public override T Resolve<T>()
	{
		return ResolutionExtensions.Resolve<T>(_componentContext);
	}

	public override object Resolve(Type serviceType)
	{
		return ResolutionExtensions.Resolve(_componentContext, serviceType);
	}

	public override bool TryResolve<T>(out T service)
	{
		return ResolutionExtensions.TryResolve<T>(_componentContext, ref service);
	}

	public override bool TryResolve(Type serviceType, out object service)
	{
		return ResolutionExtensions.TryResolve(_componentContext, serviceType, ref service);
	}

	public override T GetState<T>(string name)
	{
		return (T)_stateResolvers.GetOrAdd(name, FindResolverForState<T>)();
	}

	private Func<object> FindResolverForState<T>(string name)
	{
		Func<WorkContext, T> resolver = _workContextStateProviders.Select((Lazy<IWorkContextStateProvider> wcsp) => wcsp.Value.Get<T>(name)).FirstOrDefault((Func<WorkContext, T> value) => !object.Equals(value, default(T)));
		if (resolver == null)
		{
			return () => default(T);
		}
		return () => resolver(this);
	}

	public override void SetState<T>(string name, T value)
	{
		_stateResolvers[name] = () => value;
	}
}
