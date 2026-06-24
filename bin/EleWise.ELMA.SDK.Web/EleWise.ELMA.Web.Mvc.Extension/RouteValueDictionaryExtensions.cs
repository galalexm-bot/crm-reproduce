using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;

namespace EleWise.ELMA.Web.Mvc.Extensions;

public static class RouteValueDictionaryExtensions
{
	public static bool EqualsTo(this RouteValueDictionary self, RouteValueDictionary target)
	{
		if (self == target)
		{
			return true;
		}
		if (self == null || target == null)
		{
			return false;
		}
		if (CompareByKeys(self, target))
		{
			return CompareByKeys(target, self);
		}
		return false;
	}

	public static string AsText(this RouteValueDictionary self)
	{
		if (self == null)
		{
			return null;
		}
		return "{" + string.Join(", ", self.Select((KeyValuePair<string, object> p) => p.Key + " " + p.Value).ToArray()) + "}";
	}

	private static bool CompareByKeys(RouteValueDictionary self, RouteValueDictionary target)
	{
		return self.All((KeyValuePair<string, object> x) => object.Equals(x.Value.SafeToString(), target[x.Key].SafeToString()));
	}

	public static string GetAreaName(Type controllerType)
	{
		if (!controllerType.Namespace.EndsWith(".Controllers"))
		{
			throw new InvalidOperationException(SR.T("Не удалось определить area для контроллера, потому что пространство имен не содержит слово \"Controllers\""));
		}
		return controllerType.Namespace.Substring(0, controllerType.Namespace.Length - ".Controllers".Length);
	}
}
