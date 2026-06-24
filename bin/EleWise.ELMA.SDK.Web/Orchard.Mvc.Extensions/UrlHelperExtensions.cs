using System;
using System.Web.Mvc;
using Orchard.Utility.Extensions;

namespace Orchard.Mvc.Extensions;

public static class UrlHelperExtensions
{
	public static string AbsoluteAction(this UrlHelper urlHelper, Func<string> urlAction)
	{
		return urlHelper.MakeAbsolute(urlAction());
	}

	public static string AbsoluteAction(this UrlHelper urlHelper, string actionName)
	{
		return urlHelper.MakeAbsolute(urlHelper.Action(actionName));
	}

	public static string AbsoluteAction(this UrlHelper urlHelper, string actionName, object routeValues)
	{
		return urlHelper.MakeAbsolute(urlHelper.Action(actionName, routeValues));
	}

	public static string AbsoluteAction(this UrlHelper urlHelper, string actionName, string controller)
	{
		return urlHelper.MakeAbsolute(urlHelper.Action(actionName, controller));
	}

	public static string AbsoluteAction(this UrlHelper urlHelper, string actionName, string controller, object routeValues)
	{
		return urlHelper.MakeAbsolute(urlHelper.Action(actionName, controller, routeValues));
	}

	public static string MakeAbsolute(this UrlHelper urlHelper, string url, string baseUrl = null)
	{
		if (url != null && url.StartsWith("http", StringComparison.OrdinalIgnoreCase))
		{
			return url;
		}
		if (string.IsNullOrEmpty(baseUrl))
		{
			baseUrl = urlHelper.get_RequestContext().GetWorkContext().CurrentSite.BaseUrl;
			if (string.IsNullOrWhiteSpace(baseUrl))
			{
				baseUrl = urlHelper.get_RequestContext().HttpContext.Request.ToApplicationRootUrlString();
			}
		}
		if (string.IsNullOrEmpty(url))
		{
			return baseUrl;
		}
		string text = urlHelper.get_RequestContext().HttpContext.Request.ApplicationPath ?? string.Empty;
		if (url.StartsWith("~/", StringComparison.OrdinalIgnoreCase))
		{
			url = url.Substring(1);
		}
		if (!url.StartsWith("/"))
		{
			url = "/" + url;
		}
		if (url.StartsWith(text, StringComparison.OrdinalIgnoreCase))
		{
			url = url.Substring(text.Length);
		}
		baseUrl = baseUrl.TrimEnd('/');
		url = url.TrimStart('/');
		return baseUrl + "/" + url;
	}
}
