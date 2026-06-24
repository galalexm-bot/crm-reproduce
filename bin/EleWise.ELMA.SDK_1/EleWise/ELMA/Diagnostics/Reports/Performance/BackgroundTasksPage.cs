// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.BackgroundTasksPage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
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
  /// <summary>Страница отчета "Фоновые задачи"</summary>
  [ComponentOrder(20)]
  internal class BackgroundTasksPage : PerformanceReportPage
  {
    internal static BackgroundTasksPage QmrxdHEfUnFdHADhFiOo;

    /// <summary>Ctor</summary>
    /// <param name="builders">Построители колонок</param>
    public BackgroundTasksPage(
      IEnumerable<IPerformanceReportPageColumnBuilder> builders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(builders);
    }

    /// <inheritdoc />
    public override string Name => (string) BackgroundTasksPage.aQYsLlEfzJr21tTRsycH((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979502143));

    /// <inheritdoc />
    public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
    {
      int num1 = 6;
      MetricsGroup<BackgroundTaskMetric> metricsGroup;
      MetricExcelTable<BackgroundTaskMetric> table;
      while (true)
      {
        switch (num1)
        {
          case 1:
            MetricExcelTable<BackgroundTaskMetric> metricExcelTable1 = table;
            List<KeyValuePair<string, BackgroundTaskMetric>> keyValuePairList;
            if (metricsGroup == null)
            {
              keyValuePairList = new List<KeyValuePair<string, BackgroundTaskMetric>>();
            }
            else
            {
              MetricsGroup<BackgroundTaskMetric> source = metricsGroup;
              // ISSUE: reference to a compiler-generated field
              Func<KeyValuePair<string, BackgroundTaskMetric>, string> func = BackgroundTasksPage.\u003C\u003Ec.\u003C\u003E9__3_9;
              Func<KeyValuePair<string, BackgroundTaskMetric>, string> keySelector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                BackgroundTasksPage.\u003C\u003Ec.\u003C\u003E9__3_9 = keySelector = (Func<KeyValuePair<string, BackgroundTaskMetric>, string>) (s => s.Key);
              }
              else
                goto label_16;
label_14:
              keyValuePairList = source.OrderBy<KeyValuePair<string, BackgroundTaskMetric>, string>(keySelector).ToList<KeyValuePair<string, BackgroundTaskMetric>>();
              goto label_15;
label_16:
              keySelector = func;
              goto label_14;
            }
label_15:
            metricExcelTable1.Items = (IEnumerable<KeyValuePair<string, BackgroundTaskMetric>>) keyValuePairList;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
            continue;
          case 2:
            metricsGroup = metrics.Get<BackgroundTaskMetric>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_12;
          case 4:
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
                    cb.AddColumn<BackgroundTaskMetric>(table);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 2;
            continue;
          case 5:
            MetricExcelTable<BackgroundTaskMetric> metricExcelTable2 = new MetricExcelTable<BackgroundTaskMetric>();
            BackgroundTasksPage.CrxMqhEQFoFLQL83BDdr((object) metricExcelTable2, 1);
            object title = BackgroundTasksPage.aQYsLlEfzJr21tTRsycH((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16488201));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, BackgroundTaskMetric>, CellValue> func1 = BackgroundTasksPage.\u003C\u003Ec.\u003C\u003E9__3_0;
            Func<KeyValuePair<string, BackgroundTaskMetric>, CellValue> valueAccessor1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              BackgroundTasksPage.\u003C\u003Ec.\u003C\u003E9__3_0 = valueAccessor1 = (Func<KeyValuePair<string, BackgroundTaskMetric>, CellValue>) (s => new CellValue((object) s.Key, (IExcelCellFormat) new CustomCellFormat((Action<Cell, object>) ((cell, v) =>
              {
                int num3 = 2;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      object obj = BackgroundTasksPage.\u003C\u003Ec__DisplayClass3_1.M3BpDP8RBoBNk5qGdteB(BackgroundTasksPage.\u003C\u003Ec__DisplayClass3_1.cVHqo58RFaudwIHNi0J5((object) cell, BackgroundTasksPage.\u003C\u003Ec__DisplayClass3_1.RcWZf88izA3GjEnZ4o2g((object) s.Key, '('), s.Key.LastIndexOf(')')));
                      ((Font) obj).Size = 8;
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      BackgroundTasksPage.\u003C\u003Ec__DisplayClass3_1.SQAFuG8RooRjnLeiCc8u(obj, BackgroundTasksPage.\u003C\u003Ec__DisplayClass3_1.wk9yxD8RWdmxpX473Z2h());
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      BackgroundTasksPage.\u003C\u003Ec__DisplayClass3_1.Hv0e3w8ictVc9LO0IZX7((object) cell, (object) s.Key);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_5;
                  }
                }
label_2:
                return;
label_5:;
              }))));
            }
            else
              goto label_17;
label_8:
            MetricExcelTable<BackgroundTaskMetric> metricExcelTable3 = metricExcelTable2.AddColumn<CellValue>((string) title, 60.0, valueAccessor1);
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = (ParameterExpression) BackgroundTasksPage.Ostp1ZEQWQvCogXaJI1X(BackgroundTasksPage.IwgtgCEQBXLFOTew42vP(__typeref (BackgroundTaskMetric)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822860162));
            // ISSUE: method reference
            Expression<Func<BackgroundTaskMetric, long>> valueAccessor2 = Expression.Lambda<Func<BackgroundTaskMetric, long>>((Expression) BackgroundTasksPage.E6cm4YEQbRDGmUZMTgrU((object) parameterExpression1, (object) (MethodInfo) BackgroundTasksPage.bMJr4nEQotuNNwwHGL1Z(__methodref (CountMetric.get_CountCall))), parameterExpression1);
            MetricExcelTable<BackgroundTaskMetric> metricExcelTable4 = metricExcelTable3.AddColumn<long>(valueAccessor2);
            ParameterExpression parameterExpression2 = (ParameterExpression) BackgroundTasksPage.Ostp1ZEQWQvCogXaJI1X(typeof (BackgroundTaskMetric), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236164009));
            // ISSUE: method reference
            Expression<Func<BackgroundTaskMetric, long>> valueAccessor3 = Expression.Lambda<Func<BackgroundTaskMetric, long>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) BackgroundTasksPage.bMJr4nEQotuNNwwHGL1Z(__methodref (CountMetric.get_CountErrorCall))), parameterExpression2);
            MetricExcelTable<BackgroundTaskMetric> metricExcelTable5 = metricExcelTable4.AddColumn<long>(valueAccessor3);
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) BackgroundTasksPage.Ostp1ZEQWQvCogXaJI1X(BackgroundTasksPage.IwgtgCEQBXLFOTew42vP(__typeref (BackgroundTaskMetric)), BackgroundTasksPage.mPmVGQEQhwXeiGoPGGMJ(1514961705 ^ 1515045199));
            // ISSUE: method reference
            Expression<Func<BackgroundTaskMetric, TimeSpan>> valueAccessor4 = Expression.Lambda<Func<BackgroundTaskMetric, TimeSpan>>((Expression) BackgroundTasksPage.E6cm4YEQbRDGmUZMTgrU((object) parameterExpression3, (object) (MethodInfo) BackgroundTasksPage.bMJr4nEQotuNNwwHGL1Z(__methodref (CountTimeMetric.get_TotalTime))), parameterExpression3);
            MetricExcelTable<BackgroundTaskMetric> metricExcelTable6 = metricExcelTable5.AddColumn<TimeSpan>(valueAccessor4);
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = Expression.Parameter(BackgroundTasksPage.IwgtgCEQBXLFOTew42vP(__typeref (BackgroundTaskMetric)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409006248));
            // ISSUE: method reference
            Expression<Func<BackgroundTaskMetric, double>> valueAccessor5 = Expression.Lambda<Func<BackgroundTaskMetric, double>>((Expression) BackgroundTasksPage.E6cm4YEQbRDGmUZMTgrU((object) parameterExpression4, (object) (MethodInfo) BackgroundTasksPage.bMJr4nEQotuNNwwHGL1Z(__methodref (CountTimeMetric.get_MaxTime))), parameterExpression4);
            object format1 = BackgroundTasksPage.GEbJSPEQGhtwI80h8Xdf();
            MetricExcelTable<BackgroundTaskMetric> metricExcelTable7 = metricExcelTable6.AddColumn<double>(valueAccessor5, format: (IExcelCellFormat) format1);
            // ISSUE: type reference
            ParameterExpression parameterExpression5 = (ParameterExpression) BackgroundTasksPage.Ostp1ZEQWQvCogXaJI1X(BackgroundTasksPage.IwgtgCEQBXLFOTew42vP(__typeref (BackgroundTaskMetric)), BackgroundTasksPage.mPmVGQEQhwXeiGoPGGMJ(~1767720452 ^ -1767701603));
            // ISSUE: method reference
            Expression<Func<BackgroundTaskMetric, double>> valueAccessor6 = Expression.Lambda<Func<BackgroundTaskMetric, double>>((Expression) BackgroundTasksPage.E6cm4YEQbRDGmUZMTgrU((object) parameterExpression5, (object) (MethodInfo) BackgroundTasksPage.bMJr4nEQotuNNwwHGL1Z(__methodref (CountTimeMetric.get_AvgTime))), parameterExpression5);
            object format2 = BackgroundTasksPage.GEbJSPEQGhtwI80h8Xdf();
            MetricExcelTable<BackgroundTaskMetric> metricExcelTable8 = metricExcelTable7.AddColumn<double>(valueAccessor6, format: (IExcelCellFormat) format2);
            // ISSUE: type reference
            ParameterExpression parameterExpression6 = (ParameterExpression) BackgroundTasksPage.Ostp1ZEQWQvCogXaJI1X(BackgroundTasksPage.IwgtgCEQBXLFOTew42vP(__typeref (BackgroundTaskMetric)), BackgroundTasksPage.mPmVGQEQhwXeiGoPGGMJ(-1921202237 ^ -1921155675));
            // ISSUE: method reference
            Expression<Func<BackgroundTaskMetric, TimeSpan>> valueAccessor7 = Expression.Lambda<Func<BackgroundTaskMetric, TimeSpan>>((Expression) BackgroundTasksPage.E6cm4YEQbRDGmUZMTgrU((object) parameterExpression6, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CallContextMetric.get_TotalProcessorTime))), parameterExpression6);
            MetricExcelTable<BackgroundTaskMetric> metricExcelTable9 = metricExcelTable8.AddColumn<TimeSpan>(valueAccessor7);
            // ISSUE: type reference
            ParameterExpression parameterExpression7 = (ParameterExpression) BackgroundTasksPage.Ostp1ZEQWQvCogXaJI1X(BackgroundTasksPage.IwgtgCEQBXLFOTew42vP(__typeref (BackgroundTaskMetric)), BackgroundTasksPage.mPmVGQEQhwXeiGoPGGMJ(--1333735954 ^ 1333692532));
            // ISSUE: method reference
            Expression<Func<BackgroundTaskMetric, TimeSpan>> valueAccessor8 = Expression.Lambda<Func<BackgroundTaskMetric, TimeSpan>>((Expression) BackgroundTasksPage.E6cm4YEQbRDGmUZMTgrU((object) parameterExpression7, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CallContextMetric.get_UserProcessorTime))), parameterExpression7);
            table = metricExcelTable9.AddColumn<TimeSpan>(valueAccessor8);
            num1 = 4;
            continue;
label_17:
            valueAccessor1 = func1;
            goto label_8;
          case 6:
            num1 = 5;
            continue;
          default:
            builder.RenderTable<KeyValuePair<string, BackgroundTaskMetric>>((ExcelTable<KeyValuePair<string, BackgroundTaskMetric>>) table);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 3 : 2;
            continue;
        }
      }
label_12:;
    }

    internal static object aQYsLlEfzJr21tTRsycH([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool VAlkgdEfs3EMFsyOflO8() => BackgroundTasksPage.QmrxdHEfUnFdHADhFiOo == null;

    internal static BackgroundTasksPage RGJ1wsEfcm0VwQCFc0x4() => BackgroundTasksPage.QmrxdHEfUnFdHADhFiOo;

    internal static void CrxMqhEQFoFLQL83BDdr([In] object obj0, [In] int obj1) => ((ExcelTable<KeyValuePair<string, BackgroundTaskMetric>>) obj0).FixedRows = obj1;

    internal static Type IwgtgCEQBXLFOTew42vP([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Ostp1ZEQWQvCogXaJI1X([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object bMJr4nEQotuNNwwHGL1Z([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object E6cm4YEQbRDGmUZMTgrU([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object mPmVGQEQhwXeiGoPGGMJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object GEbJSPEQGhtwI80h8Xdf() => (object) FloatFormat.Default;
  }
}
