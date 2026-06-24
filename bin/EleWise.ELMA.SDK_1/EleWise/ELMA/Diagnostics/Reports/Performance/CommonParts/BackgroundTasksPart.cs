// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts.BackgroundTasksPart
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts
{
  /// <summary>
  /// Статистика по фоновым задачам на странице отчета "Общая"
  /// </summary>
  [ComponentOrder(20)]
  internal class BackgroundTasksPart : CommonInformationPart
  {
    internal static BackgroundTasksPart dDIXMkEveieq48MHUXZa;

    /// <inheritdoc />
    public override string Title => (string) BackgroundTasksPart.AoXZwBEv3C0jWGbkVNev(BackgroundTasksPart.ju9JRyEvNV0VSExLDq6W(-675505729 ^ -675763121));

    /// <inheritdoc />
    public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
    {
      MetricsGroup<BackgroundTaskMetric> source = metrics.Get<BackgroundTaskMetric>();
      if (source == null)
        return (IEnumerable<CommonInformationPartItem>) new CommonInformationPartItem[0];
      return (IEnumerable<CommonInformationPartItem>) new CommonInformationPartItem[3]
      {
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195859813)),
          Value1 = (object) source.Sum<KeyValuePair<string, BackgroundTaskMetric>>((Func<KeyValuePair<string, BackgroundTaskMetric>, long>) (m => m.Value.CountCall))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1871171083)),
          Value1 = (object) new CellValue((object) source.Sum<KeyValuePair<string, BackgroundTaskMetric>>((Func<KeyValuePair<string, BackgroundTaskMetric>, TimeSpan>) (m => m.Value.TotalTime)), (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1787166138)),
          Value1 = (object) source.Sum<KeyValuePair<string, BackgroundTaskMetric>>((Func<KeyValuePair<string, BackgroundTaskMetric>, long>) (m => m.Value.CountErrorCall))
        }
      };
    }

    public BackgroundTasksPart()
    {
      BackgroundTasksPart.Ps2TluEvpdroRRmZbAIO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object ju9JRyEvNV0VSExLDq6W(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object AoXZwBEv3C0jWGbkVNev([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool X3gtN1EvPd3KTuGFuW9H() => BackgroundTasksPart.dDIXMkEveieq48MHUXZa == null;

    internal static BackgroundTasksPart cI3QemEv1e6GNsCdMPwZ() => BackgroundTasksPart.dDIXMkEveieq48MHUXZa;

    internal static void Ps2TluEvpdroRRmZbAIO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
