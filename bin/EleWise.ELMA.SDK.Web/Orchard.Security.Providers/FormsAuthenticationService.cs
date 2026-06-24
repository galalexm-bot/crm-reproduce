using System;
using System.Web;
using System.Web.Security;
using EleWise.ELMA.Logging;
using Orchard.Environment.Configuration;
using Orchard.Mvc;
using Orchard.Mvc.Extensions;
using Orchard.Services;
using Orchard.Utility.Extensions;

namespace Orchard.Security.Providers;

public class FormsAuthenticationService : IAuthenticationService, IDependency
{
	private const int _cookieVersion = 3;

	private readonly ShellSettings _settings;

	private readonly IClock _clock;

	private readonly IMembershipService _membershipService;

	private readonly IHttpContextAccessor _httpContextAccessor;

	private readonly ISslSettingsProvider _sslSettingsProvider;

	private readonly IMembershipValidationService _membershipValidationService;

	private IUser _signedInUser;

	private bool _isAuthenticated;

	private bool _isNonOrchardUser;

	public ILogger Logger { get; set; }

	public TimeSpan ExpirationTimeSpan { get; set; }

	public FormsAuthenticationService(ShellSettings settings, IClock clock, IMembershipService membershipService, IHttpContextAccessor httpContextAccessor, ISslSettingsProvider sslSettingsProvider, IMembershipValidationService membershipValidationService)
	{
		_settings = settings;
		_clock = clock;
		_membershipService = membershipService;
		_httpContextAccessor = httpContextAccessor;
		_sslSettingsProvider = sslSettingsProvider;
		_membershipValidationService = membershipValidationService;
		Logger = NullLogger.Instance;
		ExpirationTimeSpan = TimeSpan.FromDays(30.0);
	}

	public void SignIn(IUser user, bool createPersistentCookie)
	{
		DateTime issueDate = _clock.UtcNow.ToLocalTime();
		string userData = user.UserName.ToBase64() + ";" + _settings.Name;
		FormsAuthenticationTicket formsAuthenticationTicket = new FormsAuthenticationTicket(3, user.UserName, issueDate, issueDate.Add(ExpirationTimeSpan), createPersistentCookie, userData, FormsAuthentication.FormsCookiePath);
		string value = FormsAuthentication.Encrypt(formsAuthenticationTicket);
		HttpCookie httpCookie = new HttpCookie(FormsAuthentication.FormsCookieName, value)
		{
			HttpOnly = true,
			Secure = _sslSettingsProvider.GetRequiresSSL(),
			Path = FormsAuthentication.FormsCookiePath
		};
		HttpContextBase httpContextBase = _httpContextAccessor.Current();
		if (!string.IsNullOrEmpty(_settings.RequestUrlPrefix))
		{
			httpCookie.Path = GetCookiePath(httpContextBase);
		}
		if (FormsAuthentication.CookieDomain != null)
		{
			httpCookie.Domain = FormsAuthentication.CookieDomain;
		}
		if (createPersistentCookie)
		{
			httpCookie.Expires = formsAuthenticationTicket.Expiration;
		}
		httpContextBase.Response.Cookies.Add(httpCookie);
		_isAuthenticated = true;
		_isNonOrchardUser = false;
		_signedInUser = user;
	}

	public void SignOut()
	{
		_signedInUser = null;
		_isAuthenticated = false;
		FormsAuthentication.SignOut();
		HttpContextBase httpContextBase = _httpContextAccessor.Current();
		HttpCookie httpCookie = new HttpCookie(FormsAuthentication.FormsCookieName, "")
		{
			Expires = DateTime.Now.AddYears(-1)
		};
		if (!string.IsNullOrEmpty(_settings.RequestUrlPrefix))
		{
			httpCookie.Path = GetCookiePath(httpContextBase);
		}
		httpContextBase.Response.Cookies.Add(httpCookie);
	}

	public void SetAuthenticatedUserForRequest(IUser user)
	{
		_signedInUser = user;
		_isAuthenticated = true;
		_isNonOrchardUser = false;
	}

	public IUser GetAuthenticatedUser()
	{
		if (_isNonOrchardUser)
		{
			return null;
		}
		if (_signedInUser != null || _isAuthenticated)
		{
			return _signedInUser;
		}
		HttpContextBase httpContextBase = _httpContextAccessor.Current();
		if (httpContextBase.IsBackgroundContext() || !httpContextBase.Request.IsAuthenticated || !(httpContextBase.User.Identity is FormsIdentity))
		{
			return null;
		}
		string[] array = (((FormsIdentity)httpContextBase.User.Identity).Ticket.UserData ?? "").Split(';');
		if (array.Length < 2)
		{
			return null;
		}
		string value = array[0];
		string a = array[1];
		try
		{
			value = value.FromBase64();
		}
		catch
		{
			return null;
		}
		if (!string.Equals(a, _settings.Name, StringComparison.Ordinal))
		{
			return null;
		}
		_signedInUser = _membershipService.GetUser(value);
		if (_signedInUser == null || !_membershipValidationService.CanAuthenticateWithCookie(_signedInUser))
		{
			_isNonOrchardUser = true;
			return null;
		}
		_isAuthenticated = true;
		return _signedInUser;
	}

	private string GetCookiePath(HttpContextBase httpContext)
	{
		string text = httpContext.Request.ApplicationPath;
		if (text != null && text.Length > 1)
		{
			text += "/";
		}
		return text + _settings.RequestUrlPrefix;
	}
}
