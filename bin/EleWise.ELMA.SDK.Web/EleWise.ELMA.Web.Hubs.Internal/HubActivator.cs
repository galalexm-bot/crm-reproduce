using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs.Internal;

internal sealed class HubActivator : IHubActivator
{
	private readonly IDependencyResolver dependencyResolver;

	private readonly MethodInfo resolveMethod = typeof(HubActivator).GetMethod("Resolve", BindingFlags.Static | BindingFlags.NonPublic);

	private readonly ConcurrentDictionary<Type, Func<IHub>> hubActivators = new ConcurrentDictionary<Type, Func<IHub>>();

	public HubActivator(IDependencyResolver dependencyResolver)
	{
		this.dependencyResolver = dependencyResolver;
	}

	public IHub Create(HubDescriptor descriptor)
	{
		Contract.ArgumentNotNull(descriptor, "descriptor");
		if (descriptor.get_HubType() == null)
		{
			return null;
		}
		return hubActivators.GetOrAdd(descriptor.get_HubType(), delegate(Type hubType)
		{
			ConstructorInfo constructorInfo = hubType.GetConstructors(BindingFlags.Instance | BindingFlags.Public).FirstOrDefault();
			if (constructorInfo == null)
			{
				return null;
			}
			IEnumerable<MethodInfo> source = from parameter in constructorInfo.GetParameters()
				select parameter.ParameterType into type
				select resolveMethod.MakeGenericMethod(type);
			return Expression.Lambda<Func<IHub>>(Expression.New(constructorInfo, source.Select((MethodInfo method) => Expression.Call(method, Expression.Constant(dependencyResolver)))), Array.Empty<ParameterExpression>()).Compile();
		})();
	}

	private static TResult Resolve<TResult>(IDependencyResolver resolver)
	{
		return (TResult)DependencyResolverExtensions.Resolve(resolver, typeof(TResult));
	}
}
