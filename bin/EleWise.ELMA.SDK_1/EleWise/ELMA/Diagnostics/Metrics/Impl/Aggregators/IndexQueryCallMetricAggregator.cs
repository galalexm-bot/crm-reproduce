// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators.IndexQueryCallMetricAggregator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators
{
  /// <summary>Агрегатор метрик запросов в индекс</summary>
  [Component]
  public class IndexQueryCallMetricAggregator : BaseMetricAggregator<IndexQueryInfo>
  {
    internal static IndexQueryCallMetricAggregator I1erDDEVeOnMjhRdEbOb;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики метрики</param>
    public IndexQueryCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(processors);
    }

    /// <inheritdoc />
    public override void Add(IndexQueryInfo callInfo, MetricsContainer container)
    {
      int num1 = 3;
      IEnumerator<IMetricProcessor> enumerator;
      IndexQueryMetric orAdd;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_14;
          case 2:
            enumerator = this.MetricProcessors.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          case 3:
            orAdd = container.GetOrAdd<IndexQueryMetric>().GetOrAdd(callInfo.Description);
            num1 = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_14:
      return;
label_2:
      try
      {
label_5:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_6;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            goto label_5;
          case 2:
            return;
          default:
            goto label_7;
        }
label_6:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 2;
        goto label_4;
label_7:
        IndexQueryCallMetricAggregator.JiFbSYEVNrVhHSr5Gnex((object) enumerator.Current, (object) callInfo, (object) orAdd);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        {
          num2 = 1;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_16;
              default:
                IndexQueryCallMetricAggregator.zDGmEYEV365Sx7LF0ZVh((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_16:;
      }
    }

    internal static void JiFbSYEVNrVhHSr5Gnex([In] object obj0, [In] object obj1, [In] object obj2) => ((IMetricProcessor) obj0).Process(obj1, (IMetric) obj2);

    internal static void zDGmEYEV365Sx7LF0ZVh([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool qQahXMEVPtwfTpMhCI4p() => IndexQueryCallMetricAggregator.I1erDDEVeOnMjhRdEbOb == null;

    internal static IndexQueryCallMetricAggregator URr9NSEV1lYpQu6kFoH3() => IndexQueryCallMetricAggregator.I1erDDEVeOnMjhRdEbOb;
  }
}
