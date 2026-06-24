// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.CountTimeMetric
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics
{
  /// <summary>
  /// Метрика, способная подсчитывать количество вызовов, ошибок,
  /// время выполнения, его среднее, максимальное и минимальное значение
  /// </summary>
  public class CountTimeMetric : CountMetric
  {
    private static CountTimeMetric qnSHXUE8UmYIEc04qaeZ;

    /// <inheritdoc />
    public override Guid Uid => new Guid((string) CountTimeMetric.PKUr6NE8zfO9btf1T710(-1822890472 ^ -1822644134));

    /// <summary>Общее время выполнения</summary>
    [Order(300)]
    [DisplayName(typeof (CountTimeMetric.__CountTimeMetricLocalization), "TotalTime")]
    public TimeSpan TotalTime
    {
      get => this.\u003CTotalTime\u003Ek__BackingField;
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
              this.\u003CTotalTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    /// <summary>Максимальное время одного выполнения</summary>
    [Order(400)]
    [DisplayName(typeof (CountTimeMetric.__CountTimeMetricLocalization), "MaxTime")]
    public double MaxTime
    {
      get => this.\u003CMaxTime\u003Ek__BackingField;
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
              this.\u003CMaxTime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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

    /// <summary>Среднее время одного выполнения</summary>
    [Order(500)]
    [DisplayName(typeof (CountTimeMetric.__CountTimeMetricLocalization), "AvgTime")]
    public double AvgTime
    {
      get
      {
        int num = 1;
        TimeSpan totalTime;
        while (true)
        {
          switch (num)
          {
            case 1:
              totalTime = this.TotalTime;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return totalTime.TotalMilliseconds / (double) this.CountCall;
      }
    }

    /// <inheritdoc />
    public override void Merge(IMetric metric)
    {
      int num = 1;
      CountTimeMetric countTimeMetric;
      while (true)
      {
        switch (num)
        {
          case 1:
            countTimeMetric = metric as CountTimeMetric;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            this.TotalTime += countTimeMetric.TotalTime;
            num = 4;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (this.MaxTime < CountTimeMetric.wKYxRTEZFYd0f0L2Uwxn((object) countTimeMetric))
            {
              num = 6;
              continue;
            }
            goto label_11;
          case 5:
            base.Merge(metric);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 2;
            continue;
          case 6:
            this.MaxTime = CountTimeMetric.wKYxRTEZFYd0f0L2Uwxn((object) countTimeMetric);
            num = 3;
            continue;
          default:
            if (countTimeMetric != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 5;
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

    public CountTimeMetric()
    {
      CountTimeMetric.KgngorEZBawqN5syCwXD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object PKUr6NE8zfO9btf1T710(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool BC8XwLE8skPS62s2cjRI() => CountTimeMetric.qnSHXUE8UmYIEc04qaeZ == null;

    internal static CountTimeMetric A7gSaoE8cNaCcdR5nFID() => CountTimeMetric.qnSHXUE8UmYIEc04qaeZ;

    internal static double wKYxRTEZFYd0f0L2Uwxn([In] object obj0) => ((CountTimeMetric) obj0).MaxTime;

    internal static void KgngorEZBawqN5syCwXD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static class __CountTimeMetricLocalization
    {
      private static CountTimeMetric.__CountTimeMetricLocalization WaySXv8KKuTBZ0wSoNr6;

      public static string TotalTime => EleWise.ELMA.SR.T((string) CountTimeMetric.__CountTimeMetricLocalization.DATF6f8KkG0jYW7S1BSG(1514961705 ^ 1514774509));

      public static string MaxTime => (string) CountTimeMetric.__CountTimeMetricLocalization.gFkxM28KnZG0HnFqR6P7((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195899911));

      public static string AvgTime => (string) CountTimeMetric.__CountTimeMetricLocalization.gFkxM28KnZG0HnFqR6P7(CountTimeMetric.__CountTimeMetricLocalization.DATF6f8KkG0jYW7S1BSG(-680446928 - -370807692 ^ -309419392));

      internal static object DATF6f8KkG0jYW7S1BSG(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool C1wFSr8KXxoJcs38Vkro() => CountTimeMetric.__CountTimeMetricLocalization.WaySXv8KKuTBZ0wSoNr6 == null;

      internal static CountTimeMetric.__CountTimeMetricLocalization NEEk1Y8KTLFMdWGfos6c() => CountTimeMetric.__CountTimeMetricLocalization.WaySXv8KKuTBZ0wSoNr6;

      internal static object gFkxM28KnZG0HnFqR6P7([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
    }
  }
}
