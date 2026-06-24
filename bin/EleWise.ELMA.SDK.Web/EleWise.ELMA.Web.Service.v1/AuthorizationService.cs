using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Mvc.Services;

namespace EleWise.ELMA.Web.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[Component]
[Uid("{7C37420B-285E-4D08-966D-2F09E136F27E}")]
public class AuthorizationService : IAuthorizationService, ICorePublicService
{
	[Serializable]
	internal class ServiceTempAuthenticationInfo : TemporaryAuthenticationInfo
	{
		public override void ApplyTemplate(object entity)
		{
		}

		public override IUser GetUser()
		{
			return Locator.GetServiceNotNull<IMembershipService>().GetUser(base.UserId);
		}
	}

	public const string GuidS = "{7C37420B-285E-4D08-966D-2F09E136F27E}";

	public static Guid Guid = new Guid("{7C37420B-285E-4D08-966D-2F09E136F27E}");

	private const string ApplicationTokenHeader = "ApplicationToken";

	private const string SessionTokenHeader = "SessionToken";

	private const string AuthTokenHeader = "AuthToken";

	private const string AuthorizationHeader = "Authorization";

	private const string Bearer = "Bearer ";

	private const string LangClaim = "lang";

	private static readonly string VersionString = VersionInfo.GetVersion<SR>().ToString();

	private static readonly ILogger AuthLog = EleWise.ELMA.Logging.Logger.GetLogger("AuthLog");

	private IPublicClientService _clientSvc;

	private IAuthenticationTokenService _authTokenService;

	private IJwtAuthTokenService jwtAuthTokenService;

	private static ApiVersionResponse cachedAllVersions;

	private IPublicClientService clientSvc
	{
		get
		{
			if (_clientSvc == null)
			{
				_clientSvc = Locator.GetServiceNotNull<IPublicClientService>();
			}
			return _clientSvc;
		}
	}

	private IAuthenticationTokenService authTokenService
	{
		get
		{
			if (_authTokenService == null)
			{
				_authTokenService = Locator.GetServiceNotNull<IAuthenticationTokenService>();
			}
			return _authTokenService;
		}
	}

	private IJwtAuthTokenService JwtAuthTokenService
	{
		get
		{
			if (jwtAuthTokenService == null)
			{
				jwtAuthTokenService = Locator.GetServiceNotNull<IJwtAuthTokenService>();
			}
			return jwtAuthTokenService;
		}
	}

	public ILogger Logger => EleWise.ELMA.Logging.Logger.Log;

	public string Version()
	{
		return VersionString;
	}

	public ApiVersionResponse ApiVersion(bool allServices)
	{
		if (!allServices)
		{
			return GetApiVersion();
		}
		return GetAllApiVersions();
	}

	public DateTime ServerTime()
	{
		CheckCurrentSession((AuthorizationService s) => s.ServerTime());
		return DateTime.Now;
	}

	public DateTime ServerTimeUTC()
	{
		CheckCurrentSession((AuthorizationService s) => s.ServerTimeUTC());
		return DateTime.Now.ToUniversalTime();
	}

	public AuthResponse CheckToken(Guid token)
	{
		try
		{
			IPublicClientSession session = clientSvc.GetSession(token);
			if (session == null || !clientSvc.IsSessionValid(session.SessionToken, out session))
			{
				LogServiceError((AuthorizationService s) => s.CheckToken(token), SR.T("Не задан токен авторизации и сессия не найдена"));
				AuthLog.Error(SR.T("CheckToken: Ошибка при поиске сессии: сессия id = {0} невалидна или не существует сессии связанной с заданным токеном авторизации {1}", session?.SessionToken, token));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			AuthLog.Debug(SR.T("CheckToken: По токену авторизации = {0} найдена сессия {1}", token, session.SessionToken));
			IUser user = authTokenService.GetUser(token);
			if (user == null)
			{
				user = session.AuthUser;
				Guid guid = authTokenService.CreateToken(session.AuthUser);
				if (!clientSvc.UpdateAuthToken(session.SessionToken, guid))
				{
					LogServiceError((AuthorizationService s) => s.LoginWithBasic(), SR.T("Ошибка обновления токена сессии в БД"));
					AuthLog.Error(SR.T("CheckToken: Не удалось обновить токен авторизации c {0} на {1} для сессии = {2}", token, guid, session.SessionToken));
					throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
				}
				AuthLog.Debug(SR.T("CheckToken: Токен авторизации {0} успешно обновлен на {1} для сессии id = {2}", token, guid, session.SessionToken));
				token = guid;
			}
			ContextVars.Set("PublicContractInfo.SessionContextKey", session);
			ContextVars.Set("PublicContractInfo.ExecutingApplicationContextKey", session.Application);
			clientSvc.PromoteSession(session.SessionToken);
			return new AuthResponse
			{
				AuthToken = token,
				SessionToken = session.SessionToken,
				CurrentUserId = user.GetId().ToString(),
				CurrentUserName = user.UserName,
				Lang = user.Lang
			};
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			LogServiceError((AuthorizationService s) => s.CheckToken(token), ex2.ToString());
			AuthLog.Error(SR.T("CheckToken: Непредвиденная ошибка при проверке токена авторизации = {0}", token), ex2);
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка на сервере"), 500);
		}
	}

	public AuthResponse LoginWithBasic()
	{
		try
		{
			string applicationToken;
			IPublicClientSession publicClientSession = CheckTokensOnLogin(out applicationToken);
			if (publicClientSession == null && string.IsNullOrWhiteSpace(applicationToken))
			{
				LogServiceError((AuthorizationService s) => s.LoginWithBasic(), SR.T("Не задан токен авторизации приложения и сессия не найдена"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
			if (currentUser == null)
			{
				LogServiceError((AuthorizationService s) => s.LoginWithBasic(), SR.T("Текущий пользователь не опознан"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			CheckPublicApplicationUserAccess(applicationToken, currentUser);
			Guid guid = authTokenService.CreateToken(currentUser);
			if (publicClientSession != null)
			{
				clientSvc.UpdateAuthToken(publicClientSession.SessionToken, guid);
			}
			else
			{
				publicClientSession = clientSvc.CreateSession(guid, applicationToken);
			}
			if (publicClientSession == null)
			{
				LogServiceError((AuthorizationService s) => s.LoginWithBasic(), SR.T("Сессия не заполнена"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			OnAuthorizeUser(currentUser, publicClientSession.SessionToken);
			return new AuthResponse
			{
				AuthToken = guid,
				SessionToken = publicClientSession.SessionToken,
				CurrentUserId = currentUser.GetId().ToString(),
				CurrentUserName = currentUser.UserName,
				Lang = currentUser.Lang
			};
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			LogServiceError((AuthorizationService s) => s.LoginWithBasic(), ex2.ToString());
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка на сервере"), 500);
		}
	}

	public AuthResponse LoginWithUserName(string username, string password)
	{
		try
		{
			string applicationToken;
			IPublicClientSession publicClientSession = CheckTokensOnLogin(out applicationToken);
			if (publicClientSession == null && string.IsNullOrWhiteSpace(applicationToken))
			{
				LogServiceError((AuthorizationService s) => s.LoginWithUserName(username, password), SR.T("Не задан токен авторизации приложения и сессия не найдена"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			IMembershipService serviceNotNull = Locator.GetServiceNotNull<IMembershipService>();
			IUser user = serviceNotNull.ValidateUser(username, password);
			if (user == null)
			{
				LogServiceError((AuthorizationService s) => s.LoginWithUserName(username, password), SR.T("Ошибка авторизации по логину паролю"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			CheckPublicApplicationUserAccess(applicationToken, user);
			Guid guid = authTokenService.CreateToken(user);
			if (publicClientSession != null)
			{
				clientSvc.UpdateAuthToken(publicClientSession.SessionToken, guid);
			}
			else
			{
				publicClientSession = clientSvc.CreateSession(guid, applicationToken);
			}
			if (publicClientSession == null)
			{
				LogServiceError((AuthorizationService s) => s.LoginWithUserName(username, password), SR.T("Сессия клиента не установлена"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			serviceNotNull.CheckRequireChangePassword(user.GetId());
			AuthResponse result = new AuthResponse
			{
				AuthToken = guid,
				SessionToken = publicClientSession.SessionToken,
				CurrentUserId = user.GetId().ToString(),
				CurrentUserName = user.UserName,
				Lang = user.Lang
			};
			OnAuthorizeUser(user, publicClientSession.SessionToken);
			return result;
		}
		catch (FaultException)
		{
			throw;
		}
		catch (RequireChangePasswordException ex2)
		{
			LogServiceError((AuthorizationService s) => s.LoginWithUserName(username, password), ex2.Message.ToString());
			throw PublicServiceException.CreateWebFault(ex2.Message, 401);
		}
		catch (Exception ex3)
		{
			LogServiceError((AuthorizationService s) => s.LoginWithUserName(username, password), ex3.ToString());
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка сервера при авторизации"), 500);
		}
	}

	public JwtAuthResponse LoginJwt(string username, string password)
	{
		try
		{
			string requestHeader = APIRouteProvider.GetRequestHeader("ApplicationToken");
			IMembershipService serviceNotNull = Locator.GetServiceNotNull<IMembershipService>();
			IUser user = serviceNotNull.ValidateUser(username, password);
			if (user == null)
			{
				LogServiceError((AuthorizationService s) => s.LoginJwt(username, password), SR.T("Ошибка авторизации по логину паролю"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			serviceNotNull.CheckRequireChangePassword(user.GetId());
			CheckPublicApplicationUserAccess(requestHeader, user);
			Dictionary<string, string> additionalClaims = new Dictionary<string, string>(1) { { "lang", user.Lang } };
			JwtTokenContainer jwtTokenContainer = JwtAuthTokenService.CreateToken(new AuthInfoContainer(Convert.ToInt64(user.GetId()), requestHeader, additionalClaims));
			AuthLog.Debug(SR.T("LoginJwt: Успешная авторизация пользователя id = {0}, токен = {1}", user.GetId(), jwtTokenContainer.JwtToken));
			OnAuthorizeUser(user, string.Empty);
			return new JwtAuthResponse
			{
				AuthToken = jwtTokenContainer.JwtToken,
				RefreshToken = jwtTokenContainer.RefreshToken
			};
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			LogServiceError((AuthorizationService s) => s.LoginJwt(username, password), ex2.ToString());
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка на сервере при авторизации пользователя"), 500);
		}
	}

	public JwtAuthResponse RefreshToken(string refreshToken)
	{
		try
		{
			JwtTokenContainer jwtTokenContainer = null;
			try
			{
				jwtTokenContainer = JwtAuthTokenService.RefreshToken(refreshToken);
				if (jwtTokenContainer == null)
				{
					throw new ArgumentException(SR.T("Ошибка обновления токена авторизации, возможно токен обновления просрочен или невалиден"));
				}
			}
			catch (ArgumentException exception)
			{
				LogServiceError((AuthorizationService s) => s.RefreshToken(refreshToken), SR.T("Ошибка обновления токена авторизации"));
				AuthLog.Error(SR.T("RefreshToken: Ошибка обновления токена авторизации. RefreshToken: {0}", refreshToken), exception);
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			AuthInfoContainer authInfo = jwtAuthTokenService.GetAuthInfo(jwtTokenContainer.JwtToken);
			IMembershipService serviceNotNull = Locator.GetServiceNotNull<IMembershipService>();
			IUser user = serviceNotNull.GetUser(authInfo.UserId);
			serviceNotNull.CheckRequireChangePassword(user.GetId());
			CheckPublicApplicationUserAccess(authInfo.ApplicationToken, user);
			AuthLog.Debug(SR.T("RefreshToken: Токен для пользователя id = {0} и приложения token = {1} успешно обновлен на {2}", user.GetId(), authInfo.ApplicationToken, jwtTokenContainer.JwtToken));
			return new JwtAuthResponse
			{
				AuthToken = jwtTokenContainer.JwtToken,
				RefreshToken = jwtTokenContainer.RefreshToken
			};
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			LogServiceError((AuthorizationService s) => s.RefreshToken(refreshToken), ex2.ToString());
			AuthLog.Error(SR.T("RefreshToken: Ошибка обновления токена авторизации. RefreshToken: {0}", refreshToken), ex2);
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка на сервере при обновлении токена"), 500);
		}
	}

	public AuthResponse LoginWithSSPI(string ticket)
	{
		try
		{
			string applicationToken;
			IPublicClientSession publicClientSession = CheckTokensOnLogin(out applicationToken);
			if (publicClientSession == null && string.IsNullOrWhiteSpace(applicationToken))
			{
				LogServiceError((AuthorizationService s) => s.LoginWithBasic(), SR.T("Не задан токен авторизации приложения и сессия не найдена"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			ISspiService obj = Locator.GetService<ISspiService>() ?? throw PublicServiceException.CreateWebFault(SR.T("Сервис сквозной авторизации не найден"), 501);
			string userHostAddress = HttpContextAccessor.CurrentContext.Request.UserHostAddress;
			IUser user = obj.ValidateUser(ticket, "ElmaAgent", userHostAddress);
			if (user == null)
			{
				LogServiceError((AuthorizationService s) => s.LoginWithBasic(), SR.T("Текущий пользователь не опознан"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			CheckPublicApplicationUserAccess(applicationToken, user);
			Guid guid = authTokenService.CreateToken(user);
			if (publicClientSession != null)
			{
				clientSvc.UpdateAuthToken(publicClientSession.SessionToken, guid);
			}
			else
			{
				publicClientSession = clientSvc.CreateSession(guid, applicationToken);
			}
			if (publicClientSession == null)
			{
				LogServiceError((AuthorizationService s) => s.LoginWithBasic(), SR.T("Сессия не заполнена"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			OnAuthorizeUser(user, publicClientSession.SessionToken);
			return new AuthResponse
			{
				AuthToken = guid,
				SessionToken = publicClientSession.SessionToken,
				CurrentUserId = user.GetId().ToString(),
				CurrentUserName = user.UserName,
				Lang = user.Lang
			};
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			LogServiceError((AuthorizationService s) => s.LoginWithBasic(), ex2.ToString());
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка на сервере"), 500);
		}
	}

	public Guid TemporaryGuid()
	{
		try
		{
			ITemporaryAuthenticationService serviceNotNull = Locator.GetServiceNotNull<ITemporaryAuthenticationService>();
			ServiceTempAuthenticationInfo serviceTempAuthenticationInfo = new ServiceTempAuthenticationInfo
			{
				Key = Guid.NewGuid(),
				UserId = AuthenticationService.GetCurrentUser().GetId()
			};
			serviceNotNull.Add(serviceTempAuthenticationInfo);
			return serviceTempAuthenticationInfo.Key;
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			LogServiceError((AuthorizationService s) => s.TemporaryGuid(), ex2.ToString());
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка на сервере"), 500);
		}
	}

	public CheckPermissionResponse[] CheckPermissions(CheckPermissionRequest[] requestList)
	{
		try
		{
			ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
			List<CheckPermissionResponse> list = new List<CheckPermissionResponse>();
			IPermissionManagmentService serviceNotNull2 = Locator.GetServiceNotNull<IPermissionManagmentService>();
			CheckPermissionRequest[] array = requestList;
			foreach (CheckPermissionRequest checkPermissionRequest in array)
			{
				if (checkPermissionRequest.Id == Guid.Empty)
				{
					continue;
				}
				Permission permission = serviceNotNull2.GetPermission(checkPermissionRequest.Id);
				if (!(permission == null))
				{
					if (checkPermissionRequest.ObjectId > 0 && checkPermissionRequest.TypeUid != Guid.Empty)
					{
						IEntity entity = ModelHelper.GetEntity(checkPermissionRequest.TypeUid, checkPermissionRequest.ObjectId);
						list.Add(new CheckPermissionResponse
						{
							Id = checkPermissionRequest.Id,
							Allow = (serviceNotNull.CanCheckPermission(permission, entity) && serviceNotNull.HasPermission(permission, entity))
						});
					}
					else
					{
						list.Add(new CheckPermissionResponse
						{
							Id = checkPermissionRequest.Id,
							Allow = serviceNotNull.HasPermission(permission)
						});
					}
				}
			}
			return list.ToArray();
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			LogServiceError((AuthorizationService s) => s.CheckPermissions(requestList), ex2.ToString());
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка на сервере"), 500);
		}
	}

	public LogOutResponse ApplicationLogOut()
	{
		try
		{
			if (!Guid.TryParse(APIRouteProvider.GetRequestHeader("AuthToken"), out var result))
			{
				if (TryBearer())
				{
					return new LogOutResponse
					{
						Success = true
					};
				}
				LogServiceError((AuthorizationService s) => s.ApplicationLogOut(), SR.T("Неверный формат AuthToken"));
				throw new ArgumentException("Неверный формат AuthToken");
			}
			if (!long.TryParse(APIRouteProvider.GetRequestHeader("CurrentUserId"), out var result2))
			{
				LogServiceError((AuthorizationService s) => s.ApplicationLogOut(), SR.T("Неверный формат CurrentUserId"));
				throw new ArgumentException("Неверный формат CurrentUserId");
			}
			if (CheckTokensOnLogin(out var applicationToken) == null && string.IsNullOrWhiteSpace(applicationToken))
			{
				LogServiceError((AuthorizationService s) => s.ApplicationLogOut(), SR.T("Не задан токен авторизации приложения и сессия не найдена"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			IUser user = authTokenService.GetUser(result);
			if (user == null || (long)user.GetId() != result2)
			{
				LogServiceError((AuthorizationService s) => s.ApplicationLogOut(), SR.T("Текущий пользователь не опознан"));
				throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
			}
			authTokenService.RemoveToken(result);
			return new LogOutResponse
			{
				Success = true
			};
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			LogServiceError((AuthorizationService s) => s.ApplicationLogOut(), ex2.ToString());
			throw PublicServiceException.CreateWebFault(SR.T("Непредвиденная ошибка на сервере"), 500);
		}
		bool TryBearer()
		{
			string requestHeader = APIRouteProvider.GetRequestHeader("Authorization");
			if (!string.IsNullOrEmpty(requestHeader))
			{
				bool? flag = LogOutJwt(requestHeader);
				if (flag.HasValue)
				{
					if (!flag.Value)
					{
						string message = SR.T("Невалидный токен в заголовке {0}", "Authorization");
						LogServiceError((AuthorizationService s) => s.ApplicationLogOut(), message);
						throw PublicServiceException.CreateWebFault(message, 401);
					}
					return true;
				}
			}
			return false;
		}
	}

	private bool? LogOutJwt(string authorizationHeader)
	{
		if (authorizationHeader.IndexOf("Bearer ") != 0)
		{
			return null;
		}
		string jwtToken = authorizationHeader.Substring("Bearer ".Length);
		AuthInfoContainer authInfo = JwtAuthTokenService.GetAuthInfo(jwtToken);
		if (authInfo == null)
		{
			return false;
		}
		JwtAuthTokenService.Revoke(authInfo);
		return true;
	}

	private static void OnAuthorizeUser(IUser user, string sessionToken)
	{
		IAuthorizationServiceEventHandler serviceNotNull = Locator.GetServiceNotNull<IAuthorizationServiceEventHandler>();
		AuthorizeUserEventArgs e = new AuthorizeUserEventArgs
		{
			UserId = user.GetId().ToString(),
			SessionToken = sessionToken
		};
		serviceNotNull.OnAuthorizeUser(e);
	}

	private static void LogServiceError(Expression<Func<AuthorizationService, object>> method, string message)
	{
		EleWise.ELMA.Logging.Logger.Log.Error(SR.T("В сервисе \"{0}\" в методе \"{1}\" произошла ошибка: {2}", typeof(AuthorizationService), method, message));
	}

	private static void LogServiceError(Expression<Action<AuthorizationService>> method, string message)
	{
		EleWise.ELMA.Logging.Logger.Log.Error(SR.T("В сервисе \"{0}\" в методе \"{1}\" произошла ошибка: {2}", typeof(AuthorizationService), method, message));
	}

	private static IPublicClientSession CheckTokensOnLogin(out string applicationToken)
	{
		try
		{
			string requestHeader = APIRouteProvider.GetRequestHeader("SessionToken");
			applicationToken = APIRouteProvider.GetRequestHeader("ApplicationToken");
			if (requestHeader == null || applicationToken == null)
			{
				return null;
			}
			if (!Locator.GetServiceNotNull<IPublicClientService>().IsSessionValid(requestHeader, out var session))
			{
				return null;
			}
			if (session != null)
			{
				IPublicApplication application = session.Application;
				if (application != null)
				{
					ContextVars.Set("PublicContractInfo.ExecutingApplicationContextKey", application);
				}
			}
			return session;
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			throw PublicServiceException.CreateWebFault(ex2.ToString(), 500);
		}
	}

	private static IPublicClientSession GetCurrentSession()
	{
		try
		{
			IPublicClientService serviceNotNull = Locator.GetServiceNotNull<IPublicClientService>();
			Guid guidToken = APIRouteProvider.GetGuidToken("AuthToken");
			IPublicClientSession session = serviceNotNull.GetSession(guidToken);
			if (session == null || !serviceNotNull.IsSessionValid(session.SessionToken, out session))
			{
				return null;
			}
			if (session != null)
			{
				ContextVars.Set("PublicContractInfo.ExecutingApplicationContextKey", session.Application);
				ContextVars.Set("PublicContractInfo.SessionContextKey", session);
				serviceNotNull.PromoteSession(session.SessionToken);
			}
			return session;
		}
		catch (FaultException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			throw PublicServiceException.CreateWebFault(ex2.ToString(), 500);
		}
	}

	private static void CheckCurrentSession(Expression<Func<AuthorizationService, object>> method)
	{
		if (GetCurrentSession() != null)
		{
			return;
		}
		LogServiceError(method, SR.T("Не задан токен авторизации приложения или сессия не действительна"));
		throw PublicServiceException.CreateWebFault(SR.T("Ошибка авторизации"), 401);
	}

	private static ApiVersionResponse GetAllApiVersions()
	{
		ApiVersionResponse result = cachedAllVersions ?? new ApiVersionResponse
		{
			Version = "1.0.9",
			Services = (from t in ComponentManager.Current.GetExtensionPoints<IPublicService>()
				select new ApiServiceVersionResponse
				{
					Name = t.Name,
					Methods = (from m in ComponentManager.Current.GetExtensionPoints<IPublicServiceMethodsProvider>().SelectMany((IPublicServiceMethodsProvider provider) => from method in provider.GetMethods()
							where method.ServiceUid == t.Uid
							select method)
						select new ApiMethodResponse
						{
							Name = m.Name,
							Version = m.Version.ToString(3)
						}).ToArray()
				}).ToArray()
		};
		cachedAllVersions = result;
		return result;
	}

	private static ApiVersionResponse GetApiVersion()
	{
		return new ApiVersionResponse
		{
			Version = "1.0.9"
		};
	}

	private void CheckPublicApplicationUserAccess(string applicationToken, IUser user)
	{
		if (!Locator.GetServiceNotNull<IPublicApplicationService>().HasUserAccess(applicationToken, user))
		{
			LogServiceError((Expression<Action<AuthorizationService>>)((AuthorizationService s) => s.CheckPublicApplicationUserAccess(applicationToken, user)), SR.T("Нет доступа у пользователя {0} по токену приложения {1}", user.UserName, applicationToken));
			throw PublicServiceException.CreateWebFault(SR.T("Нет доступа к приложению, или приложение не активировано"), 403);
		}
	}
}
