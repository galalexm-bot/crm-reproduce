// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.WebRequestsPage
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
  /// <summary>Страница отчета "Web-запросы"</summary>
  [ComponentOrder(10)]
  internal class WebRequestsPage : PerformanceReportPage
  {
    private static WebRequestsPage Si6FGWECpQAZNyNcSTK7;

    /// <summary>Ctor</summary>
    /// <param name="builders">Построители колонок</param>
    public WebRequestsPage(
      IEnumerable<IPerformanceReportPageColumnBuilder> builders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(builders);
    }

    /// <inheritdoc />
    public override string Name => EleWise.ELMA.SR.T((string) WebRequestsPage.iBtolnECtY0y1vi6EReV(-740338220 ^ -740593880));

    /// <inheritdoc />
    public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
    {
      int num1 = 2;
      MetricsGroup<WebRequestMetric> source;
      MetricExcelTable<WebRequestMetric> table;
      while (true)
      {
        switch (num1)
        {
          case 1:
            MetricExcelTable<WebRequestMetric> metricExcelTable1 = new MetricExcelTable<WebRequestMetric>();
            WebRequestsPage.UVhq7xECwJhx9Ppg5w57((object) metricExcelTable1, 1);
            MetricExcelTable<WebRequestMetric> metricExcelTable2 = metricExcelTable1.AddColumn<string>((string) WebRequestsPage.hYj5BvEC4K357YNKaNbe(WebRequestsPage.iBtolnECtY0y1vi6EReV(-1088304168 ^ -1088332940)), 60.0, (Func<KeyValuePair<string, WebRequestMetric>, string>) (s => s.Key));
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = Expression.Parameter(WebRequestsPage.oAV1aCEC6xmmX6wfC0Jk(__typeref (WebRequestMetric)), (string) WebRequestsPage.iBtolnECtY0y1vi6EReV(-680446928 - -370807692 ^ -309658150));
            // ISSUE: method reference
            Expression<Func<WebRequestMetric, long>> valueAccessor1 = Expression.Lambda<Func<WebRequestMetric, long>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) WebRequestsPage.KSo5SkECHto1oSOxkxBC(__methodref (CountMetric.get_CountCall))), parameterExpression1);
            MetricExcelTable<WebRequestMetric> metricExcelTable3 = metricExcelTable2.AddColumn<long>(valueAccessor1);
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) WebRequestsPage.BPV7WZECAeIy7m3DDe0F(WebRequestsPage.oAV1aCEC6xmmX6wfC0Jk(__typeref (WebRequestMetric)), WebRequestsPage.iBtolnECtY0y1vi6EReV(~210725948 ^ -210687579));
            // ISSUE: method reference
            Expression<Func<WebRequestMetric, long>> valueAccessor2 = Expression.Lambda<Func<WebRequestMetric, long>>((Expression) WebRequestsPage.uPE8GsEC7wEpWcnhPOV2((object) parameterExpression2, (object) (MethodInfo) WebRequestsPage.KSo5SkECHto1oSOxkxBC(__methodref (CountMetric.get_CountErrorCall))), parameterExpression2);
            MetricExcelTable<WebRequestMetric> metricExcelTable4 = metricExcelTable3.AddColumn<long>(valueAccessor2);
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) WebRequestsPage.BPV7WZECAeIy7m3DDe0F(WebRequestsPage.oAV1aCEC6xmmX6wfC0Jk(__typeref (WebRequestMetric)), WebRequestsPage.iBtolnECtY0y1vi6EReV(1581325282 << 3 ^ -234265226));
            // ISSUE: method reference
            Expression<Func<WebRequestMetric, TimeSpan>> valueAccessor3 = Expression.Lambda<Func<WebRequestMetric, TimeSpan>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CountTimeMetric.get_TotalTime))), parameterExpression3);
            MetricExcelTable<WebRequestMetric> metricExcelTable5 = metricExcelTable4.AddColumn<TimeSpan>(valueAccessor3);
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = (ParameterExpression) WebRequestsPage.BPV7WZECAeIy7m3DDe0F(WebRequestsPage.oAV1aCEC6xmmX6wfC0Jk(__typeref (WebRequestMetric)), WebRequestsPage.iBtolnECtY0y1vi6EReV(323422137 << 2 ^ 1293788290));
            // ISSUE: method reference
            Expression<Func<WebRequestMetric, double>> valueAccessor4 = Expression.Lambda<Func<WebRequestMetric, double>>((Expression) WebRequestsPage.uPE8GsEC7wEpWcnhPOV2((object) parameterExpression4, (object) (MethodInfo) WebRequestsPage.KSo5SkECHto1oSOxkxBC(__methodref (CountTimeMetric.get_MaxTime))), parameterExpression4);
            FloatFormat format1 = FloatFormat.Default;
            MetricExcelTable<WebRequestMetric> metricExcelTable6 = metricExcelTable5.AddColumn<double>(valueAccessor4, format: (IExcelCellFormat) format1);
            ParameterExpression parameterExpression5 = (ParameterExpression) WebRequestsPage.BPV7WZECAeIy7m3DDe0F(typeof (WebRequestMetric), WebRequestsPage.iBtolnECtY0y1vi6EReV(694673736 ^ -23604109 ^ -672034979));
            // ISSUE: method reference
            Expression<Func<WebRequestMetric, double>> valueAccessor5 = Expression.Lambda<Func<WebRequestMetric, double>>((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) WebRequestsPage.KSo5SkECHto1oSOxkxBC(__methodref (CountTimeMetric.get_AvgTime))), parameterExpression5);
            object format2 = WebRequestsPage.ccC6ywECxBnAZ4Dgp9jI();
            MetricExcelTable<WebRequestMetric> metricExcelTable7 = metricExcelTable6.AddColumn<double>(valueAccessor5, format: (IExcelCellFormat) format2);
            // ISSUE: type reference
            ParameterExpression parameterExpression6 = (ParameterExpression) WebRequestsPage.BPV7WZECAeIy7m3DDe0F(WebRequestsPage.oAV1aCEC6xmmX6wfC0Jk(__typeref (WebRequestMetric)), WebRequestsPage.iBtolnECtY0y1vi6EReV(993438473 ^ 993464687));
            // ISSUE: method reference
            Expression<Func<WebRequestMetric, TimeSpan>> valueAccessor6 = Expression.Lambda<Func<WebRequestMetric, TimeSpan>>((Expression) WebRequestsPage.uPE8GsEC7wEpWcnhPOV2((object) parameterExpression6, (object) (MethodInfo) WebRequestsPage.KSo5SkECHto1oSOxkxBC(__methodref (CallContextMetric.get_TotalProcessorTime))), parameterExpression6);
            MetricExcelTable<WebRequestMetric> metricExcelTable8 = metricExcelTable7.AddColumn<TimeSpan>(valueAccessor6);
            ParameterExpression parameterExpression7 = (ParameterExpression) WebRequestsPage.BPV7WZECAeIy7m3DDe0F(typeof (WebRequestMetric), WebRequestsPage.iBtolnECtY0y1vi6EReV(1199946765 ^ 1199834731));
            // ISSUE: method reference
            Expression<Func<WebRequestMetric, TimeSpan>> valueAccessor7 = Expression.Lambda<Func<WebRequestMetric, TimeSpan>>((Expression) Expression.Property((Expression) parameterExpression7, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CallContextMetric.get_UserProcessorTime))), parameterExpression7);
            table = metricExcelTable8.AddColumn<TimeSpan>(valueAccessor7);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 3 : 3;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
            continue;
          case 3:
            this.PerformanceReportPageColumnBuilders.ForEach<IPerformanceReportPageColumnBuilder>((Action<IPerformanceReportPageColumnBuilder>) (cb =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    cb.AddColumn<WebRequestMetric>(table);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 6 : 6;
            continue;
          case 4:
            table.Items = source != null ? (IEnumerable<KeyValuePair<string, WebRequestMetric>>) source.OrderBy<KeyValuePair<string, WebRequestMetric>, string>((Func<KeyValuePair<string, WebRequestMetric>, string>) (s => s.Key)).ToList<KeyValuePair<string, WebRequestMetric>>() : (IEnumerable<KeyValuePair<string, WebRequestMetric>>) new List<KeyValuePair<string, WebRequestMetric>>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_2;
          case 6:
            source = metrics.Get<WebRequestMetric>();
            num1 = 4;
            continue;
          default:
            builder.RenderTable<KeyValuePair<string, WebRequestMetric>>((ExcelTable<KeyValuePair<string, WebRequestMetric>>) table);
            num1 = 5;
            continue;
        }
      }
label_2:;
    }

    internal static object iBtolnECtY0y1vi6EReV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool jFJ1UbECaUjZWV9XmAUg() => WebRequestsPage.Si6FGWECpQAZNyNcSTK7 == null;

    internal static WebRequestsPage XlHrhaECDH3dRKGdtOw2() => WebRequestsPage.Si6FGWECpQAZNyNcSTK7;

    internal static void UVhq7xECwJhx9Ppg5w57([In] object obj0, [In] int obj1) => ((ExcelTable<KeyValuePair<string, WebRequestMetric>>) obj0).FixedRows = obj1;

    internal static object hYj5BvEC4K357YNKaNbe([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static Type oAV1aCEC6xmmX6wfC0Jk([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object KSo5SkECHto1oSOxkxBC([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object BPV7WZECAeIy7m3DDe0F([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object uPE8GsEC7wEpWcnhPOV2([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object ccC6ywECxBnAZ4Dgp9jI() => (object) FloatFormat.Default;
  }
}
