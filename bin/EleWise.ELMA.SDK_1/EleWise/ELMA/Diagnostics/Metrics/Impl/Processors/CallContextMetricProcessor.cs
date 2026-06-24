// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Processors.CallContextMetricProcessor
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
  /// <summary>
  /// Обработчик метрик для CallContextInfo и его наследников
  /// </summary>
  [Component]
  public class CallContextMetricProcessor : IMetricProcessor
  {
    private static CallContextMetricProcessor Mfrl2sEuCgN9F6pxaOyu;

    /// <inheritdoc />
    public Type[] AggregatorTypes => new Type[3]
    {
      TypeOf<WebRequestMetricAggregator>.Raw,
      TypeOf<BackgroundTaskMetricAggregator>.Raw,
      TypeOf<CustomDiagnostcisSessionMetricAggregator>.Raw
    };

    /// <inheritdoc />
    public void Process(object callInfo, IMetric currentMetric)
    {
      int num = 6;
      CallContextInfo callContextInfo;
      CallContextMetric callContextMetric1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (callContextInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 3;
              continue;
            }
            goto case 8;
          case 2:
            ((MetricsContainer) CallContextMetricProcessor.c2dDlLEuqkDa0AJgflXh((object) callContextMetric1)).Merge((MetricsContainer) CallContextMetricProcessor.cQtSuuEuKUtS7kd63QbE((object) callContextInfo));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 9 : 9;
            continue;
          case 3:
            goto label_5;
          case 4:
            CallContextMetric callContextMetric2 = callContextMetric1;
            CallContextMetricProcessor.qblmJOEuRTXVbH40Fvq9((object) callContextMetric2, CallContextMetricProcessor.Wua9RIEuIMSjWVweqg6t(CallContextMetricProcessor.xrZaQNEuSW0dP4K6oyix((object) callContextMetric2), CallContextMetricProcessor.W5HuohEuip2692KnaY1c((object) callContextInfo)));
            num = 2;
            continue;
          case 5:
            callContextMetric1 = currentMetric as CallContextMetric;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
            continue;
          case 6:
            callContextInfo = callInfo as CallContextInfo;
            num = 5;
            continue;
          case 7:
            goto label_2;
          case 8:
            if (callContextMetric1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 9:
            goto label_11;
          default:
            CallContextMetric callContextMetric3 = callContextMetric1;
            CallContextMetricProcessor.NMIFcmEuVUFGanyXAnbU((object) callContextMetric3, CallContextMetricProcessor.Wua9RIEuIMSjWVweqg6t(CallContextMetricProcessor.SbvIvKEuZxAUBxDxbnFG((object) callContextMetric3), CallContextMetricProcessor.McfymwEuuunhbYGxHrFu((object) callContextInfo)));
            num = 4;
            continue;
        }
      }
label_5:
      return;
label_2:
      return;
label_11:
      return;
label_9:;
    }

    public CallContextMetricProcessor()
    {
      CallContextMetricProcessor.pAcWS1EuXFMIM3sDkiRf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool M1S5MbEuvVyaJ7ZcrK95() => CallContextMetricProcessor.Mfrl2sEuCgN9F6pxaOyu == null;

    internal static CallContextMetricProcessor HtRoWiEu8bC9lM35xjqP() => CallContextMetricProcessor.Mfrl2sEuCgN9F6pxaOyu;

    internal static TimeSpan SbvIvKEuZxAUBxDxbnFG([In] object obj0) => ((CallContextMetric) obj0).TotalProcessorTime;

    internal static TimeSpan McfymwEuuunhbYGxHrFu([In] object obj0) => ((CallContextInfo) obj0).TotalProcessorTime;

    internal static TimeSpan Wua9RIEuIMSjWVweqg6t([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 + obj1;

    internal static void NMIFcmEuVUFGanyXAnbU([In] object obj0, TimeSpan value) => ((CallContextMetric) obj0).TotalProcessorTime = value;

    internal static TimeSpan xrZaQNEuSW0dP4K6oyix([In] object obj0) => ((CallContextMetric) obj0).UserProcessorTime;

    internal static TimeSpan W5HuohEuip2692KnaY1c([In] object obj0) => ((CallContextInfo) obj0).UserProcessorTime;

    internal static void qblmJOEuRTXVbH40Fvq9([In] object obj0, TimeSpan value) => ((CallContextMetric) obj0).UserProcessorTime = value;

    internal static object c2dDlLEuqkDa0AJgflXh([In] object obj0) => (object) ((CallContextMetric) obj0).Metrics;

    internal static object cQtSuuEuKUtS7kd63QbE([In] object obj0) => (object) ((CallContextInfo) obj0).Metrics;

    internal static void pAcWS1EuXFMIM3sDkiRf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
