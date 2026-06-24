using System;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Orchard.Environment.Extensions;
using Orchard.Environment.Extensions.Models;
using Orchard.Mvc.Filters;
using Orchard.Security;

namespace Orchard.Mvc.AntiForgery;

public class AntiForgeryAuthorizationFilter : FilterProvider, IAuthorizationFilter
{
	private class HackHttpContext : HttpContextWrapper
	{
		private readonly HttpContextBase _originalHttpContextBase;

		private readonly HttpContext _originalHttpContext;

		private HttpRequestWrapper _request;

		public HttpContextBase OriginalHttpContextBase => _originalHttpContextBase;

		public override HttpRequestBase Request
		{
			get
			{
				if (_request == null)
				{
					_request = new HackHttpRequest(_originalHttpContext.Request);
				}
				return _request;
			}
		}

		public HackHttpContext(HttpContextBase httpContextBase, HttpContext httpContext)
			: base(httpContext)
		{
			_originalHttpContextBase = httpContextBase;
			_originalHttpContext = httpContext;
		}
	}

	private class HackHttpRequest : HttpRequestWrapper
	{
		private readonly HttpRequest _originalHttpRequest;

		private NameValueCollection _form;

		public override NameValueCollection Form
		{
			get
			{
				if (_form == null)
				{
					_form = new NameValueCollection(_originalHttpRequest.Form);
				}
				return _form;
			}
		}

		public HackHttpRequest(HttpRequest httpRequest)
			: base(httpRequest)
		{
			_originalHttpRequest = httpRequest;
		}

		public void AddFormValue(string key, string value)
		{
			Form.Add(key, value);
		}
	}

	private readonly IAuthenticationService _authenticationService;

	private readonly IExtensionManager _extensionManager;

	public AntiForgeryAuthorizationFilter(IAuthenticationService authenticationService, IExtensionManager extensionManager)
	{
		_authenticationService = authenticationService;
		_extensionManager = extensionManager;
	}

	public void OnAuthorization(AuthorizationContext filterContext)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (((!(((ControllerContext)filterContext).get_HttpContext().Request.HttpMethod != "POST") && _authenticationService.GetAuthenticatedUser() != null) || ShouldValidateGet(filterContext)) && IsAntiForgeryProtectionEnabled(filterContext))
		{
			new ValidateAntiForgeryTokenAttribute().OnAuthorization(filterContext);
			if (((ControllerContext)filterContext).get_HttpContext() is HackHttpContext)
			{
				((ControllerContext)filterContext).set_HttpContext(((HackHttpContext)((ControllerContext)filterContext).get_HttpContext()).OriginalHttpContextBase);
			}
		}
	}

	private bool IsAntiForgeryProtectionEnabled(AuthorizationContext context)
	{
		ValidateAntiForgeryTokenOrchardAttribute[] array = (ValidateAntiForgeryTokenOrchardAttribute[])context.get_ActionDescriptor().GetCustomAttributes(typeof(ValidateAntiForgeryTokenOrchardAttribute), false);
		if (array.Length != 0 && !array[0].Enabled)
		{
			return false;
		}
		string currentModule = GetArea(((ControllerContext)context).get_RouteData());
		if (!string.IsNullOrEmpty(currentModule))
		{
			return _extensionManager.AvailableExtensions().First((ExtensionDescriptor descriptor) => string.Equals(descriptor.Id, currentModule, StringComparison.OrdinalIgnoreCase)).AntiForgery.Equals("enabled", StringComparison.OrdinalIgnoreCase);
		}
		return false;
	}

	private static string GetArea(RouteData routeData)
	{
		if (routeData.Values.ContainsKey("area"))
		{
			return routeData.Values["area"] as string;
		}
		return (routeData.DataTokens["area"] as string) ?? "";
	}

	private static bool ShouldValidateGet(AuthorizationContext context)
	{
		ValidateAntiForgeryTokenOrchardAttribute[] array = (ValidateAntiForgeryTokenOrchardAttribute[])context.get_ActionDescriptor().GetCustomAttributes(typeof(ValidateAntiForgeryTokenOrchardAttribute), false);
		if (array.Length != 0 && array[0].Enabled)
		{
			if (!string.IsNullOrEmpty(((ControllerContext)context).get_HttpContext().Request.QueryString["__RequestVerificationToken"]))
			{
				((ControllerContext)context).set_HttpContext((HttpContextBase)new HackHttpContext(((ControllerContext)context).get_HttpContext(), (HttpContext)((ControllerContext)context).get_HttpContext().Items["originalHttpContext"]));
				((HackHttpRequest)((ControllerContext)context).get_HttpContext().Request).AddFormValue("__RequestVerificationToken", ((ControllerContext)context).get_HttpContext().Request.QueryString["__RequestVerificationToken"]);
			}
			return true;
		}
		return false;
	}
}
