using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Services;

public static class AuthenticationService
{
	private static IAuthenticationService service;

	private static AuthenticationService Puh06FBsJp7LHL3ytlDx;

	private static IAuthenticationService Service
	{
		get
		{
			int num = 1;
			int num2 = num;
			IAuthenticationService authenticationService;
			while (true)
			{
				switch (num2)
				{
				case 1:
					authenticationService = service;
					if (authenticationService == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					authenticationService = (service = Locator.GetServiceNotNull<IAuthenticationService>());
					break;
				}
				break;
			}
			return authenticationService;
		}
	}

	public static string CurrentUserName => (string)ETvpsuBsrjXElfUHf2Ge(onDc9ABslX6Jbb5bM0OP());

	public static string CurrentUserFullName => (string)aoYhAUBsgy6Gihpx4VDK(onDc9ABslX6Jbb5bM0OP());

	public static string CurrentUserEMail => (string)GXXZAQBs54mcdbLxTUQA(GetCurrentUser());

	static AuthenticationService()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	public static IUser GetCurrentUser()
	{
		return Service.GetCurrentUser();
	}

	public static T GetCurrentUser<T>() where T : IUser
	{
		return Service.GetCurrentUser<T>();
	}

	public static void SignIn(IUser user, bool rememberMeSet)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				((IAuthenticationService)uEDHhGBsjNmWhMdLOJyY()).SignIn(user, rememberMeSet, checkRequireChangePassword: false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void SignIn(IUser user, bool rememberMeSet, bool checkRequireChangePassword)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				oAVaVgBsYcVSCinRWbF3(uEDHhGBsjNmWhMdLOJyY(), user, rememberMeSet, checkRequireChangePassword);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void SignOut()
	{
		((IAuthenticationService)uEDHhGBsjNmWhMdLOJyY()).SignOut();
	}

	public static void SetAuthenticatedUserForRequest(IUser user)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				V2aZdvBsLK0ydBoFNtVf(uEDHhGBsjNmWhMdLOJyY(), user);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool ztg8miBs9VbxPTm8Crbe()
	{
		return Puh06FBsJp7LHL3ytlDx == null;
	}

	internal static AuthenticationService wqPVSsBsdAcPENXsVvZO()
	{
		return Puh06FBsJp7LHL3ytlDx;
	}

	internal static object onDc9ABslX6Jbb5bM0OP()
	{
		return GetCurrentUser();
	}

	internal static object ETvpsuBsrjXElfUHf2Ge(object P_0)
	{
		return ((IUser)P_0).UserName;
	}

	internal static object aoYhAUBsgy6Gihpx4VDK(object P_0)
	{
		return ((IUser)P_0).FullName;
	}

	internal static object GXXZAQBs54mcdbLxTUQA(object P_0)
	{
		return ((IUser)P_0).EMail;
	}

	internal static object uEDHhGBsjNmWhMdLOJyY()
	{
		return Service;
	}

	internal static void oAVaVgBsYcVSCinRWbF3(object P_0, object P_1, bool rememberMeSet, bool checkRequireChangePassword)
	{
		((IAuthenticationService)P_0).SignIn((IUser)P_1, rememberMeSet, checkRequireChangePassword);
	}

	internal static void V2aZdvBsLK0ydBoFNtVf(object P_0, object P_1)
	{
		((IAuthenticationService)P_0).SetAuthenticatedUserForRequest((IUser)P_1);
	}
}
