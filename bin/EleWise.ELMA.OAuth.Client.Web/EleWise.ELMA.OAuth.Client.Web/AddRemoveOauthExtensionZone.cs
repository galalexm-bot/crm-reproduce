using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.OAuth.Client.Services;
using EleWise.ELMA.OAuth.Client.Web.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.OAuth.Client.Web.Components;

[Component(Order = -20)]
public class AddRemoveOauthExtensionZone : IExtensionZone
{
	public const string ZoneId = "EleWise.ELMA.BPM.Web.Security.User.SecurityActions";

	private readonly IEnumerable<IOAuthProvider> oAuthProviders;

	public AddRemoveOauthExtensionZone(IEnumerable<IOAuthProvider> oAuthProviders)
	{
		this.oAuthProviders = oAuthProviders;
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return "EleWise.ELMA.BPM.Web.Security.User.SecurityActions" == zoneId;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (!("EleWise.ELMA.BPM.Web.Security.User.SecurityActions" == zoneId) || !(html.get_ViewData().get_Model() is LogOnSecurityActionsModel logOnSecurityActionsModel) || logOnSecurityActionsModel.User == null)
		{
			return;
		}
		EleWise.ELMA.Security.Models.IUser user = logOnSecurityActionsModel.User.CastAsRealType();
		if (user == null)
		{
			return;
		}
		EleWise.ELMA.Security.IUser currentUser = AuthenticationService.GetCurrentUser();
		if (currentUser == null || user.Id != (long)currentUser.GetId() || oAuthProviders.Count() <= 0)
		{
			return;
		}
		List<OAuthSecurityActionsModel> list = new List<OAuthSecurityActionsModel>();
		foreach (IOAuthProvider oAuthProvider in oAuthProviders)
		{
			if (oAuthProvider.OAuthAccepted(user))
			{
				list.Add(new OAuthSecurityActionsModel
				{
					ProviderName = oAuthProvider.ProviderName,
					ProviderUid = oAuthProvider.ProviderUid,
					OAuthExist = oAuthProvider.OAuthExist(user),
					Icon = oAuthProvider.Icon16
				});
			}
		}
		RenderPartialExtensions.RenderPartial(html, "AddRemoveOauthExtensionZone", (object)list);
	}
}
