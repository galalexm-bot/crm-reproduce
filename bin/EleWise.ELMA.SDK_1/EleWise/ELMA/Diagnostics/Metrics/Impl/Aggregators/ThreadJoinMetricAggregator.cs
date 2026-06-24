// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators.ThreadJoinMetricAggregator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators
{
  /// <summary>Агрегатор метрик ожидания завершения работы потока</summary>
  [Component]
  internal class ThreadJoinMetricAggregator : BaseMetricAggregator<ThreadJoinCallInfo>
  {
    internal static ThreadJoinMetricAggregator oEN3CdEIxOi2KTdlDnya;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики метрики</param>
    public ThreadJoinMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(processors);
    }

    /// <inheritdoc />
    public override void Add(ThreadJoinCallInfo callInfo, MetricsContainer container)
    {
      int num1 = 1;
      ThreadJoinMetric orAdd;
      IEnumerator<IMetricProcessor> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            orAdd = container.GetOrAdd<ThreadJoinMetric>().GetOrAdd((string) ThreadJoinMetricAggregator.HAlUhVEIy6j5bwkeIrFL((object) callInfo));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_15;
          default:
            enumerator = this.MetricProcessors.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 0;
            continue;
        }
      }
label_15:
      return;
label_3:
      try
      {
label_7:
        if (ThreadJoinMetricAggregator.mcFlThEIJYycBqBc4KhQ((object) enumerator))
          goto label_5;
        else
          goto label_8;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            break;
          case 2:
            return;
          default:
            goto label_7;
        }
label_5:
        ThreadJoinMetricAggregator.S0dmjHEIMnCpIVsN38MJ((object) enumerator.Current, (object) callInfo, (object) orAdd);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
label_8:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 2;
        goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 1;
        else
          goto label_13;
label_11:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_13:
        ThreadJoinMetricAggregator.ECdN9LEI9uRkEYu5Okes((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
        {
          num3 = 0;
          goto label_11;
        }
        else
          goto label_11;
      }
    }

    internal static object HAlUhVEIy6j5bwkeIrFL([In] object obj0) => (object) ((AbstractCallInfo) obj0).Description;

    internal static void S0dmjHEIMnCpIVsN38MJ([In] object obj0, [In] object obj1, [In] object obj2) => ((IMetricProcessor) obj0).Process(obj1, (IMetric) obj2);

    internal static bool mcFlThEIJYycBqBc4KhQ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void ECdN9LEI9uRkEYu5Okes([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool DXZdL5EI0ZBbExV7XHr7() => ThreadJoinMetricAggregator.oEN3CdEIxOi2KTdlDnya == null;

    internal static ThreadJoinMetricAggregator LKywe8EImTBTeLms1FL2() => ThreadJoinMetricAggregator.oEN3CdEIxOi2KTdlDnya;
  }
}
