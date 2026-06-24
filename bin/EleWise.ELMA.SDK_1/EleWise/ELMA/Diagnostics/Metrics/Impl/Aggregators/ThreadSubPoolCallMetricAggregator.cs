// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators.ThreadSubPoolCallMetricAggregator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators
{
  /// <summary>Агрегатор метрик для вызовов методов из пула потоков</summary>
  [Component]
  internal class ThreadSubPoolCallMetricAggregator : BaseMetricAggregator<ThreadSubPoolCallInfo>
  {
    private static ThreadSubPoolCallMetricAggregator jGgK84EIdHYTInWSHopI;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики метрики</param>
    public ThreadSubPoolCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(processors);
    }

    /// <inheritdoc />
    public override void Add(ThreadSubPoolCallInfo callInfo, MetricsContainer container)
    {
      int num1 = 3;
      ThreadSubPoolMethodMetric orAdd;
      IEnumerator<IMetricProcessor> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_15;
          case 1:
            goto label_3;
          case 2:
            enumerator = this.MetricProcessors.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
            continue;
          case 3:
            orAdd = container.GetOrAdd<ThreadSubPoolMethodMetric>().GetOrAdd((string) ThreadSubPoolCallMetricAggregator.dH1YBmEIjx4hNDZSgIwx(ThreadSubPoolCallMetricAggregator.PoObxbEIgZYYMueNLCne((object) callInfo), ThreadSubPoolCallMetricAggregator.MI53qOEI5KevxLu9FUty(-1921202237 ^ -1921212183), (object) callInfo.OwnerType.FullName, ThreadSubPoolCallMetricAggregator.MI53qOEI5KevxLu9FUty(-488881205 ^ -488739287)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 0;
            continue;
          default:
            goto label_10;
        }
      }
label_15:
      return;
label_10:
      return;
label_3:
      try
      {
label_8:
        if (ThreadSubPoolCallMetricAggregator.U1P4mDEILHHPlZ0JEL9a((object) enumerator))
          goto label_6;
        else
          goto label_9;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            break;
          case 2:
            return;
          default:
            goto label_8;
        }
label_6:
        ThreadSubPoolCallMetricAggregator.RVVferEIYL3bvmsVNp0Z((object) enumerator.Current, (object) callInfo, (object) orAdd);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
label_9:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 1;
        goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
                continue;
              default:
                goto label_17;
            }
          }
        }
label_17:;
      }
    }

    internal static object PoObxbEIgZYYMueNLCne([In] object obj0) => (object) ((AbstractCallInfo) obj0).Description;

    internal static object MI53qOEI5KevxLu9FUty(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object dH1YBmEIjx4hNDZSgIwx(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) ((string) obj0 + (string) obj1 + (string) obj2 + (string) obj3);
    }

    internal static void RVVferEIYL3bvmsVNp0Z([In] object obj0, [In] object obj1, [In] object obj2) => ((IMetricProcessor) obj0).Process(obj1, (IMetric) obj2);

    internal static bool U1P4mDEILHHPlZ0JEL9a([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool CwZKZgEIlLgadPMhdCx6() => ThreadSubPoolCallMetricAggregator.jGgK84EIdHYTInWSHopI == null;

    internal static ThreadSubPoolCallMetricAggregator VhEIogEIrKwB02SiLbEo() => ThreadSubPoolCallMetricAggregator.jGgK84EIdHYTInWSHopI;
  }
}
