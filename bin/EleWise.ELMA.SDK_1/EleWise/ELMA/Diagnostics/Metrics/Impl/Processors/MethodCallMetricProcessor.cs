// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Processors.MethodCallMetricProcessor
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
  /// Обработчик метрик для вызовов функций, пользовательских сценариев
  /// </summary>
  [Component]
  public class MethodCallMetricProcessor : IMetricProcessor
  {
    private static MethodCallMetricProcessor MhgSDWEIvh58MYTu9NGY;

    /// <inheritdoc />
    public Type[] AggregatorTypes => new Type[3]
    {
      TypeOf<MethodCallMetricAggregator>.Raw,
      TypeOf<ScriptCallMetricAggregator>.Raw,
      TypeOf<ThreadSubPoolCallMetricAggregator>.Raw
    };

    /// <inheritdoc />
    public void Process(object callInfo, IMetric currentMetric)
    {
      int num1 = 2;
      MethodMetric methodMetric1;
      MethodCallInfo methodCallInfo;
      TimeSpan timeSpan;
      while (true)
      {
        switch (num1)
        {
          case 1:
            methodMetric1 = currentMetric as MethodMetric;
            num1 = 5;
            continue;
          case 2:
            methodCallInfo = callInfo as MethodCallInfo;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 1 : 1;
            continue;
          case 3:
            MethodMetric methodMetric2 = methodMetric1;
            MethodCallMetricProcessor.PTRwvMEISpQ5nsOGKduq((object) methodMetric2, MethodCallMetricProcessor.r017LJEIVuUSCaHmWh60(MethodCallMetricProcessor.AF6qQ6EIuGhv3hCuShJi((object) methodMetric2), MethodCallMetricProcessor.O3h0uBEIIZgudG2ko1vk((object) methodCallInfo)));
            num1 = 7;
            continue;
          case 4:
            goto label_4;
          case 5:
            if (methodCallInfo != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 8 : 8;
              continue;
            }
            goto label_15;
          case 6:
            goto label_11;
          case 7:
            double num2 = MethodCallMetricProcessor.MdGw0XEIicj2nJA4pNc2((object) methodMetric1);
            timeSpan = methodCallInfo.ClearTime;
            double totalMilliseconds1 = timeSpan.TotalMilliseconds;
            if (num2 < totalMilliseconds1)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 8:
            if (methodMetric1 != null)
            {
              num1 = 3;
              continue;
            }
            goto label_16;
          default:
            MethodMetric methodMetric3 = methodMetric1;
            timeSpan = MethodCallMetricProcessor.O3h0uBEIIZgudG2ko1vk((object) methodCallInfo);
            double totalMilliseconds2 = timeSpan.TotalMilliseconds;
            MethodCallMetricProcessor.JbM3cBEIRjaitpwJwYJL((object) methodMetric3, totalMilliseconds2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 5 : 6;
            continue;
        }
      }
label_4:
      return;
label_11:
      return;
label_15:
      return;
label_16:
      return;
label_2:;
    }

    public MethodCallMetricProcessor()
    {
      MethodCallMetricProcessor.gu62HbEIq2Jjm1SGYdEi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool g9hQYCEI8K7MsHT48fMC() => MethodCallMetricProcessor.MhgSDWEIvh58MYTu9NGY == null;

    internal static MethodCallMetricProcessor s8jfHWEIZxBntyDhmThp() => MethodCallMetricProcessor.MhgSDWEIvh58MYTu9NGY;

    internal static TimeSpan AF6qQ6EIuGhv3hCuShJi([In] object obj0) => ((MethodMetric) obj0).ClearTotalTime;

    internal static TimeSpan O3h0uBEIIZgudG2ko1vk([In] object obj0) => ((AbstractCallInfo) obj0).ClearTime;

    internal static TimeSpan r017LJEIVuUSCaHmWh60([In] TimeSpan obj0, [In] TimeSpan obj1) => obj0 + obj1;

    internal static void PTRwvMEISpQ5nsOGKduq([In] object obj0, TimeSpan value) => ((MethodMetric) obj0).ClearTotalTime = value;

    internal static double MdGw0XEIicj2nJA4pNc2([In] object obj0) => ((MethodMetric) obj0).ClearMaxTime;

    internal static void JbM3cBEIRjaitpwJwYJL([In] object obj0, double value) => ((MethodMetric) obj0).ClearMaxTime = value;

    internal static void gu62HbEIq2Jjm1SGYdEi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
