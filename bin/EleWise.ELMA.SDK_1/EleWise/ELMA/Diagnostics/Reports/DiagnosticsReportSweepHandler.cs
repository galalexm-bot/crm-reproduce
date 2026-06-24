// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.DiagnosticsReportSweepHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Diagnostics.Reports
{
  [Component(Type = ComponentType.WebServer)]
  internal class DiagnosticsReportSweepHandler : ISweepHandler, IThreadPoolContainer
  {
    private readonly ThreadSubPool _sweepPool;
    private readonly DiagnosticsReportExporter _exporter;
    private static DiagnosticsReportSweepHandler JBW8ydEhDXuJjnCjj9bW;

    public DiagnosticsReportSweepHandler(DiagnosticsReportExporter exporter)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._exporter = exporter;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
            if (exporter != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          case 3:
            goto label_4;
          case 4:
            goto label_6;
          default:
            this._sweepPool = new ThreadSubPool(1);
            num = 4;
            continue;
        }
      }
label_6:
      return;
label_4:
      throw new ArgumentNullException((string) DiagnosticsReportSweepHandler.qWsQEkEh4DR1oDWqpEPl(516838154 ^ 516579906));
    }

    IThreadPool IThreadPoolContainer.Pool => (IThreadPool) this._sweepPool;

    public void Execute()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._exporter.Execute();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static object qWsQEkEh4DR1oDWqpEPl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool FsZ7bNEhtKCFSu6P2HRS() => DiagnosticsReportSweepHandler.JBW8ydEhDXuJjnCjj9bW == null;

    internal static DiagnosticsReportSweepHandler A9EYa2EhwHVE4lrXCSL8() => DiagnosticsReportSweepHandler.JBW8ydEhDXuJjnCjj9bW;
  }
}
