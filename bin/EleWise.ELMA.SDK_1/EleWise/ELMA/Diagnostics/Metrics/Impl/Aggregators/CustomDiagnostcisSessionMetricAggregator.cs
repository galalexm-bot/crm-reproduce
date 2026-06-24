// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators.CustomDiagnostcisSessionMetricAggregator
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
  /// <summary>Агрегатор метрик кастомных сессий диагностики</summary>
  [Component]
  public class CustomDiagnostcisSessionMetricAggregator : BaseMetricAggregator<CallContextInfo>
  {
    internal static CustomDiagnostcisSessionMetricAggregator S9dQQFEIwU7ZTM9Icyjo;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики метрики</param>
    public CustomDiagnostcisSessionMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(processors);
    }

    /// <inheritdoc />
    public override void Add(CallContextInfo callInfo, MetricsContainer container)
    {
      int num1 = 3;
      CallContextType? type;
      IEnumerator<IMetricProcessor> enumerator;
      CustomDiagnosticsSessionMetrics orAdd;
      CallContextType callContextType;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_23;
          case 2:
            if (!type.HasValue)
            {
              num1 = 4;
              continue;
            }
            goto case 7;
          case 3:
            type = callInfo.Type;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 2 : 1;
            continue;
          case 4:
          case 10:
            orAdd = container.GetOrAdd<CustomDiagnosticsSessionMetrics>().GetOrAdd((string) CustomDiagnostcisSessionMetricAggregator.mkiAOkEIHaUpLomkY0Ph((object) callInfo));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          case 5:
            callContextType = CallContextType.SubContext;
            num1 = 9;
            continue;
          case 6:
            goto label_3;
          case 7:
            type = callInfo.Type;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 5 : 3;
            continue;
          case 8:
            goto label_25;
          case 9:
            if (type.GetValueOrDefault() == callContextType & type.HasValue)
            {
              num1 = 10;
              continue;
            }
            goto label_22;
          default:
            enumerator = this.MetricProcessors.GetEnumerator();
            num1 = 6;
            continue;
        }
      }
label_23:
      return;
label_25:
      return;
label_3:
      try
      {
label_7:
        if (CustomDiagnostcisSessionMetricAggregator.Vo7CllEI7OuJ1Ub6b3u0((object) enumerator))
          goto label_5;
        else
          goto label_8;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            goto label_7;
          case 2:
            return;
        }
label_5:
        CustomDiagnostcisSessionMetricAggregator.jg77T3EIAO3HThtygmrb((object) enumerator.Current, (object) callInfo, (object) orAdd);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        {
          num2 = 1;
          goto label_4;
        }
        else
          goto label_4;
label_8:
        num2 = 2;
        goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
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
        enumerator.Dispose();
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
        {
          num3 = 1;
          goto label_11;
        }
        else
          goto label_11;
      }
label_22:;
    }

    internal static object mkiAOkEIHaUpLomkY0Ph([In] object obj0) => (object) ((CallContextInfo) obj0).Name;

    internal static void jg77T3EIAO3HThtygmrb([In] object obj0, [In] object obj1, [In] object obj2) => ((IMetricProcessor) obj0).Process(obj1, (IMetric) obj2);

    internal static bool Vo7CllEI7OuJ1Ub6b3u0([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool MNsEJeEI4RlSm5s5OoOp() => CustomDiagnostcisSessionMetricAggregator.S9dQQFEIwU7ZTM9Icyjo == null;

    internal static CustomDiagnostcisSessionMetricAggregator jXX4rNEI6OwMod874cdQ() => CustomDiagnostcisSessionMetricAggregator.S9dQQFEIwU7ZTM9Icyjo;
  }
}
