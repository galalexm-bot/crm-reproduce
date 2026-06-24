// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.BackgroundThreadStartEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее о начале выполнения фонового потока
  /// </summary>
  public class BackgroundThreadStartEvent : DiagnosticsEvent
  {
    private static BackgroundThreadStartEvent JBwFysEKN8YAqtonAcag;

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    public BackgroundThreadStartEvent(CallContextInfo callContextInfo)
    {
      BackgroundThreadStartEvent.GMA4CTEKaZ1bIADNe2Un();
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
            this.Level = EleWise.ELMA.Logging.LogLevel.Information;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          default:
            this.Message = EleWise.ELMA.SR.T(true, (string) BackgroundThreadStartEvent.TTBIDoEKDBfw9VQyw8fC(1819636893 << 3 ^ 1672474950), (object) BackgroundThreadStartEvent.yVAiWwEKtmsF8CgJhjr1(callContextInfo.StartTime).ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837926459)), (object) BackgroundThreadStartEvent.SPGHT9EKwLwcsYmeiQ2o((object) callContextInfo), BackgroundThreadStartEvent.juLe1FEK4m1kpVyRUINu((object) callContextInfo));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static void GMA4CTEKaZ1bIADNe2Un() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object TTBIDoEKDBfw9VQyw8fC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static DateTime yVAiWwEKtmsF8CgJhjr1(DateTime dateTime) => dateTime.ConvertUtcToLocal();

    internal static long SPGHT9EKwLwcsYmeiQ2o([In] object obj0) => ((CallContextInfo) obj0).ManagedThreadId;

    internal static object juLe1FEK4m1kpVyRUINu([In] object obj0) => (object) ((CallContextInfo) obj0).Name;

    internal static bool uZr9oTEK3QMiy2uuMB52() => BackgroundThreadStartEvent.JBwFysEKN8YAqtonAcag == null;

    internal static BackgroundThreadStartEvent T8tQ1IEKpXnu4UVDNawu() => BackgroundThreadStartEvent.JBwFysEKN8YAqtonAcag;
  }
}
