// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders.BackgroundTasksCacheCallColumnBuilder
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
  /// Построитель столбцов статистики по обращению к кешу в отчете по фоновым задачам
  /// </summary>
  [Component]
  internal class BackgroundTasksCacheCallColumnBuilder : IPerformanceReportPageColumnBuilder
  {
    internal static BackgroundTasksCacheCallColumnBuilder Ttb03UEvywiR7mKT40jV;

    /// <inheritdoc />
    public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
    {
      if (!(table is MetricExcelTable<BackgroundTaskMetric> metricExcelTable))
        return;
      string title = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333491692));
      metricExcelTable.AddColumn<TimeSpan>(1000L, title, 12.0, (Func<BackgroundTaskMetric, TimeSpan>) (s =>
      {
        int num = 2;
        MetricsGroup<CacheMetric> metricsGroup;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (metricsGroup != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 2:
              metricsGroup = s.Metrics.Get<CacheMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        MetricsGroup<CacheMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, CacheMetric>, TimeSpan> func = BackgroundTasksCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_9;
        Func<KeyValuePair<string, CacheMetric>, TimeSpan> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          BackgroundTasksCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_9 = selector = (Func<KeyValuePair<string, CacheMetric>, TimeSpan>) (c => c.Value.ReadTotalTime);
        }
        else
          goto label_6;
label_8:
        return source.Sum<KeyValuePair<string, CacheMetric>>(selector);
label_6:
        selector = func;
        goto label_8;
label_9:
        return TimeSpan.Zero;
      })).AddColumn<double>(1100L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137703942)), 10.0, (Func<BackgroundTaskMetric, double>) (s =>
      {
        int num = 5;
        MetricsGroup<CacheMetric> metricsGroup;
        TimeSpan totalTime;
        while (true)
        {
          switch (num)
          {
            case 1:
              totalTime = s.TotalTime;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 6 : 6;
              continue;
            case 3:
              goto label_9;
            case 4:
              if (metricsGroup == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 5:
              metricsGroup = s.Metrics.Get<CacheMetric>();
              num = 4;
              continue;
            case 6:
              if (totalTime.Ticks == 0L)
              {
                num = 2;
                continue;
              }
              goto label_9;
            default:
              goto label_12;
          }
        }
label_9:
        MetricsGroup<CacheMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, CacheMetric>, long> func = BackgroundTasksCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_10;
        Func<KeyValuePair<string, CacheMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          BackgroundTasksCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_10 = selector = (Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.ReadTotalTime.Ticks);
        }
        else
          goto label_2;
label_11:
        return (double) source.Sum<KeyValuePair<string, CacheMetric>>(selector) / (double) s.TotalTime.Ticks;
label_2:
        selector = func;
        goto label_11;
label_12:
        return 0.0;
      }), (IExcelCellFormat) PercentFormat.Default).AddColumn<double>(1200L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413282425)), 10.0, (Func<BackgroundTaskMetric, double>) (s =>
      {
        int num1 = 3;
        MetricsGroup<CacheMetric> source1;
        long num2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (num2 == 0L)
              {
                num1 = 4;
                continue;
              }
              goto label_11;
            case 2:
              if (source1 == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                continue;
              }
              MetricsGroup<CacheMetric> source2 = source1;
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<string, CacheMetric>, long> func = BackgroundTasksCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_11;
              Func<KeyValuePair<string, CacheMetric>, long> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                BackgroundTasksCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_11 = selector = (Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.ReadTotalCount);
              }
              else
                goto label_13;
label_10:
              num2 = source2.Sum<KeyValuePair<string, CacheMetric>>(selector);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 1;
              continue;
label_13:
              selector = func;
              goto label_10;
            case 3:
              source1 = s.Metrics.Get<CacheMetric>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 2;
              continue;
            case 4:
              goto label_12;
            case 5:
              goto label_11;
            default:
              goto label_7;
          }
        }
label_7:
        return 0.0;
label_11:
        return (double) source1.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.SuccesReadTotalCount)) / (double) num2;
label_12:
        return 0.0;
      }), (IExcelCellFormat) PercentFormat.Default).AddColumn<long>(1300L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360086185)), 10.0, (Func<BackgroundTaskMetric, long>) (s =>
      {
        int num = 1;
        MetricsGroup<CacheMetric> source;
        while (true)
        {
          switch (num)
          {
            case 1:
              source = s.Metrics.Get<CacheMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_5;
            default:
              if (source == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 1;
                continue;
              }
              goto label_5;
          }
        }
label_5:
        return source.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.ReadTotalCount));
label_6:
        return 0;
      })).AddColumn<long>(1400L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35748057)), 10.0, (Func<BackgroundTaskMetric, long>) (s =>
      {
        int num = 3;
        MetricsGroup<CacheMetric> source;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_7;
            case 2:
              if (source == null)
              {
                num = 4;
                continue;
              }
              break;
            case 3:
              source = s.Metrics.Get<CacheMetric>();
              num = 2;
              continue;
            case 4:
              goto label_8;
          }
          if (s.CountCall != 0L)
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
          else
            goto label_8;
        }
label_7:
        return source.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.ReadTotalCount)) / s.CountCall;
label_8:
        return 0;
      })).AddColumn<TimeSpan>(1500L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675750159)), 12.0, (Func<BackgroundTaskMetric, TimeSpan>) (s =>
      {
        int num = 1;
        MetricsGroup<CacheMetric> source;
        while (true)
        {
          switch (num)
          {
            case 1:
              source = s.Metrics.Get<CacheMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            default:
              if (source != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 2 : 2;
                continue;
              }
              goto label_6;
          }
        }
label_5:
        return source.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, TimeSpan>) (c => c.Value.WriteTotalTime));
label_6:
        return TimeSpan.Zero;
      })).AddColumn<double>(1600L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874256849)), 10.0, (Func<BackgroundTaskMetric, double>) (s =>
      {
        int num3 = 1;
        MetricsGroup<CacheMetric> metricsGroup;
        while (true)
        {
          int num4 = num3;
          TimeSpan totalTime;
          while (true)
          {
            switch (num4)
            {
              case 1:
                metricsGroup = s.Metrics.Get<CacheMetric>();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_12;
              case 3:
                totalTime = s.TotalTime;
                num4 = 4;
                continue;
              case 4:
                if (totalTime.Ticks == 0L)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 2;
                  continue;
                }
                goto label_9;
              case 5:
                goto label_9;
              default:
                goto label_3;
            }
          }
label_3:
          if (metricsGroup != null)
            num3 = 3;
          else
            goto label_12;
        }
label_9:
        MetricsGroup<CacheMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, CacheMetric>, long> func = BackgroundTasksCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_16;
        Func<KeyValuePair<string, CacheMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          BackgroundTasksCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_16 = selector = (Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.WriteTotalTime.Ticks);
        }
        else
          goto label_13;
label_11:
        return (double) source.Sum<KeyValuePair<string, CacheMetric>>(selector) / (double) s.TotalTime.Ticks;
label_13:
        selector = func;
        goto label_11;
label_12:
        return 0.0;
      }), (IExcelCellFormat) PercentFormat.Default).AddColumn<long>(1700L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813357159)), 10.0, (Func<BackgroundTaskMetric, long>) (s =>
      {
        int num = 1;
        MetricsGroup<CacheMetric> metricsGroup;
        while (true)
        {
          switch (num)
          {
            case 1:
              metricsGroup = s.Metrics.Get<CacheMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            default:
              if (metricsGroup != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 2;
                continue;
              }
              goto label_8;
          }
        }
label_5:
        MetricsGroup<CacheMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, CacheMetric>, long> func = BackgroundTasksCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_17;
        Func<KeyValuePair<string, CacheMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          BackgroundTasksCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_17 = selector = (Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.WriteTotalCount);
        }
        else
          goto label_9;
label_7:
        return source.Sum<KeyValuePair<string, CacheMetric>>(selector);
label_9:
        selector = func;
        goto label_7;
label_8:
        return 0;
      })).AddColumn<long>(1800L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917011324)), 10.0, (Func<BackgroundTaskMetric, long>) (s =>
      {
        int num = 2;
        MetricsGroup<CacheMetric> source;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (source == null)
              {
                num = 3;
                continue;
              }
              goto case 4;
            case 2:
              source = s.Metrics.Get<CacheMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
              continue;
            case 4:
              if (s.CountCall == 0L)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 5:
              goto label_7;
            default:
              goto label_8;
          }
        }
label_7:
        return source.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.WriteTotalCount)) / s.CountCall;
label_8:
        return 0;
      }));
    }

    public BackgroundTasksCacheCallColumnBuilder()
    {
      BackgroundTasksCacheCallColumnBuilder.RtWXKEEv9o2JIOJddS2q();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void RtWXKEEv9o2JIOJddS2q() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tcGmWaEvMpu8erOZHSy7() => BackgroundTasksCacheCallColumnBuilder.Ttb03UEvywiR7mKT40jV == null;

    internal static BackgroundTasksCacheCallColumnBuilder vJufgOEvJLIk4IjPBvkY() => BackgroundTasksCacheCallColumnBuilder.Ttb03UEvywiR7mKT40jV;
  }
}
