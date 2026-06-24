using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.BulkDataImport.Extensions;

internal static class TypeExtensions
{
	public static Type[] GetInterfacesCache(this Type type)
	{
		string name = "BulkDataImport_TypeInterfaces";
		Dictionary<Type, Type[]> orAdd = ContextVars.GetOrAdd(name, () => new Dictionary<Type, Type[]>());
		if (!orAdd.TryGetValue(type, out var value))
		{
			value = (orAdd[type] = type.GetInterfaces());
			ContextVars.Set(name, orAdd);
		}
		return value;
	}

	internal static string GetExpressionName<T, TProperty>(Expression<Func<T, TProperty>> f)
	{
		string name = "BulkDataImport_GetExpressionName";
		string value2;
		if (ContextVars.TryGetValue<Dictionary<object, string>>(name, out var value))
		{
			if (value.TryGetValue(f, out value2))
			{
				return value2;
			}
			value2 = LinqUtils.NameOf(f);
			value.Add(f, value2);
			ContextVars.Set(name, value);
			return value2;
		}
		value2 = LinqUtils.NameOf(f);
		value = new Dictionary<object, string> { { f, value2 } };
		ContextVars.Set(name, value);
		return value2;
	}
}
