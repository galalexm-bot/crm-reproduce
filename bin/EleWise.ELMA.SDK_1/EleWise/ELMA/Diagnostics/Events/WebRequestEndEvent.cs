// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.WebRequestEndEvent
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
  /// Событие, сигнализирующее об окончании выполнения Web-запроса
  /// </summary>
  public class WebRequestEndEvent : DiagnosticsEvent
  {
    internal static WebRequestEndEvent kxDInFETL7JinKlWkZP5;

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполенения</param>
    /// <param name="context">Контекст Web-запроса</param>
    public WebRequestEndEvent(CallContextInfo callContextInfo, HttpContext context)
    {
      WebRequestEndEvent.daCm54ETcaUT1fDLmKRA();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Level = LogLevel.Information;
            num = 2;
            continue;
          case 2:
            this.Message = EleWise.ELMA.SR.T(true, (string) WebRequestEndEvent.yrGmU1ETzS1sQqFDT6Qf(-35995181 ^ -35743471), (object) (int) callContextInfo.TotalTime.TotalMilliseconds, WebRequestEndEvent.QmGppAEkFAnELaHCUg2U((object) callContextInfo), (object) callContextInfo.Name);
            num = 3;
            continue;
          case 3:
            goto label_3;
          default:
            this.Context = context;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 1;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
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

    internal static void daCm54ETcaUT1fDLmKRA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object yrGmU1ETzS1sQqFDT6Qf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object QmGppAEkFAnELaHCUg2U([In] object obj0) => (object) ((CallContextInfo) obj0).HttpMethod;

    internal static bool LpETmLETU36LrI0XY6Ns() => WebRequestEndEvent.kxDInFETL7JinKlWkZP5 == null;

    internal static WebRequestEndEvent BXTNpHETshSVcwK6WJI5() => WebRequestEndEvent.kxDInFETL7JinKlWkZP5;
  }
}
