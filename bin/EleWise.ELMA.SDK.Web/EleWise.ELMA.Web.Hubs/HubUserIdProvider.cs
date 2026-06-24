using System;
using EleWise.ELMA.Web.Service.v1;
using Microsoft.AspNet.SignalR;

namespace EleWise.ELMA.Web.Hubs;

internal class HubUserIdProvider : IUserIdProvider
{
	private readonly AuthorizationService authorizationService;

	public HubUserIdProvider(AuthorizationService authorizationService)
	{
		this.authorizationService = authorizationService;
	}

	public string GetUserId(IRequest request)
	{
		string text = request.get_Headers().Get("AuthToken");
		if (!string.IsNullOrWhiteSpace(text))
		{
			if (!Guid.TryParse(text, out var result))
			{
				return "";
			}
			return authorizationService.CheckToken(result).CurrentUserName;
		}
		if (!request.get_User().Identity.IsAuthenticated || string.IsNullOrWhiteSpace(request.get_User().Identity.Name))
		{
			return "";
		}
		return request.get_User().Identity.Name;
	}
}
