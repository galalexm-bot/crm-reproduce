using System;
using System.Collections.Generic;
using System.IdentityModel.Services;
using System.Linq;
using System.Security.Authentication;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.SessionState;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Code;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Licensing.Constants;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Web.Service;
using Orchard.Themes;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

[SessionState(SessionStateBehavior.Default)]
public class AccountController : BPMController
{
	private readonly IMembershipService _membershipService;

	private readonly ITrustedDeviceService _trustedDeviceService;

	private readonly IAuthenticationService _authenticationService;

	private readonly IAuthenticationTokenService _tokenService;

	private readonly IRuntimeApplication _runtimeApplication;

	private readonly UserManager _userManager;

	private const string USER_SETTINGS_COOKIE = "user_settings";

	private const string USERNAME_COOKIE_KEY = "un";

	private const string PASSWORD_COOKIE_KEY = "pw";

	private const string ActiveSessionsModel_Filter_OnlyActive = "ActiveSessionsModel.Filter.OnlyActive";

	private const string ActiveSessionsModel_Filter_OnlyConcurrentUsers = "ActiveSessionsModel.Filter.OnlyConcurrentUsers";

	public new ILogger Logger { get; set; }

	public AccountController(IMembershipService membershipService, IAuthenticationService authenticationService, IAuthenticationTokenService tokenService, IRuntimeApplication runtimeApplication, ITrustedDeviceService trustedDeviceService, UserManager userManager)
	{
		_membershipService = membershipService;
		_authenticationService = authenticationService;
		_tokenService = tokenService;
		_runtimeApplication = runtimeApplication;
		_trustedDeviceService = trustedDeviceService;
		_userManager = userManager;
		Logger = NullLogger.Instance;
	}

	private string LogOnView()
	{
		ConfigurationInfo configurationInfo = ((_runtimeApplication != null) ? _runtimeApplication.ConfigurationInfo : null);
		if (!string.IsNullOrEmpty(((Controller)this).get_Request().QueryString["ReturnUrl"]) && ((Controller)this).get_Request().QueryString["ReturnUrl"].IndexOf("/PortalConnector/Gadget") != -1)
		{
			if (configurationInfo != null && configurationInfo.Type == ConfigurationType.Demo)
			{
				((dynamic)((ControllerBase)this).get_ViewBag()).Demo = true;
			}
			return "LogOnGadget";
		}
		if (configurationInfo != null && configurationInfo.Type == ConfigurationType.Demo)
		{
			((dynamic)((ControllerBase)this).get_ViewBag()).Demo = true;
		}
		if (configurationInfo != null && configurationInfo.Type == ConfigurationType.Free)
		{
			((dynamic)((ControllerBase)this).get_ViewBag()).Free = true;
		}
		return "LogOn";
	}

	[AuthenticationFilter(NotRequired = true)]
	[Authorize]
	[Themed(false)]
	public ActionResult AdfsLogOn(string returnUrl)
	{
		AntiForgeryConfig.set_UniqueClaimTypeIdentifier("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
		Claim claim = ((ClaimsIdentity)((Controller)this).get_HttpContext().User.Identity).Claims.FirstOrDefault((Claim x) => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
		if (claim != null)
		{
			string value = claim.Value;
			if (!string.IsNullOrEmpty(value))
			{
				EleWise.ELMA.Security.Models.IUser user = _userManager.LoadByLogin(value);
				if (user != null)
				{
					_authenticationService.SignIn(user, rememberMeSet: true, checkRequireChangePassword: false);
				}
			}
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn", (object)new { returnUrl });
	}

	[AuthenticationFilter(NotRequired = true)]
	[Themed(false)]
	[WithoutSpa]
	public ActionResult LogOn(string returnUrl, int? demo = null, int? free = null)
	{
		if (_authenticationService.GetCurrentUser() != null)
		{
			return ((Controller)(object)this).RedirectLocal(returnUrl);
		}
		IAuthenticationKeyService authenticationKeyService = ComponentManager.Current.GetExtensionPoints<IAuthenticationKeyService>().FirstOrDefault((IAuthenticationKeyService k) => !string.IsNullOrEmpty(((Controller)this).get_Request().QueryString[k.SecretKeyName]) && !string.IsNullOrEmpty(((Controller)this).get_Request().QueryString[k.LoginName]));
		if (authenticationKeyService != null && authenticationKeyService.SignIn(((Controller)this).get_Request().QueryString[authenticationKeyService.SecretKeyName], ((Controller)this).get_Request().QueryString[authenticationKeyService.LoginName]))
		{
			return ((Controller)(object)this).RedirectLocal(returnUrl);
		}
		object value = ((Controller)this).get_Session()["ErrorMessage"];
		((Controller)this).get_Session().Clear();
		((Controller)this).get_Session()["ErrorMessage"] = value;
		return (ActionResult)(object)((Controller)this).View(LogOnView());
	}

	[HttpPost]
	[Themed(false)]
	[AuthenticationFilter(NotRequired = true)]
	[WithoutSpa]
	public ActionResult LogOn(string login, string password, bool rememberMe, string returnUrl, int? demo = null, int? free = null)
	{
		return LogOnInnerLogic(login, password, rememberMe, returnUrl, demo, free);
	}

	private ActionResult LogOnInnerLogic(string login, string password, bool rememberMe, string returnUrl, int? demo = null, int? free = null)
	{
		((Controller)this).get_Session().Clear();
		if (!((Controller)this).get_ModelState().get_IsValid())
		{
			return (ActionResult)(object)((Controller)this).View(LogOnView());
		}
		EleWise.ELMA.Security.IUser user = null;
		try
		{
			user = _membershipService.ValidateUser(login, password);
		}
		catch (UserNameAlreadyExistsException)
		{
			((Controller)this).get_ModelState().AddModelError("NoTrueLogin", SR.T("В системе более одного пользователя с таким именем"));
			return (ActionResult)(object)((Controller)this).View(LogOnView());
		}
		if (user == null)
		{
			((Controller)this).get_ModelState().AddModelError("NoTrueLogin", SR.NoTrueLogin);
			return (ActionResult)(object)((Controller)this).View(LogOnView());
		}
		string contextDeviceToken = TrustedDeviceTokenHelper.GetContextDeviceToken(((Controller)this).get_HttpContext(), login);
		string contextDeviceInfo = TrustedDeviceTokenHelper.GetContextDeviceInfo(((Controller)this).get_HttpContext());
		if (!_trustedDeviceService.CheckDevice(contextDeviceToken, contextDeviceInfo, user))
		{
			((Controller)this).get_ModelState().AddModelError("NoTrueLogin", SR.NoTrueLogin);
			Logger.ErrorFormat("Authentication failed from Not trusted device. User: {0}; DeviceInfo: {1}", user.UserName, contextDeviceInfo);
			return (ActionResult)(object)((Controller)this).View(LogOnView());
		}
		string text = LicensingConstants.DefaultErrorMessage;
		try
		{
			_authenticationService.SignIn(user, rememberMe, checkRequireChangePassword: true);
			return ((Controller)(object)this).RedirectLocal(returnUrl);
		}
		catch (LicenseActivationRequiredException exception)
		{
			Logger.Error(LicensingConstants.AuthFailed, exception);
			text = LicensingConstants.ActivationRequired;
		}
		catch (LicenseWorkplaceExceededException exception2)
		{
			Logger.Error(LicensingConstants.AuthFailed, exception2);
			text = LicensingConstants.WorkplaceExceeded;
		}
		catch (LicenseExpiredException exception3)
		{
			Logger.Error(LicensingConstants.AuthFailed, exception3);
			text = LicensingConstants.LicenseExpired;
		}
		catch (SimultaneousSessionExceededException ex2)
		{
			Logger.Error(LicensingConstants.AuthFailed, ex2);
			((Controller)this).get_Session()["SimultaneousSessionExceededException-UserId"] = ((ex2.User != null) ? ex2.User.GetId() : null);
			return (ActionResult)(object)((Controller)this).RedirectToAction("DemoActiveSessions");
		}
		catch (ConcurrentLicenseExceededException ex3)
		{
			Logger.Error(LicensingConstants.AuthFailed, ex3);
			text = ex3.Message;
		}
		catch (LicenseException exception4)
		{
			Logger.Error(LicensingConstants.AuthFailed, exception4);
			text = LicensingConstants.LicenseExceptionMessage;
		}
		catch (RequireChangePasswordException ex4)
		{
			Logger.Error(LicensingConstants.AuthFailed, ex4);
			return (ActionResult)(object)((Controller)this).RedirectToAction("ChangePassword", (object)new
			{
				login = ex4.User.UserName
			});
		}
		catch (AuthenticationException ex5)
		{
			Logger.Error(LicensingConstants.AuthFailed, ex5);
			text = ex5.Message;
		}
		catch (Exception exception5)
		{
			Logger.Error(LicensingConstants.AuthFailed, exception5);
		}
		((Controller)this).get_ModelState().AddModelError("NoTrueLogin", text);
		return (ActionResult)(object)((Controller)this).View(LogOnView());
	}

	[WithoutSpa]
	[AuthenticationFilter(NotRequired = true)]
	public ActionResult LogOff(string returnUrl)
	{
		_authenticationService.SignOut();
		((Controller)this).get_HttpContext().Response.RemoveOutputCacheItem(((Controller)this).get_Url().Action("Globalization", "JS"));
		((Controller)this).get_HttpContext().Response.RemoveOutputCacheItem(((Controller)this).get_Url().Action("Get", "CSS"));
		((Controller)this).get_HttpContext().Request.Cookies.Remove("StyleUpdateTimestampKey");
		((Controller)this).get_HttpContext().Response.Cookies.Add(new HttpCookie("ElmaUserTimeZoneOffset")
		{
			Expires = DateTime.Now.AddDays(-1.0)
		});
		((Controller)this).get_HttpContext().Response.Cookies.Add(new HttpCookie("ElmaServerTimeZoneOffset")
		{
			Expires = DateTime.Now.AddDays(-1.0)
		});
		((Controller)this).get_HttpContext().Response.Cookies.Add(new HttpCookie("ElmaRuntimeTimeZoneOffset")
		{
			Expires = DateTime.Now.AddDays(-1.0)
		});
		((Controller)this).get_HttpContext().Response.Cookies.Add(new HttpCookie("ElmaBlockedTimeZoneOffset")
		{
			Expires = DateTime.Now.AddDays(-1.0)
		});
		string cookieName = WindowsAuthenticationSettings.GetCookieName();
		((Controller)this).get_HttpContext().Response.Cookies.Add(new HttpCookie(cookieName)
		{
			Expires = DateTime.Now.AddDays(-1.0)
		});
		if (SR.GetSetting("ADFS.UseADFSAuthentication", defaultValue: false))
		{
			FederatedAuthentication.WSFederationAuthenticationModule.SignOut(isIPRequest: false);
			return (ActionResult)(object)((Controller)this).RedirectToAction("AdfsLogOn", (object)new
			{
				ReturnUrl = returnUrl
			});
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn", (object)new
		{
			ReturnUrl = returnUrl
		});
	}

	[Themed(false)]
	[AuthenticationFilter(NotRequired = true)]
	public ActionResult DemoActiveSessions()
	{
		object obj = ((Controller)this).get_Session()["SimultaneousSessionExceededException-UserId"];
		EleWise.ELMA.Security.Models.IUser user = ((obj != null) ? _userManager.Load((long)obj) : null);
		if (user == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn");
		}
		return (ActionResult)(object)((Controller)this).View((object)new ActiveSessionsModel
		{
			CurrentUser = user,
			UserSessions = GetActiveSessionsModel(new AuthenticatedSessionFilter
			{
				OnlyActive = true,
				OnlyConcurrentUsers = true
			})
		});
	}

	[Permission("DCD48F8C-BC6F-48BE-A9FF-25C4FAB101DC")]
	public ActionResult ActiveSessions()
	{
		ActiveSessionsModel activeSessionsModel = new ActiveSessionsModel
		{
			CurrentUser = null,
			Filter = new AuthenticatedSessionFilter
			{
				OnlyActive = (((Controller)this).get_Session()["ActiveSessionsModel.Filter.OnlyActive"] == null || (bool)((Controller)this).get_Session()["ActiveSessionsModel.Filter.OnlyActive"]),
				OnlyConcurrentUsers = (((Controller)this).get_Session()["ActiveSessionsModel.Filter.OnlyConcurrentUsers"] != null && (bool)((Controller)this).get_Session()["ActiveSessionsModel.Filter.OnlyConcurrentUsers"])
			}
		};
		activeSessionsModel.UserSessions = GetActiveSessionsModel(activeSessionsModel.Filter);
		return (ActionResult)(object)((Controller)this).View((object)activeSessionsModel);
	}

	[Permission("DCD48F8C-BC6F-48BE-A9FF-25C4FAB101DC")]
	[HttpPost]
	public ActionResult ActiveSessions(string action, string actionParam, AuthenticatedSessionFilter filter)
	{
		if (action == "RemoveUser")
		{
			long num = long.Parse(actionParam);
			_authenticationService.RemoveAllUserSessions(num);
		}
		else if (action == "RemoveSession")
		{
			Guid ticketId = Guid.Parse(actionParam);
			_authenticationService.RemoveSession(ticketId);
		}
		if (filter != null)
		{
			((Controller)this).get_Session()["ActiveSessionsModel.Filter.OnlyActive"] = filter.OnlyActive;
			((Controller)this).get_Session()["ActiveSessionsModel.Filter.OnlyConcurrentUsers"] = filter.OnlyConcurrentUsers;
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("ActiveSessions");
	}

	[Themed(false)]
	[AuthenticationFilter(NotRequired = true)]
	public ActionResult RemoveSession(string ticketIds)
	{
		Guid[] array = ticketIds.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries).Select(Guid.Parse).ToArray();
		foreach (Guid ticketId in array)
		{
			_authenticationService.RemoveSession(ticketId);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn");
	}

	[WithoutSpa]
	public ActionResult AccessDenided(AccessDeniedModel model)
	{
		if (((ControllerBase)this).get_ControllerContext().get_IsChildAction())
		{
			return (ActionResult)(object)((Controller)this).PartialView("AccessDenided", (object)model);
		}
		return (ActionResult)(object)((Controller)this).View("AccessDenided", (object)model);
	}

	[Themed(false)]
	[AuthenticationFilter(NotRequired = true)]
	[WithoutSpa]
	public ActionResult ChangePassword(string login)
	{
		if (string.IsNullOrEmpty(login))
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("LogOn");
		}
		((Controller)this).get_ModelState().AddModelError("NoTrueLogin", SR.RequireChangePassword);
		return (ActionResult)(object)((Controller)this).View((object)login);
	}

	[HttpPost]
	[Themed(false)]
	[AuthenticationFilter(NotRequired = true)]
	[WithoutSpa]
	public ActionResult ChangePassword(string login, string curPassword, string newPassword, string confirmPassword, bool rememberMe)
	{
		EleWise.ELMA.Security.Models.IUser user = _userManager.LoadByLogin(login);
		if (user != null)
		{
			Pair<bool, string> pair = PasswordChangeHelper.ChangePassword(user, curPassword, newPassword, confirmPassword);
			if (pair.First)
			{
				return LogOnInnerLogic(login, newPassword, rememberMe, "");
			}
			((Controller)this).get_ModelState().AddModelError("NoTrueLogin", pair.Second);
			return (ActionResult)(object)((Controller)this).View();
		}
		((Controller)this).get_ModelState().AddModelError("NoTrueLogin", SR.NoTrueLogin);
		return (ActionResult)(object)((Controller)this).View();
	}

	protected override void OnException(ExceptionContext errorContext)
	{
		base.OnException(errorContext);
		if (errorContext != null && errorContext.get_Exception() is HttpAntiForgeryException && object.Equals("LogOn", ((ControllerBase)this).get_ControllerContext().get_RouteData().Values["action"]) && object.Equals("Account", ((ControllerBase)this).get_ControllerContext().get_RouteData().Values["controller"]) && object.Equals("EleWise.ELMA.BPM.Web.Security", ((ControllerBase)this).get_ControllerContext().get_RouteData().Values["area"]))
		{
			string[] values = ((ControllerBase)this).get_ControllerContext().get_HttpContext().Request.Form.GetValues("login");
			string text = ((values != null && values.Length != 0) ? values[0] : null);
			System.Security.Principal.IIdentity identity = ((Controller)this).get_HttpContext().User.Identity;
			string text2 = HttpUtility.UrlDecode((identity != null) ? identity.Name : string.Empty);
			errorContext.set_Result((ActionResult)(object)((Controller)this).RedirectToAction("RedirectError", (object)new
			{
				url = "~/",
				text = (string.IsNullOrWhiteSpace(text) ? SR.T("Попытка авторизации не была успешной, т.к. осуществлена авторизация под логином '{0}'.", text2) : SR.T("Попытка авторизации под логином '{0}' не была успешной, т.к. осуществлена авторизация под логином '{1}'.", text, text2))
			}));
			errorContext.set_ExceptionHandled(true);
		}
	}

	private List<ActiveSessionsModel.UserSessionsModel> GetActiveSessionsModel(AuthenticatedSessionFilter filter)
	{
		IEnumerable<long> privilegeUserIds = Locator.GetServiceNotNull<IActiveUserSessionService>().GetPrivilegeUserIds();
		return (from s in _authenticationService.GetSessions(filter)
			group s by s.UserId into @group
			select new ActiveSessionsModel.UserSessionsModel
			{
				User = _userManager.Load((long)@group.Key),
				IsPrivileged = privilegeUserIds.Contains((long)@group.Key),
				Sessions = @group.OrderBy((AuthenticatedSessionInfo s) => (int)s.Status).ToList()
			} into m
			orderby m.User.GetFullName().ToLower()
			select m).ToList();
	}
}
