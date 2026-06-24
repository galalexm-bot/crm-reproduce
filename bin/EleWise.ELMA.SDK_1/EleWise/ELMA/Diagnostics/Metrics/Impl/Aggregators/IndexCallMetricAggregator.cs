// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators.IndexCallMetricAggregator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators
{
  /// <summary>Агрегатор метрик обращения к индексу</summary>
  [Component]
  public class IndexCallMetricAggregator : BaseMetricAggregator<IndexCallInfo>
  {
    private static IndexCallMetricAggregator C351wgEVWLXcWRC2eBbw;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики метрики</param>
    public IndexCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(processors);
    }

    /// <inheritdoc />
    public override void Add(IndexCallInfo callInfo, MetricsContainer container)
    {
      int num1 = 2;
      IEnumerator<IMetricProcessor> enumerator;
      IndexCallMetric orAdd;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this.MetricProcessors.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
            continue;
          case 2:
            orAdd = container.GetOrAdd<IndexCallMetric>().GetOrAdd(callInfo.Description);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_14;
          default:
            goto label_4;
        }
      }
label_14:
      return;
label_4:
      try
      {
label_8:
        if (IndexCallMetricAggregator.aZASEgEVGEXXeQkIKceP((object) enumerator))
          goto label_7;
        else
          goto label_9;
label_6:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            goto label_8;
        }
label_7:
        IndexCallMetricAggregator.AsJ9V1EVhWXde5KOOwYM((object) enumerator.Current, (object) callInfo, (object) orAdd);
        num2 = 2;
        goto label_6;
label_9:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
        goto label_6;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
        else
          goto label_15;
label_12:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_15:
        enumerator.Dispose();
        num3 = 2;
        goto label_12;
      }
    }

    internal static void AsJ9V1EVhWXde5KOOwYM([In] object obj0, [In] object obj1, [In] object obj2) => ((IMetricProcessor) obj0).Process(obj1, (IMetric) obj2);

    internal static bool aZASEgEVGEXXeQkIKceP([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool bVReGaEVoZXxAeChcrHN() => IndexCallMetricAggregator.C351wgEVWLXcWRC2eBbw == null;

    internal static IndexCallMetricAggregator HZZJHHEVbLCrC2cXLdRG() => IndexCallMetricAggregator.C351wgEVWLXcWRC2eBbw;
  }
}
