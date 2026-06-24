// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators.MethodCallMetricAggregator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators
{
  /// <summary>Агрегатор метрик для вызовов методов</summary>
  [Component]
  public class MethodCallMetricAggregator : BaseMetricAggregator<MethodCallInfo>
  {
    internal static MethodCallMetricAggregator F0SN9IEVpIdjl1agKqTA;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики метрики</param>
    public MethodCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(processors);
    }

    /// <inheritdoc />
    public override void Add(MethodCallInfo callInfo, MetricsContainer container)
    {
      int num1 = 1;
      IEnumerator<IMetricProcessor> enumerator;
      MethodMetric orAdd;
      while (true)
      {
        switch (num1)
        {
          case 1:
            orAdd = container.GetOrAdd<MethodMetric>().GetOrAdd((string) MethodCallMetricAggregator.BkHEudEVt0qinXBYXqNg((object) callInfo) + (string) MethodCallMetricAggregator.oqQJb5EVw7qu5VE0iE0v(654297945 ^ 654290035) + callInfo.OwnerType.FullName + (string) MethodCallMetricAggregator.oqQJb5EVw7qu5VE0iE0v(1597012150 ^ 1597134164));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_14;
          default:
            enumerator = this.MetricProcessors.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 2;
            continue;
        }
      }
label_14:
      return;
label_2:
      try
      {
label_4:
        if (MethodCallMetricAggregator.drVlDkEV682JXxCx9hdA((object) enumerator))
          goto label_6;
        else
          goto label_5;
label_3:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            goto label_6;
          default:
            goto label_4;
        }
label_5:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
        goto label_3;
label_6:
        MethodCallMetricAggregator.rlr59BEV4DYgohau8dvC((object) enumerator.Current, (object) callInfo, (object) orAdd);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        {
          num2 = 0;
          goto label_3;
        }
        else
          goto label_3;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
        else
          goto label_12;
label_10:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_12:
        MethodCallMetricAggregator.qfAsfOEVHxxGSXgvVYWu((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        {
          num3 = 1;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    internal static object BkHEudEVt0qinXBYXqNg([In] object obj0) => (object) ((AbstractCallInfo) obj0).Description;

    internal static object oqQJb5EVw7qu5VE0iE0v(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void rlr59BEV4DYgohau8dvC([In] object obj0, [In] object obj1, [In] object obj2) => ((IMetricProcessor) obj0).Process(obj1, (IMetric) obj2);

    internal static bool drVlDkEV682JXxCx9hdA([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void qfAsfOEVHxxGSXgvVYWu([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool SgKrhPEVaCcyt5IbwocT() => MethodCallMetricAggregator.F0SN9IEVpIdjl1agKqTA == null;

    internal static MethodCallMetricAggregator LqfvlUEVDFntHsuqiaJI() => MethodCallMetricAggregator.F0SN9IEVpIdjl1agKqTA;
  }
}
