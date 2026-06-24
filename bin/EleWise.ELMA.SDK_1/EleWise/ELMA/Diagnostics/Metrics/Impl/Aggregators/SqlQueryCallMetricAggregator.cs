// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators.SqlQueryCallMetricAggregator
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
  /// <summary>Агрегатор метрик для SQL-запросов</summary>
  [Component]
  public class SqlQueryCallMetricAggregator : BaseMetricAggregator<SqlQueryInfo>
  {
    private static SqlQueryCallMetricAggregator hxubH0EVJnUBbHhZen6B;

    /// <summary>Ctor</summary>
    /// <param name="processors">Обработчики метрики</param>
    public SqlQueryCallMetricAggregator(IEnumerable<IMetricProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(processors);
    }

    /// <inheritdoc />
    public override void Add(SqlQueryInfo callInfo, MetricsContainer container)
    {
      int num1 = 2;
      SqlQueryMetric orAdd;
      IEnumerator<IMetricProcessor> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_17;
          case 1:
            enumerator = this.MetricProcessors.GetEnumerator();
            num1 = 3;
            continue;
          case 2:
            orAdd = container.GetOrAdd<SqlQueryMetric>().GetOrAdd(callInfo.Description);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_14;
        }
      }
label_17:
      return;
label_14:
      return;
label_4:
      try
      {
label_6:
        if (SqlQueryCallMetricAggregator.SxGlG9EVlENWxMxKEoUU((object) enumerator))
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
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
        goto label_5;
label_8:
        enumerator.Current.Process((object) callInfo, (IMetric) orAdd);
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
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
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
        else
          goto label_15;
label_13:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_15:
        SqlQueryCallMetricAggregator.K8VBrBEVrh5RlvZi75qE((object) enumerator);
        num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        {
          num3 = 1;
          goto label_13;
        }
        else
          goto label_13;
      }
    }

    internal static bool SxGlG9EVlENWxMxKEoUU([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void K8VBrBEVrh5RlvZi75qE([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool HamHVWEV9fJpZAsQ3MQJ() => SqlQueryCallMetricAggregator.hxubH0EVJnUBbHhZen6B == null;

    internal static SqlQueryCallMetricAggregator huFrsUEVdIpFTWBVUmwj() => SqlQueryCallMetricAggregator.hxubH0EVJnUBbHhZen6B;
  }
}
