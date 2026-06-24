// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Events.BackgroundThreadErrorEvent
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
  /// Событие, сигнализирующее об ошибке в процессе выполнения фонового потока
  /// </summary>
  public class BackgroundThreadErrorEvent : DiagnosticsEvent
  {
    internal static BackgroundThreadErrorEvent YIZqTHEKiE71YPLNUn3Z;

    /// <summary>Ctor</summary>
    /// <param name="callContextInfo">Информация о текущем потоке выполнения</param>
    public BackgroundThreadErrorEvent(CallContextInfo callContextInfo)
    {
      BackgroundThreadErrorEvent.QnwALrEKK7KgfHeAMAvv();
      // ISSUE: explicit constructor call
      base.\u002Ector(callContextInfo);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.Message = EleWise.ELMA.SR.T(true, (string) BackgroundThreadErrorEvent.NZPLXGEKXFAOw3MPn0ml(-542721635 ^ -542970497), (object) (int) BackgroundThreadErrorEvent.FGdxPZEKTSeWDgvPCpTG((object) callContextInfo).TotalMilliseconds, BackgroundThreadErrorEvent.GMEpDuEKkcMecHKkMJij((object) callContextInfo));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
            continue;
          default:
            this.Level = EleWise.ELMA.Logging.LogLevel.Error;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    internal static void QnwALrEKK7KgfHeAMAvv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object NZPLXGEKXFAOw3MPn0ml(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static TimeSpan FGdxPZEKTSeWDgvPCpTG([In] object obj0) => ((CallContextInfo) obj0).TotalTime;

    internal static object GMEpDuEKkcMecHKkMJij([In] object obj0) => (object) ((CallContextInfo) obj0).Name;

    internal static bool EAHSQUEKR1iDe9EcQBxg() => BackgroundThreadErrorEvent.YIZqTHEKiE71YPLNUn3Z == null;

    internal static BackgroundThreadErrorEvent jQVuruEKqcc4yuHg9AJn() => BackgroundThreadErrorEvent.YIZqTHEKiE71YPLNUn3Z;
  }
}
