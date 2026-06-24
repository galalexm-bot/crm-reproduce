// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders.WebRequestSqlQueryColumnBuilder
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
  /// Построитель столбцов статистики по SQL-запросам в отчете по Web-запросам
  /// </summary>
  [Component]
  internal class WebRequestSqlQueryColumnBuilder : IPerformanceReportPageColumnBuilder
  {
    internal static WebRequestSqlQueryColumnBuilder JbcHcOEvs6c4Pva7m54y;

    /// <inheritdoc />
    public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
    {
      if (!(table is MetricExcelTable<WebRequestMetric> metricExcelTable))
        return;
      string title = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124362492));
      metricExcelTable.AddColumn<TimeSpan>(600L, title, 10.0, (Func<WebRequestMetric, TimeSpan>) (s =>
      {
        int num = 2;
        MetricsGroup<SqlQueryMetric> source;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (source != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              source = s.Metrics.Get<SqlQueryMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return source.Sum<KeyValuePair<string, SqlQueryMetric>>((Func<KeyValuePair<string, SqlQueryMetric>, TimeSpan>) (c => c.Value.TotalTime));
label_6:
        return TimeSpan.Zero;
      })).AddColumn<double>(700L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406078201)), 10.0, (Func<WebRequestMetric, double>) (s =>
      {
        int num = 2;
        TimeSpan totalTime;
        MetricsGroup<SqlQueryMetric> metricsGroup;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (metricsGroup == null)
              {
                num = 4;
                continue;
              }
              goto case 3;
            case 2:
              metricsGroup = s.Metrics.Get<SqlQueryMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
            case 3:
              totalTime = s.TotalTime;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_11;
            case 5:
              goto label_8;
            default:
              if (totalTime.Ticks != 0L)
              {
                num = 5;
                continue;
              }
              goto label_11;
          }
        }
label_8:
        MetricsGroup<SqlQueryMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, SqlQueryMetric>, long> func = WebRequestSqlQueryColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_5;
        Func<KeyValuePair<string, SqlQueryMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          WebRequestSqlQueryColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_5 = selector = (Func<KeyValuePair<string, SqlQueryMetric>, long>) (c => c.Value.TotalTime.Ticks);
        }
        else
          goto label_12;
label_10:
        return (double) source.Sum<KeyValuePair<string, SqlQueryMetric>>(selector) / (double) s.TotalTime.Ticks;
label_12:
        selector = func;
        goto label_10;
label_11:
        return 0.0;
      }), (IExcelCellFormat) PercentFormat.Default).AddColumn<long>(800L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542968977)), 10.0, (Func<WebRequestMetric, long>) (s =>
      {
        int num1 = 2;
        MetricsGroup<SqlQueryMetric> source;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_4;
              case 2:
                source = s.Metrics.Get<SqlQueryMetric>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
                continue;
              case 3:
                goto label_7;
              default:
                goto label_6;
            }
          }
label_4:
          if (source == null)
            num1 = 3;
          else
            break;
        }
label_6:
        return source.Sum<KeyValuePair<string, SqlQueryMetric>>((Func<KeyValuePair<string, SqlQueryMetric>, long>) (c => c.Value.CountCall));
label_7:
        return 0;
      })).AddColumn<long>(900L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874255867)), 10.0, (Func<WebRequestMetric, long>) (s =>
      {
        int num = 3;
        MetricsGroup<SqlQueryMetric> metricsGroup;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (s.CountCall != 0L)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto label_11;
            case 2:
              if (metricsGroup != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
                continue;
              }
              goto label_11;
            case 3:
              metricsGroup = s.Metrics.Get<SqlQueryMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 2 : 2;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        MetricsGroup<SqlQueryMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, SqlQueryMetric>, long> func = WebRequestSqlQueryColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_7;
        Func<KeyValuePair<string, SqlQueryMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          WebRequestSqlQueryColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_7 = selector = (Func<KeyValuePair<string, SqlQueryMetric>, long>) (c => c.Value.CountCall);
        }
        else
          goto label_8;
label_10:
        return source.Sum<KeyValuePair<string, SqlQueryMetric>>(selector) / s.CountCall;
label_8:
        selector = func;
        goto label_10;
label_11:
        return 0;
      }));
    }

    public WebRequestSqlQueryColumnBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool AisNwJEvcO9KNiHyqZO7() => WebRequestSqlQueryColumnBuilder.JbcHcOEvs6c4Pva7m54y == null;

    internal static WebRequestSqlQueryColumnBuilder JwfbNsEvzverX27bkW4O() => WebRequestSqlQueryColumnBuilder.JbcHcOEvs6c4Pva7m54y;
  }
}
