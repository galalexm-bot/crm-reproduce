using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Authentication;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Licensing;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Security;
using EleWise.ELMA.Web.Mvc.Services;
using EleWise.ELMA.Web.Service;
using NHibernate;

namespace EleWise.ELMA.Web.Mvc.Attributes;

public class AuthenticationFilterAttribute : FilterAttribute, IAuthorizationFilter, IExceptionFilter
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
	public class SkipUserAuthenticationCheckerAttribute : Attribute
	{
		public string HeaderName { get; set; }

		public string HeaderValue { get; set; }

		public bool MustBeEqual { get; set; }
	}

	private static ILogger authLog = Logger.GetLogger("AuthLog");

	private const string RequestedWithHeader = "X-Requested-With";

	private const string MobileApplicationId = "com.elewise.elmax";

	private static IAuthenticationService AuthenticationService => Locator.GetServiceNotNull<IAuthenticationService>();

	public bool NotRequired { get; set; }

	protected static bool UseInPlaceWinAuth => WindowsAuthenticationSettings.IsInPlaceWinAuthEnabled();

	protected static Func<HttpContextBase, bool> SspiAuthorizeFunc
	{
		get
		{
			if (UseInPlaceWinAuth)
			{
				return AuthorizeUsingInPlaceAuth;
			}
			return AuthorizeUsingExternalSSPI;
		}
	}

	public AuthenticationFilterAttribute()
	{
		((FilterAttribute)this).set_Order(0);
	}

	public void OnException(ExceptionContext filterContext)
	{
		Exception ex = filterContext.get_Exception();
		while (ex is TargetInvocationException && ex.InnerException != null)
		{
			ex = ex.InnerException;
		}
		if (ex is ObjectNotFoundException || ex is ObjectNotFoundException)
		{
			Logger.Log.Warn(SR.T("Объект не найден"), filterContext.get_Exception());
			filterContext.set_Result(ObjectNotFoundActionResultImpl.AccessDenidedResult(ex, ((ControllerContext)filterContext).get_Controller()));
			filterContext.set_ExceptionHandled(true);
		}
		else if (ex is SecurityException)
		{
			Logger.Log.Warn(SR.T("Ошибка доступа"), filterContext.get_Exception());
			filterContext.set_Result(PermissionActionResultImpl.AccessDeniedResult((SecurityException)ex, ((ControllerContext)filterContext).get_Controller()));
			filterContext.set_ExceptionHandled(true);
		}
		else if (ex is ElmaInvalidOperationException)
		{
			Logger.Log.Warn(ex.Message, filterContext.get_Exception());
			filterContext.set_Result(InvalidOperationActionResultImpl.InvalidOperationResult(ex, ((ControllerContext)filterContext).get_Controller()));
			filterContext.set_ExceptionHandled(true);
		}
		else if (ex is ObjectIsDeletedException)
		{
			Logger.Log.Warn(ex.Message, filterContext.get_Exception());
			filterContext.set_Result(ObjectIsDeletedActionResultImpl.RiseErrorResult(ex, ((ControllerContext)filterContext).get_Controller()));
			filterContext.set_ExceptionHandled(true);
		}
		else if (ex is HttpAntiForgeryException)
		{
			Logger.Log.Error(filterContext.get_Exception(), "{0} (Url: {1})", ex.Message, ((ControllerContext)filterContext).get_HttpContext().Request.RawUrl);
		}
		else
		{
			Logger.Log.Error(SR.T("Ошибка в методе контроллера {0}", ((ControllerContext)filterContext).get_Controller()), filterContext.get_Exception());
		}
	}

	private void LogContext(AuthorizationContext filterContext)
	{
		if (authLog.IsEnabled(LogLevel.Debug))
		{
			authLog.DebugFormat("AuthInfo: Forms={0} SSO={1} InPlace={2} Url={3}", FormsAuthentication.IsEnabled, WindowsAuthenticationSettings.IsSSOEnabled(), UseInPlaceWinAuth, FormsAuthentication.LoginUrl);
			HttpRequestBase request = ((ControllerContext)filterContext).get_HttpContext().Request;
			authLog.DebugFormat("Request: Type={0} Path={1} ClientIP={2}", request.RequestType, request.Path, request.UserHostAddress);
			string sessionID = ((ControllerContext)filterContext).get_HttpContext().Session.SessionID;
			authLog.DebugFormat("Request: SessionId={0}", sessionID);
			HttpCookie httpCookie = ((ControllerContext)filterContext).get_HttpContext().Request.Cookies["ASP.NET_SessionId"];
			if (httpCookie != null)
			{
				authLog.DebugFormat("Request: has cookie ASP.NET_SessionId ({0})", httpCookie.Value);
			}
			HttpCookie httpCookie2 = ((ControllerContext)filterContext).get_HttpContext().Request.Cookies[FormsAuthentication.FormsCookieName];
			if (httpCookie2 != null)
			{
				authLog.DebugFormat("Request: has cookie {0}", httpCookie2.Name);
			}
			string cookieName = WindowsAuthenticationSettings.GetCookieName();
			HttpCookie httpCookie3 = ((ControllerContext)filterContext).get_HttpContext().Request.Cookies[cookieName];
			if (httpCookie3 != null)
			{
				authLog.DebugFormat("Request: has cookie {0}", httpCookie3.Name);
			}
			IIdentity identity = ((ControllerContext)filterContext).get_HttpContext().User.Identity;
			authLog.DebugFormat("System User Identity: HasAuth={0} AuthType={1} Username={2}", identity.IsAuthenticated.ToString(), identity.AuthenticationType, identity.Name);
		}
	}

	public void OnAuthorization(AuthorizationContext filterContext)
	{
		if (filterContext == null)
		{
			throw new ArgumentNullException("filterContext");
		}
		if (((ControllerContext)filterContext).get_IsChildAction() || filterContext.get_ActionDescriptor().GetCustomAttributes(typeof(AuthenticationFilterAttribute), false).OfType<AuthenticationFilterAttribute>()
			.Any((AuthenticationFilterAttribute f) => f.NotRequired))
		{
			return;
		}
		IUser currentUser = AuthenticationService.GetCurrentUser();
		if (currentUser != null)
		{
			return;
		}
		LogContext(filterContext);
		bool flag = ShouldBypassIWA(((ControllerContext)filterContext).get_HttpContext());
		bool flag2 = IsMobileClient(((ControllerContext)filterContext).get_HttpContext());
		if (!((ControllerContext)filterContext).get_HttpContext().User.Identity.IsAuthenticated && (flag || flag2))
		{
			authLog.Debug("BypassIWA flag is set or it is mobile client --> forcing Forms auth");
			RedirectToLoginPage(filterContext);
			return;
		}
		bool flag3 = IsSspiCookieValid(((ControllerContext)filterContext).get_HttpContext());
		bool flag4 = FormsAuthentication.IsEnabled && FormsAuthentication.LoginUrl.Contains("SSPI");
		bool flag5 = FormsAuthentication.IsEnabled && WindowsAuthenticationSettings.IsSSOEnabled();
		if ((flag4 || flag5) && !flag3)
		{
			authLog.Debug("Redirecting to Win auth");
			HandleUnauthorizedRequest(filterContext);
			return;
		}
		if (FormsAuthentication.IsEnabled && currentUser == null && !flag3)
		{
			authLog.Debug("Redirecting to Forms auth");
			RedirectToLoginPage(filterContext);
			return;
		}
		bool skipUserAuthenticationChecker = ShouldSkipChecker(filterContext);
		if (AuthorizeCore(((ControllerContext)filterContext).get_HttpContext(), skipUserAuthenticationChecker))
		{
			authLog.Debug("User authorized!");
			HttpCachePolicyBase cache = ((ControllerContext)filterContext).get_HttpContext().Response.Cache;
			cache.SetProxyMaxAge(new TimeSpan(0L));
			cache.AddValidationCallback(CacheValidateHandler, null);
			if (flag5 || flag4)
			{
				((ControllerContext)filterContext).get_HttpContext().Response.Redirect(((ControllerContext)filterContext).get_HttpContext().Request.Url.ToString());
			}
		}
		else
		{
			authLog.Debug("Going to HandleUnauthorizedRequest");
			RedirectToLoginPage(filterContext);
		}
	}

	private bool IsMobileClient(HttpContextBase httpContext)
	{
		return httpContext.Request.Headers["X-Requested-With"]?.Equals("com.elewise.elmax", StringComparison.InvariantCultureIgnoreCase) ?? false;
	}

	private bool ShouldBypassIWA(HttpContextBase httpContext)
	{
		string text = httpContext.Request.Headers["Elma-BypassIWA"] ?? string.Empty;
		if (!text.Equals("true", StringComparison.InvariantCultureIgnoreCase) && !text.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
		{
			return text.Equals("1", StringComparison.InvariantCultureIgnoreCase);
		}
		return true;
	}

	private bool ShouldSkipChecker(AuthorizationContext filterContext)
	{
		SkipUserAuthenticationCheckerAttribute[] array = filterContext.get_ActionDescriptor().GetCustomAttributes(typeof(SkipUserAuthenticationCheckerAttribute), false).Cast<SkipUserAuthenticationCheckerAttribute>()
			.ToArray();
		if (array.Any())
		{
			SkipUserAuthenticationCheckerAttribute[] array2 = array;
			foreach (SkipUserAuthenticationCheckerAttribute skipUserAuthenticationCheckerAttribute in array2)
			{
				if (!((ControllerContext)filterContext).get_HttpContext().Request.Headers.AllKeys.Contains(skipUserAuthenticationCheckerAttribute.HeaderName))
				{
					continue;
				}
				if (skipUserAuthenticationCheckerAttribute.MustBeEqual)
				{
					if (((ControllerContext)filterContext).get_HttpContext().Request.Headers[skipUserAuthenticationCheckerAttribute.HeaderName].Equals(skipUserAuthenticationCheckerAttribute.HeaderValue))
					{
						return true;
					}
				}
				else if (((ControllerContext)filterContext).get_HttpContext().Request.Headers[skipUserAuthenticationCheckerAttribute.HeaderName].IndexOf(skipUserAuthenticationCheckerAttribute.HeaderValue, StringComparison.InvariantCultureIgnoreCase) > -1)
				{
					return true;
				}
			}
		}
		return false;
	}

	private static bool AuthorizeUsingExternalSSPI(HttpContextBase httpContext)
	{
		authLog.Debug("External sspi auth: checking cookie...");
		return CheckSspiCookie(httpContext);
	}

	private static bool AuthorizeUsingInPlaceAuth(HttpContextBase httpContext)
	{
		IUser currentUser = AuthenticationService.GetCurrentUser();
		authLog.DebugFormat("In place auth: Current ELMA user is '{0}'", (currentUser == null) ? "NULL" : currentUser.UserName);
		if (currentUser == null)
		{
			CreateSspiCookie(httpContext);
			if (CheckSspiCookie(httpContext))
			{
				authLog.Debug("In place auth: SSPI cookie was successfully validated!");
				return true;
			}
			authLog.Debug("In place auth: no SSPI ticket found!");
		}
		return false;
	}

	protected virtual bool AuthorizeCore(HttpContextBase httpContext, bool skipUserAuthenticationChecker = false)
	{
		authLog.DebugFormat("UseInPlaceWinAuth = {0}", UseInPlaceWinAuth);
		if (SspiAuthorizeFunc(httpContext))
		{
			return true;
		}
		authLog.Debug("Auth: continue after SSPI checks!");
		IUser user = AuthenticationService.GetCurrentUser();
		if (user == null)
		{
			authLog.Debug("Auth: user signout");
			AuthenticationService.SignOut();
			httpContext.Request.Cookies.Remove("StyleUpdateTimestampKey");
			return false;
		}
		authLog.DebugFormat("Auth: recognized ELMA user '{0}'!", user.UserName);
		if (skipUserAuthenticationChecker)
		{
			AuthenticationService.SetAuthenticatedUserForRequest(user);
			if (DiagnosticsManager.Initialized)
			{
				DiagnosticsManager.Instance.WebRequestAuthorized(user);
			}
			authLog.Debug("Auth: additional checks were skipped");
			return true;
		}
		authLog.Debug("Auth: doing additional checks...");
		IUserAuthenticationChecker[] source = ComponentManager.Current.GetExtensionPoints<IUserAuthenticationChecker>(useCache: true).ToArray();
		if (source.Any())
		{
			if (source.All((IUserAuthenticationChecker p) => p.Check(httpContext, user)))
			{
				AuthenticationService.SetAuthenticatedUserForRequest(user);
				if (DiagnosticsManager.Initialized)
				{
					DiagnosticsManager.Instance.WebRequestAuthorized(user);
				}
				authLog.Debug("Auth: all checks have been passed!");
				return true;
			}
			authLog.Debug("Auth: failed to pass additional checks");
			AuthenticationService.SignOut();
			return false;
		}
		AuthenticationService.SetAuthenticatedUserForRequest(user);
		if (DiagnosticsManager.Initialized)
		{
			DiagnosticsManager.Instance.WebRequestAuthorized(user);
		}
		authLog.DebugFormat("Auth: user '{0}' is temporarily authorized", user.UserName);
		return true;
	}

	protected virtual void HandleUnauthorizedRequest(AuthorizationContext filterContext)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		SavePostForm(filterContext);
		filterContext.set_Result((ActionResult)new HttpUnauthorizedResult());
	}

	protected virtual void RedirectToLoginPage(AuthorizationContext filterContext)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		SavePostForm(filterContext);
		filterContext.set_Result((ActionResult)new RedirectToRouteResult(new RouteValueDictionary(new
		{
			controller = "Account",
			action = "LogOn",
			area = "EleWise.ELMA.BPM.Web.Security",
			returnUrl = ((ControllerContext)filterContext).get_HttpContext().Request.RawUrl
		})));
	}

	protected virtual HttpValidationStatus OnCacheAuthorization(HttpContextBase httpContext)
	{
		if (httpContext == null)
		{
			throw new ArgumentNullException("httpContext");
		}
		if (AuthorizeCore(httpContext))
		{
			return HttpValidationStatus.Valid;
		}
		return HttpValidationStatus.IgnoreThisRequest;
	}

	private void CacheValidateHandler(HttpContext context, object data, ref HttpValidationStatus validationStatus)
	{
		validationStatus = OnCacheAuthorization(new HttpContextWrapper(context));
	}

	private static bool CheckSspiCookie(HttpContextBase httpContext)
	{
		string cookieName = WindowsAuthenticationSettings.GetCookieName();
		HttpCookie httpCookie = httpContext.Request.Cookies[cookieName];
		if (httpCookie == null)
		{
			authLog.Debug("CheckSspiCookie: no cookie to check!");
			return false;
		}
		Guid instanceUid = WindowsAuthenticationSettings.GetInstanceUid();
		bool flag = false;
		ISspiService service = Locator.GetService<ISspiService>();
		if (service != null)
		{
			IUser cookieUser = service.ValidateUser(httpCookie.Value, httpContext.Request.UserAgent.Replace(';', ','), httpContext.Request.UserHostAddress);
			if (cookieUser != null && cookieUser.AuthProviderGuid == instanceUid)
			{
				authLog.DebugFormat("CheckSspiCookie: recognized ELMA user '{0}'!", cookieUser.UserName);
				try
				{
					if (!ComponentManager.Current.GetExtensionPoints<IUserAuthenticationChecker>(useCache: true).All((IUserAuthenticationChecker p) => p.Check(httpContext, cookieUser)))
					{
						throw new AuthenticationException(SR.NoTrueLogin);
					}
					AuthenticationService.SignIn(cookieUser);
					authLog.Debug("CheckSspiCookie: passed all additional checks, form cookie is set!");
				}
				catch (ConcurrentLicenseExceededException ex)
				{
					SessionVars.Set("ErrorMessage", ex.Message);
					authLog.DebugFormat("CheckSspiCookie: additional check error: {0}!", ex.Message);
					flag = true;
				}
				catch (AuthenticationException ex2)
				{
					SessionVars.Set("ErrorMessage", ex2.Message);
					authLog.DebugFormat("CheckSspiCookie: additional check error: {0}!", ex2.Message);
					flag = true;
				}
			}
			else
			{
				authLog.Debug("CheckSspiCookie: failed to validate user. Redirecting to form auth.");
				flag = true;
			}
		}
		else
		{
			SessionVars.Set("ErrorMessage", SR.T("Не активирован модуль Single Sign-On"));
			authLog.Debug("CheckSspiCookie: SSO module is not activated. Redirecting to form auth.");
			flag = true;
		}
		if (UseInPlaceWinAuth)
		{
			httpCookie.Expires = DateTime.Now.AddDays(-1.0);
			httpContext.Response.Cookies.Remove(cookieName);
			httpContext.Response.Cookies.Add(httpCookie);
		}
		else
		{
			httpCookie.Expires = DateTime.Now.AddDays(-1.0);
			httpContext.Response.Cookies.Add(httpCookie);
		}
		if (flag)
		{
			httpContext.Response.Redirect("~/Security/Account/LogOn?ReturnUrl=" + HttpUtility.UrlEncode(httpContext.Request.Url.AbsolutePath + httpContext.Request.Url.Query));
		}
		return true;
	}

	private static void CreateSspiCookie(HttpContextBase httpContext)
	{
		if (!new string[2] { "NTLM", "Negotiate" }.Contains(httpContext.User.Identity.AuthenticationType))
		{
			authLog.Debug("CreateSspiCookie: AuthType is not NLTM or Negotiate. Unable to create SSPI ticket!");
			return;
		}
		string value = SspiTicketService.CreateSspiTicket(new TicketRequest
		{
			IdentityName = httpContext.User.Identity.Name,
			UserAgent = httpContext?.Request.UserAgent.Replace(';', ','),
			RemoteAddress = httpContext?.Request.UserHostAddress,
			CreateTime = DateTime.UtcNow.ToLocalTime()
		});
		string cookieName = WindowsAuthenticationSettings.GetCookieName();
		HttpCookie cookie = new HttpCookie(cookieName, value)
		{
			HttpOnly = true,
			Secure = FormsAuthentication.RequireSSL,
			Path = FormsAuthentication.FormsCookiePath
		};
		httpContext.Response.Cookies.Remove(cookieName);
		httpContext.Response.Cookies.Add(cookie);
		authLog.Debug("CreateSspiCookie: SSPI ticket created, cookie is set!");
	}

	private static bool IsSspiCookieValid(HttpContextBase httpContext)
	{
		string cookieName = WindowsAuthenticationSettings.GetCookieName();
		return httpContext.Request.Cookies[cookieName] != null;
	}

	private static void SavePostForm(AuthorizationContext filterContext)
	{
		HttpRequestBase request = ((ControllerContext)filterContext).get_HttpContext().Request;
		if (!(request.HttpMethod == "POST"))
		{
			return;
		}
		((ControllerContext)filterContext).get_Controller().get_TempData().set_Item("Form", (object)request.Form);
		if (request.Files.Count <= 0)
		{
			return;
		}
		Dictionary<string, Guid> dictionary = new Dictionary<string, Guid>();
		ICacheFilesService service = Locator.GetService<ICacheFilesService>();
		if (service == null)
		{
			return;
		}
		HttpFileCollectionBase files = request.Files;
		string[] allKeys = files.AllKeys;
		foreach (string text in allKeys)
		{
			try
			{
				HttpPostedFileBase httpPostedFileBase = files[text];
				if (httpPostedFileBase != null && !string.IsNullOrWhiteSpace(httpPostedFileBase.FileName) && httpPostedFileBase.ContentLength > 0)
				{
					string fileName = Path.GetFileName(httpPostedFileBase.FileName);
					Guid guid = service.CreateCacheFile(fileName);
					httpPostedFileBase.SaveAs(service.GetFilePath(guid));
					dictionary.Add(text, guid);
				}
			}
			catch (Exception)
			{
			}
		}
		((ControllerContext)filterContext).get_Controller().get_TempData().set_Item("Files", (object)dictionary);
	}
}
