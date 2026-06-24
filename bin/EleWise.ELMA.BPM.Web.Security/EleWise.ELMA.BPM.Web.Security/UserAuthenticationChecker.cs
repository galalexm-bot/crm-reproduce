using System.Web;
using EleWise.ELMA.BPM.Web.Security.Code;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Security.Components;

[Component]
public class UserAuthenticationChecker : IUserAuthenticationChecker
{
	private ITrustedDeviceService TrustedDeviceService => Locator.GetServiceNotNull<ITrustedDeviceService>();

	public bool Check(HttpContextBase httpContext, EleWise.ELMA.Security.IUser user)
	{
		TrustedDeviceTicketInfo trustedDeviceTicketInfo = httpContext.GetTrustedDeviceTicketInfo();
		if (trustedDeviceTicketInfo == null)
		{
			string contextDeviceInfo = TrustedDeviceTokenHelper.GetContextDeviceInfo(httpContext);
			string contextDeviceToken = TrustedDeviceTokenHelper.GetContextDeviceToken(httpContext, user.UserName);
			if (!TrustedDeviceService.CheckDevice(contextDeviceToken, contextDeviceInfo, user))
			{
				return false;
			}
		}
		else
		{
			switch (trustedDeviceTicketInfo.Type)
			{
			case TrustedDeviceType.Certificate:
			{
				string value2 = trustedDeviceTicketInfo.Value;
				if (UserCertificateManager.Instance.GetCertificatesByThumbprintAndAction(user, value2, AuthCryptoAction.UID) == null)
				{
					return false;
				}
				break;
			}
			case TrustedDeviceType.Token:
			{
				string value = trustedDeviceTicketInfo.Value;
				if (UserPublicKeyTokenManager.Instance.GetTokenByPublicKey(user, value) == null)
				{
					return false;
				}
				break;
			}
			default:
				return false;
			}
		}
		return true;
	}
}
