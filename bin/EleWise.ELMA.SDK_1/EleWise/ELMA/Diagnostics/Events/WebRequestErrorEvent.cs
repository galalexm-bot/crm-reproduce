// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.WebRequestErrorEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;
using System.Web;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об ошибке в процессе выполнения Web-запроса
  /// </summary>
  public class WebRequestErrorEvent : DiagnosticsEvent
  {
    private static WebRequestErrorEvent NakBsTEkBo73EM337Cdw;

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    /// <param name="context">Контекст Web-запроса</param>
    public WebRequestErrorEvent(CallContextInfo callContextInfo, HttpContext context)
    {
      WebRequestErrorEvent.wrkGvdEkbGuwXaRWWuxs();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo);
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.Context = context;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
            continue;
          case 3:
            this.Message = EleWise.ELMA.SR.T(true, (string) WebRequestErrorEvent.afaR29Ekh1gG0TaYuoNH(1470440286 ^ 1470200398), (object) (int) callContextInfo.TotalTime.TotalMilliseconds, WebRequestErrorEvent.fqD3ENEkG5e0HdVWDY1r((object) callContextInfo), WebRequestErrorEvent.dsTFG1EkEaPUn6QTK5R5((object) callContextInfo));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 1;
            continue;
          default:
            this.Level = LogLevel.Error;
            num = 3;
            continue;
        }
      }
label_2:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
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

    internal static void wrkGvdEkbGuwXaRWWuxs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object afaR29Ekh1gG0TaYuoNH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object fqD3ENEkG5e0HdVWDY1r([In] object obj0) => (object) ((CallContextInfo) obj0).HttpMethod;

    internal static object dsTFG1EkEaPUn6QTK5R5([In] object obj0) => (object) ((CallContextInfo) obj0).Name;

    internal static bool bTW25BEkWhMwjIUWZyZ5() => WebRequestErrorEvent.NakBsTEkBo73EM337Cdw == null;

    internal static WebRequestErrorEvent SkcpdREkoGRulRguiG0j() => WebRequestErrorEvent.NakBsTEkBo73EM337Cdw;
  }
}
