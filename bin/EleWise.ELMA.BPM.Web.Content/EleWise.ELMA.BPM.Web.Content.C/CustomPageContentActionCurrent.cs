using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Content.Components;

[Component]
internal class CustomPageContentActionCurrentMatcher : IContentActionCurrentMatcher
{
	private const string CustomPageUriPart = "/ContentArea/Page/View";

	public int MatchCurrent(string area, ActionRoute routes, RequestContext requestContext)
	{
		if (routes.Area == "EleWise.ELMA.BPM.Web.Content" && routes.Controller == "Page" && routes.Action == "View")
		{
			if (routes.EqualsTo(requestContext.RouteData.Values))
			{
				return 9;
			}
			if (object.Equals(routes.Action, requestContext.RouteData.Values["action"]) && object.Equals(routes.Controller, requestContext.RouteData.Values["controller"]) && object.Equals(area, requestContext.RouteData.Values["area"]))
			{
				return 5;
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
		if (requestUri.AbsolutePath.Contains("/ContentArea/Page/View"))
		{
			if (requestUri.LocalPath == contentItemUri.LocalPath)
			{
				NameValueCollection contentItemCollection = HttpUtility.ParseQueryString(contentItemUri.Query);
				NameValueCollection requestCollection = HttpUtility.ParseQueryString(requestUri.Query);
				Dictionary<string, string> contentItemUriParameters = contentItemCollection.AllKeys.ToDictionary((string key) => key, (string key) => contentItemCollection.Get(key));
				Dictionary<string, string> requestUriParameters = requestCollection.AllKeys.ToDictionary((string key) => key, (string key) => requestCollection.Get(key));
				if (requestUriParameters.Count > 0 && contentItemUriParameters.Count == requestUriParameters.Count && !requestUriParameters.Except(contentItemUriParameters).Any())
				{
					return 10;
				}
				if (contentItemUriParameters.Intersect(requestUriParameters).Any())
				{
					if (!requestUriParameters.Keys.Any((string key) => contentItemUriParameters.ContainsKey(key) && contentItemUriParameters[key] != requestUriParameters[key]))
					{
						return 9;
					}
					return 8;
				}
			}
			else if (contentItemUri.AbsolutePath.Contains("/ContentArea/Page/View"))
			{
				return 5;
			}
		}
		return 0;
	}
}
