using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Routing;

namespace Orchard.Utility.Extensions;

public static class RouteValueDictionaryExtensions
{
	public static RouteValueDictionary Merge(this RouteValueDictionary dictionary, object values)
	{
		if (values != null)
		{
			return dictionary.Merge(new RouteValueDictionary(values));
		}
		return dictionary;
	}

	public static RouteValueDictionary Merge(this RouteValueDictionary dictionary, RouteValueDictionary dictionaryToMerge)
	{
		if (dictionaryToMerge == null)
		{
			return dictionary;
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary(dictionary);
		foreach (KeyValuePair<string, object> item in dictionaryToMerge)
		{
			routeValueDictionary[item.Key] = item.Value;
		}
		return routeValueDictionary;
	}

	public static bool Match(this RouteValueDictionary x, RouteValueDictionary y)
	{
		if (x == y)
		{
			return true;
		}
		if (x == null || y == null)
		{
			return false;
		}
		if (x.Count != y.Count)
		{
			return false;
		}
		bool[] source = (from kv1 in x
			join kv2 in y on kv1.Key.ToLowerInvariant() equals kv2.Key.ToLowerInvariant()
			select StringMatch(kv1.Value, kv2.Value)).ToArray();
		if (source.All((bool b) => b))
		{
			return source.Count() == x.Count;
		}
		return false;
	}

	private static bool StringMatch(object value1, object value2)
	{
		return string.Equals(Convert.ToString(value1, CultureInfo.InvariantCulture), Convert.ToString(value2, CultureInfo.InvariantCulture), StringComparison.InvariantCultureIgnoreCase);
	}

	public static RouteValueDictionary ToRouteValueDictionary(this IEnumerable<KeyValuePair<string, string>> routeValues)
	{
		if (routeValues == null)
		{
			return null;
		}
		RouteValueDictionary routeValueDictionary = new RouteValueDictionary();
		foreach (KeyValuePair<string, string> routeValue in routeValues)
		{
			if (routeValue.Key.EndsWith("-"))
			{
				routeValueDictionary.Add(routeValue.Key.Substring(0, routeValue.Key.Length - 1), routeValue.Value);
			}
			else
			{
				routeValueDictionary.Add(routeValue.Key, routeValue.Value);
			}
		}
		return routeValueDictionary;
	}
}
