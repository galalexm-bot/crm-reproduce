// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.BackgroundThreadEndEvent
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
  /// Событие, сигнализирующее об окончанни выполнения фонового потока
  /// </summary>
  public class BackgroundThreadEndEvent : DiagnosticsEvent
  {
    internal static BackgroundThreadEndEvent VLoaL1EKnGu7grEmUBxh;

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    public BackgroundThreadEndEvent(CallContextInfo callContextInfo)
    {
      BackgroundThreadEndEvent.g9fOPNEKedKhubFvelbg();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Message = EleWise.ELMA.SR.T(true, (string) BackgroundThreadEndEvent.uWXV2PEKPa9GrnompOBc(277947046 - -1479185048 ^ 1757405304), (object) (int) BackgroundThreadEndEvent.hVcMtaEK1rKbWqWslDae((object) callContextInfo).TotalMilliseconds, (object) callContextInfo.Name);
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.Level = EleWise.ELMA.Logging.LogLevel.Information;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static void g9fOPNEKedKhubFvelbg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object uWXV2PEKPa9GrnompOBc(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static TimeSpan hVcMtaEK1rKbWqWslDae([In] object obj0) => ((CallContextInfo) obj0).TotalTime;

    internal static bool W0vWkIEKOrrHY05aos95() => BackgroundThreadEndEvent.VLoaL1EKnGu7grEmUBxh == null;

    internal static BackgroundThreadEndEvent KPSbHsEK2w7uebRJa3HR() => BackgroundThreadEndEvent.VLoaL1EKnGu7grEmUBxh;
  }
}
