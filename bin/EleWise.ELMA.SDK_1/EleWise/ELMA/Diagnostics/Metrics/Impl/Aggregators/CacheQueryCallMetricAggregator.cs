// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators.CacheQueryCallMetricAggregator
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
  /// <summary>Агрегатор метрик работы с кешем</summary>
  [Component]
  public class CacheQueryCallMetricAggregator : 
    BaseMetricAggregator<CacheQueryInfo>,
    IMetricAggregator
  {
    private static CacheQueryCallMetricAggregator VbLIBYEVKiq9gFJ5Oi28;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики метрики</param>
    public CacheQueryCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(processors);
    }

    /// <inheritdoc />
    void IMetricAggregator.Add(object callInfo, MetricsContainer container)
    {
      int num = 1;
      CacheQueryInfo callInfo1;
      while (true)
      {
        switch (num)
        {
          case 1:
            callInfo1 = callInfo as CacheQueryInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_6;
          default:
            if (callInfo1 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 2;
              continue;
            }
            this.Add(callInfo1, container);
            num = 3;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <inheritdoc />
    public override void Add(CacheQueryInfo callInfo, MetricsContainer container)
    {
      int num1 = 3;
      IEnumerator<IMetricProcessor> enumerator;
      CacheMetric orAdd;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_16;
          case 1:
            goto label_2;
          case 2:
            enumerator = this.MetricProcessors.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 1;
            continue;
          case 3:
            orAdd = container.GetOrAdd<CacheMetric>().GetOrAdd((string) CacheQueryCallMetricAggregator.S0Jln7EVkcWfkNrp7Ztx(-1710575414 ^ -1710319544));
            num1 = 2;
            continue;
          default:
            goto label_13;
        }
      }
label_16:
      return;
label_13:
      return;
label_2:
      try
      {
label_5:
        if (CacheQueryCallMetricAggregator.DfB9MXEVO0FpvQtZaCWU((object) enumerator))
          goto label_7;
        else
          goto label_6;
label_3:
        int num2;
        switch (num2)
        {
          case 0:
            return;
          case 1:
            goto label_5;
          case 2:
            goto label_7;
          default:
            return;
        }
label_6:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
        goto label_3;
label_7:
        CacheQueryCallMetricAggregator.JASNGREVnu6OSkU7PO4J((object) enumerator.Current, (object) callInfo, (object) orAdd);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
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
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
        else
          goto label_14;
label_12:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_14:
        CacheQueryCallMetricAggregator.vliG35EV2IJOfuh2lM9i((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
        {
          num3 = 0;
          goto label_12;
        }
        else
          goto label_12;
      }
    }

    internal static bool zaN934EVXmBBLq9qnhFA() => CacheQueryCallMetricAggregator.VbLIBYEVKiq9gFJ5Oi28 == null;

    internal static CacheQueryCallMetricAggregator LfncU2EVTxHoHP5u47uw() => CacheQueryCallMetricAggregator.VbLIBYEVKiq9gFJ5Oi28;

    internal static object S0Jln7EVkcWfkNrp7Ztx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void JASNGREVnu6OSkU7PO4J([In] object obj0, [In] object obj1, [In] object obj2) => ((IMetricProcessor) obj0).Process(obj1, (IMetric) obj2);

    internal static bool DfB9MXEVO0FpvQtZaCWU([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void vliG35EV2IJOfuh2lM9i([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}
