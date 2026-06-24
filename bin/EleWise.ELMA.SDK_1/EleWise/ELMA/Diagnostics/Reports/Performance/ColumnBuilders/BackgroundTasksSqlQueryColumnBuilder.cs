// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders.BackgroundTasksSqlQueryColumnBuilder
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
  /// Построитель столбцов статистики по SQL-запросам в отчете по фоновым задачам
  /// </summary>
  [Component]
  internal class BackgroundTasksSqlQueryColumnBuilder : IPerformanceReportPageColumnBuilder
  {
    private static BackgroundTasksSqlQueryColumnBuilder Pqs2kwEvY9hZintW3qX3;

    /// <inheritdoc />
    public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
    {
      if (!(table is MetricExcelTable<BackgroundTaskMetric> metricExcelTable))
        return;
      string title = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107734420));
      metricExcelTable.AddColumn<TimeSpan>(600L, title, 10.0, (Func<BackgroundTaskMetric, TimeSpan>) (s =>
      {
        int num = 2;
        MetricsGroup<SqlQueryMetric> metricsGroup;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (metricsGroup != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 2:
              metricsGroup = s.Metrics.Get<SqlQueryMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        MetricsGroup<SqlQueryMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, SqlQueryMetric>, TimeSpan> func = BackgroundTasksSqlQueryColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_4;
        Func<KeyValuePair<string, SqlQueryMetric>, TimeSpan> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          BackgroundTasksSqlQueryColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_4 = selector = (Func<KeyValuePair<string, SqlQueryMetric>, TimeSpan>) (c => c.Value.TotalTime);
        }
        else
          goto label_6;
label_8:
        return source.Sum<KeyValuePair<string, SqlQueryMetric>>(selector);
label_6:
        selector = func;
        goto label_8;
label_9:
        return TimeSpan.Zero;
      })).AddColumn<double>(700L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236348285)), 10.0, (Func<BackgroundTaskMetric, double>) (s =>
      {
        int num = 4;
        TimeSpan totalTime;
        MetricsGroup<SqlQueryMetric> source;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_9;
            case 3:
              if (source != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 4:
              source = s.Metrics.Get<SqlQueryMetric>();
              num = 3;
              continue;
            case 5:
              if (totalTime.Ticks == 0L)
              {
                num = 2;
                continue;
              }
              goto label_8;
            default:
              totalTime = s.TotalTime;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 5 : 0;
              continue;
          }
        }
label_8:
        return (double) source.Sum<KeyValuePair<string, SqlQueryMetric>>((Func<KeyValuePair<string, SqlQueryMetric>, long>) (c => c.Value.TotalTime.Ticks)) / (double) s.TotalTime.Ticks;
label_9:
        return 0.0;
      }), (IExcelCellFormat) PercentFormat.Default).AddColumn<long>(800L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675753139)), 10.0, (Func<BackgroundTaskMetric, long>) (s =>
      {
        int num = 1;
        MetricsGroup<SqlQueryMetric> source;
        while (true)
        {
          switch (num)
          {
            case 1:
              source = s.Metrics.Get<SqlQueryMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_5;
            default:
              if (source == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
                continue;
              }
              goto label_5;
          }
        }
label_5:
        return source.Sum<KeyValuePair<string, SqlQueryMetric>>((Func<KeyValuePair<string, SqlQueryMetric>, long>) (c => c.Value.CountCall));
label_6:
        return 0;
      })).AddColumn<long>(900L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757412866)), 10.0, (Func<BackgroundTaskMetric, long>) (s =>
      {
        int num = 4;
        MetricsGroup<SqlQueryMetric> metricsGroup;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_10;
            case 2:
              goto label_7;
            case 3:
              if (metricsGroup == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 1;
                continue;
              }
              break;
            case 4:
              metricsGroup = s.Metrics.Get<SqlQueryMetric>();
              num = 3;
              continue;
          }
          if (s.CountCall != 0L)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 2;
          else
            goto label_10;
        }
label_7:
        MetricsGroup<SqlQueryMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, SqlQueryMetric>, long> func = BackgroundTasksSqlQueryColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_7;
        Func<KeyValuePair<string, SqlQueryMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          BackgroundTasksSqlQueryColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_7 = selector = (Func<KeyValuePair<string, SqlQueryMetric>, long>) (c => c.Value.CountCall);
        }
        else
          goto label_11;
label_9:
        return source.Sum<KeyValuePair<string, SqlQueryMetric>>(selector) / s.CountCall;
label_11:
        selector = func;
        goto label_9;
label_10:
        return 0;
      }));
    }

    public BackgroundTasksSqlQueryColumnBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool sbdC24EvLuuXJu9igy4q() => BackgroundTasksSqlQueryColumnBuilder.Pqs2kwEvY9hZintW3qX3 == null;

    internal static BackgroundTasksSqlQueryColumnBuilder QDlc4ZEvUS5PcgrX3yx4() => BackgroundTasksSqlQueryColumnBuilder.Pqs2kwEvY9hZintW3qX3;
  }
}
