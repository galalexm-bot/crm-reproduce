using System;
using System.Linq;
using System.Web;
using EleWise.ELMA.BPM.Web.Security.Code;
using EleWise.ELMA.BPM.Web.Security.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class UserTrustedDevicesModel
{
	public EleWise.ELMA.Security.Models.IUser User { get; set; }

	public bool IsCurrentUser { get; set; }

	public string CurrentToken { get; set; }

	public ICryptoProviderWebBase CryptoProvider { get; set; }

	public TrustedDeviceType? TrustedDeviceType { get; set; }

	public string TrustedDeviceValue { get; set; }

	[DisplayName(typeof(__Resources_UserTrustedDevicesModel), "P_LogonFromTrustedDevicesOnly_DisplayName")]
	public bool LogonFromTrustedDevicesOnly { get; set; }

	public UserTrustedDevicesModel()
	{
	}

	public UserTrustedDevicesModel(HttpContextBase context, EleWise.ELMA.Security.Models.IUser user, Guid cryptoProviderUid)
	{
		TrustedDeviceService serviceNotNull = Locator.GetServiceNotNull<TrustedDeviceService>();
		IAuthCryptoProviderWeb cryptoProvider = ComponentManager.Current.GetExtensionPoints<IAuthCryptoProviderWeb>().FirstOrDefault((IAuthCryptoProviderWeb p) => p.ProviderUid == cryptoProviderUid);
		User = user;
		LogonFromTrustedDevicesOnly = user != null && !user.IsNew() && serviceNotNull.TrustedLogonEnabled(user);
		CryptoProvider = cryptoProvider;
		EleWise.ELMA.Security.IUser currentUser = AuthenticationService.GetCurrentUser();
		if (user == currentUser)
		{
			string contextDeviceInfo = TrustedDeviceTokenHelper.GetContextDeviceInfo(context);
			string[] deviceTokens = serviceNotNull.GetDeviceTokens(contextDeviceInfo, currentUser);
			string contextDeviceToken = TrustedDeviceTokenHelper.GetContextDeviceToken(context, currentUser.UserName);
			CurrentToken = ((!string.IsNullOrEmpty(contextDeviceToken) && deviceTokens.Contains(contextDeviceToken)) ? contextDeviceToken : null);
			IsCurrentUser = true;
			TrustedDeviceTicketInfo trustedDeviceTicketInfo = context.GetTrustedDeviceTicketInfo();
			if (trustedDeviceTicketInfo != null)
			{
				TrustedDeviceType = trustedDeviceTicketInfo.Type;
				TrustedDeviceValue = trustedDeviceTicketInfo.Value;
			}
		}
	}
}
