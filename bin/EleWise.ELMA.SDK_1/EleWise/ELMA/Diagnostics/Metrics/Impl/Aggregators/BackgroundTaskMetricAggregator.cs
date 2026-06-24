// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators.BackgroundTaskMetricAggregator
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
  /// <summary>Агрегатор метрик фоновых задач</summary>
  [Component]
  public class BackgroundTaskMetricAggregator : BaseMetricAggregator<CallContextInfo>
  {
    internal static BackgroundTaskMetricAggregator wksYW9EIUmt0d2EFrbSv;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики метрики</param>
    public BackgroundTaskMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(processors);
    }

    /// <inheritdoc />
    public override void Add(CallContextInfo callInfo, MetricsContainer container)
    {
      int num1 = 2;
      CallContextType? type;
      CallContextType callContextType;
      IEnumerator<IMetricProcessor> enumerator;
      BackgroundTaskMetric orAdd;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!type.HasValue)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 3 : 1;
              continue;
            }
            goto case 4;
          case 2:
            type = callInfo.Type;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
            continue;
          case 3:
            orAdd = container.GetOrAdd<BackgroundTaskMetric>().GetOrAdd((string) BackgroundTaskMetricAggregator.DDMIwAEIzTI6uSeUvjtQ((object) callInfo));
            num1 = 7;
            continue;
          case 4:
            type = callInfo.Type;
            num1 = 8;
            continue;
          case 5:
            goto label_25;
          case 6:
            if (!(type.GetValueOrDefault() == callContextType & type.HasValue))
            {
              num1 = 9;
              continue;
            }
            goto case 3;
          case 7:
            enumerator = this.MetricProcessors.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
            continue;
          case 8:
            callContextType = CallContextType.BackgroundTask;
            num1 = 6;
            continue;
          case 9:
            goto label_2;
          default:
            goto label_10;
        }
      }
label_25:
      return;
label_2:
      return;
label_10:
      try
      {
label_13:
        if (BackgroundTaskMetricAggregator.yorhunEVBZQBqcmqKebd((object) enumerator))
          goto label_15;
        else
          goto label_14;
label_12:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            goto label_15;
          default:
            goto label_13;
        }
label_14:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
        goto label_12;
label_15:
        BackgroundTaskMetricAggregator.sBVfNkEVFfyidx6ixrZj((object) enumerator.Current, (object) callInfo, (object) orAdd);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
        {
          num2 = 0;
          goto label_12;
        }
        else
          goto label_12;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = 2;
        else
          goto label_20;
label_19:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_20:
        enumerator.Dispose();
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        {
          num3 = 1;
          goto label_19;
        }
        else
          goto label_19;
      }
    }

    internal static object DDMIwAEIzTI6uSeUvjtQ([In] object obj0) => (object) ((CallContextInfo) obj0).Name;

    internal static void sBVfNkEVFfyidx6ixrZj([In] object obj0, [In] object obj1, [In] object obj2) => ((IMetricProcessor) obj0).Process(obj1, (IMetric) obj2);

    internal static bool yorhunEVBZQBqcmqKebd([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool Ouype6EIswlLiRqbt2ol() => BackgroundTaskMetricAggregator.wksYW9EIUmt0d2EFrbSv == null;

    internal static BackgroundTaskMetricAggregator T8E2RbEIc8T1e1kxa12e() => BackgroundTaskMetricAggregator.wksYW9EIUmt0d2EFrbSv;
  }
}
