// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.BackgroundTaskStartEvent
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
  /// Событие, сигнализирующее о начале выполнения фоновой задачи
  /// </summary>
  public class BackgroundTaskStartEvent : DiagnosticsEvent
  {
    private static BackgroundTaskStartEvent OJKyeDETX8Um8VyDfS7x;

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    public BackgroundTaskStartEvent(CallContextInfo callContextInfo)
    {
      BackgroundTaskStartEvent.zBU6rvETnWZu1jqLsGbD();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Level = EleWise.ELMA.Logging.LogLevel.Information;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.Message = EleWise.ELMA.SR.T(true, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514679381), (object) BackgroundTaskStartEvent.hA8je9ETOSEseC94pMGS((object) callContextInfo).ConvertUtcToLocal().ToString((string) BackgroundTaskStartEvent.RkrWJpET2HFNjm526rsB(-606654180 ^ -606914398)), (object) BackgroundTaskStartEvent.u76aw5ETehCjrqdG7TeM((object) callContextInfo), BackgroundTaskStartEvent.R7D9yqETP0NuUsBU7wNZ((object) callContextInfo));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 0;
            continue;
        }
      }
label_3:;
    }

    internal static void zBU6rvETnWZu1jqLsGbD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static DateTime hA8je9ETOSEseC94pMGS([In] object obj0) => ((CallContextInfo) obj0).StartTime;

    internal static object RkrWJpET2HFNjm526rsB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static long u76aw5ETehCjrqdG7TeM([In] object obj0) => ((CallContextInfo) obj0).ManagedThreadId;

    internal static object R7D9yqETP0NuUsBU7wNZ([In] object obj0) => (object) ((CallContextInfo) obj0).Name;

    internal static bool t2X98XETTq197f9K9Ibw() => BackgroundTaskStartEvent.OJKyeDETX8Um8VyDfS7x == null;

    internal static BackgroundTaskStartEvent b24M0xETkZ6SpTC2NuFn() => BackgroundTaskStartEvent.OJKyeDETX8Um8VyDfS7x;
  }
}
