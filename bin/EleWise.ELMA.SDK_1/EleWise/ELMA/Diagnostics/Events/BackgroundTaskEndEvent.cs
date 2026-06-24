// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.BackgroundTaskEndEvent
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Events
{
  /// <summary>
  /// Событие, сигнализирующее об окончанни выполнения фоновой задачи
  /// </summary>
  public class BackgroundTaskEndEvent : DiagnosticsEvent
  {
    internal static BackgroundTaskEndEvent kOd07CETQic2Q9JtoFOP;

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    public BackgroundTaskEndEvent(CallContextInfo callContextInfo)
    {
      BackgroundTaskEndEvent.V3KbnOET8g7ifnq0f3iy();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Level = EleWise.ELMA.Logging.LogLevel.Information;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.Message = EleWise.ELMA.SR.T(true, (string) BackgroundTaskEndEvent.GKSthEETZnkMZWqhYq0c(1251470110 >> 2 ^ 312585321), (object) (int) BackgroundTaskEndEvent.khChigETu2RSxxaQv5Ye((object) callContextInfo).TotalMilliseconds, BackgroundTaskEndEvent.x5g0OrETIcHxbfDUkSAP((object) callContextInfo));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 2 : 0;
            continue;
        }
      }
label_3:;
    }

    internal static void V3KbnOET8g7ifnq0f3iy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object GKSthEETZnkMZWqhYq0c(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static TimeSpan khChigETu2RSxxaQv5Ye([In] object obj0) => ((CallContextInfo) obj0).TotalTime;

    internal static object x5g0OrETIcHxbfDUkSAP([In] object obj0) => (object) ((CallContextInfo) obj0).Name;

    internal static bool V2FXQFETCOlBOadUhvO0() => BackgroundTaskEndEvent.kOd07CETQic2Q9JtoFOP == null;

    internal static BackgroundTaskEndEvent BHEuRJETvfT3BZdp2fdJ() => BackgroundTaskEndEvent.kOd07CETQic2Q9JtoFOP;
  }
}
