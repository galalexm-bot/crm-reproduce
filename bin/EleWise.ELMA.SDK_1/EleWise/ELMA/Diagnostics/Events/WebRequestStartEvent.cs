// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.WebRequestStartEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;
using System.Web;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее о начале выполнения Web-запроса
  /// </summary>
  public class WebRequestStartEvent : DiagnosticsEvent
  {
    private static WebRequestStartEvent IE5RXwEkfkO1yinZUuEl;

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="context">Контекст Web-запроса</param>
    public WebRequestStartEvent(CallContextInfo callContextInfo, HttpContext context)
    {
      WebRequestStartEvent.wgl7Y5EkvKoeROh44U6L();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Level = LogLevel.Information;
            num = 3;
            continue;
          case 3:
            this.Message = EleWise.ELMA.SR.T(true, (string) WebRequestStartEvent.moiuRWEk8CboruTYXIiF(1178210108 ^ 1178490446), (object) callContextInfo.StartTime.ConvertUtcToLocal().ToString((string) WebRequestStartEvent.moiuRWEk8CboruTYXIiF(-680446928 - -370807692 ^ -309375486)), (object) callContextInfo.ManagedThreadId, WebRequestStartEvent.rLr4r4EkZrciQ2GbC6aT((object) callContextInfo), WebRequestStartEvent.Kj8QrkEkuVpoQltuqwwD((object) callContextInfo), WebRequestStartEvent.f1MwgrEkIyRjwxpeSdDe((object) callContextInfo));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
            continue;
          default:
            this.Context = context;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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

    internal static void wgl7Y5EkvKoeROh44U6L() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object moiuRWEk8CboruTYXIiF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object rLr4r4EkZrciQ2GbC6aT([In] object obj0) => (object) ((CallContextInfo) obj0).HttpMethod;

    internal static object Kj8QrkEkuVpoQltuqwwD([In] object obj0) => (object) ((CallContextInfo) obj0).Name;

    internal static object f1MwgrEkIyRjwxpeSdDe([In] object obj0) => (object) ((CallContextInfo) obj0).UserHostAddress;

    internal static bool jQQi9yEkQikklVAp4DnX() => WebRequestStartEvent.IE5RXwEkfkO1yinZUuEl == null;

    internal static WebRequestStartEvent HVYC5mEkCW6pnh3DfrCM() => WebRequestStartEvent.IE5RXwEkfkO1yinZUuEl;
  }
}
