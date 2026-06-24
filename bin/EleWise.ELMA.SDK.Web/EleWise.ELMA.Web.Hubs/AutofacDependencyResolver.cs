using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using EleWise.ELMA.ComponentModel;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs;

[Service]
internal class AutofacDependencyResolver : DefaultDependencyResolver, IAutofacDependencyResolver, IDependencyResolver, IDisposable
{
	private readonly ILifetimeScope lifetimeScope;

	public static IAutofacDependencyResolver Current => GlobalHost.get_DependencyResolver() as IAutofacDependencyResolver;

	public ILifetimeScope LifetimeScope => lifetimeScope;

	public AutofacDependencyResolver(ILifetimeScope lifetimeScope)
	{
		if (lifetimeScope == null)
		{
			throw new ArgumentNullException("lifetimeScope");
		}
		this.lifetimeScope = lifetimeScope;
	}

	public override object GetService(Type serviceType)
	{
		return Wrap(ResolutionExtensions.ResolveOptional((IComponentContext)(object)lifetimeScope, serviceType) ?? ((DefaultDependencyResolver)this).GetService(serviceType));
	}

	public override IEnumerable<object> GetServices(Type serviceType)
	{
		List<object> list = ((IEnumerable<object>)ResolutionExtensions.Resolve((IComponentContext)(object)lifetimeScope, typeof(IEnumerable<>).MakeGenericType(serviceType))).ToList();
		if (!list.Any())
		{
			return ((DefaultDependencyResolver)this).GetServices(serviceType);
		}
		return list;
	}

	private object Wrap(object value)
	{
		IHubPipelineInvoker invoker;
		if ((invoker = (IHubPipelineInvoker)((value is IHubPipelineInvoker) ? value : null)) == null)
		{
			return value;
		}
		return new HubPipelineInvokerWrapper(invoker);
	}
}
