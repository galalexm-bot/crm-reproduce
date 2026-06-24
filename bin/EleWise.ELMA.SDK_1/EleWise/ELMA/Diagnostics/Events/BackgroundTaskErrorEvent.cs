// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.BackgroundTaskErrorEvent
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
  /// Событие, сигнализирующее об ошибке в процессе выполнения фоновой задачи
  /// </summary>
  public class BackgroundTaskErrorEvent : DiagnosticsEvent
  {
    private static BackgroundTaskErrorEvent YAnuBIETVHmDg1ilhJ6g;

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    public BackgroundTaskErrorEvent(CallContextInfo callContextInfo)
    {
      BackgroundTaskErrorEvent.n5iVyWETRHQWxfMJXwZ1();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Message = EleWise.ELMA.SR.T(true, (string) BackgroundTaskErrorEvent.E9UisnETq8v69xfq4l3h(-2112703338 ^ -2112429182), (object) (int) BackgroundTaskErrorEvent.djrCEyETKih7V1l3ow1F((object) callContextInfo).TotalMilliseconds, (object) callContextInfo.Name);
            num = 2;
            continue;
          case 2:
            goto label_3;
          default:
            this.Level = EleWise.ELMA.Logging.LogLevel.Error;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static void n5iVyWETRHQWxfMJXwZ1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object E9UisnETq8v69xfq4l3h(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static TimeSpan djrCEyETKih7V1l3ow1F([In] object obj0) => ((CallContextInfo) obj0).TotalTime;

    internal static bool g5nfoMETSBZqDgZLqOQH() => BackgroundTaskErrorEvent.YAnuBIETVHmDg1ilhJ6g == null;

    internal static BackgroundTaskErrorEvent V4FrKtETiUT1RwhyBv4W() => BackgroundTaskErrorEvent.YAnuBIETVHmDg1ilhJ6g;
  }
}
