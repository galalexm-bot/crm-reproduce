// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders.WebRequestCacheCallColumnBuilder
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
  /// Построитель столбцов статистики по обращению к кешу в отчете по Web-запросам
  /// </summary>
  [Component]
  internal class WebRequestCacheCallColumnBuilder : IPerformanceReportPageColumnBuilder
  {
    internal static WebRequestCacheCallColumnBuilder CUe8u1EvdtBpPMlttUWZ;

    /// <inheritdoc />
    public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
    {
      if (!(table is MetricExcelTable<WebRequestMetric> metricExcelTable))
        return;
      string title = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272346251));
      metricExcelTable.AddColumn<TimeSpan>(1000L, title, 12.0, (Func<WebRequestMetric, TimeSpan>) (s =>
      {
        int num = 1;
        MetricsGroup<CacheMetric> source;
        while (true)
        {
          switch (num)
          {
            case 1:
              source = s.Metrics.Get<CacheMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
              goto label_6;
            default:
              if (source == null)
              {
                num = 3;
                continue;
              }
              goto label_5;
          }
        }
label_5:
        return source.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, TimeSpan>) (c => c.Value.ReadTotalTime));
label_6:
        return TimeSpan.Zero;
      })).AddColumn<double>(1100L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902037583)), 10.0, (Func<WebRequestMetric, double>) (s =>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            case 2:
            case 3:
              goto label_12;
            case 4:
              if (metricsGroup == null)
              {
                num = 3;
                continue;
              }
              goto case 1;
            case 5:
              metricsGroup = s.Metrics.Get<CacheMetric>();
              num = 4;
              continue;
            case 6:
              goto label_8;
            default:
              if (totalTime.Ticks == 0L)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 2 : 2;
                continue;
              }
              goto label_8;
          }
        }
label_8:
        MetricsGroup<CacheMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, CacheMetric>, long> func = WebRequestCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_10;
        Func<KeyValuePair<string, CacheMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          WebRequestCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_10 = selector = (Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.ReadTotalTime.Ticks);
        }
        else
          goto label_9;
label_11:
        return (double) source.Sum<KeyValuePair<string, CacheMetric>>(selector) / (double) s.TotalTime.Ticks;
label_9:
        selector = func;
        goto label_11;
label_12:
        return 0.0;
      }), (IExcelCellFormat) PercentFormat.Default).AddColumn<double>(1200L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501717999)), 10.0, (Func<WebRequestMetric, double>) (s =>
      {
        int num1 = 2;
        MetricsGroup<CacheMetric> source;
        long num2;
        while (true)
        {
          switch (num1)
          {
            case 1:
              if (source != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 5;
                continue;
              }
              goto label_7;
            case 2:
              source = s.Metrics.Get<CacheMetric>();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_10;
            case 4:
              goto label_7;
            case 5:
              num2 = source.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.ReadTotalCount));
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 6:
              goto label_9;
            default:
              if (num2 == 0L)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 3;
                continue;
              }
              goto label_9;
          }
        }
label_7:
        return 0.0;
label_9:
        return (double) source.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.SuccesReadTotalCount)) / (double) num2;
label_10:
        return 0.0;
      }), (IExcelCellFormat) PercentFormat.Default).AddColumn<long>(1300L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1668968239)), 10.0, (Func<WebRequestMetric, long>) (s =>
      {
        int num = 3;
        MetricsGroup<CacheMetric> source;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              if (source == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
                continue;
              }
              goto label_5;
            case 3:
              source = s.Metrics.Get<CacheMetric>();
              num = 2;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return source.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.ReadTotalCount));
label_6:
        return 0;
      })).AddColumn<long>(1400L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459313807)), 10.0, (Func<WebRequestMetric, long>) (s =>
      {
        int num3 = 2;
        MetricsGroup<CacheMetric> metricsGroup;
        while (true)
        {
          int num4 = num3;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_6;
              case 2:
                metricsGroup = s.Metrics.Get<CacheMetric>();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
                continue;
              case 3:
                if (s.CountCall != 0L)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
                  continue;
                }
                goto label_12;
              default:
                goto label_8;
            }
          }
label_6:
          if (metricsGroup != null)
            num3 = 3;
          else
            goto label_12;
        }
label_8:
        MetricsGroup<CacheMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, CacheMetric>, long> func = WebRequestCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_14;
        Func<KeyValuePair<string, CacheMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          WebRequestCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_14 = selector = (Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.ReadTotalCount);
        }
        else
          goto label_9;
label_11:
        return source.Sum<KeyValuePair<string, CacheMetric>>(selector) / s.CountCall;
label_9:
        selector = func;
        goto label_11;
label_12:
        return 0;
      })).AddColumn<TimeSpan>(1500L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082120790)), 12.0, (Func<WebRequestMetric, TimeSpan>) (s =>
      {
        int num = 2;
        MetricsGroup<CacheMetric> metricsGroup;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (metricsGroup == null)
              {
                num = 3;
                continue;
              }
              goto label_5;
            case 2:
              metricsGroup = s.Metrics.Get<CacheMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
              continue;
            case 3:
              goto label_9;
            default:
              goto label_5;
          }
        }
label_5:
        MetricsGroup<CacheMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, CacheMetric>, TimeSpan> func = WebRequestCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_15;
        Func<KeyValuePair<string, CacheMetric>, TimeSpan> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          WebRequestCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_15 = selector = (Func<KeyValuePair<string, CacheMetric>, TimeSpan>) (c => c.Value.WriteTotalTime);
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
      })).AddColumn<double>(1600L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413282715)), 10.0, (Func<WebRequestMetric, double>) (s =>
      {
        int num = 1;
        MetricsGroup<CacheMetric> metricsGroup;
        TimeSpan totalTime;
        while (true)
        {
          switch (num)
          {
            case 1:
              metricsGroup = s.Metrics.Get<CacheMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            case 2:
              totalTime = s.TotalTime;
              num = 3;
              continue;
            case 3:
              if (totalTime.Ticks == 0L)
              {
                num = 4;
                continue;
              }
              goto label_8;
            case 4:
            case 6:
              goto label_11;
            case 5:
              goto label_8;
            default:
              if (metricsGroup == null)
              {
                num = 6;
                continue;
              }
              goto case 2;
          }
        }
label_8:
        MetricsGroup<CacheMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, CacheMetric>, long> func = WebRequestCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_16;
        Func<KeyValuePair<string, CacheMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          WebRequestCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_16 = selector = (Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.WriteTotalTime.Ticks);
        }
        else
          goto label_12;
label_10:
        return (double) source.Sum<KeyValuePair<string, CacheMetric>>(selector) / (double) s.TotalTime.Ticks;
label_12:
        selector = func;
        goto label_10;
label_11:
        return 0.0;
      }), (IExcelCellFormat) PercentFormat.Default).AddColumn<long>(1700L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289469988)), 10.0, (Func<WebRequestMetric, long>) (s =>
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
              goto label_5;
            case 2:
              source = s.Metrics.Get<CacheMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
              continue;
            case 3:
              goto label_6;
            default:
              goto label_5;
          }
        }
label_5:
        return source.Sum<KeyValuePair<string, CacheMetric>>((Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.WriteTotalCount));
label_6:
        return 0;
      })).AddColumn<long>(1800L, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418716704)), 10.0, (Func<WebRequestMetric, long>) (s =>
      {
        int num = 3;
        MetricsGroup<CacheMetric> metricsGroup;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (s.CountCall != 0L)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                continue;
              }
              goto label_11;
            case 2:
              if (metricsGroup != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
                continue;
              }
              goto label_11;
            case 3:
              metricsGroup = s.Metrics.Get<CacheMetric>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 2;
              continue;
            default:
              goto label_7;
          }
        }
label_7:
        MetricsGroup<CacheMetric> source = metricsGroup;
        // ISSUE: reference to a compiler-generated field
        Func<KeyValuePair<string, CacheMetric>, long> func = WebRequestCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_18;
        Func<KeyValuePair<string, CacheMetric>, long> selector;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          WebRequestCacheCallColumnBuilder.\u003C\u003Ec__0<TMetric>.\u003C\u003E9__0_18 = selector = (Func<KeyValuePair<string, CacheMetric>, long>) (c => c.Value.WriteTotalCount);
        }
        else
          goto label_8;
label_10:
        return source.Sum<KeyValuePair<string, CacheMetric>>(selector) / s.CountCall;
label_8:
        selector = func;
        goto label_10;
label_11:
        return 0;
      }));
    }

    public WebRequestCacheCallColumnBuilder()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lDkgljEvllQFoXtTfc8A() => WebRequestCacheCallColumnBuilder.CUe8u1EvdtBpPMlttUWZ == null;

    internal static WebRequestCacheCallColumnBuilder SW4BBkEvrMgkBotvahYD() => WebRequestCacheCallColumnBuilder.CUe8u1EvdtBpPMlttUWZ;
  }
}
