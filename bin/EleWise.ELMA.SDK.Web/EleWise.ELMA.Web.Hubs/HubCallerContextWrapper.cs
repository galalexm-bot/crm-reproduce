using System.Collections.Generic;
using System.Security.Principal;
using EleWise.ELMA.Hubs;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hosting;
using Microsoft.AspNet.SignalR.Hubs;

namespace EleWise.ELMA.Web.Hubs;

internal sealed class HubCallerContextWrapper : HubCallerContext, IHubCallerContextWrapper
{
	private readonly HubCallerContext hubCallerContext;

	private RequestWrapper requestWrapper;

	public override string ConnectionId => hubCallerContext.get_ConnectionId();

	public override IDictionary<string, Cookie> RequestCookies => hubCallerContext.get_RequestCookies();

	public override INameValueCollection Headers => hubCallerContext.get_Headers();

	public override INameValueCollection QueryString => hubCallerContext.get_QueryString();

	public override IPrincipal User => hubCallerContext.get_User();

	public override IRequest Request => hubCallerContext.get_Request();

	IDictionary<string, ICookieWrapper> IHubCallerContextWrapper.RequestCookies => GetRequest().Cookies;

	INameValueCollectionWrapper IHubCallerContextWrapper.Headers => GetRequest().Headers;

	INameValueCollectionWrapper IHubCallerContextWrapper.QueryString => GetRequest().QueryString;

	IPrincipal IHubCallerContextWrapper.User => GetRequest().User;

	IRequestWrapper IHubCallerContextWrapper.Request => GetRequest();

	public HubCallerContextWrapper(HubCallerContext hubCallerContext)
	{
		this.hubCallerContext = hubCallerContext;
	}

	private IRequestWrapper GetRequest()
	{
		if (requestWrapper != hubCallerContext.get_Request())
		{
			requestWrapper = new RequestWrapper(hubCallerContext.get_Request());
		}
		return requestWrapper;
	}
}
