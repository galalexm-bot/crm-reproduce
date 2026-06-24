// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders.WebRequestIndexCallColumnBuilder
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

namespace EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders
{
  /// <summary>
  /// Построитель столбцов статистики по работе с индексом в отчете по Web-запросам
  /// </summary>
  [Component]
  internal class WebRequestIndexCallColumnBuilder : IPerformanceReportPageColumnBuilder
  {
    private static WebRequestIndexCallColumnBuilder fecG1GEvg5nMhAyr14q3;

    /// <inheritdoc />
    public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
    {
      if (!(table is MetricExcelTable<WebRequestMetric> metricExcelTable))
        return;
      string title = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16508957));
      metricExcelTable.AddColumn<TimeSpan>(1900L, title, 12.0, (Func<WebRequestMetric, TimeSpan>) (s =>
      {
        int num = 1;
        MetricsGroup<IndexQueryMetric> source;
        while (true)
        {
          switch (num)
          {
            case 1:
              source = s.Metrics.Get<IndexQueryMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            default:
              if (source != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 2;
                continue;
              }
              goto label_6;
          }
        }
label_5:
        return source.Sum<KeyValuePair<string, IndexQueryMetric>>((Func<KeyValuePair<string, IndexQueryMetric>, TimeSpan>) (c => c.Value.TotalTime));
label_6:
        return TimeSpan.Zero;
      })).AddColumn<double>(2000L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87089885)), 10.0, (Func<WebRequestMetric, double>) (s =>
      {
        int num1 = 1;
        MetricsGroup<IndexQueryMetric> source;
        while (true)
        {
          int num2 = num1;
          TimeSpan totalTime;
          while (true)
          {
            switch (num2)
            {
              case 1:
                source = s.Metrics.Get<IndexQueryMetric>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_6;
              case 3:
                goto label_9;
              case 4:
                goto label_10;
              case 5:
                if (totalTime.Ticks == 0L)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 4;
                  continue;
                }
                goto label_9;
              default:
                if (source != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 2;
                  continue;
                }
                goto label_10;
            }
          }
label_6:
          totalTime = s.TotalTime;
          num1 = 5;
        }
label_9:
        return (double) source.Sum<KeyValuePair<string, IndexQueryMetric>>((Func<KeyValuePair<string, IndexQueryMetric>, long>) (c => c.Value.TotalTime.Ticks)) / (double) s.TotalTime.Ticks;
label_10:
        return 0.0;
      }), (IExcelCellFormat) PercentFormat.Default).AddColumn<long>(2100L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867479503)), 10.0, (Func<WebRequestMetric, long>) (s =>
      {
        int num = 1;
        MetricsGroup<IndexQueryMetric> metricsGroup;
        while (true)
        {
          switch (num)
          {
            case 1:
              metricsGroup = s.Metrics.Get<IndexQueryMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            default:
              if (metricsGroup != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 0;
                continue;
              }
              goto label_8;
          }
        }
label_5:
        MetricsGroup<IndexQueryMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, IndexQueryMetric>, long> func = WebRequestIndexCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_6;
        Func<KeyValuePair<string, IndexQueryMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          WebRequestIndexCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_6 = selector = (Func<KeyValuePair<string, IndexQueryMetric>, long>) (c => c.Value.CountCall);
        }
        else
          goto label_9;
label_7:
        return source.Sum<KeyValuePair<string, IndexQueryMetric>>(selector);
label_9:
        selector = func;
        goto label_7;
label_8:
        return 0;
      })).AddColumn<long>(2200L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309391806)), 10.0, (Func<WebRequestMetric, long>) (s =>
      {
        int num = 1;
        MetricsGroup<IndexQueryMetric> metricsGroup;
        while (true)
        {
          switch (num)
          {
            case 1:
              metricsGroup = s.Metrics.Get<IndexQueryMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_7;
            case 3:
              if (s.CountCall != 0L)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 2;
                continue;
              }
              goto label_10;
            case 4:
              goto label_10;
            default:
              if (metricsGroup == null)
              {
                num = 4;
                continue;
              }
              goto case 3;
          }
        }
label_7:
        MetricsGroup<IndexQueryMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, IndexQueryMetric>, long> func = WebRequestIndexCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_7;
        Func<KeyValuePair<string, IndexQueryMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          WebRequestIndexCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_7 = selector = (Func<KeyValuePair<string, IndexQueryMetric>, long>) (c => c.Value.CountCall);
        }
        else
          goto label_11;
label_9:
        return source.Sum<KeyValuePair<string, IndexQueryMetric>>(selector) / s.CountCall;
label_11:
        selector = func;
        goto label_9;
label_10:
        return 0;
      }));
    }

    public WebRequestIndexCallColumnBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool LATYvAEv5ltNkn61DPXX() => WebRequestIndexCallColumnBuilder.fecG1GEvg5nMhAyr14q3 == null;

    internal static WebRequestIndexCallColumnBuilder aEQBs0EvjHZYTd2y0kQp() => WebRequestIndexCallColumnBuilder.fecG1GEvg5nMhAyr14q3;
  }
}
