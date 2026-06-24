// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts.IndexPart
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

namespace EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts
{
  /// <summary>
  /// Статистика по работе с индексом на странице отчета "Общая"
  /// </summary>
  [ComponentOrder(60)]
  internal class IndexPart : CommonInformationPart
  {
    internal static IndexPart FLy586EvvhbuSpvPlg54;

    /// <inheritdoc />
    public override string Title => EleWise.ELMA.SR.T((string) IndexPart.vKy3R8Evuy6CmqWOW3Xr(1925118608 << 2 ^ -889203386));

    /// <inheritdoc />
    public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
    {
      MetricsGroup<IndexQueryMetric> source1 = metrics.Get<IndexQueryMetric>() ?? new MetricsGroup<IndexQueryMetric>();
      MetricsGroup<IndexCallMetric> source2 = metrics.Get<IndexCallMetric>() ?? new MetricsGroup<IndexCallMetric>();
      return (IEnumerable<CommonInformationPartItem>) new CommonInformationPartItem[6]
      {
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 221892696)),
          Value1 = (object) source2.Sum<KeyValuePair<string, IndexCallMetric>>((Func<KeyValuePair<string, IndexCallMetric>, long>) (m => m.Value.CountCall))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124382184)),
          Value1 = (object) source2.Sum<KeyValuePair<string, IndexCallMetric>>((Func<KeyValuePair<string, IndexCallMetric>, long>) (m => m.Value.CountCancelCall))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112451798)),
          Value1 = (object) new CellValue((object) source2.Sum<KeyValuePair<string, IndexCallMetric>>((Func<KeyValuePair<string, IndexCallMetric>, TimeSpan>) (m => m.Value.TotalTime)), (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654046379)),
          Value1 = (object) source1.Sum<KeyValuePair<string, IndexQueryMetric>>((Func<KeyValuePair<string, IndexQueryMetric>, long>) (m => m.Value.CountCall))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539122273)),
          Value1 = (object) source1.Sum<KeyValuePair<string, IndexQueryMetric>>((Func<KeyValuePair<string, IndexQueryMetric>, long>) (m => m.Value.CountErrorCall))
        },
        new CommonInformationPartItem()
        {
          Name = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87616733)),
          Value1 = (object) new CellValue((object) source1.Sum<KeyValuePair<string, IndexQueryMetric>>((Func<KeyValuePair<string, IndexQueryMetric>, TimeSpan>) (m => m.Value.TotalTime)), (IExcelCellFormat) new TimeSpanFormat(TimeSpanStyle.HHMMSS))
        }
      };
    }

    public IndexPart()
    {
      IndexPart.CmWZQsEvIqXX9MJaQMpJ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object vKy3R8Evuy6CmqWOW3Xr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool W0bEZnEv8n3Qn4DIvwmY() => IndexPart.FLy586EvvhbuSpvPlg54 == null;

    internal static IndexPart grMVOcEvZw7gxp4FHRhR() => IndexPart.FLy586EvvhbuSpvPlg54;

    internal static void CmWZQsEvIqXX9MJaQMpJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
