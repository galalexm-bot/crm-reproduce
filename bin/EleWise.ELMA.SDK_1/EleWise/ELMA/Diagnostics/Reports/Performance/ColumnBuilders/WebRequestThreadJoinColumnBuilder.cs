// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders.WebRequestThreadJoinColumnBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders
{
  /// <summary>
  /// Построитель столбцов статистики по ожиданию завершения потоков в отчете по Web-запросам
  /// </summary>
  [Component]
  internal class WebRequestThreadJoinColumnBuilder : IPerformanceReportPageColumnBuilder
  {
    internal static WebRequestThreadJoinColumnBuilder mDh1laEvH5MBqOVIiEri;

    /// <inheritdoc />
    public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
    {
      if (!(table is MetricExcelTable<WebRequestMetric> metricExcelTable))
        return;
      string title = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293441908));
      metricExcelTable.AddColumn<double>(330L, title, 10.0, (Func<WebRequestMetric, double>) (s =>
      {
        int num = 2;
        TimeSpan timeSpan;
        MetricsGroup<ThreadJoinMetric> source;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (source != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 3;
                continue;
              }
              goto label_3;
            case 2:
              source = s.Metrics.Get<ThreadJoinMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
              continue;
            case 3:
              timeSpan = source.Sum<KeyValuePair<string, ThreadJoinMetric>>((Func<KeyValuePair<string, ThreadJoinMetric>, TimeSpan>) (c => c.Value.TotalTime));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return timeSpan.TotalMilliseconds;
label_3:
        return 0.0;
      }));
    }

    public WebRequestThreadJoinColumnBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qLTjwUEvAcMHvEX5RR06() => WebRequestThreadJoinColumnBuilder.mDh1laEvH5MBqOVIiEri == null;

    internal static WebRequestThreadJoinColumnBuilder uILbsGEv7uWvM3Ba8qHc() => WebRequestThreadJoinColumnBuilder.mDh1laEvH5MBqOVIiEri;
  }
}
