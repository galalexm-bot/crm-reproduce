// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.IndexQueriesPage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Performance
{
  /// <summary>Страница отчета "Запросы в индекс"</summary>
  [ComponentOrder(500)]
  internal class IndexQueriesPage : PerformanceReportPage
  {
    private static IndexQueriesPage kQppIkEQmX7FdK8niQdP;

    /// <summary>Ctor</summary>
    /// <param name="builders">Построители колонок</param>
    public IndexQueriesPage(
      IEnumerable<IPerformanceReportPageColumnBuilder> builders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(builders);
    }

    /// <inheritdoc />
    public override string Name => (string) IndexQueriesPage.QGt62xEQ9vGVfFpUA36s(IndexQueriesPage.n4QPiaEQJ6wBxUT0FhDp(-218496594 ^ -218220886));

    /// <inheritdoc />
    public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        MetricsGroup<IndexQueryMetric> metricsGroup;
        MetricExcelTable<IndexQueryMetric> table;
        while (true)
        {
          switch (num2)
          {
            case 1:
              MetricExcelTable<IndexQueryMetric> metricExcelTable1 = table;
              List<KeyValuePair<string, IndexQueryMetric>> keyValuePairList;
              if (metricsGroup == null)
              {
                keyValuePairList = new List<KeyValuePair<string, IndexQueryMetric>>();
              }
              else
              {
                MetricsGroup<IndexQueryMetric> source = metricsGroup;
                // ISSUE: reference to a compiler-generated field
                Func<KeyValuePair<string, IndexQueryMetric>, string> func = IndexQueriesPage.\u003C\u003Ec.\u003C\u003E9__3_7;
                Func<KeyValuePair<string, IndexQueryMetric>, string> keySelector;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  IndexQueriesPage.\u003C\u003Ec.\u003C\u003E9__3_7 = keySelector = (Func<KeyValuePair<string, IndexQueryMetric>, string>) (s => s.Key);
                }
                else
                  goto label_15;
label_13:
                keyValuePairList = source.OrderBy<KeyValuePair<string, IndexQueryMetric>, string>(keySelector).ToList<KeyValuePair<string, IndexQueryMetric>>();
                goto label_14;
label_15:
                keySelector = func;
                goto label_13;
              }
label_14:
              metricExcelTable1.Items = (IEnumerable<KeyValuePair<string, IndexQueryMetric>>) keyValuePairList;
              num2 = 3;
              continue;
            case 2:
              goto label_11;
            case 3:
              builder.RenderTable<KeyValuePair<string, IndexQueryMetric>>((ExcelTable<KeyValuePair<string, IndexQueryMetric>>) table);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 2 : 1;
              continue;
            case 4:
              metricsGroup = metrics.Get<IndexQueryMetric>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
              continue;
            case 5:
              MetricExcelTable<IndexQueryMetric> metricExcelTable2 = new MetricExcelTable<IndexQueryMetric>();
              IndexQueriesPage.cSXfAbEQdIvJEkkYhPF0((object) metricExcelTable2, 1);
              MetricExcelTable<IndexQueryMetric> metricExcelTable3 = metricExcelTable2.AddColumn<string>(EleWise.ELMA.SR.T((string) IndexQueriesPage.n4QPiaEQJ6wBxUT0FhDp(-1120607109 - 305487170 ^ -1426345967)), 80.0, (Func<KeyValuePair<string, IndexQueryMetric>, string>) (s => s.Key));
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = Expression.Parameter(IndexQueriesPage.awZqhHEQlfVkuQMScHbc(__typeref (IndexQueryMetric)), (string) IndexQueriesPage.n4QPiaEQJ6wBxUT0FhDp(-675505729 ^ -675470375));
              // ISSUE: method reference
              Expression<Func<IndexQueryMetric, long>> valueAccessor1 = Expression.Lambda<Func<IndexQueryMetric, long>>((Expression) IndexQueriesPage.P1rj3SEQg8yBWjBuaAf7((object) parameterExpression1, (object) (MethodInfo) IndexQueriesPage.MvwL1LEQrBTHc0ZMawic(__methodref (CountMetric.get_CountCall))), parameterExpression1);
              MetricExcelTable<IndexQueryMetric> metricExcelTable4 = metricExcelTable3.AddColumn<long>(valueAccessor1);
              // ISSUE: type reference
              ParameterExpression parameterExpression2 = Expression.Parameter(IndexQueriesPage.awZqhHEQlfVkuQMScHbc(__typeref (IndexQueryMetric)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852946334));
              // ISSUE: method reference
              Expression<Func<IndexQueryMetric, long>> valueAccessor2 = Expression.Lambda<Func<IndexQueryMetric, long>>((Expression) IndexQueriesPage.P1rj3SEQg8yBWjBuaAf7((object) parameterExpression2, (object) (MethodInfo) IndexQueriesPage.MvwL1LEQrBTHc0ZMawic(__methodref (CountMetric.get_CountErrorCall))), parameterExpression2);
              MetricExcelTable<IndexQueryMetric> metricExcelTable5 = metricExcelTable4.AddColumn<long>(valueAccessor2);
              ParameterExpression parameterExpression3 = (ParameterExpression) IndexQueriesPage.QFWd9KEQ5IuG0V33IXUB(typeof (IndexQueryMetric), IndexQueriesPage.n4QPiaEQJ6wBxUT0FhDp(-812025778 ^ -812072408));
              // ISSUE: method reference
              Expression<Func<IndexQueryMetric, TimeSpan>> valueAccessor3 = Expression.Lambda<Func<IndexQueryMetric, TimeSpan>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) IndexQueriesPage.MvwL1LEQrBTHc0ZMawic(__methodref (CountTimeMetric.get_TotalTime))), parameterExpression3);
              MetricExcelTable<IndexQueryMetric> metricExcelTable6 = metricExcelTable5.AddColumn<TimeSpan>(valueAccessor3);
              // ISSUE: type reference
              ParameterExpression parameterExpression4 = Expression.Parameter(IndexQueriesPage.awZqhHEQlfVkuQMScHbc(__typeref (IndexQueryMetric)), (string) IndexQueriesPage.n4QPiaEQJ6wBxUT0FhDp(1253244298 - 1829393894 ^ -576119358));
              // ISSUE: method reference
              Expression<Func<IndexQueryMetric, double>> valueAccessor4 = Expression.Lambda<Func<IndexQueryMetric, double>>((Expression) IndexQueriesPage.P1rj3SEQg8yBWjBuaAf7((object) parameterExpression4, (object) (MethodInfo) IndexQueriesPage.MvwL1LEQrBTHc0ZMawic(__methodref (CountTimeMetric.get_MaxTime))), parameterExpression4);
              object format1 = IndexQueriesPage.y2CNbUEQjwP0PtAGZRvv();
              MetricExcelTable<IndexQueryMetric> metricExcelTable7 = metricExcelTable6.AddColumn<double>(valueAccessor4, format: (IExcelCellFormat) format1);
              ParameterExpression parameterExpression5 = (ParameterExpression) IndexQueriesPage.QFWd9KEQ5IuG0V33IXUB(typeof (IndexQueryMetric), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951536768));
              // ISSUE: method reference
              Expression<Func<IndexQueryMetric, double>> valueAccessor5 = Expression.Lambda<Func<IndexQueryMetric, double>>((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) IndexQueriesPage.MvwL1LEQrBTHc0ZMawic(__methodref (CountTimeMetric.get_AvgTime))), parameterExpression5);
              object format2 = IndexQueriesPage.y2CNbUEQjwP0PtAGZRvv();
              table = metricExcelTable7.AddColumn<double>(valueAccessor5, format: (IExcelCellFormat) format2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            case 6:
              goto label_4;
            default:
              this.PerformanceReportPageColumnBuilders.ForEach<IPerformanceReportPageColumnBuilder>((Action<IPerformanceReportPageColumnBuilder>) (cb =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      cb.AddColumn<IndexQueryMetric>(table);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 4;
              continue;
          }
        }
label_4:
        num1 = 5;
      }
label_11:;
    }

    internal static object n4QPiaEQJ6wBxUT0FhDp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object QGt62xEQ9vGVfFpUA36s([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool MMsJ8qEQyAciBZIwtRdU() => IndexQueriesPage.kQppIkEQmX7FdK8niQdP == null;

    internal static IndexQueriesPage qgjdktEQMFm2LnYoYdHT() => IndexQueriesPage.kQppIkEQmX7FdK8niQdP;

    internal static void cSXfAbEQdIvJEkkYhPF0([In] object obj0, [In] int obj1) => ((ExcelTable<KeyValuePair<string, IndexQueryMetric>>) obj0).FixedRows = obj1;

    internal static Type awZqhHEQlfVkuQMScHbc([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object MvwL1LEQrBTHc0ZMawic([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object P1rj3SEQg8yBWjBuaAf7([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object QFWd9KEQ5IuG0V33IXUB([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object y2CNbUEQjwP0PtAGZRvv() => (object) FloatFormat.Default;
  }
}
