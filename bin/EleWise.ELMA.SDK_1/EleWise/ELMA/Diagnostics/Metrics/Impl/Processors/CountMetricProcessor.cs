// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Processors.CountMetricProcessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Processors
{
  /// <summary>Обработчик метрик, наследуемых от CountMetric</summary>
  [Component(Order = -10)]
  public class CountMetricProcessor : IMetricProcessor
  {
    private readonly Type baseMetricAggregatorType;
    private static CountMetricProcessor fJDfniEu5fxxsmn2CZs8;

    /// <inheritdoc />
    public Type[] AggregatorTypes => new Type[1]
    {
      this.baseMetricAggregatorType
    };

    /// <inheritdoc />
    public void Process(object callInfo, IMetric currentMetric)
    {
      int num = 2;
      IWorkTreeElement workTreeElement;
      CountMetric countMetric1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            workTreeElement = callInfo as IWorkTreeElement;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 5 : 1;
            continue;
          case 2:
            countMetric1 = currentMetric as CountMetric;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
            continue;
          case 3:
            CountMetric countMetric2 = countMetric1;
            CountMetricProcessor.WOQyaVEuz77Tcs7fhGdW((object) countMetric2, CountMetricProcessor.iBsCKkEucpjlRCVMNxHj((object) countMetric2) + 1L);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 4:
            if (CountMetricProcessor.MdtxvtEus9s4wL7LQBvA((object) workTreeElement) != null)
            {
              num = 3;
              continue;
            }
            goto label_15;
          case 5:
            if (workTreeElement == null)
            {
              num = 8;
              continue;
            }
            goto case 7;
          case 6:
            goto label_9;
          case 7:
            if (countMetric1 != null)
            {
              CountMetric countMetric3 = countMetric1;
              CountMetricProcessor.d27UdmEuU8eZPt1shPs9((object) countMetric3, CountMetricProcessor.JuMU3EEuLGd88FCLwYak((object) countMetric3) + 1L);
              num = 4;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 6 : 3;
            continue;
          case 8:
            goto label_2;
          default:
            goto label_16;
        }
      }
label_5:
      return;
label_9:
      return;
label_2:
      return;
label_16:
      return;
label_15:;
    }

    public CountMetricProcessor()
    {
      CountMetricProcessor.i4uVxFEIFv84n2TEpvdr();
      this.baseMetricAggregatorType = typeof (BaseMetricAggregator<>);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool FBXTSYEuj1RGTPgA8jxg() => CountMetricProcessor.fJDfniEu5fxxsmn2CZs8 == null;

    internal static CountMetricProcessor H9cgNSEuYlXs70BtAU6G() => CountMetricProcessor.fJDfniEu5fxxsmn2CZs8;

    internal static long JuMU3EEuLGd88FCLwYak([In] object obj0) => ((CountMetric) obj0).CountCall;

    internal static void d27UdmEuU8eZPt1shPs9([In] object obj0, long value) => ((CountMetric) obj0).CountCall = value;

    internal static object MdtxvtEus9s4wL7LQBvA([In] object obj0) => (object) ((IWorkTreeElement) obj0).Exception;

    internal static long iBsCKkEucpjlRCVMNxHj([In] object obj0) => ((CountMetric) obj0).CountErrorCall;

    internal static void WOQyaVEuz77Tcs7fhGdW([In] object obj0, long value) => ((CountMetric) obj0).CountErrorCall = value;

    internal static void i4uVxFEIFv84n2TEpvdr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
