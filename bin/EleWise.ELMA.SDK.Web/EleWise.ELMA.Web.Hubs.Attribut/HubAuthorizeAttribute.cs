using System;
using System.Linq;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class HubAuthorizeAttribute : AuthorizeAttribute
{
	public override bool AuthorizeHubConnection(HubDescriptor hubDescriptor, IRequest request)
	{
		if (((AuthorizeAttribute)this).AuthorizeHubConnection(hubDescriptor, request))
		{
			return AuthorizeCore(HttpContextAccessor.CurrentContext);
		}
		return false;
	}

	public override bool AuthorizeHubMethodInvocation(IHubIncomingInvokerContext hubIncomingInvokerContext, bool appliesToMethod)
	{
		if (((AuthorizeAttribute)this).AuthorizeHubMethodInvocation(hubIncomingInvokerContext, appliesToMethod))
		{
			return AuthorizeCore(HttpContextAccessor.CurrentContext);
		}
		return false;
	}

	private bool AuthorizeCore(HttpContextBase httpContext, bool skipUserAuthenticationChecker = false)
	{
		IAuthenticationService service = Locator.GetService<IAuthenticationService>();
		if (service == null)
		{
			return false;
		}
		IUser user = service.GetCurrentUser();
		if (user == null)
		{
			service.SignOut();
			return false;
		}
		if (skipUserAuthenticationChecker)
		{
			service.SetAuthenticatedUserForRequest(user);
			if (DiagnosticsManager.Initialized)
			{
				DiagnosticsManager.Instance.WebRequestAuthorized(user);
			}
			return true;
		}
		IUserAuthenticationChecker[] source = ComponentManager.Current.GetExtensionPoints<IUserAuthenticationChecker>(useCache: true).ToArray();
		if (source.Any())
		{
			if (source.All((IUserAuthenticationChecker p) => p.Check(httpContext, user)))
			{
				service.SetAuthenticatedUserForRequest(user);
				if (DiagnosticsManager.Initialized)
				{
					DiagnosticsManager.Instance.WebRequestAuthorized(user);
				}
				return true;
			}
			service.SignOut();
			return false;
		}
		service.SetAuthenticatedUserForRequest(user);
		if (DiagnosticsManager.Initialized)
		{
			DiagnosticsManager.Instance.WebRequestAuthorized(user);
		}
		return true;
	}
}
