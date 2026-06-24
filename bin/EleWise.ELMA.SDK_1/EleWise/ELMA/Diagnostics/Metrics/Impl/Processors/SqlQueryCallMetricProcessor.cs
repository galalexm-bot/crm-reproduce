// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Metrics.Impl.Processors.SqlQueryCallMetricProcessor
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
  /// <summary>Обработчик метрик для SQL-запросов</summary>
  [Component]
  public class SqlQueryCallMetricProcessor : IMetricProcessor
  {
    internal static SqlQueryCallMetricProcessor NVJ7sZEIKsNUgDdMT56C;

    /// <inheritdoc />
    public Type[] AggregatorTypes => new Type[1]
    {
      TypeOf<SqlQueryCallMetricAggregator>.Raw
    };

    /// <inheritdoc />
    public void Process(object callInfo, IMetric currentMetric)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        SqlQueryMetric sqlQueryMetric1;
        SqlQueryInfo sqlQueryInfo;
        TimeSpan timeSpan;
        TimeSpan totalTime;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_26;
            case 2:
              SqlQueryCallMetricProcessor.tuDTtwEInj4dgQcuqCDe((object) sqlQueryMetric1, (long) totalTime.TotalMilliseconds);
              num2 = 11;
              continue;
            case 3:
              if (sqlQueryMetric1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
                continue;
              }
              totalTime = sqlQueryInfo.TotalTime;
              num2 = 6;
              continue;
            case 4:
              if (sqlQueryInfo == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 14 : 0;
                continue;
              }
              goto case 3;
            case 5:
              SqlQueryMetric sqlQueryMetric2 = sqlQueryMetric1;
              long totalAffectedRows = sqlQueryMetric2.TotalAffectedRows;
              long? rowsAffected = sqlQueryInfo.RowsAffected;
              long num3;
              if (!rowsAffected.HasValue)
              {
                num3 = 0L;
              }
              else
              {
                rowsAffected = sqlQueryInfo.RowsAffected;
                num3 = rowsAffected.Value;
              }
              SqlQueryCallMetricProcessor.uQky2yEIDqxa0byrbW10((object) sqlQueryMetric2, totalAffectedRows + num3);
              num2 = 9;
              continue;
            case 6:
              if ((double) SqlQueryCallMetricProcessor.KpcRy4EIkb0Xd8LTuSRt((object) sqlQueryMetric1) < totalTime.TotalMilliseconds)
              {
                num2 = 2;
                continue;
              }
              goto case 11;
            case 7:
              sqlQueryMetric1 = currentMetric as SqlQueryMetric;
              num2 = 4;
              continue;
            case 8:
              sqlQueryInfo = callInfo as SqlQueryInfo;
              num2 = 7;
              continue;
            case 9:
              goto label_10;
            case 10:
              double num4 = (double) SqlQueryCallMetricProcessor.bpoMfOEI1pj9u06CQHK1((object) sqlQueryMetric1);
              timeSpan = SqlQueryCallMetricProcessor.tPTISAEINWgFWxy4aoCY((object) sqlQueryInfo);
              double totalMilliseconds1 = timeSpan.TotalMilliseconds;
              if (num4 >= totalMilliseconds1)
                goto case 12;
              else
                goto label_5;
            case 11:
              SqlQueryCallMetricProcessor.aWTfiOEIeLLEqn5WoJuG((object) sqlQueryMetric1, SqlQueryCallMetricProcessor.nwi4H3EIOAYSYwshUZFc((object) sqlQueryMetric1) != 0L ? (double) ((long) (SqlQueryCallMetricProcessor.qOOjivEI2WZkfbJEV2uA((object) sqlQueryMetric1) * (double) (SqlQueryCallMetricProcessor.nwi4H3EIOAYSYwshUZFc((object) sqlQueryMetric1) - 1L) + totalTime.TotalMilliseconds) / sqlQueryMetric1.CountCall) : 0.0);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
              continue;
            case 12:
              SqlQueryMetric sqlQueryMetric3 = sqlQueryMetric1;
              long num5;
              if (SqlQueryCallMetricProcessor.nwi4H3EIOAYSYwshUZFc((object) sqlQueryMetric1) == 0L)
              {
                num5 = 0L;
              }
              else
              {
                double num6 = SqlQueryCallMetricProcessor.mQq0d1EIpfvJsldgGpch((object) sqlQueryMetric1) * (double) (SqlQueryCallMetricProcessor.nwi4H3EIOAYSYwshUZFc((object) sqlQueryMetric1) - 1L);
                timeSpan = SqlQueryCallMetricProcessor.tPTISAEINWgFWxy4aoCY((object) sqlQueryInfo);
                double totalMilliseconds2 = timeSpan.TotalMilliseconds;
                num5 = (long) (num6 + totalMilliseconds2) / sqlQueryMetric1.CountCall;
              }
              double num7 = (double) num5;
              SqlQueryCallMetricProcessor.i6eqYmEIavAO4M1wUgIa((object) sqlQueryMetric3, num7);
              num2 = 5;
              continue;
            case 13:
              SqlQueryMetric sqlQueryMetric4 = sqlQueryMetric1;
              timeSpan = SqlQueryCallMetricProcessor.tPTISAEINWgFWxy4aoCY((object) sqlQueryInfo);
              long totalMilliseconds3 = (long) timeSpan.TotalMilliseconds;
              SqlQueryCallMetricProcessor.K00kpgEI32X1l9cQCygC((object) sqlQueryMetric4, totalMilliseconds3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 9 : 12;
              continue;
            case 14:
              goto label_3;
            default:
              if (SqlQueryCallMetricProcessor.A1YphrEIPars2Wedis11((object) sqlQueryInfo))
              {
                num2 = 10;
                continue;
              }
              goto case 5;
          }
        }
label_5:
        num1 = 13;
      }
label_26:
      return;
label_10:
      return;
label_3:;
    }

    public SqlQueryCallMetricProcessor()
    {
      SqlQueryCallMetricProcessor.naSvwmEItxiqAZdoC1UQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool zB4NMrEIXVwXIx2wnTE2() => SqlQueryCallMetricProcessor.NVJ7sZEIKsNUgDdMT56C == null;

    internal static SqlQueryCallMetricProcessor fqU4HyEITf4HM86CBvv3() => SqlQueryCallMetricProcessor.NVJ7sZEIKsNUgDdMT56C;

    internal static long KpcRy4EIkb0Xd8LTuSRt([In] object obj0) => ((SqlQueryMetric) obj0).MaxExecuteTime;

    internal static void tuDTtwEInj4dgQcuqCDe([In] object obj0, long value) => ((SqlQueryMetric) obj0).MaxExecuteTime = value;

    internal static long nwi4H3EIOAYSYwshUZFc([In] object obj0) => ((CountMetric) obj0).CountCall;

    internal static double qOOjivEI2WZkfbJEV2uA([In] object obj0) => ((SqlQueryMetric) obj0).AvgExecuteTime;

    internal static void aWTfiOEIeLLEqn5WoJuG([In] object obj0, double value) => ((SqlQueryMetric) obj0).AvgExecuteTime = value;

    internal static bool A1YphrEIPars2Wedis11([In] object obj0) => ((SqlQueryInfo) obj0).IsPrepare;

    internal static long bpoMfOEI1pj9u06CQHK1([In] object obj0) => ((SqlQueryMetric) obj0).MaxPrepareTime;

    internal static TimeSpan tPTISAEINWgFWxy4aoCY([In] object obj0) => ((AbstractCallInfo) obj0).TotalTime;

    internal static void K00kpgEI32X1l9cQCygC([In] object obj0, long value) => ((SqlQueryMetric) obj0).MaxPrepareTime = value;

    internal static double mQq0d1EIpfvJsldgGpch([In] object obj0) => ((SqlQueryMetric) obj0).AvgPrepareTime;

    internal static void i6eqYmEIavAO4M1wUgIa([In] object obj0, double value) => ((SqlQueryMetric) obj0).AvgPrepareTime = value;

    internal static void uQky2yEIDqxa0byrbW10([In] object obj0, long value) => ((SqlQueryMetric) obj0).TotalAffectedRows = value;

    internal static void naSvwmEItxiqAZdoC1UQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
