using System;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class PublicSessionAuthorizeAttribute : AuthorizeAttribute
{
	public override bool AuthorizeHubConnection(HubDescriptor hubDescriptor, IRequest request)
	{
		return AuthorizeCore(request);
	}

	public override bool AuthorizeHubMethodInvocation(IHubIncomingInvokerContext hubIncomingInvokerContext, bool appliesToMethod)
	{
		IRequest request = hubIncomingInvokerContext.get_Hub().get_Context().get_Request();
		return AuthorizeCore(request);
	}

	private bool AuthorizeCore(IRequest request)
	{
		IPublicClientService serviceNotNull = Locator.GetServiceNotNull<IPublicClientService>();
		string text = request.get_Headers().Get("AuthToken");
		if (string.IsNullOrEmpty(text) || !Guid.TryParse(text, out var result))
		{
			return false;
		}
		IPublicClientSession session = serviceNotNull.GetSession(result);
		if (session == null || !serviceNotNull.IsSessionValid(session.SessionToken, out session))
		{
			return false;
		}
		Locator.GetService<IAuthenticationService>().SetAuthenticatedUserForRequest(session.AuthUser);
		if (DiagnosticsManager.Initialized)
		{
			DiagnosticsManager.Instance.WebRequestAuthorized(session.AuthUser);
		}
		serviceNotNull.PromoteSession(session.SessionToken);
		return true;
	}
}
