using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Threading;
using EleWise.ELMA.API;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;

namespace EleWise.ELMA.Web.Service;

[AttributeUsage(AttributeTargets.Method)]
public class AuthorizeOperationBehavior : Attribute, IOperationBehavior
{
	internal class SecurityOperationInvoker : IOperationInvoker
	{
		private IOperationInvoker InnerOperationInvoker { get; set; }

		protected string InnerReplyAction { get; set; }

		protected string InnerAction { get; set; }

		public bool IsSynchronous => InnerOperationInvoker.IsSynchronous;

		private static IJwtAuthTokenService JwtAuthTokenService => Locator.GetServiceNotNull<IJwtAuthTokenService>();

		private static IPublicApplicationService ApplicationService => Locator.GetServiceNotNull<IPublicApplicationService>();

		private static IMembershipService MembershipService => Locator.GetServiceNotNull<IMembershipService>();

		public SecurityOperationInvoker(DispatchOperation dispatchOperation)
		{
			InnerOperationInvoker = dispatchOperation.Invoker;
			InnerAction = dispatchOperation.Action;
			InnerReplyAction = dispatchOperation.ReplyAction;
		}

		public object[] AllocateInputs()
		{
			return InnerOperationInvoker.AllocateInputs();
		}

		public static CultureInfo ResolveCultureInfo(IUser user)
		{
			bool flag = true;
			if (WebOperationContext.Current != null)
			{
				try
				{
					List<string> list = WebOperationContext.Current.IncomingRequest.UriTemplateMatch.RequestUri.Segments.Select((string s) => s.ToLower().Replace("/", "")).ToList();
					flag = !list.Contains("rest") || !list.Contains("help");
				}
				catch (Exception)
				{
				}
			}
			if (flag)
			{
				CultureInfo requestLanguage = APIRouteProvider.GetRequestLanguage();
				if (requestLanguage != null)
				{
					return requestLanguage;
				}
			}
			if (user != null && !string.IsNullOrEmpty(user.Lang))
			{
				try
				{
					CultureInfo requestLanguage = SR.GetCultureByName(user.Lang);
					if (requestLanguage != null)
					{
						return requestLanguage;
					}
				}
				catch (Exception)
				{
				}
			}
			return SR.GetCultureFromSettings() ?? SR.KeyCultureInfo;
		}

		protected void SetThreadCulture()
		{
			CultureInfo cultureInfo = ResolveCultureInfo(Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser());
			Thread.CurrentThread.CurrentCulture = cultureInfo;
			Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(cultureInfo.Name);
		}

		public object Invoke(object instance, object[] inputs, out object[] outputs)
		{
			object result = null;
			object[] output = null;
			InvokeWithCheck(delegate
			{
				SetThreadCulture();
				result = InnerOperationInvoker.Invoke(instance, inputs, out output);
			});
			outputs = output;
			return result;
		}

		public IAsyncResult InvokeBegin(object instance, object[] inputs, AsyncCallback callback, object state)
		{
			IAsyncResult asyncResult = null;
			InvokeWithCheck(delegate
			{
				TranslateService.Instance.InLineDisabled = true;
				SetThreadCulture();
				asyncResult = InnerOperationInvoker.InvokeBegin(instance, inputs, callback, state);
			});
			return asyncResult;
		}

		public object InvokeEnd(object instance, out object[] outputs, IAsyncResult result)
		{
			return InnerOperationInvoker.InvokeEnd(instance, out outputs, result);
		}

		private static void InvokeWithCheck(Action callIfOk)
		{
			try
			{
				if (callIfOk == null)
				{
					throw new ArgumentNullException("callIfOk");
				}
				IPublicClientService service = Locator.GetService<IPublicClientService>();
				AuthorizeContractBehavior.SecurityServiceAuthorizationManager.CheckTrustedServices(OperationContext.Current);
				if (ContextVars.TryGetValue<IPublicClientSession>("PublicContractInfo.SessionContextKey", out var value))
				{
					IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
					if (value.AuthUser == currentUser)
					{
						callIfOk();
						service?.PromoteSession(value.SessionToken);
						return;
					}
				}
				string requestHeader = APIRouteProvider.GetRequestHeader("AuthToken");
				if (!string.IsNullOrEmpty(requestHeader) && Guid.TryParse(requestHeader, out var result) && service != null)
				{
					value = service.GetSession(result);
					if (value == null || !service.IsSessionValid(value.SessionToken, out value))
					{
						throw PublicServiceException.CreateWebFault(SR.T("Токен авторизации недействителен"), 401);
					}
					if (!Locator.GetServiceNotNull<IPublicSignatureService>().CheckRequestSignature(value))
					{
						throw PublicServiceException.CreateWebFault(SR.T("Неверная подпись запроса"), 401);
					}
					IUser user = Locator.GetServiceNotNull<IAuthenticationTokenService>().GetUser(result);
					if (user == null || !object.Equals(value.AuthUser.GetId(), user.GetId()))
					{
						throw PublicServiceException.CreateWebFault(SR.T("Токен авторизации недействителен"), 401);
					}
					Locator.GetServiceNotNull<IAuthenticationService>().SetAuthenticatedUserForRequest(user);
					ContextVars.Set("PublicContractInfo.ExecutingApplicationContextKey", value.Application);
					ContextVars.Set("PublicContractInfo.SessionContextKey", value);
					if (!Locator.GetServiceNotNull<IPublicApplicationService>().HasUserAccess(value.ClientToken.Token, user))
					{
						throw PublicServiceException.CreateWebFault(SR.T("Нет доступа к приложению, или приложение не активировано"), 403);
					}
					callIfOk();
					service.PromoteSession(value.SessionToken);
					return;
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
						callIfOk();
						return;
					}
				}
				throw PublicServiceException.CreateWebFault(SR.T("Необходимо указать заголовок авторизации: {0}", "AuthToken"), 401);
			}
			catch (SecurityException ex)
			{
				throw PublicServiceException.CreateWebFault(ex.Message, 401);
			}
			catch (FaultException)
			{
				throw;
			}
		}

		private static bool? CheckBearerAuth(string authorizationHeader)
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
			return true;
		}
	}

	private const string AuthTokenHeader = "AuthToken";

	private const string AuthorizationHeader = "Authorization";

	private const string Bearer = "Bearer ";

	void IOperationBehavior.Validate(OperationDescription operationDescription)
	{
	}

	void IOperationBehavior.ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
	{
		dispatchOperation.Invoker = new SecurityOperationInvoker(dispatchOperation);
	}

	void IOperationBehavior.ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
	{
	}

	void IOperationBehavior.AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
	{
	}
}
