// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.MethodMetric
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>
  /// Метрики вызова метода.
  /// Является базовой метрикой для скриптов, фоновых задач и методов, вызываемых в пуле потоков
  /// </summary>
  [Aggregator(typeof (MethodCallMetricAggregator))]
  public class MethodMetric : CountTimeMetric
  {
    internal static MethodMetric rjNneGEZ25FCJIOb5mGV;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) MethodMetric.d36PHrEZ10LHDKm3MH8R(-1852837372 ^ -1853113034));

    /// <summary>Чистое время работы</summary>
    [DisplayName(typeof (MethodMetric.__MethodMetricLocalization), "ClearTotalTime")]
    [Order(600)]
    public TimeSpan ClearTotalTime
    {
      get => this.\u003CClearTotalTime\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CClearTotalTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Максимальное чистое время работы</summary>
    [Order(700)]
    [DisplayName(typeof (MethodMetric.__MethodMetricLocalization), "ClearMaxTime")]
    public double ClearMaxTime
    {
      get => this.\u003CClearMaxTime\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CClearMaxTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Чистое среднее время работы</summary>
    [DisplayName(typeof (MethodMetric.__MethodMetricLocalization), "ClearAvgTime")]
    [Order(800)]
    public double ClearAvgTime
    {
      get
      {
        int num = 1;
        TimeSpan clearTotalTime;
        while (true)
        {
          switch (num)
          {
            case 1:
              clearTotalTime = this.ClearTotalTime;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return clearTotalTime.TotalMilliseconds / (double) this.CountCall;
      }
    }

    /// <inheritdoc />
    public override void Merge(IMetric metric)
    {
      int num = 1;
      MethodMetric methodMetric;
      while (true)
      {
        switch (num)
        {
          case 1:
            methodMetric = metric as MethodMetric;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (this.ClearMaxTime < MethodMetric.h34G43EZ3GSfH1obBfuu((object) methodMetric))
            {
              num = 4;
              continue;
            }
            goto label_11;
          case 4:
            this.ClearMaxTime = MethodMetric.h34G43EZ3GSfH1obBfuu((object) methodMetric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 2;
            continue;
          case 5:
            this.ClearTotalTime = MethodMetric.jTpAfuEZNlic3tfcIVBS(this.ClearTotalTime, methodMetric.ClearTotalTime);
            num = 3;
            continue;
          case 6:
            base.Merge(metric);
            num = 5;
            continue;
          default:
            if (methodMetric != null)
            {
              num = 6;
              continue;
            }
            goto label_12;
        }
      }
label_2:
      return;
label_11:
      return;
label_12:;
    }

    public MethodMetric()
    {
      MethodMetric.mgtsayEZpa5RrtQ1Q0xa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object d36PHrEZ10LHDKm3MH8R(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool XdXGh3EZeN0d34d50hVX() => MethodMetric.rjNneGEZ25FCJIOb5mGV == null;

    internal static MethodMetric IeOlp5EZPtnBPJI3Mqvc() => MethodMetric.rjNneGEZ25FCJIOb5mGV;

    internal static TimeSpan jTpAfuEZNlic3tfcIVBS([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 + obj1;

    internal static double h34G43EZ3GSfH1obBfuu([In] object obj0) => ((MethodMetric) obj0).ClearMaxTime;

    internal static void mgtsayEZpa5RrtQ1Q0xa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static class __MethodMetricLocalization
    {
      private static MethodMetric.__MethodMetricLocalization PdOpQN8KNSHHCelK69gX;

      public static string ClearTotalTime => (string) MethodMetric.__MethodMetricLocalization.iZjrbY8Ka87NrgfLLYOg((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(381945751 ^ 1158627804 ^ 1406051215));

      public static string ClearMaxTime => EleWise.ELMA.SR.T((string) MethodMetric.__MethodMetricLocalization.NFNQkk8KDYYnOOFVdqis(-244066886 - -48452443 ^ -195900177));

      public static string ClearAvgTime => (string) MethodMetric.__MethodMetricLocalization.iZjrbY8Ka87NrgfLLYOg(MethodMetric.__MethodMetricLocalization.NFNQkk8KDYYnOOFVdqis(-2106517564 ^ -2106265188));

      internal static object iZjrbY8Ka87NrgfLLYOg([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool UwK43d8K3jqMlGOqLRRy() => MethodMetric.__MethodMetricLocalization.PdOpQN8KNSHHCelK69gX == null;

      internal static MethodMetric.__MethodMetricLocalization pSrbSD8KpBju0LBksTh2() => MethodMetric.__MethodMetricLocalization.PdOpQN8KNSHHCelK69gX;

      internal static object NFNQkk8KDYYnOOFVdqis(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
    }
  }
}
