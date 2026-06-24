using System;

namespace EleWise.ELMA.OAuth.Client.Web.Models;

public class OAuthSecurityActionsModel
{
	public bool OAuthExist { get; set; }

	public string ProviderName { get; set; }

	public Guid ProviderUid { get; set; }

	public string Icon { get; set; }
}
