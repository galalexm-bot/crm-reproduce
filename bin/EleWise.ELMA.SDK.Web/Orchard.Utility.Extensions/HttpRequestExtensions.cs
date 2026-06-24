using System;
using System.Web;

namespace Orchard.Utility.Extensions;

public static class HttpRequestExtensions
{
	public static string ToRootUrlString(this HttpRequestBase request)
	{
		return string.Format("{0}://{1}", request.UrlReferrer.Scheme, request.Headers["Host"]);
	}

	public static string ToRootUrlString(this HttpRequest request)
	{
		return string.Format("{0}://{1}", request.UrlReferrer.Scheme, request.Headers["Host"]);
	}

	public static string ToApplicationRootUrlString(this HttpRequestBase request)
	{
		return string.Format("{0}://{1}{2}", request.UrlReferrer.Scheme, request.Headers["Host"], (request.ApplicationPath == "/") ? string.Empty : request.ApplicationPath);
	}

	public static string ToApplicationRootUrlString(this HttpRequest request)
	{
		return string.Format("{0}://{1}{2}", request.UrlReferrer.Scheme, request.Headers["Host"], (request.ApplicationPath == "/") ? string.Empty : request.ApplicationPath);
	}

	public static string ToUrlString(this HttpRequestBase request)
	{
		return string.Format("{0}://{1}{2}", request.UrlReferrer.Scheme, request.Headers["Host"], request.RawUrl);
	}

	public static string ToUrlString(this HttpRequest request)
	{
		return string.Format("{0}://{1}{2}", request.UrlReferrer.Scheme, request.Headers["Host"], request.RawUrl);
	}

	public static bool IsLocalUrl(this HttpRequestBase request, string url)
	{
		if (string.IsNullOrWhiteSpace(url))
		{
			return false;
		}
		if (url.StartsWith("~/"))
		{
			return true;
		}
		if (url.StartsWith("//") || url.StartsWith("/\\"))
		{
			return false;
		}
		if (url.StartsWith("/"))
		{
			return true;
		}
		try
		{
			Uri uri = new Uri(url);
			if (uri.Authority.Equals(request.Headers["Host"], StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
			WorkContext workContext = request.RequestContext.GetWorkContext();
			if (workContext != null)
			{
				string baseUrl = workContext.CurrentSite.BaseUrl;
				if (!string.IsNullOrWhiteSpace(baseUrl) && uri.Authority.Equals(new Uri(baseUrl).Authority, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}
		catch
		{
			return false;
		}
	}
}
