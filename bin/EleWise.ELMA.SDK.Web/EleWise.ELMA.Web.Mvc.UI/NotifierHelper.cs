using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Web.Mvc.UI;

public static class NotifierHelper
{
	public static string WrapHtmlAction(string action, string controller, RouteValueDictionary routeValues)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		dictionary["Action"] = action;
		dictionary["Controller"] = controller;
		dictionary["RouteValues"] = routeValues?.ToDictionary((KeyValuePair<string, object> p) => p.Key, (KeyValuePair<string, object> p) => p.Value);
		return new JsonSerializer().Serialize(dictionary);
	}

	public static void UnwrapHtmlAction(string json, out string action, out string controller, out RouteValueDictionary routeValues)
	{
		Dictionary<string, object> dictionary = (Dictionary<string, object>)new JsonSerializer().Deserialize(json, typeof(Dictionary<string, object>));
		IDictionary<string, object> dictionary2 = dictionary["RouteValues"] as IDictionary<string, object>;
		routeValues = ((dictionary2 != null) ? new RouteValueDictionary(dictionary2) : null);
		action = (string)dictionary["Action"];
		controller = (string)dictionary["Controller"];
	}
}
