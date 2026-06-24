using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Web;
using System.Web.Caching;
using System.Web.Hosting;
using System.Web.Instrumentation;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Orchard.Mvc.Extensions;
using Orchard.Mvc.Routes;
using Orchard.Settings;

namespace Orchard.Mvc;

public class MvcModule : Module
{
	public class HttpContextPlaceholder : HttpContextBase, IDisposable
	{
		private HttpContext _httpContext;

		private HttpRequestPlaceholder _request;

		private readonly Lazy<string> _baseUrl;

		private readonly IDictionary _items = new Dictionary<object, object>();

		public override HttpRequestBase Request
		{
			get
			{
				if (_httpContext == null)
				{
					HttpContext httpContext = new HttpContext(new HttpRequest("", _baseUrl.Value, ""), new HttpResponse(new StringWriter()));
					httpContext.Items["IsBackgroundHttpContext"] = true;
					_httpContext = httpContext;
				}
				if (HttpContext.Current != _httpContext)
				{
					HttpContext.Current = _httpContext;
				}
				if (_request == null)
				{
					_request = new HttpRequestPlaceholder(this, _baseUrl);
				}
				return _request;
			}
		}

		internal RequestContext RequestContext
		{
			get
			{
				if (_request == null)
				{
					_request = new HttpRequestPlaceholder(this, _baseUrl);
				}
				return _request.RequestContext;
			}
		}

		public override HttpSessionStateBase Session => new HttpSessionStatePlaceholder();

		public override IHttpHandler Handler { get; set; }

		public override HttpResponseBase Response => new HttpResponsePlaceholder();

		public override IDictionary Items => _items;

		public override PageInstrumentationService PageInstrumentation => new PageInstrumentationService();

		public override Cache Cache => HttpRuntime.Cache;

		public override HttpServerUtilityBase Server => new HttpServerUtilityPlaceholder();

		public HttpContextPlaceholder(Func<string> baseUrl)
		{
			_baseUrl = new Lazy<string>(baseUrl);
		}

		public void Dispose()
		{
			_httpContext = null;
			if (HttpContext.Current != null)
			{
				HttpContext.Current = null;
			}
		}

		public override object GetService(Type serviceType)
		{
			return null;
		}
	}

	public class HttpSessionStatePlaceholder : HttpSessionStateBase
	{
		public override object this[string name] => null;
	}

	public class HttpResponsePlaceholder : HttpResponseBase
	{
		public override HttpCookieCollection Cookies => new HttpCookieCollection();

		public override string ApplyAppPathModifier(string virtualPath)
		{
			return virtualPath;
		}
	}

	public class HttpRequestPlaceholder : HttpRequestBase
	{
		private HttpContextBase _httpContext;

		private RequestContext _requestContext;

		private readonly Lazy<string> _baseUrl;

		private readonly NameValueCollection _queryString = new NameValueCollection();

		private Uri _uri;

		public override RequestContext RequestContext
		{
			get
			{
				if (_requestContext == null)
				{
					_requestContext = new RequestContext(_httpContext, new RouteData());
				}
				return _requestContext;
			}
		}

		public override NameValueCollection QueryString => _queryString;

		public override string RawUrl => Url.OriginalString;

		public override bool IsAuthenticated => false;

		public override string AnonymousID => Guid.NewGuid().ToString("D", CultureInfo.InvariantCulture);

		public override NameValueCollection Form => new NameValueCollection();

		public override Uri Url
		{
			get
			{
				if (_uri == null)
				{
					_uri = new Uri(_baseUrl.Value);
				}
				return _uri;
			}
		}

		public override NameValueCollection Headers => new NameValueCollection { { "Host", Url.Authority } };

		public override string HttpMethod => "";

		public override NameValueCollection Params => new NameValueCollection();

		public override string AppRelativeCurrentExecutionFilePath => "~/";

		public override string ApplicationPath => Url.LocalPath;

		public override NameValueCollection ServerVariables => new NameValueCollection
		{
			{
				"SERVER_PORT",
				Url.Port.ToString(CultureInfo.InvariantCulture)
			},
			{
				"HTTP_HOST",
				Url.Authority.ToString(CultureInfo.InvariantCulture)
			}
		};

		public override HttpCookieCollection Cookies => new HttpCookieCollection();

		public override bool IsLocal => true;

		public override string Path => "/";

		public override string UserAgent => "Placeholder";

		public override string UserHostAddress => "127.0.0.1";

		public override string[] UserLanguages => new string[0];

		public override HttpBrowserCapabilitiesBase Browser => new HttpBrowserCapabilitiesPlaceholder();

		public HttpRequestPlaceholder(HttpContextBase httpContext, Lazy<string> baseUrl)
		{
			_httpContext = httpContext;
			_baseUrl = baseUrl;
		}
	}

	public class HttpBrowserCapabilitiesPlaceholder : HttpBrowserCapabilitiesBase
	{
		public override string this[string key] => "";

		public override bool IsMobileDevice => false;

		public override string Browser => "Placeholder";

		public override bool Cookies => true;

		public override ArrayList Browsers => new ArrayList();
	}

	public class HttpServerUtilityPlaceholder : HttpServerUtilityBase
	{
		public override int ScriptTimeout { get; set; }

		public override string MapPath(string path)
		{
			return HostingEnvironment.MapPath(path);
		}
	}

	public const string IsBackgroundHttpContextKey = "IsBackgroundHttpContext";

	protected override void Load(ContainerBuilder moduleBuilder)
	{
		RegistrationExtensions.RegisterType<ShellRoute>(moduleBuilder).InstancePerDependency();
		RegistrationExtensions.Register<HttpContextBase>(moduleBuilder, (Func<IComponentContext, HttpContextBase>)HttpContextBaseFactory).As<HttpContextBase>().InstancePerDependency();
		RegistrationExtensions.Register<RequestContext>(moduleBuilder, (Func<IComponentContext, RequestContext>)RequestContextFactory).As<RequestContext>().InstancePerDependency();
		RegistrationExtensions.Register<UrlHelper>(moduleBuilder, (Func<IComponentContext, UrlHelper>)UrlHelperFactory).As<UrlHelper>().InstancePerDependency();
	}

	private static HttpContextBase HttpContextBaseFactory(IComponentContext context)
	{
		HttpContextBase httpContextBase = ResolutionExtensions.Resolve<IHttpContextAccessor>(context).Current();
		if (httpContextBase != null)
		{
			return httpContextBase;
		}
		ISiteService siteService = ResolutionExtensions.Resolve<ISiteService>(context);
		return new HttpContextPlaceholder(delegate
		{
			string baseUrl = siteService.GetSiteSettings().BaseUrl;
			return string.IsNullOrWhiteSpace(baseUrl) ? ("http://localhost" + HostingEnvironment.ApplicationVirtualPath.TrimEnd('/')) : baseUrl;
		});
	}

	private static RequestContext RequestContextFactory(IComponentContext context)
	{
		HttpContextBase httpContextBase = HttpContextBaseFactory(context);
		if (!httpContextBase.IsBackgroundContext())
		{
			IHttpHandler handler = httpContextBase.Handler;
			MvcHandler val = (MvcHandler)((handler is MvcHandler) ? handler : null);
			if (val != null)
			{
				return val.get_RequestContext();
			}
			if (httpContextBase.Handler is IHasRequestContext hasRequestContext && hasRequestContext.RequestContext != null)
			{
				return hasRequestContext.RequestContext;
			}
		}
		else if (httpContextBase is HttpContextPlaceholder)
		{
			return ((HttpContextPlaceholder)httpContextBase).RequestContext;
		}
		return new RequestContext(httpContextBase, new RouteData());
	}

	private static UrlHelper UrlHelperFactory(IComponentContext context)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		return new UrlHelper(ResolutionExtensions.Resolve<RequestContext>(context), ResolutionExtensions.Resolve<RouteCollection>(context));
	}
}
