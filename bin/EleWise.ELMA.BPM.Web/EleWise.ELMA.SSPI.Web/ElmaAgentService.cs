using System;
using System.ComponentModel;
using System.Web.Script.Services;
using System.Web.Services;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.SSPI.Web;

[WebService(Namespace = "http://elma.elewise.ru/", Description = "Веб сервис для работы Элма Агента с SSPI")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ToolboxItem(false)]
[ScriptService]
public class ElmaAgentService : WebService
{
	[WebMethod]
	public string AuthTicket()
	{
		TicketRequest ticketRequest = new TicketRequest
		{
			IdentityName = base.Context.Request.LogonUserIdentity.Name,
			UserAgent = "ElmaAgent",
			RemoteAddress = ((base.Context != null) ? base.Context.Request.UserHostAddress : null),
			CreateTime = DateTime.UtcNow.ToLocalTime()
		};
		return SspiTicketService.CreateSspiTicket(ticketRequest);
	}
}
