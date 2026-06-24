using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EleWise.ELMA.Orleans.Runtime;

internal static class OrleansServiceCollectionHelper
{
	private static List<Action<IServiceCollection>> serviceCollectionActions;

	private static readonly MethodInfo RegisterProxyToActorServiceActionMethod;

	private static readonly MethodInfo RegisterElmaServiceToOrleansMethod;

	public static ParameterInfo[] ActorProxyConstructorParameters { get; }

	static OrleansServiceCollectionHelper()
	{
		serviceCollectionActions = new List<Action<IServiceCollection>>();
		RegisterProxyToActorServiceActionMethod = typeof(OrleansServiceCollectionHelper).GetMethod("RegisterProxyToActorServiceAction", BindingFlags.Static | BindingFlags.NonPublic);
		RegisterElmaServiceToOrleansMethod = typeof(OrleansServiceCollectionHelper).GetMethod("RegisterElmaServiceToOrleans", BindingFlags.Static | BindingFlags.NonPublic);
		ActorProxyConstructorParameters = (from parameter in typeof(ActorProxy<>).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).First().GetParameters()
			where parameter.Position > 0
			select parameter).ToArray();
		ParameterInfo[] actorProxyConstructorParameters = ActorProxyConstructorParameters;
		foreach (ParameterInfo parameterInfo in actorProxyConstructorParameters)
		{
			MethodInfo registerServiceMethod = RegisterElmaServiceToOrleansMethod.MakeGenericMethod(parameterInfo.ParameterType);
			serviceCollectionActions.Add(delegate(IServiceCollection services)
			{
				registerServiceMethod.Invoke(null, new object[1] { services });
			});
		}
	}

	public static void ParseAssembly(Assembly assembly)
	{
		foreach (Type item in assembly.ExportedTypes.Where((Type exportedType) => exportedType.IsInterface))
		{
			ActorProxyToAttribute attribute = AttributeHelper<ActorProxyToAttribute>.GetAttribute(item, inherited: false);
			if (attribute != null)
			{
				MethodInfo registerActorToProxyMethod = RegisterProxyToActorServiceActionMethod.MakeGenericMethod(item, attribute.ProxyToActorWrapper);
				serviceCollectionActions.Add(delegate(IServiceCollection services)
				{
					registerActorToProxyMethod.Invoke(null, new object[1] { services });
				});
				MethodInfo registerActorToOrleansMethod = RegisterElmaServiceToOrleansMethod.MakeGenericMethod(attribute.ActorInterfaceType);
				serviceCollectionActions.Add(delegate(IServiceCollection services)
				{
					registerActorToOrleansMethod.Invoke(null, new object[1] { services });
				});
			}
		}
	}

	public static IServiceCollection RegisterActorModelTypes(this IServiceCollection serviceCollection)
	{
		foreach (Action<IServiceCollection> serviceCollectionAction in serviceCollectionActions)
		{
			serviceCollectionAction(serviceCollection);
		}
		serviceCollectionActions = null;
		return serviceCollection;
	}

	private static void RegisterProxyToActorServiceAction<TActorProxy, TWrapper>(IServiceCollection serviceCollection) where TActorProxy : class, IActor where TWrapper : class, TActorProxy
	{
		ServiceCollectionServiceExtensions.AddTransient<TActorProxy, TWrapper>(serviceCollection);
	}

	private static void RegisterElmaServiceToOrleans<TService>(IServiceCollection serviceCollection) where TService : class
	{
		ServiceCollectionServiceExtensions.AddTransient<TService>(serviceCollection, (Func<IServiceProvider, TService>)((IServiceProvider serviceProvider) => Locator.GetServiceNotNull<TService>()));
	}
}
