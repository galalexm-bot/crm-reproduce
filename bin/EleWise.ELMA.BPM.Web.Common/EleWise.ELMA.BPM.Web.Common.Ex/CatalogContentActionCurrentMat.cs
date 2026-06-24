using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

[Component]
internal class CatalogContentActionCurrentMatcher : IContentActionCurrentMatcher
{
	public int MatchCurrent(string area, ActionRoute routes, RequestContext requestContext)
	{
		if (routes.Area == "EleWise.ELMA.BPM.Web.Common" && routes.Controller == "Catalogs")
		{
			if (routes.EqualsTo(requestContext.RouteData.Values))
			{
				return 9;
			}
			if (object.Equals(routes.Action, requestContext.RouteData.Values["action"]) && object.Equals(routes.Controller, requestContext.RouteData.Values["controller"]) && object.Equals(area, requestContext.RouteData.Values["area"]))
			{
				return 8;
			}
			if (object.Equals(routes.Controller, requestContext.RouteData.Values["controller"]) && object.Equals(area, requestContext.RouteData.Values["area"]))
			{
				return 6;
			}
			if (object.Equals(area, requestContext.RouteData.Values["area"]))
			{
				return 4;
			}
		}
		return 0;
	}

	public int MatchCurrent(Uri contentItemUri, Uri requestUri)
	{
		if (requestUri.AbsolutePath.Contains("/Common/Catalogs"))
		{
			Dictionary<string, string> contentItemUriParameters = new Dictionary<string, string>();
			Dictionary<string, string> requestUriParameters = new Dictionary<string, string>();
			NameValueCollection nameValueCollection = HttpUtility.ParseQueryString(contentItemUri.Query);
			NameValueCollection nameValueCollection2 = HttpUtility.ParseQueryString(requestUri.Query);
			string[] allKeys = nameValueCollection.AllKeys;
			foreach (string text in allKeys)
			{
				contentItemUriParameters.Add(text, nameValueCollection.Get(text));
			}
			allKeys = nameValueCollection2.AllKeys;
			foreach (string text2 in allKeys)
			{
				requestUriParameters.Add(text2, nameValueCollection2.Get(text2));
			}
			if (requestUriParameters["uid"] == contentItemUriParameters["uid"])
			{
				if (!requestUriParameters.Keys.Any((string key) => contentItemUriParameters.ContainsKey(key) && contentItemUriParameters[key] != requestUriParameters[key]))
				{
					return 9;
				}
				return 8;
			}
			if (contentItemUri.AbsolutePath.Contains("/Common/Catalogs"))
			{
				return 5;
			}
		}
		return 0;
	}
}
