using System;
using System.Security.Authentication;
using System.Web;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Security.Mobile.Web;

public class AuthenticationHandler : IHttpModule
{
	internal const string MobileApplicationKey = "MobileAuthentication";

	internal const string ApplicationTokenKey = "ApplicationToken";

	internal const string AuthTokenKey = "AuthToken";

	internal const string UserIdKey = "AuthUserId";

	private static bool initialized;

	private static UserManager userManager;

	private static IAuthenticationService authenticationService;

	private static IPublicClientService publicClientService;

	private static IPublicApplicationService publicApplicationService;

	public AuthenticationHandler()
	{
	}

	internal AuthenticationHandler(UserManager userManager, IAuthenticationService authenticationService, IPublicClientService publicClientService, IPublicApplicationService publicApplicationService)
	{
		initialized = true;
		AuthenticationHandler.userManager = userManager;
		AuthenticationHandler.authenticationService = authenticationService;
		AuthenticationHandler.publicClientService = publicClientService;
		AuthenticationHandler.publicApplicationService = publicApplicationService;
	}

	public void Dispose()
	{
	}

	public void Init(HttpApplication context)
	{
		context.BeginRequest += OnBeginRequest;
	}

	private void OnBeginRequest(object sender, EventArgs e)
	{
		if (sender is HttpApplication httpApplication && httpApplication.Context.Request != null && Locator.Initialized && StartInformation.Root.Status == StartStatus.Started && InitServices())
		{
			LogOn(httpApplication.Context.Request);
		}
	}

	private bool InitServices()
	{
		if (!initialized)
		{
			try
			{
				if (userManager == null)
				{
					userManager = UserManager.Instance;
				}
				if (authenticationService == null)
				{
					authenticationService = Locator.GetServiceNotNull<IAuthenticationService>();
				}
				if (publicClientService == null)
				{
					publicClientService = Locator.GetServiceNotNull<IPublicClientService>();
				}
				if (publicApplicationService == null)
				{
					publicApplicationService = Locator.GetServiceNotNull<IPublicApplicationService>();
				}
				initialized = true;
			}
			catch (ServiceNotFoundException message)
			{
				Logger.Log.Error(message);
			}
		}
		return initialized;
	}

	private void LogOn(HttpRequest request)
	{
		string mobileApplication = request.Headers.Get("MobileAuthentication");
		string text = request.Headers.Get("ApplicationToken");
		string authToken = request.Headers.Get("AuthToken");
		string userIdStr = request.Headers.Get("AuthUserId");
		HttpCookie httpCookie = request.Cookies.Get("ApplicationToken");
		if (httpCookie == null || string.IsNullOrWhiteSpace(httpCookie.Value))
		{
			HttpContext.Current.Response.Cookies.Add(new HttpCookie("ApplicationToken", text));
		}
		LogOn(mobileApplication, userIdStr, authToken, text);
	}

	internal void LogOn(string mobileApplication, string userIdStr, string authToken, string applicationToken)
	{
		if (bool.TryParse(mobileApplication, out var result) && result)
		{
			if (string.IsNullOrWhiteSpace(applicationToken))
			{
				string message = SR.T("Не задан токен авторизации приложения");
				Logger.Log.Error(message);
				throw new AuthenticationException(message);
			}
			Guid result2 = Guid.Empty;
			if (string.IsNullOrWhiteSpace(authToken) || !Guid.TryParse(authToken, out result2))
			{
				string message2 = SR.T("Не задан или неверный токен авторизации");
				Logger.Log.Error(message2);
				throw new AuthenticationException(message2);
			}
			if (string.IsNullOrWhiteSpace(userIdStr) || !long.TryParse(userIdStr, out var result3))
			{
				string message3 = SR.T("Не задан или неверный идентификатор пользователя");
				Logger.Log.Error(message3);
				throw new AuthenticationException(message3);
			}
			if (!publicApplicationService.IsTokenValid(applicationToken, out var token) || token == null)
			{
				Logger.Log.Error(SR.T("Неверный токен приложения"));
				throw new AuthenticationException(SR.T("Нет доступа к приложению, или приложение не активировано"));
			}
			EleWise.ELMA.Security.Models.IUser user = userManager.LoadOrNull(result3);
			if (user == null)
			{
				string message4 = SR.T("Пользователь с id = {0} не найден", result3);
				Logger.Log.Error(message4);
				throw new AuthenticationException(message4);
			}
			IPublicClientSession session = publicClientService.GetSession(result2);
			if (session == null || session.AuthUser == null)
			{
				string message5 = SR.T("Не найдена сессия пользователя");
				Logger.Log.Error(message5);
				throw new AuthenticationException(message5);
			}
			if ((long)session.AuthUser.GetId() != user.Id)
			{
				string message6 = SR.T("Неверный токен пользователя");
				Logger.Log.Error(message6);
				throw new AuthenticationException(message6);
			}
			authenticationService.SignIn(user);
		}
	}
}
