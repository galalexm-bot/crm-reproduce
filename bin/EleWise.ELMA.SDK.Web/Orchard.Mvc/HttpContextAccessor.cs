using System;
using System.Web;
using Autofac;

namespace Orchard.Mvc;

public class HttpContextAccessor : IHttpContextAccessor
{
	private readonly ILifetimeScope _lifetimeScope;

	private HttpContextBase _httpContext;

	private IWorkContextAccessor _wca;

	public HttpContextAccessor(ILifetimeScope lifetimeScope)
	{
		_lifetimeScope = lifetimeScope;
	}

	public HttpContextBase Current()
	{
		HttpContext staticProperty = GetStaticProperty();
		if (!IsBackgroundHttpContext(staticProperty))
		{
			return new HttpContextWrapper(staticProperty);
		}
		if (_httpContext != null)
		{
			return _httpContext;
		}
		if (_wca == null && ResolutionExtensions.IsRegistered<IWorkContextAccessor>((IComponentContext)(object)_lifetimeScope))
		{
			_wca = ResolutionExtensions.Resolve<IWorkContextAccessor>((IComponentContext)(object)_lifetimeScope);
		}
		return ((_wca != null) ? _wca.GetLogicalContext() : null)?.HttpContext;
	}

	public void Set(HttpContextBase httpContext)
	{
		_httpContext = httpContext;
	}

	internal static bool IsBackgroundHttpContext(HttpContext httpContext)
	{
		return httpContext?.Items.Contains("IsBackgroundHttpContext") ?? true;
	}

	private static HttpContext GetStaticProperty()
	{
		HttpContext current = HttpContext.Current;
		if (current == null)
		{
			return null;
		}
		try
		{
			if (current.Request == null)
			{
				return null;
			}
			return current;
		}
		catch (Exception)
		{
			return null;
		}
	}
}
