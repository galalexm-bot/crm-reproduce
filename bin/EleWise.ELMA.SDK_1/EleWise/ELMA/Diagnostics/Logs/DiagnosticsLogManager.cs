// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Logs.DiagnosticsLogManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using log4net;
using log4net.Core;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Logs
{
  /// <summary>Логгер журналов диагностики</summary>
  [Service(Type = ComponentType.Server, EnableInterceptors = false)]
  public class DiagnosticsLogManager
  {
    private readonly ILog completeSessionLogger;
    private readonly ILog activeSessionLogger;
    private readonly Type callerType;
    private static DiagnosticsLogManager Xdr3L2EVgwsIOdv6LBOk;

    /// <summary>Отправить событие в журнал</summary>
    /// <param name="e">Событие диагностики</param>
    public void Log(DiagnosticsEvent e)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            DiagnosticsLogManager.BXlTn6EVUa32C1ulmPCb(DiagnosticsLogManager.TcsOX3EVYL7qkVxWTUwR((object) this.completeSessionLogger), this.callerType, DiagnosticsLogManager.KSCHAmEVLOZBRYRp3Vyt(e.Level), (object) e, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 3 : 1;
            continue;
          case 2:
            if (this.completeSessionLogger != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (this.activeSessionLogger == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 5 : 2;
              continue;
            }
            break;
          case 4:
            goto label_5;
          case 5:
            goto label_2;
        }
        ((log4net.Core.ILogger) DiagnosticsLogManager.TcsOX3EVYL7qkVxWTUwR((object) this.activeSessionLogger)).Log(this.callerType, (Level) DiagnosticsLogManager.KSCHAmEVLOZBRYRp3Vyt(e.Level), (object) e, (Exception) null);
        num = 4;
      }
label_5:
      return;
label_2:;
    }

    public DiagnosticsLogManager()
    {
      DiagnosticsLogManager.qZICBBEVsAMsxyU7qANp();
      this.completeSessionLogger = LogManager.GetLogger((string) DiagnosticsLogManager.GFRjMKEVcXcvRldMD40u(1654249598 >> 2 ^ 413279991));
      this.activeSessionLogger = (ILog) DiagnosticsLogManager.y594RKEVzVH0NcgbobFC((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35745549));
      this.callerType = TypeOf<DiagnosticsLogManager>.Raw;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object TcsOX3EVYL7qkVxWTUwR([In] object obj0) => (object) ((ILoggerWrapper) obj0).Logger;

    internal static object KSCHAmEVLOZBRYRp3Vyt(EleWise.ELMA.Logging.LogLevel level) => (object) Log4NetLogger.GetLevel(level);

    internal static void BXlTn6EVUa32C1ulmPCb(
      [In] object obj0,
      [In] Type obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      ((log4net.Core.ILogger) obj0).Log(obj1, (Level) obj2, obj3, (Exception) obj4);
    }

    internal static bool ym2SYNEV5539ti28OE02() => DiagnosticsLogManager.Xdr3L2EVgwsIOdv6LBOk == null;

    internal static DiagnosticsLogManager iQoyhkEVjZ7JI30qJMG2() => DiagnosticsLogManager.Xdr3L2EVgwsIOdv6LBOk;

    internal static void qZICBBEVsAMsxyU7qANp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object GFRjMKEVcXcvRldMD40u(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object y594RKEVzVH0NcgbobFC([In] object obj0) => (object) LogManager.GetLogger((string) obj0);
  }
}
