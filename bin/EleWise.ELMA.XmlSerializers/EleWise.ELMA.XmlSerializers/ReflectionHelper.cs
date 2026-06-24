using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace EleWise.ELMA.XmlSerializers;

internal static class ReflectionHelper
{
	private class TypeCache
	{
		public Type Type { get; private set; }

		public ConcurrentDictionary<string, PropertyInfo> PropertyInfos { get; private set; }

		public ConcurrentDictionary<string, MethodInfo> MethodInfos { get; private set; }

		public TypeCache(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			PropertyInfos = new ConcurrentDictionary<string, PropertyInfo>();
			MethodInfos = new ConcurrentDictionary<string, MethodInfo>();
			Type = type;
		}

		public PropertyInfo GetProperty(string name)
		{
			if (!PropertyInfos.TryGetValue(name, out var value))
			{
				lock (PropertyInfos)
				{
					if (PropertyInfos.TryGetValue(name, out value))
					{
						return value;
					}
					value = Type.GetProperty(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					PropertyInfos[name] = value;
					if (value == null)
					{
						throw new MemberAccessException($"Property '{name}' not found in type '{Type.FullName}'");
					}
					return value;
				}
			}
			return value;
		}

		public MethodInfo GetMethod(string name)
		{
			if (!MethodInfos.TryGetValue(name, out var value))
			{
				lock (MethodInfos)
				{
					if (MethodInfos.TryGetValue(name, out value))
					{
						return value;
					}
					value = Type.GetMethod(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					MethodInfos[name] = value;
					if (value == null)
					{
						throw new MemberAccessException($"Method '{name}' not found in type '{Type.FullName}'");
					}
					return value;
				}
			}
			return value;
		}
	}

	private static ConcurrentDictionary<Type, TypeCache> _cache = new ConcurrentDictionary<Type, TypeCache>();

	public static Func<TObj, TValue> GetPropertyValueExpression<TObj, TValue>(string propertyName)
	{
		PropertyInfo property = GetTypeCache(typeof(TObj)).GetProperty(propertyName);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(TObj), "obj");
		return (Func<TObj, TValue>)Expression.Lambda(Expression.Call(parameterExpression, property.GetGetMethod(nonPublic: true)), parameterExpression).Compile();
	}

	public static Action<TObj, TValue> SetPropertyValueAction<TObj, TValue>(string propertyName)
	{
		PropertyInfo property = GetTypeCache(typeof(TObj)).GetProperty(propertyName);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(TObj), "obj");
		ParameterExpression parameterExpression2 = Expression.Parameter(typeof(TValue), "value");
		return (Action<TObj, TValue>)Expression.Lambda(Expression.Call(parameterExpression, property.GetSetMethod(nonPublic: true), parameterExpression2), parameterExpression, parameterExpression2).Compile();
	}

	public static Delegate InvokeMethodExpression<TObj, TParam1>(string methodName)
	{
		return InvokeMethodExpression<TObj>(methodName, new Type[1] { typeof(TParam1) });
	}

	public static Delegate InvokeMethodExpression<TObj, TParam1, TParam2>(string methodName)
	{
		return InvokeMethodExpression<TObj>(methodName, new Type[2]
		{
			typeof(TParam1),
			typeof(TParam2)
		});
	}

	public static Delegate InvokeMethodExpression<TObj, TParam1, TParam2, TParam3>(string methodName)
	{
		return InvokeMethodExpression<TObj>(methodName, new Type[3]
		{
			typeof(TParam1),
			typeof(TParam2),
			typeof(TParam3)
		});
	}

	public static Delegate InvokeMethodExpression<TObj>(string methodName, params Type[] parameterTypes)
	{
		MethodInfo method = GetTypeCache(typeof(TObj)).GetMethod(methodName);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(TObj), "obj");
		List<ParameterExpression> list = new List<ParameterExpression>();
		if (parameterTypes != null)
		{
			for (int i = 0; i < parameterTypes.Length; i++)
			{
				ParameterExpression item = Expression.Parameter(parameterTypes[i], "arg" + i);
				list.Add(item);
			}
		}
		MethodCallExpression body = Expression.Call(parameterExpression, method, list);
		List<ParameterExpression> list2 = new List<ParameterExpression>();
		list2.Add(parameterExpression);
		list2.AddRange(list);
		return Expression.Lambda(body, list2.ToArray()).Compile();
	}

	private static TypeCache GetTypeCache(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (!_cache.TryGetValue(type, out var value))
		{
			lock (_cache)
			{
				if (_cache.TryGetValue(type, out value))
				{
					return value;
				}
				value = new TypeCache(type);
				_cache[type] = value;
				return value;
			}
		}
		return value;
	}
}
