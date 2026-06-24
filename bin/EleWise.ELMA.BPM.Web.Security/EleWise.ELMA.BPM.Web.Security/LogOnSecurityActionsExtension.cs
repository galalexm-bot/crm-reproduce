using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Security.Code;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component]
public class LogOnSecurityActionsExtension : IUserProfileSecurityActionsExtension
{
	public SecuritySettingsModule Module { get; set; }

	public TrustedDeviceService TrustedDeviceService { get; set; }

	public AuthCryptoProviderService AuthCryptoProviderService { get; set; }

	public IEnumerable<IAuthCryptoProviderWeb> AuthCryptoProviders { get; set; }

	public AuthCryptoAction AuthCryptoAction { get; set; }

	public MvcHtmlString Render(HtmlHelper html)
	{
		if (!(html.get_ViewData().get_Model() is UserSecurityActionsModel userSecurityActionsModel))
		{
			return MvcHtmlString.Empty;
		}
		if (!AuthCryptoAction.HasPermission(userSecurityActionsModel.User))
		{
			return MvcHtmlString.Empty;
		}
		SecuritySettings settings = Module.Settings;
		string contextDeviceToken = TrustedDeviceTokenHelper.GetContextDeviceToken(((ControllerContext)html.get_ViewContext()).get_HttpContext(), userSecurityActionsModel.User.UserName);
		string[] deviceTokens = TrustedDeviceService.GetDeviceTokens(TrustedDeviceTokenHelper.GetContextDeviceInfo(((ControllerContext)html.get_ViewContext()).get_HttpContext()), userSecurityActionsModel.User);
		Guid providerUid = AuthCryptoProviderService.GetUserProviderUid(userSecurityActionsModel.User);
		return PartialExtensions.Partial(html, "Editors/LogOnSecurityActions", (object)new LogOnSecurityActionsModel
		{
			User = userSecurityActionsModel.User,
			IsCurrentUser = userSecurityActionsModel.IsCurrentUser,
			AllowLoginByCertificate = settings.AllowLoginByCertificate,
			AllowLoginByToken = settings.AllowLoginByToken,
			CurrentToken = (deviceTokens.Contains(contextDeviceToken) ? contextDeviceToken : null),
			TrustedLogonEnabled = TrustedDeviceService.TrustedLogonEnabled(userSecurityActionsModel.User),
			CryptoProvider = AuthCryptoProviders.FirstOrDefault((IAuthCryptoProviderWeb p) => p.ProviderUid == providerUid),
			CryptoProviders = AuthCryptoProviders,
			SelectedCryptoProviderUid = AuthCryptoProviderService.GetUserProviderUid(userSecurityActionsModel.User, onlyProfile: true),
			DefaultCryptoProviderUid = AuthCryptoProviderService.DefaultProviderUid,
			SelectedDigitalSignatureTypeUid = AuthCryptoProviderService.GetUserDigitalSignatureTypeUid(userSecurityActionsModel.User, onlyProfile: true),
			DefaultDigitalSignatureTypeUid = AuthCryptoProviderService.DefaultDigitalSignatureTypeUid,
			DigitalSignatureTypes = AuthCryptoProviderService.GetDigitalSignatureTypes()
		});
	}
}
