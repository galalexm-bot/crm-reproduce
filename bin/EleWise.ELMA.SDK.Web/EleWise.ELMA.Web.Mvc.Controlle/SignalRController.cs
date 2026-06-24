using System;
using System.Web.Mvc;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Hubs.Services;
using EleWise.ELMA.Web.Mvc.Attributes;

namespace EleWise.ELMA.Web.Mvc.Controllers;

public class SignalRController : BaseController
{
	private IAgentHubConnectionService agentHubConnectionService;

	private IAgentHubConnectionService AgentHubConnectionService => agentHubConnectionService ?? (agentHubConnectionService = Locator.GetServiceNotNull<IAgentHubConnectionService>());

	public ActionResult IsAgentConnected()
	{
		IUser currentUser = base.AuthenticationService.GetCurrentUser();
		if (currentUser == null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false
			}, (JsonRequestBehavior)0);
		}
		bool isOnline = AgentHubConnectionService.IsConnected(currentUser.UserName);
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true,
			userId = currentUser.GetId(),
			userName = currentUser.UserName,
			isOnline = isOnline
		}, (JsonRequestBehavior)0);
	}

	[AuthenticationFilter(NotRequired = true)]
	[Obsolete("Метод устарел и больше не используется", false)]
	public ActionResult GetAgentConnectionPort()
	{
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = false,
			errorMessage = SR.T("Метод устарел и больше не используется")
		}, (JsonRequestBehavior)0);
	}
}
