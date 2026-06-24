using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Orleans.CodeGeneration;
using Orleans;

namespace EleWise.ELMA.Orleans.Runtime;

internal static class GrainFactoryExtensions
{
	private static readonly Dictionary<Type, Type> WrapperInterfaces = new Dictionary<Type, Type>();

	private static readonly Dictionary<Type, (Type actorProxyInterface, Type wrapper)> ActorToActorProxyWrappers = new Dictionary<Type, (Type, Type)>();

	private static readonly ConcurrentDictionary<Type, Func<IGrainFactory, long, IActorWithIntegerKey>> GetGrainWithIntegerKeyFunctions = new ConcurrentDictionary<Type, Func<IGrainFactory, long, IActorWithIntegerKey>>();

	private static readonly ConcurrentDictionary<Type, Func<IGrainFactory, string, IActorWithStringKey>> GetGrainWithStringKeyFunctions = new ConcurrentDictionary<Type, Func<IGrainFactory, string, IActorWithStringKey>>();

	private static readonly ConcurrentDictionary<Type, Func<IGrainFactory, Guid, IActorWithGuidKey>> GetGrainWithGuidKeyFunctions = new ConcurrentDictionary<Type, Func<IGrainFactory, Guid, IActorWithGuidKey>>();

	private static readonly ConcurrentDictionary<Type, Func<IGrainFactory, Guid, string, IActorWithGuidCompoundKey>> GetGrainWithGuidCompoundKeyFunctions = new ConcurrentDictionary<Type, Func<IGrainFactory, Guid, string, IActorWithGuidCompoundKey>>();

	internal static void Init(Assembly grainsAssembly)
	{
		foreach (Type item in grainsAssembly.ExportedTypes.Where((Type t) => t.IsInterface))
		{
			GrainWrapperForAttribute customAttribute = item.GetCustomAttribute<GrainWrapperForAttribute>(inherit: false);
			if (customAttribute != null)
			{
				WrapperInterfaces[customAttribute.ActorInterface] = item;
				ActorProxyToAttribute attribute = AttributeHelper<ActorProxyToAttribute>.GetAttribute(customAttribute.ActorInterface, inherited: false);
				if (attribute != null)
				{
					ActorToActorProxyWrappers[attribute.ActorInterfaceType] = (customAttribute.ActorInterface, attribute.ActorToProxyWrapper);
				}
			}
		}
	}

	public static TActorInterface GetActor<TActorInterface>(this IGrainFactory grainFactory, long primaryKey) where TActorInterface : IActorWithIntegerKey
	{
		return (TActorInterface)GetGrainFunc<TActorInterface, Func<IGrainFactory, long, IActorWithIntegerKey>>("GetGrainWithIntegerKey", GetGrainWithIntegerKeyFunctions)(grainFactory, primaryKey);
	}

	public static TActorInterface GetActor<TActorInterface>(this IGrainFactory grainFactory, string primaryKey) where TActorInterface : IActorWithStringKey
	{
		return (TActorInterface)GetGrainFunc<TActorInterface, Func<IGrainFactory, string, IActorWithStringKey>>("GetGrainWithStringKey", GetGrainWithStringKeyFunctions)(grainFactory, primaryKey);
	}

	public static TActorInterface GetActor<TActorInterface>(this IGrainFactory grainFactory, Guid primaryKey) where TActorInterface : IActorWithGuidKey
	{
		return (TActorInterface)GetGrainFunc<TActorInterface, Func<IGrainFactory, Guid, IActorWithGuidKey>>("GetGrainWithGuidKey", GetGrainWithGuidKeyFunctions)(grainFactory, primaryKey);
	}

	public static TActorInterface GetActor<TActorInterface>(this IGrainFactory grainFactory, Guid primaryKey, string keyExtension) where TActorInterface : IActorWithGuidCompoundKey
	{
		return (TActorInterface)GetGrainFunc<TActorInterface, Func<IGrainFactory, Guid, string, IActorWithGuidCompoundKey>>("GetGrainWithGuidCompoundKey", GetGrainWithGuidCompoundKeyFunctions)(grainFactory, primaryKey, keyExtension);
	}

	private static TDelegate GetGrainFunc<TActorInterface, TDelegate>(string methodName, ConcurrentDictionary<Type, TDelegate> cache)
	{
		if (!cache.TryGetValue(typeof(TActorInterface), out var value))
		{
			lock (cache)
			{
				if (cache.TryGetValue(typeof(TActorInterface), out value))
				{
					return value;
				}
				if (!ActorToActorProxyWrappers.TryGetValue(typeof(TActorInterface), out var value2))
				{
					throw new InvalidOperationException("Cannot find proxy information for '" + typeof(TActorInterface).FullName + "'");
				}
				if (!WrapperInterfaces.TryGetValue(value2.Item1, out var value3))
				{
					throw new InvalidOperationException("Cannot find grain wrapper type for '" + value2.Item1.FullName + "'");
				}
				MethodInfo method = typeof(GrainFactoryExtensions).GetMethod(methodName, BindingFlags.Static | BindingFlags.NonPublic);
				MethodInfo method2 = method.MakeGenericMethod(value2.Item1, value3);
				ParameterExpression[] array = (from paramInfo in method.GetParameters()
					select Expression.Parameter(paramInfo.ParameterType, paramInfo.Name)).ToArray();
				ConstructorInfo constructor = value2.Item2.GetConstructor(new Type[1] { value2.Item1 });
				Expression[] array2 = new Expression[1];
				Expression[] arguments = array;
				array2[0] = Expression.Call(method2, arguments);
				value = Expression.Lambda<TDelegate>(Expression.New(constructor, array2), array).Compile();
				cache[typeof(TActorInterface)] = value;
				return value;
			}
		}
		return value;
	}

	private static TGrainInterface GetGrainWithIntegerKey<TProxyActorInterface, TGrainInterface>(IGrainFactory grainFactory, long primaryKey) where TProxyActorInterface : IActorWithIntegerKey where TGrainInterface : IGrainWithIntegerKey, TProxyActorInterface
	{
		return grainFactory.GetGrain<TGrainInterface>(primaryKey, (string)null);
	}

	private static TGrainInterface GetGrainWithStringKey<TProxyActorInterface, TGrainInterface>(IGrainFactory grainFactory, string primaryKey) where TProxyActorInterface : IActorWithStringKey where TGrainInterface : IGrainWithStringKey, TProxyActorInterface
	{
		return grainFactory.GetGrain<TGrainInterface>(primaryKey, (string)null);
	}

	private static TGrainInterface GetGrainWithGuidKey<TProxyActorInterface, TGrainInterface>(IGrainFactory grainFactory, Guid primaryKey) where TProxyActorInterface : IActorWithGuidKey where TGrainInterface : IGrainWithGuidKey, TProxyActorInterface
	{
		return grainFactory.GetGrain<TGrainInterface>(primaryKey, (string)null);
	}

	private static TGrainInterface GetGrainWithGuidCompoundKey<TProxyActorInterface, TGrainInterface>(IGrainFactory grainFactory, Guid primaryKey, string keyExtension) where TProxyActorInterface : IActorWithGuidCompoundKey where TGrainInterface : IGrainWithGuidCompoundKey, TProxyActorInterface
	{
		return grainFactory.GetGrain<TGrainInterface>(primaryKey, keyExtension, (string)null);
	}
}
