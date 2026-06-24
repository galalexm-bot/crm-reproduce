// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.AuthenticationService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Статический сервис для быстрого доступа к текущему <see cref="T:EleWise.ELMA.Security.Services.IAuthenticationService" />
  /// </summary>
  public static class AuthenticationService
  {
    private static IAuthenticationService service;
    private static AuthenticationService Puh06FBsJp7LHL3ytlDx;

    private static IAuthenticationService Service
    {
      get
      {
        int num = 1;
        IAuthenticationService service;
        while (true)
        {
          switch (num)
          {
            case 1:
              service = AuthenticationService.service;
              if (service == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return service;
label_5:
        return AuthenticationService.service = Locator.GetServiceNotNull<IAuthenticationService>();
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:System.Object" /> class.
    /// </summary>
    static AuthenticationService() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    public static string CurrentUserName => (string) AuthenticationService.ETvpsuBsrjXElfUHf2Ge(AuthenticationService.onDc9ABslX6Jbb5bM0OP());

    public static string CurrentUserFullName => (string) AuthenticationService.aoYhAUBsgy6Gihpx4VDK(AuthenticationService.onDc9ABslX6Jbb5bM0OP());

    public static string CurrentUserEMail => (string) AuthenticationService.GXXZAQBs54mcdbLxTUQA((object) AuthenticationService.GetCurrentUser());

    /// <summary>Получить текущего пользователя системы</summary>
    /// <returns>Текущий пользователь, либо <c>null</c></returns>
    public static IUser GetCurrentUser() => AuthenticationService.Service.GetCurrentUser();

    /// <summary>Получить текущего пользователя системы</summary>
    /// <typeparam name="T">Тип пользователя</typeparam>
    /// <returns>Текущий пользователь, либо <c>null</c></returns>
    public static T GetCurrentUser<T>() where T : IUser => AuthenticationService.Service.GetCurrentUser<T>();

    /// <summary>Авторизовать пользователя системы</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="rememberMeSet">Запомнить авторизацию для следующей сессии</param>
    public static void SignIn(IUser user, bool rememberMeSet)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ((IAuthenticationService) AuthenticationService.uEDHhGBsjNmWhMdLOJyY()).SignIn(user, rememberMeSet, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Авторизовать пользователя системы</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="rememberMeSet">Запомнить авторизацию для следующей сессии</param>
    /// <param name="checkRequireChangePassword">Проверять обязательную смену пароля</param>
    public static void SignIn(IUser user, bool rememberMeSet, bool checkRequireChangePassword)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AuthenticationService.oAVaVgBsYcVSCinRWbF3(AuthenticationService.uEDHhGBsjNmWhMdLOJyY(), (object) user, rememberMeSet, checkRequireChangePassword);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Убрать авторизацию пользователя</summary>
    public static void SignOut() => ((IAuthenticationService) AuthenticationService.uEDHhGBsjNmWhMdLOJyY()).SignOut();

    /// <summary>
    /// Установить авторизованного пользователя только в рамках этого запроса
    /// </summary>
    /// <param name="user">Пользователь</param>
    public static void SetAuthenticatedUserForRequest(IUser user)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AuthenticationService.V2aZdvBsLK0ydBoFNtVf(AuthenticationService.uEDHhGBsjNmWhMdLOJyY(), (object) user);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool ztg8miBs9VbxPTm8Crbe() => AuthenticationService.Puh06FBsJp7LHL3ytlDx == null;

    internal static AuthenticationService wqPVSsBsdAcPENXsVvZO() => AuthenticationService.Puh06FBsJp7LHL3ytlDx;

    internal static object onDc9ABslX6Jbb5bM0OP() => (object) AuthenticationService.GetCurrentUser();

    internal static object ETvpsuBsrjXElfUHf2Ge([In] object obj0) => (object) ((IUser) obj0).UserName;

    internal static object aoYhAUBsgy6Gihpx4VDK([In] object obj0) => (object) ((IUser) obj0).FullName;

    internal static object GXXZAQBs54mcdbLxTUQA([In] object obj0) => (object) ((IUser) obj0).EMail;

    internal static object uEDHhGBsjNmWhMdLOJyY() => (object) AuthenticationService.Service;

    internal static void oAVaVgBsYcVSCinRWbF3(
      [In] object obj0,
      [In] object obj1,
      bool rememberMeSet,
      bool checkRequireChangePassword)
    {
      ((IAuthenticationService) obj0).SignIn((IUser) obj1, rememberMeSet, checkRequireChangePassword);
    }

    internal static void V2aZdvBsLK0ydBoFNtVf([In] object obj0, [In] object obj1) => ((IAuthenticationService) obj0).SetAuthenticatedUserForRequest((IUser) obj1);
  }
}
