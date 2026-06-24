using System;
using System.Collections;
using System.Web;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class HttpContextExtensions
{
	public static void UpdateItem<T>(this HttpContext httpContext, string key, T val)
	{
		UpdateItem(httpContext?.Items, key, val);
	}

	public static void UpdateItem<T>(this HttpContextBase httpContext, string key, T val)
	{
		UpdateItem(httpContext?.Items, key, val);
	}

	public static T GetOrAddItem<T>(this HttpContext httpContext, string key, Func<T> val)
	{
		return GetOrAddItem(httpContext?.Items, key, val);
	}

	public static T GetOrAddItem<T>(this HttpContextBase httpContext, string key, Func<T> val)
	{
		return GetOrAddItem(httpContext?.Items, key, val);
	}

	private static void UpdateItem<T>(IDictionary items, string key, T val)
	{
		if (items != null)
		{
			items[key] = val;
		}
	}

	private static T GetOrAddItem<T>(IDictionary items, string key, Func<T> val)
	{
		if (items == null)
		{
			return val();
		}
		if (items.Contains(key))
		{
			return (T)items[key];
		}
		T val2 = val();
		items[key] = val2;
		return val2;
	}
}
