using System;
using System.Collections.Specialized;
using System.Web;
using System.Web.Routing;

namespace EleWise.ELMA.Web.Mvc.Util;

public static class RouteUtils
{
	internal class RewritedHttpContextBase : HttpContextWrapper
	{
		internal class MockHttpRequestBase : HttpRequestWrapper
		{
			private readonly string _appRelativeUrl;

			private NameValueCollection _queryString;

			public override string AppRelativeCurrentExecutionFilePath
			{
				get
				{
					if (_appRelativeUrl.Contains("?"))
					{
						return _appRelativeUrl.Split(new string[1] { "?" }, StringSplitOptions.RemoveEmptyEntries)[0];
					}
					return _appRelativeUrl;
				}
			}

			public override string PathInfo => "";

			public override NameValueCollection QueryString
			{
				get
				{
					NameValueCollection obj = _queryString ?? HttpUtility.ParseQueryString(_appRelativeUrl.Substring(_appRelativeUrl.IndexOf("?") + 1));
					NameValueCollection result = obj;
					_queryString = obj;
					return result;
				}
			}

			public MockHttpRequestBase(string appRelativeUrl, HttpRequest requestBase)
				: base(requestBase)
			{
				_appRelativeUrl = appRelativeUrl;
			}
		}

		private readonly HttpRequestBase mockHttpRequestBase;

		public override HttpRequestBase Request => mockHttpRequestBase;

		public RewritedHttpContextBase(string appRelativeUrl, HttpContext baseContext = null)
			: base(baseContext ?? HttpContext.Current)
		{
			mockHttpRequestBase = new MockHttpRequestBase(appRelativeUrl, (baseContext != null) ? baseContext.Request : HttpContext.Current.Request);
		}
	}

	public static RouteData GetRouteDataByUrl(string url, bool addQueryData = true, bool replace = false)
	{
		RouteData routeData = RouteTable.Routes.GetRouteData(new RewritedHttpContextBase(url));
		if (addQueryData)
		{
			NameValueCollection queryStringValues = GetQueryStringValues(url);
			if (queryStringValues.Count > 0)
			{
				string[] allKeys = queryStringValues.AllKeys;
				foreach (string text in allKeys)
				{
					if (replace || !routeData.Values.ContainsKey(text))
					{
						routeData.Values[text] = queryStringValues[text];
					}
				}
			}
		}
		return routeData;
	}

	public static NameValueCollection GetQueryStringValues(string url)
	{
		if (string.IsNullOrEmpty(url))
		{
			return new NameValueCollection();
		}
		return HttpUtility.ParseQueryString(url.Substring(url.IndexOf("?") + 1));
	}
}
