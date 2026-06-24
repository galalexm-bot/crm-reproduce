using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Security.Code;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Constants;
using EleWise.ELMA.Logging;
using EleWise.ELMA.OAuth.Client.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using Orchard.Themes;

namespace EleWise.ELMA.OAuth.Client.Web.Controllers;

public class OAuthClientController : BaseController
{
	private readonly ITrustedDeviceService trustedDeviceService;

	private readonly IAuthenticationService authenticationService;

	private readonly IEnumerable<IOAuthProvider> oAuthProvider;

	private readonly IOAuthService oAuthService;

	public OAuthClientController(IAuthenticationService authenticationService, ITrustedDeviceService trustedDeviceService, IEnumerable<IOAuthProvider> oAuthProvider, IOAuthService oAuthService)
	{
		this.authenticationService = authenticationService;
		this.trustedDeviceService = trustedDeviceService;
		this.oAuthProvider = oAuthProvider;
		this.oAuthService = oAuthService;
	}

	[Themed(false)]
	[AuthenticationFilter(NotRequired = true)]
	public ActionResult LogOn(Guid providerUid, string returnUrl)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		IOAuthProvider iOAuthProvider = oAuthProvider.FirstOrDefault((IOAuthProvider a) => providerUid.Equals(a.ProviderUid));
		if (iOAuthProvider != null)
		{
			return (ActionResult)new RedirectResult(iOAuthProvider.LogOn(this, returnUrl));
		}
		if (!string.IsNullOrWhiteSpace(returnUrl))
		{
			return (ActionResult)new RedirectResult(returnUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn", "Account", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security"
		});
	}

	[Themed(false)]
	[AuthenticationFilter(NotRequired = true)]
	public ActionResult LogOnResponse(string returnUrl)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		IOAuthProvider iOAuthProvider = OAuthProvider(null);
		if (iOAuthProvider != null)
		{
			string text = iOAuthProvider.LogOnResponse(this, returnUrl);
			if (text != null)
			{
				return LogOnInnerLogic(text, iOAuthProvider.ProviderUid, rememberMe: true, returnUrl);
			}
		}
		if (!string.IsNullOrWhiteSpace(returnUrl))
		{
			return (ActionResult)new RedirectResult(returnUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn", "Account", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security"
		});
	}

	public ActionResult AddOAuth(Guid providerUid)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		Contract.ArgumentNotNull(providerUid, "providerUid");
		EleWise.ELMA.Security.Models.IUser currentUser = UserManager.Instance.GetCurrentUser();
		if (currentUser != null)
		{
			IOAuthProvider iOAuthProvider = OAuthProvider(providerUid);
			if (iOAuthProvider != null)
			{
				string text = iOAuthProvider.AddOAuth(this, currentUser);
				if (!string.IsNullOrWhiteSpace(text))
				{
					return (ActionResult)new RedirectResult(text);
				}
			}
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("CurrentProfile", "User", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security"
		});
	}

	public ActionResult AddOAuthResponse()
	{
		OAuthProvider(null)?.AddOAuthResponse(this);
		return (ActionResult)(object)((Controller)this).RedirectToAction("CurrentProfile", "User", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security"
		});
	}

	public ActionResult RemoveOAuth(Guid providerUid)
	{
		Contract.ArgumentNotNull(providerUid, "providerUid");
		EleWise.ELMA.Security.Models.IUser currentUser = UserManager.Instance.GetCurrentUser();
		if (currentUser != null)
		{
			OAuthProvider(providerUid)?.RemoveOAuth(currentUser);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true
		});
	}

	private ActionResult LogOnInnerLogic(string token, Guid providerUid, bool rememberMe = true, string returnUrl = null, int? demo = null, int? free = null)
	{
		((Controller)this).get_Session().Clear();
		if (!((Controller)this).get_ModelState().get_IsValid())
		{
			return (ActionResult)(object)((Controller)this).View("LogOn", "Account", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Security"
			});
		}
		EleWise.ELMA.Security.IUser user = null;
		try
		{
			user = oAuthService.ValidateUser(token, providerUid);
		}
		catch (Exception exception)
		{
			base.Logger.Error(LicensingConstants.AuthFailed, exception);
			((Controller)this).get_Session()["ErrorMessage"] = LicensingConstants.NoTokenUser;
			return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn", "Account", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Security"
			});
		}
		if (user == null)
		{
			((Controller)this).get_Session()["ErrorMessage"] = LicensingConstants.NoTokenUser;
			return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn", "Account", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Security"
			});
		}
		string contextDeviceToken = TrustedDeviceTokenHelper.GetContextDeviceToken(((Controller)this).get_HttpContext(), user.UserName);
		string contextDeviceInfo = TrustedDeviceTokenHelper.GetContextDeviceInfo(((Controller)this).get_HttpContext());
		if (!trustedDeviceService.CheckDevice(contextDeviceToken, contextDeviceInfo, user))
		{
			((Controller)this).get_Session()["ErrorMessage"] = SR.NoTrueLogin;
			base.Logger.ErrorFormat("Authentication failed from Not trusted device. User: {0}; DeviceInfo: {1}", user.UserName, contextDeviceInfo);
			return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn", "Account", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Security"
			});
		}
		string value = LicensingConstants.DefaultErrorMessage;
		try
		{
			authenticationService.SignIn(user, rememberMe);
			return ((Controller)(object)this).RedirectLocal(returnUrl);
		}
		catch (LicenseActivationRequiredException exception2)
		{
			base.Logger.Error(LicensingConstants.AuthFailed, exception2);
			value = LicensingConstants.ActivationRequired;
		}
		catch (LicenseWorkplaceExceededException exception3)
		{
			base.Logger.Error(LicensingConstants.AuthFailed, exception3);
			value = LicensingConstants.WorkplaceExceeded;
		}
		catch (LicenseExpiredException exception4)
		{
			base.Logger.Error(LicensingConstants.AuthFailed, exception4);
			value = LicensingConstants.LicenseExpired;
		}
		catch (SimultaneousSessionExceededException ex)
		{
			base.Logger.Error(LicensingConstants.AuthFailed, ex);
			((Controller)this).get_Session()["SimultaneousSessionExceededException-UserId"] = ((ex.User != null) ? ex.User.GetId() : null);
			return (ActionResult)(object)((Controller)this).RedirectToAction("DemoActiveSessions");
		}
		catch (ConcurrentLicenseExceededException ex2)
		{
			base.Logger.Error(LicensingConstants.AuthFailed, ex2);
			value = ex2.Message;
		}
		catch (LicenseException exception5)
		{
			base.Logger.Error(LicensingConstants.AuthFailed, exception5);
			value = LicensingConstants.LicenseExceptionMessage;
		}
		catch (RequireChangePasswordException ex3)
		{
			base.Logger.Error(LicensingConstants.AuthFailed, ex3);
			return (ActionResult)(object)((Controller)this).RedirectToAction("ChangePassword", (object)new
			{
				login = ex3.User.UserName
			});
		}
		catch (AuthenticationException ex4)
		{
			base.Logger.Error(LicensingConstants.AuthFailed, ex4);
			value = ex4.Message;
		}
		catch (Exception exception6)
		{
			base.Logger.Error(LicensingConstants.AuthFailed, exception6);
		}
		((Controller)this).get_Session()["ErrorMessage"] = value;
		return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn", "Account", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Security"
		});
	}

	private IOAuthProvider OAuthProvider(Guid? uid)
	{
		if (uid.HasValue)
		{
			return oAuthProvider.FirstOrDefault((IOAuthProvider a) => uid.Value.Equals(a.ProviderUid));
		}
		return oAuthProvider.FirstOrDefault((IOAuthProvider a) => a.CanUse());
	}
}
