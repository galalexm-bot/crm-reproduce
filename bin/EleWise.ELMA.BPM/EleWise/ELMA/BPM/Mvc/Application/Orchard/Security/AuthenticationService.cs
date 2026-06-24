// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.BPM.Mvc.Application.Orchard.Security.AuthenticationService
// Assembly: EleWise.ELMA.BPM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EE1B80B5-F464-4FFF-85CF-6A69B66F676D
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.BPM.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using Orchard;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.BPM.Mvc.Application.Orchard.Security
{
  /// <summary>Сервис для управления аутентификацией</summary>
  public class AuthenticationService : Orchard.Security.IAuthenticationService, IDependency
  {
    private readonly EleWise.ELMA.Security.Services.IAuthenticationService authenticationService;
    internal static AuthenticationService bxLnDqAnrpLhFIbrk2W;

    /// <summary>Ctor</summary>
    /// <param name="authenticationService">Сервис аутентификации</param>
    public AuthenticationService([NotNull] EleWise.ELMA.Security.Services.IAuthenticationService authenticationService)
    {
      AuthenticationService.Rfi2lIAK9Bq1lv4iEVX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (<Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_f0d1bba4ac354526b5e9d10858e05d66 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (authenticationService != null)
            {
              num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_a8d19b8ac515491596472bbbe20cf06b == 0 ? 3 : 1;
              continue;
            }
            goto label_5;
          case 2:
            goto label_7;
          case 3:
            this.authenticationService = authenticationService;
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_1e79dc0610de45c592ecefd56530deb8 != 0 ? 2 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_7:
      return;
label_5:
      throw new ArgumentNullException((string) AuthenticationService.X03hjqAvyYm8yRaFhad(1859810385 ^ -816524181 ^ -1584484302));
    }

    /// <summary>Авторизоваться</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="createPersistentCookie">Создать хранимые куки</param>
    public void SignIn(Orchard.Security.IUser user, bool createPersistentCookie) => throw new NotImplementedException();

    /// <summary>Разлогиниться</summary>
    public void SignOut() => throw new NotImplementedException();

    /// <summary>Получить авторизованных пользователей</summary>
    /// <param name="user">Пользователь</param>
    public void SetAuthenticatedUserForRequest(Orchard.Security.IUser user) => throw new NotImplementedException();

    /// <summary>Устновить авторизованного пользователя</summary>
    /// <returns></returns>
    public Orchard.Security.IUser GetAuthenticatedUser()
    {
      int num = 1;
      EleWise.ELMA.Security.Models.IUser currentUser;
      while (true)
      {
        switch (num)
        {
          case 1:
            currentUser = this.authenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
            num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_6341d0b5e4864f4ea84d119cd91bd0cd == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (currentUser == null)
            {
              num = <Module>\u007B504e5b1f\u002D950e\u002D4a78\u002D8884\u002D439e3d0cd04d\u007D.m_4857ff0c85a64b17b36a438afd6598b1 == 0 ? 2 : 0;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return (Orchard.Security.IUser) null;
label_6:
      return (Orchard.Security.IUser) new OrchardUser(currentUser);
    }

    internal static void Rfi2lIAK9Bq1lv4iEVX() => TKW1L3mlUyvXmg29jA.RWk58XigPN();

    internal static object X03hjqAvyYm8yRaFhad(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool v5eXLOAtDKGpysRCOT6() => AuthenticationService.bxLnDqAnrpLhFIbrk2W == null;

    internal static AuthenticationService WJSRTZA20rLKRS9UjKs() => AuthenticationService.bxLnDqAnrpLhFIbrk2W;
  }
}
