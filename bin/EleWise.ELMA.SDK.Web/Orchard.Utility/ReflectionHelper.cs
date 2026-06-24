using System;
using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Reflection;

namespace Orchard.Utility;

public class ReflectionHelper<T>
{
	public delegate TProperty PropertyGetterDelegate<out TProperty>(T target);

	private static readonly ConcurrentDictionary<string, Delegate> _getterCache = new ConcurrentDictionary<string, Delegate>();

	public static PropertyInfo GetPropertyInfo<TProperty>(Expression<Func<T, TProperty>> expression)
	{
		PropertyInfo obj = ((expression.Body as MemberExpression) ?? throw new InvalidOperationException("Expression is not a member expression.")).Member as PropertyInfo;
		if (obj == null)
		{
			throw new InvalidOperationException("Expression is not for a property.");
		}
		return obj;
	}

	public static PropertyGetterDelegate<TProperty> GetGetter<TProperty>(Expression<Func<T, TProperty>> targetExpression)
	{
		PropertyInfo propertyInfo = GetPropertyInfo(targetExpression);
		return (PropertyGetterDelegate<TProperty>)_getterCache.GetOrAdd(propertyInfo.Name, (string s) => Delegate.CreateDelegate(typeof(PropertyGetterDelegate<TProperty>), propertyInfo.GetGetMethod()));
	}
}
