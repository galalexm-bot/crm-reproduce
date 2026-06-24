// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators.ScriptCallMetricAggregator
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
  /// <summary>Агрегатор метрик для пользовательских сценариев</summary>
  [Component]
  public class ScriptCallMetricAggregator : BaseMetricAggregator<ScriptCallInfo>
  {
    internal static ScriptCallMetricAggregator DPRd4pEVAZeEmc46YTRQ;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики метрики</param>
    public ScriptCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(processors);
    }

    /// <inheritdoc />
    public override void Add(ScriptCallInfo callInfo, MetricsContainer container)
    {
      int num1 = 3;
      IEnumerator<IMetricProcessor> enumerator;
      ScriptMetric orAdd;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_15;
          case 2:
            enumerator = this.MetricProcessors.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 3:
            orAdd = container.GetOrAdd<ScriptMetric>().GetOrAdd((string) ScriptCallMetricAggregator.ieHJBMEV0juFaelgG49E((object) callInfo));
            num1 = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_15:
      return;
label_3:
      try
      {
label_6:
        if (ScriptCallMetricAggregator.eTFo9qEVyTXelG7fHQkB((object) enumerator))
          goto label_8;
        else
          goto label_7;
label_5:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            goto label_8;
          default:
            goto label_6;
        }
label_7:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
        goto label_5;
label_8:
        ScriptCallMetricAggregator.jMosHvEVmkG3cenjTZM0((object) enumerator.Current, (object) callInfo, (object) orAdd);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
        else
          goto label_14;
label_12:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_14:
        ScriptCallMetricAggregator.alWvN8EVMm1rCc7Y9V7t((object) enumerator);
        num3 = 2;
        goto label_12;
      }
    }

    internal static object ieHJBMEV0juFaelgG49E([In] object obj0) => (object) ((AbstractCallInfo) obj0).Description;

    internal static void jMosHvEVmkG3cenjTZM0([In] object obj0, [In] object obj1, [In] object obj2) => ((IMetricProcessor) obj0).Process(obj1, (IMetric) obj2);

    internal static bool eTFo9qEVyTXelG7fHQkB([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void alWvN8EVMm1rCc7Y9V7t([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool XF75SvEV7tWOcR03FlIN() => ScriptCallMetricAggregator.DPRd4pEVAZeEmc46YTRQ == null;

    internal static ScriptCallMetricAggregator KSqDqSEVxCXSQ1DU7vQr() => ScriptCallMetricAggregator.DPRd4pEVAZeEmc46YTRQ;
  }
}
