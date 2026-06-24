using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class AuthorizeContractBehavior : Attribute, IContractBehavior
{
	internal class SecurityServiceAuthorizationManager : ServiceAuthorizationManager
	{
		[Serializable]
		internal sealed class TrustedServiceApplication : IPublicApplication
		{
			public Guid Uid { get; private set; }

			public string Name { get; private set; }

			public string Description { get; private set; }

			public string Author { get; private set; }

			public string Site { get; private set; }

			internal static TrustedServiceApplication GetApplication(string name)
			{
				return new TrustedServiceApplication(new Guid("58381AA7-39CD-4346-AFEC-4236E0E6DD7B"), name, "Trusted service application", "ELMA", "www.elma-bpm.ru");
			}

			private TrustedServiceApplication(Guid uid, string name, string description, string author, string site)
			{
				Uid = uid;
				Name = name;
				Description = description;
				Author = author;
				Site = site;
			}
		}

		[Serializable]
		internal sealed class TrustedServiceToken : IPublicApplicationToken
		{
			public IPublicApplication Application { get; private set; }

			public string Token { get; private set; }

			public DateTime Expire { get; private set; }

			internal static TrustedServiceToken GetToken(TrustedServiceApplication application, string sessionToken)
			{
				string token = SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(sessionToken + Guid.NewGuid().ToString("N"))).ToHexString();
				return new TrustedServiceToken(application, token, DateTime.MaxValue);
			}

			private TrustedServiceToken(IPublicApplication application, string token, DateTime expire)
			{
				Application = application;
				Token = token;
				Expire = expire;
			}
		}

		[Serializable]
		internal sealed class TrustedServiceSession : IPublicClientSession
		{
			public Guid AuthToken { get; private set; }

			public IPublicApplicationToken ClientToken { get; private set; }

			public IPublicApplication Application { get; private set; }

			public string SessionToken { get; private set; }

			public IUser AuthUser { get; private set; }

			public DateTime LastAccess { get; private set; }

			public byte[] LastChangesPackage { get; set; }

			internal static TrustedServiceSession GetSession(TrustedServiceApplication application, IUser user)
			{
				Guid authToken = Guid.NewGuid();
				string sessionToken = SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(application.Uid.ToString("N") + authToken.ToString("N"))).ToHexString();
				return new TrustedServiceSession(authToken, application, sessionToken, user, DateTime.Now);
			}

			private TrustedServiceSession(Guid authToken, TrustedServiceApplication application, string sessionToken, IUser authUser, DateTime lastAccess)
			{
				AuthToken = authToken;
				Application = application;
				SessionToken = sessionToken;
				AuthUser = authUser;
				LastAccess = lastAccess;
				ClientToken = TrustedServiceToken.GetToken(application, sessionToken);
			}
		}

		private readonly string[] skipOperations;

		internal const string TrustedServicesSettingsKey = "TrustedServices.PrefixList";

		private static IJwtAuthTokenService JwtAuthTokenService => Locator.GetServiceNotNull<IJwtAuthTokenService>();

		private static IPublicApplicationService ApplicationService => Locator.GetServiceNotNull<IPublicApplicationService>();

		private static IMembershipService MembershipService => Locator.GetServiceNotNull<IMembershipService>();

		public SecurityServiceAuthorizationManager(string[] skipOperations)
		{
			this.skipOperations = skipOperations;
		}

		protected void SetThreadCulture(IUser user)
		{
			CultureInfo cultureInfo = AuthorizeOperationBehavior.SecurityOperationInvoker.ResolveCultureInfo(user);
			Thread.CurrentThread.CurrentCulture = cultureInfo;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);
		}

		protected override bool CheckAccessCore(OperationContext operationContext)
		{
			TranslateService.Instance.InLineDisabled = true;
			if (OperationSkipAuthorization(operationContext))
			{
				SetThreadCulture(null);
				return true;
			}
			if (CheckTrustedServices(operationContext))
			{
				SetThreadCulture(null);
				return true;
			}
			string requestHeader = APIRouteProvider.GetRequestHeader("AuthToken");
			if (!string.IsNullOrEmpty(requestHeader) && Guid.TryParse(requestHeader, out var result))
			{
				IPublicClientService serviceNotNull = Locator.GetServiceNotNull<IPublicClientService>();
				IPublicClientSession session = serviceNotNull.GetSession(result);
				if (session == null || !serviceNotNull.IsSessionValid(session.SessionToken, out session))
				{
					throw PublicServiceException.CreateWebFault(SR.T("Токен авторизации недействителен"), 401);
				}
				if (!Locator.GetServiceNotNull<IPublicSignatureService>().CheckRequestSignature(session))
				{
					throw PublicServiceException.CreateWebFault(SR.T("Неверная подпись запроса"), 401);
				}
				IUser user = Locator.GetServiceNotNull<IAuthenticationTokenService>().GetUser(result);
				if (user == null || !object.Equals(session.AuthUser.GetId(), user.GetId()))
				{
					throw PublicServiceException.CreateWebFault(SR.T("Токен авторизации недействителен"), 401);
				}
				Locator.GetServiceNotNull<IAuthenticationService>().SetAuthenticatedUserForRequest(user);
				ContextVars.Set("PublicContractInfo.ExecutingApplicationContextKey", session.Application);
				ContextVars.Set("PublicContractInfo.SessionContextKey", session);
				if (!Locator.GetServiceNotNull<IPublicApplicationService>().HasUserAccess(session.ClientToken.Token, user))
				{
					throw PublicServiceException.CreateWebFault(SR.T("Нет доступа к приложению, или приложение не активировано"), 403);
				}
				serviceNotNull.PromoteSession(session.SessionToken);
				SetThreadCulture(user);
				return true;
			}
			string requestHeader2 = APIRouteProvider.GetRequestHeader("Authorization");
			if (!string.IsNullOrEmpty(requestHeader2))
			{
				bool? flag = CheckBearerAuth(requestHeader2);
				if (flag.HasValue)
				{
					if (!flag.Value)
					{
						throw PublicServiceException.CreateWebFault(SR.T("Невалидный токен в заголовке {0}", "Authorization"), 401);
					}
					return true;
				}
			}
			throw PublicServiceException.CreateWebFault(SR.T("Необходимо указать валидный заголовок авторизации {0}", "Auth-Info"), 401);
		}

		internal static bool CheckTrustedServices(OperationContext operationContext, bool authorizeTrustedUser = true)
		{
			string setting = SR.GetSetting("TrustedServices.PrefixList");
			if (setting.IsNullOrWhiteSpace())
			{
				return false;
			}
			return setting.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries).Any((string prefix) => CheckTrustedServiceAccess(prefix, operationContext, authorizeTrustedUser));
		}

		private static bool CheckTrustedServiceAccess(string prefix, OperationContext operationContext, bool authorizeTrustedUser = true)
		{
			try
			{
				if (prefix.IsNullOrWhiteSpace())
				{
					return false;
				}
				string requestHeader = APIRouteProvider.GetRequestHeader("TrustedServiceToken");
				if (requestHeader.IsNullOrWhiteSpace())
				{
					return false;
				}
				if (SR.GetSetting(prefix + ".Token") != requestHeader)
				{
					return false;
				}
				string requestHeader2 = APIRouteProvider.GetRequestHeader("TrustedServiceHash");
				if (requestHeader2.IsNullOrWhiteSpace())
				{
					return false;
				}
				string[] array = requestHeader2.Split(new string[1] { ";" }, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length != 2)
				{
					return false;
				}
				string s = array[1];
				string text = array[0];
				string s2 = operationContext.IncomingMessageHeaders.Action ?? ((string)operationContext.IncomingMessageProperties["HttpOperationName"]);
				string setting = SR.GetSetting(prefix + ".Salt");
				if (setting.IsNullOrWhiteSpace())
				{
					return false;
				}
				MD5 mD = MD5.Create();
				bool flag = Convert.ToBase64String(mD.ComputeHash(mD.ComputeHash(Encoding.UTF8.GetBytes(s2).Concat(Convert.FromBase64String(s)).ToArray()).Concat(Convert.FromBase64String(setting)).ToArray())) == text;
				if (flag && authorizeTrustedUser)
				{
					string setting2 = SR.GetSetting(prefix + ".User");
					if (setting2.IsNullOrWhiteSpace())
					{
						return false;
					}
					IUser user = Locator.GetServiceNotNull<IMembershipService>().GetUser(setting2);
					if (user == null)
					{
						return false;
					}
					Locator.GetServiceNotNull<IAuthenticationService>().SetAuthenticatedUserForRequest(user);
					TrustedServiceApplication application = TrustedServiceApplication.GetApplication(prefix);
					ContextVars.Set("PublicContractInfo.ExecutingApplicationContextKey", application);
					ContextVars.Set("PublicContractInfo.SessionContextKey", TrustedServiceSession.GetSession(application, user));
				}
				return flag;
			}
			catch (Exception exception)
			{
				Logger.Log.Error(SR.T("Ошибка проверки доверенного сервиса"), exception);
			}
			return false;
		}

		private bool OperationSkipAuthorization(OperationContext operationContext)
		{
			string text = operationContext.IncomingMessageHeaders.Action ?? ((string)operationContext.IncomingMessageProperties["HttpOperationName"]);
			if (string.IsNullOrWhiteSpace(text) || text == "HelpPageInvoke")
			{
				return true;
			}
			if (skipOperations != null)
			{
				return skipOperations.Contains(text);
			}
			return false;
		}

		private bool? CheckBearerAuth(string authorizationHeader)
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
			IUser user = MembershipService.GetUser(authInfo.UserId);
			if (user == null)
			{
				throw PublicServiceException.CreateWebFault(SR.T("Пользователь с идентификатором {0} не найден", authInfo.UserId), 401);
			}
			if (!ApplicationService.HasUserAccess(authInfo.ApplicationToken, user))
			{
				throw PublicServiceException.CreateWebFault(SR.T("Нет доступа к приложению, или приложение не активировано"), 403);
			}
			Locator.GetServiceNotNull<IAuthenticationService>().SetAuthenticatedUserForRequest(user);
			SetThreadCulture(user);
			return true;
		}
	}

	private const string AuthTokenHeader = "AuthToken";

	private const string AuthInfoHeader = "Auth-Info";

	private const string AuthorizationHeader = "Authorization";

	private const string Bearer = "Bearer ";

	public string[] SkipOperations { get; set; }

	void IContractBehavior.Validate(ContractDescription contractDescription, ServiceEndpoint endpoint)
	{
	}

	void IContractBehavior.ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime)
	{
		dispatchRuntime.ServiceAuthorizationManager = new SecurityServiceAuthorizationManager(SkipOperations);
	}

	void IContractBehavior.ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, ClientRuntime clientRuntime)
	{
	}

	void IContractBehavior.AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
	{
	}
}
