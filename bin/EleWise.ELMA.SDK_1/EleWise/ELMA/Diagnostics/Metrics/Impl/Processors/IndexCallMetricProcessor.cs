// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Processors.IndexCallMetricProcessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Processors
{
  /// <summary>Обработчик метрик, наследуемых от IndexCallMetric</summary>
  [Component]
  public class IndexCallMetricProcessor : IMetricProcessor
  {
    private static IndexCallMetricProcessor YbPte4EuT7W7G7vTFT0M;

    /// <inheritdoc />
    public Type[] AggregatorTypes => new Type[1]
    {
      TypeOf<IndexCallMetricAggregator>.Raw
    };

    /// <inheritdoc />
    public void Process(object callInfo, IMetric currentMetric)
    {
      int num = 1;
      IndexCallInfo indexCallInfo;
      IndexCallMetric indexCallMetric1;
      while (true)
      {
        switch (num)
        {
          case 1:
            indexCallMetric1 = currentMetric as IndexCallMetric;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          case 2:
            IndexCallMetric indexCallMetric2 = indexCallMetric1;
            IndexCallMetricProcessor.HJugubEueZ8kQx44bLtK((object) indexCallMetric2, IndexCallMetricProcessor.dgMbOXEu23UJ5lxr64mh((object) indexCallMetric2) + 1L);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 4 : 3;
            continue;
          case 3:
            if (indexCallInfo != null)
            {
              num = 5;
              continue;
            }
            goto label_14;
          case 4:
            goto label_10;
          case 5:
            if (indexCallMetric1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 7;
              continue;
            }
            if (!IndexCallMetricProcessor.pCPaEBEuOdBRa3tHr8c1((object) indexCallInfo))
            {
              num = 6;
              continue;
            }
            goto case 2;
          case 6:
            goto label_2;
          case 7:
            goto label_5;
          default:
            indexCallInfo = callInfo as IndexCallInfo;
            num = 3;
            continue;
        }
      }
label_10:
      return;
label_2:
      return;
label_5:
      return;
label_14:;
    }

    public IndexCallMetricProcessor()
    {
      IndexCallMetricProcessor.KIFk6TEuPHfPklsMwHvT();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool naEkjlEukVlWapiTthvc() => IndexCallMetricProcessor.YbPte4EuT7W7G7vTFT0M == null;

    internal static IndexCallMetricProcessor ydprakEunb91GZuxuw2B() => IndexCallMetricProcessor.YbPte4EuT7W7G7vTFT0M;

    internal static bool pCPaEBEuOdBRa3tHr8c1([In] object obj0) => ((IndexCallInfo) obj0).IsCancel;

    internal static long dgMbOXEu23UJ5lxr64mh([In] object obj0) => ((IndexCallMetric) obj0).CountCancelCall;

    internal static void HJugubEueZ8kQx44bLtK([In] object obj0, long value) => ((IndexCallMetric) obj0).CountCancelCall = value;

    internal static void KIFk6TEuPHfPklsMwHvT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
