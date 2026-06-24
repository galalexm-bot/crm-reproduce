// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.WebRequestAuthorizedEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;
using System.Web;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об авторизации пользователя в системе
  /// </summary>
  public class WebRequestAuthorizedEvent : DiagnosticsEvent
  {
    internal static WebRequestAuthorizedEvent vK4SCIETloeT35TDgg6M;

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="context">Контекст Web-запроса</param>
    /// <param name="user">Пользователь</param>
    public WebRequestAuthorizedEvent(
      CallContextInfo callContextInfo,
      HttpContext context,
      IUser user)
    {
      WebRequestAuthorizedEvent.mgE54FET5VWq9fs005j9();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Context = context;
            num = 4;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.User = user;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          case 4:
            this.Level = LogLevel.Information;
            num = 3;
            continue;
          default:
            this.Message = EleWise.ELMA.SR.T(true, (string) WebRequestAuthorizedEvent.oGTZOnETjeZQfjMsny5A(236071375 ^ 236351933), WebRequestAuthorizedEvent.M3Di37ETYc26FmKndTRX((object) user));
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Контекст Web-запроса</summary>
    public HttpContext Context
    {
      get => this.\u003CContext\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CContext\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Пользователь</summary>
    public IUser User
    {
      get => this.\u003CUser\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CUser\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static void mgE54FET5VWq9fs005j9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object oGTZOnETjeZQfjMsny5A(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object M3Di37ETYc26FmKndTRX([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static bool FmK19TETrwB5UE4BuuCE() => WebRequestAuthorizedEvent.vK4SCIETloeT35TDgg6M == null;

    internal static WebRequestAuthorizedEvent r7VOcLETgh7FJGOKiVJR() => WebRequestAuthorizedEvent.vK4SCIETloeT35TDgg6M;
  }
}
