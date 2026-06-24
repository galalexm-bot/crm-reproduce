// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.CallsStatisticsPage
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
  /// <summary>Страница отчета "Вызовы методов"</summary>
  [ComponentOrder(100)]
  internal class CallsStatisticsPage : PerformanceReportPage
  {
    private static CallsStatisticsPage mqnLrTEQEBFdvbhlFJhJ;

    /// <summary>Ctor</summary>
    /// <param name="builders">Построители колонок</param>
    public CallsStatisticsPage(
      IEnumerable<IPerformanceReportPageColumnBuilder> builders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(builders);
    }

    /// <inheritdoc />
    public override string Name => (string) CallsStatisticsPage.Tc6u44EQvTxtFdOSDs5C(CallsStatisticsPage.GKJVdZEQCbq7VKdGyiMb(1051276242 - 990076387 ^ 60941277));

    /// <inheritdoc />
    public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        MetricsGroup<MethodMetric> metricsGroup;
        MetricExcelTable<MethodMetric> table;
        while (true)
        {
          switch (num2)
          {
            case 1:
              MetricExcelTable<MethodMetric> metricExcelTable1 = new MetricExcelTable<MethodMetric>();
              CallsStatisticsPage.PKYaO9EQ8KIyFxI17e4x((object) metricExcelTable1, 1);
              MetricExcelTable<MethodMetric> metricExcelTable2 = metricExcelTable1.AddColumn<CellValue>((string) CallsStatisticsPage.Tc6u44EQvTxtFdOSDs5C(CallsStatisticsPage.GKJVdZEQCbq7VKdGyiMb(993438473 ^ 993172827)), 60.0, (Func<KeyValuePair<string, MethodMetric>, CellValue>) (s => new CellValue((object) s.Key, (IExcelCellFormat) new CustomCellFormat((Action<Cell, object>) ((cell, v) =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      CallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.DjHSf78RV5CeTQL60F7F((object) cell, (object) s.Key);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_2;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      object obj = CallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.nvlDg68RRBLky0Y6kQdF(CallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.y0Stdm8RiVOFTTI63K28((object) cell, CallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.pRhYen8RSacRWsZwUKd8((object) s.Key, '('), CallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.pRhYen8RSacRWsZwUKd8((object) s.Key, ')')));
                      ((Font) obj).Size = 8;
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      CallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.mtH2bv8RKDh1CrfMFNRb(obj, CallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.mXJKR18Rq5vZb7jnHW21());
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 2 : 0;
                      continue;
                  }
                }
label_2:;
              })))));
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = (ParameterExpression) CallsStatisticsPage.ht2lHQEQuhV1aIvjG2nI(CallsStatisticsPage.Oo5lv1EQZGkM90Z95rJm(__typeref (MethodMetric)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312754337));
              // ISSUE: method reference
              Expression<Func<MethodMetric, long>> valueAccessor1 = Expression.Lambda<Func<MethodMetric, long>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) CallsStatisticsPage.mswLbeEQIu58PoVC1kd9(__methodref (CountMetric.get_CountCall))), parameterExpression1);
              MetricExcelTable<MethodMetric> metricExcelTable3 = metricExcelTable2.AddColumn<long>(valueAccessor1);
              // ISSUE: type reference
              ParameterExpression parameterExpression2 = (ParameterExpression) CallsStatisticsPage.ht2lHQEQuhV1aIvjG2nI(CallsStatisticsPage.Oo5lv1EQZGkM90Z95rJm(__typeref (MethodMetric)), CallsStatisticsPage.GKJVdZEQCbq7VKdGyiMb(-1426456882 ^ 2009939514 ^ -583697774));
              // ISSUE: method reference
              Expression<Func<MethodMetric, long>> valueAccessor2 = Expression.Lambda<Func<MethodMetric, long>>((Expression) CallsStatisticsPage.rI5U0pEQVJjesR9t7S4b((object) parameterExpression2, (object) (MethodInfo) CallsStatisticsPage.mswLbeEQIu58PoVC1kd9(__methodref (CountMetric.get_CountErrorCall))), parameterExpression2);
              MetricExcelTable<MethodMetric> metricExcelTable4 = metricExcelTable3.AddColumn<long>(valueAccessor2);
              // ISSUE: type reference
              ParameterExpression parameterExpression3 = (ParameterExpression) CallsStatisticsPage.ht2lHQEQuhV1aIvjG2nI(CallsStatisticsPage.Oo5lv1EQZGkM90Z95rJm(__typeref (MethodMetric)), CallsStatisticsPage.GKJVdZEQCbq7VKdGyiMb(1654249598 >> 2 ^ 413650041));
              // ISSUE: method reference
              Expression<Func<MethodMetric, TimeSpan>> valueAccessor3 = Expression.Lambda<Func<MethodMetric, TimeSpan>>((Expression) CallsStatisticsPage.rI5U0pEQVJjesR9t7S4b((object) parameterExpression3, (object) (MethodInfo) CallsStatisticsPage.mswLbeEQIu58PoVC1kd9(__methodref (CountTimeMetric.get_TotalTime))), parameterExpression3);
              MetricExcelTable<MethodMetric> metricExcelTable5 = metricExcelTable4.AddColumn<TimeSpan>(valueAccessor3);
              // ISSUE: type reference
              ParameterExpression parameterExpression4 = (ParameterExpression) CallsStatisticsPage.ht2lHQEQuhV1aIvjG2nI(CallsStatisticsPage.Oo5lv1EQZGkM90Z95rJm(__typeref (MethodMetric)), CallsStatisticsPage.GKJVdZEQCbq7VKdGyiMb(694673736 ^ -23604109 ^ -672034979));
              // ISSUE: method reference
              Expression<Func<MethodMetric, double>> valueAccessor4 = Expression.Lambda<Func<MethodMetric, double>>((Expression) CallsStatisticsPage.rI5U0pEQVJjesR9t7S4b((object) parameterExpression4, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CountTimeMetric.get_MaxTime))), parameterExpression4);
              object format1 = CallsStatisticsPage.y5L7RlEQSbsXxsEibblF();
              MetricExcelTable<MethodMetric> metricExcelTable6 = metricExcelTable5.AddColumn<double>(valueAccessor4, format: (IExcelCellFormat) format1);
              // ISSUE: type reference
              ParameterExpression parameterExpression5 = (ParameterExpression) CallsStatisticsPage.ht2lHQEQuhV1aIvjG2nI(CallsStatisticsPage.Oo5lv1EQZGkM90Z95rJm(__typeref (MethodMetric)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951536768));
              // ISSUE: method reference
              Expression<Func<MethodMetric, double>> valueAccessor5 = Expression.Lambda<Func<MethodMetric, double>>((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) CallsStatisticsPage.mswLbeEQIu58PoVC1kd9(__methodref (CountTimeMetric.get_AvgTime))), parameterExpression5);
              FloatFormat format2 = FloatFormat.Default;
              MetricExcelTable<MethodMetric> metricExcelTable7 = metricExcelTable6.AddColumn<double>(valueAccessor5, format: (IExcelCellFormat) format2);
              // ISSUE: type reference
              ParameterExpression parameterExpression6 = (ParameterExpression) CallsStatisticsPage.ht2lHQEQuhV1aIvjG2nI(CallsStatisticsPage.Oo5lv1EQZGkM90Z95rJm(__typeref (MethodMetric)), CallsStatisticsPage.GKJVdZEQCbq7VKdGyiMb(-1445902765 ^ -1980277732 ^ 539467817));
              // ISSUE: method reference
              Expression<Func<MethodMetric, TimeSpan>> valueAccessor6 = Expression.Lambda<Func<MethodMetric, TimeSpan>>((Expression) CallsStatisticsPage.rI5U0pEQVJjesR9t7S4b((object) parameterExpression6, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (MethodMetric.get_ClearTotalTime))), parameterExpression6);
              MetricExcelTable<MethodMetric> metricExcelTable8 = metricExcelTable7.AddColumn<TimeSpan>(valueAccessor6);
              // ISSUE: type reference
              ParameterExpression parameterExpression7 = (ParameterExpression) CallsStatisticsPage.ht2lHQEQuhV1aIvjG2nI(CallsStatisticsPage.Oo5lv1EQZGkM90Z95rJm(__typeref (MethodMetric)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757024088));
              // ISSUE: method reference
              Expression<Func<MethodMetric, double>> valueAccessor7 = Expression.Lambda<Func<MethodMetric, double>>((Expression) CallsStatisticsPage.rI5U0pEQVJjesR9t7S4b((object) parameterExpression7, (object) (MethodInfo) CallsStatisticsPage.mswLbeEQIu58PoVC1kd9(__methodref (MethodMetric.get_ClearMaxTime))), parameterExpression7);
              object format3 = CallsStatisticsPage.y5L7RlEQSbsXxsEibblF();
              MetricExcelTable<MethodMetric> metricExcelTable9 = metricExcelTable8.AddColumn<double>(valueAccessor7, format: (IExcelCellFormat) format3);
              // ISSUE: type reference
              ParameterExpression parameterExpression8 = Expression.Parameter(CallsStatisticsPage.Oo5lv1EQZGkM90Z95rJm(__typeref (MethodMetric)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099647183));
              // ISSUE: method reference
              Expression<Func<MethodMetric, double>> valueAccessor8 = Expression.Lambda<Func<MethodMetric, double>>((Expression) CallsStatisticsPage.rI5U0pEQVJjesR9t7S4b((object) parameterExpression8, (object) (MethodInfo) CallsStatisticsPage.mswLbeEQIu58PoVC1kd9(__methodref (MethodMetric.get_ClearAvgTime))), parameterExpression8);
              object format4 = CallsStatisticsPage.y5L7RlEQSbsXxsEibblF();
              table = metricExcelTable9.AddColumn<double>(valueAccessor8, format: (IExcelCellFormat) format4);
              num2 = 5;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
              continue;
            case 3:
              builder.RenderTable<KeyValuePair<string, MethodMetric>>((ExcelTable<KeyValuePair<string, MethodMetric>>) table);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 4;
              continue;
            case 4:
              goto label_11;
            case 5:
              this.PerformanceReportPageColumnBuilders.ForEach<IPerformanceReportPageColumnBuilder>((Action<IPerformanceReportPageColumnBuilder>) (cb =>
              {
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      cb.AddColumn<MethodMetric>(table);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
              continue;
            case 6:
              goto label_8;
            default:
              metricsGroup = metrics.Get<MethodMetric>();
              num2 = 6;
              continue;
          }
        }
label_8:
        MetricExcelTable<MethodMetric> metricExcelTable10 = table;
        List<KeyValuePair<string, MethodMetric>> keyValuePairList;
        if (metricsGroup == null)
        {
          keyValuePairList = new List<KeyValuePair<string, MethodMetric>>();
        }
        else
        {
          MetricsGroup<MethodMetric> source = metricsGroup;
          // ISSUE: reference to a compiler-generated field
          Func<KeyValuePair<string, MethodMetric>, string> func = CallsStatisticsPage.\u003C\u003Ec.\u003C\u003E9__3_10;
          Func<KeyValuePair<string, MethodMetric>, string> keySelector;
          if (func == null)
          {
            // ISSUE: reference to a compiler-generated field
            CallsStatisticsPage.\u003C\u003Ec.\u003C\u003E9__3_10 = keySelector = (Func<KeyValuePair<string, MethodMetric>, string>) (s => s.Key);
          }
          else
            goto label_15;
label_13:
          keyValuePairList = source.OrderBy<KeyValuePair<string, MethodMetric>, string>(keySelector).ToList<KeyValuePair<string, MethodMetric>>();
          goto label_14;
label_15:
          keySelector = func;
          goto label_13;
        }
label_14:
        metricExcelTable10.Items = (IEnumerable<KeyValuePair<string, MethodMetric>>) keyValuePairList;
        num1 = 3;
      }
label_11:;
    }

    internal static object GKJVdZEQCbq7VKdGyiMb(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Tc6u44EQvTxtFdOSDs5C([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool P2esNfEQf6oCVu10P23S() => CallsStatisticsPage.mqnLrTEQEBFdvbhlFJhJ == null;

    internal static CallsStatisticsPage FxxGgNEQQ7qLTuETJKya() => CallsStatisticsPage.mqnLrTEQEBFdvbhlFJhJ;

    internal static void PKYaO9EQ8KIyFxI17e4x([In] object obj0, [In] int obj1) => ((ExcelTable<KeyValuePair<string, MethodMetric>>) obj0).FixedRows = obj1;

    internal static Type Oo5lv1EQZGkM90Z95rJm([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object ht2lHQEQuhV1aIvjG2nI([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object mswLbeEQIu58PoVC1kd9([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object rI5U0pEQVJjesR9t7S4b([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object y5L7RlEQSbsXxsEibblF() => (object) FloatFormat.Default;
  }
}
