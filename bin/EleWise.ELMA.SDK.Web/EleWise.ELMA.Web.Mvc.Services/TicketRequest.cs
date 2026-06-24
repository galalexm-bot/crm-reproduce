using System;

namespace EleWise.ELMA.Web.Mvc.Services;

public class TicketRequest
{
	public string IdentityName { get; set; }

	public string UserAgent { get; set; }

	public string RemoteAddress { get; set; }

	public DateTime CreateTime { get; set; }
}
