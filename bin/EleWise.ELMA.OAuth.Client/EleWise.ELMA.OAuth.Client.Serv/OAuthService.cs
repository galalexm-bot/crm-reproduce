using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.OAuth.Client.Services;

[Service(Scope = ServiceScope.Shell)]
internal class OAuthService : IOAuthService
{
	[NotNull]
	private readonly UserManager userManager;

	[NotNull]
	private readonly UserSecurityProfileManager userSecurityProfileManager;

	[NotNull]
	private readonly IMembershipServiceEventHandler membershipServiceEventHandler;

	[NotNull]
	private readonly IMembershipServiceEventHandler2 membershipServiceEventHandler2;

	[NotNull]
	private readonly IEnumerable<IOAuthProvider> oAuthProvider;

	public OAuthService(UserManager userManager, UserSecurityProfileManager userSecurityProfileManager, IMembershipServiceEventHandler2 membershipServiceEventHandler2, IMembershipServiceEventHandler membershipServiceEventHandler, IEnumerable<IOAuthProvider> oAuthProvider)
	{
		this.userManager = userManager;
		this.userSecurityProfileManager = userSecurityProfileManager;
		this.membershipServiceEventHandler = membershipServiceEventHandler;
		this.membershipServiceEventHandler2 = membershipServiceEventHandler2;
		this.oAuthProvider = oAuthProvider;
	}

	public EleWise.ELMA.Security.IUser ValidateUser(string token, Guid providerUid)
	{
		Contract.ArgumentNotNull(token, "token");
		Contract.ArgumentNotNull(providerUid, "providerUid");
		IOAuthProvider iOAuthProvider = oAuthProvider.FirstOrDefault((IOAuthProvider a) => providerUid.Equals(a.ProviderUid));
		if (iOAuthProvider == null)
		{
			membershipServiceEventHandler2.ValidationError(new UserValidationContext
			{
				Error = new Exception(string.Format(SR.T("Ошибка авторизации пользователя по ключу внешней системы. Не определен провайдер аутентификации")))
			});
			return null;
		}
		EleWise.ELMA.Security.Models.IUser user = iOAuthProvider.UserByToken(token);
		if (user != null)
		{
			if (userSecurityProfileManager.Load(user).DisallowLogon)
			{
				return null;
			}
			UserValidationContext validationContext = new UserValidationContext
			{
				Authorized = true,
				User = user
			};
			return ValidateUserContext(validationContext);
		}
		membershipServiceEventHandler2.ValidationError(new UserValidationContext
		{
			Error = new Exception(string.Format(SR.T("Ошибка авторизации пользователя по ключу внешней системы")))
		});
		return null;
	}

	private EleWise.ELMA.Security.IUser ValidateUserContext(UserValidationContext validationContext)
	{
		if (TryUserError(validationContext))
		{
			return null;
		}
		try
		{
			membershipServiceEventHandler.Validating(validationContext);
			if (validationContext.Error == null)
			{
				membershipServiceEventHandler.Validated(validationContext);
				return validationContext.User;
			}
			membershipServiceEventHandler2.ValidationError(validationContext);
		}
		catch (Exception ex)
		{
			membershipServiceEventHandler2.ValidationError(validationContext);
			Logger.Log.Error(ex.Message, ex);
		}
		return null;
	}

	private bool TryUserError(UserValidationContext context)
	{
		if ((context.User as EleWise.ELMA.Security.Models.IUser).Status == UserStatus.Blocked)
		{
			context.Error = new AuthenticationException(SR.T("Учетная запись заблокирована"));
		}
		else if ((context.User as EleWise.ELMA.Security.Models.IUser).Status == UserStatus.System)
		{
			context.Error = new AuthenticationException(SR.T("Учетная запись является системной"));
		}
		if (context.Error != null)
		{
			membershipServiceEventHandler2.ValidationError(context);
		}
		return context.Error != null;
	}
}
