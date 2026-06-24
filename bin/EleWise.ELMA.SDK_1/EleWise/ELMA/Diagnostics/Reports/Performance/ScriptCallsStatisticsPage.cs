// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.ScriptCallsStatisticsPage
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
  /// <summary>Страница отчета "Сценарии"</summary>
  [ComponentOrder(20)]
  internal class ScriptCallsStatisticsPage : PerformanceReportPage
  {
    private static ScriptCallsStatisticsPage nCCjilECvaSML8uyX52u;

    /// <summary>Ctor</summary>
    /// <param name="builders">Построители колонок</param>
    public ScriptCallsStatisticsPage(
      IEnumerable<IPerformanceReportPageColumnBuilder> builders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(builders);
    }

    /// <inheritdoc />
    public override string Name => (string) ScriptCallsStatisticsPage.XJqsEwECIJ9gmUQRedSL(ScriptCallsStatisticsPage.lPw4JAECucKHKxTYMiKv(-680446928 - -370807692 ^ -309363342));

    /// <inheritdoc />
    public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        MetricsGroup<ScriptMetric> source;
        MetricExcelTable<ScriptMetric> table;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
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
                      cb.AddColumn<ScriptMetric>(table);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 2;
              continue;
            case 2:
              source = metrics.Get<ScriptMetric>();
              num2 = 6;
              continue;
            case 3:
              builder.RenderTable<KeyValuePair<string, ScriptMetric>>((ExcelTable<KeyValuePair<string, ScriptMetric>>) table);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            case 4:
              MetricExcelTable<ScriptMetric> metricExcelTable1 = new MetricExcelTable<ScriptMetric>();
              ScriptCallsStatisticsPage.T2HdKOECVAh63fbHLmZ9((object) metricExcelTable1, 1);
              MetricExcelTable<ScriptMetric> metricExcelTable2 = metricExcelTable1.AddColumn<CellValue>((string) ScriptCallsStatisticsPage.XJqsEwECIJ9gmUQRedSL(ScriptCallsStatisticsPage.lPw4JAECucKHKxTYMiKv(-2138160520 ^ -2138409942)), 60.0, (Func<KeyValuePair<string, ScriptMetric>, CellValue>) (s => new CellValue((object) s.Key, (IExcelCellFormat) new CustomCellFormat((Action<Cell, object>) ((cell, v) =>
              {
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      ScriptCallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.ktXFSa8qF3vdMaeXLvth((object) cell, (object) s.Key);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_2;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      Font font = cell.Characters(ScriptCallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.xKmmIU8qBabZio77u5gl((object) s.Key, '('), ScriptCallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.xKmmIU8qBabZio77u5gl((object) s.Key, ')')).Font;
                      font.Size = 8;
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      ScriptCallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.dAiNJO8qoKCKDswHras8((object) font, ScriptCallsStatisticsPage.\u003C\u003Ec__DisplayClass3_1.wBDl0F8qWgRpnqv3nfc2());
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 2;
                      continue;
                  }
                }
label_2:;
              })))));
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = (ParameterExpression) ScriptCallsStatisticsPage.Mb5JGRECig0RtLyFSgDu(ScriptCallsStatisticsPage.DoLmj5ECSZm7JP7LC9tj(__typeref (ScriptMetric)), ScriptCallsStatisticsPage.lPw4JAECucKHKxTYMiKv(864270449 << 6 ^ -521165274));
              // ISSUE: method reference
              Expression<Func<ScriptMetric, long>> valueAccessor1 = Expression.Lambda<Func<ScriptMetric, long>>((Expression) ScriptCallsStatisticsPage.kSxRvbECqHDMM9u6Jvxe((object) parameterExpression1, (object) (MethodInfo) ScriptCallsStatisticsPage.FamojjECRn85VnRbneGQ(__methodref (CountMetric.get_CountCall))), parameterExpression1);
              MetricExcelTable<ScriptMetric> metricExcelTable3 = metricExcelTable2.AddColumn<long>(valueAccessor1);
              // ISSUE: type reference
              ParameterExpression parameterExpression2 = (ParameterExpression) ScriptCallsStatisticsPage.Mb5JGRECig0RtLyFSgDu(ScriptCallsStatisticsPage.DoLmj5ECSZm7JP7LC9tj(__typeref (ScriptMetric)), ScriptCallsStatisticsPage.lPw4JAECucKHKxTYMiKv(-710283084 ^ -537863435 ^ 173576231));
              // ISSUE: method reference
              Expression<Func<ScriptMetric, long>> valueAccessor2 = Expression.Lambda<Func<ScriptMetric, long>>((Expression) ScriptCallsStatisticsPage.kSxRvbECqHDMM9u6Jvxe((object) parameterExpression2, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CountMetric.get_CountErrorCall))), parameterExpression2);
              MetricExcelTable<ScriptMetric> metricExcelTable4 = metricExcelTable3.AddColumn<long>(valueAccessor2);
              // ISSUE: type reference
              ParameterExpression parameterExpression3 = (ParameterExpression) ScriptCallsStatisticsPage.Mb5JGRECig0RtLyFSgDu(ScriptCallsStatisticsPage.DoLmj5ECSZm7JP7LC9tj(__typeref (ScriptMetric)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576119358));
              // ISSUE: method reference
              Expression<Func<ScriptMetric, TimeSpan>> valueAccessor3 = Expression.Lambda<Func<ScriptMetric, TimeSpan>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) ScriptCallsStatisticsPage.FamojjECRn85VnRbneGQ(__methodref (CountTimeMetric.get_TotalTime))), parameterExpression3);
              MetricExcelTable<ScriptMetric> metricExcelTable5 = metricExcelTable4.AddColumn<TimeSpan>(valueAccessor3);
              // ISSUE: type reference
              ParameterExpression parameterExpression4 = (ParameterExpression) ScriptCallsStatisticsPage.Mb5JGRECig0RtLyFSgDu(ScriptCallsStatisticsPage.DoLmj5ECSZm7JP7LC9tj(__typeref (ScriptMetric)), ScriptCallsStatisticsPage.lPw4JAECucKHKxTYMiKv(-1858887263 ^ -1858987065));
              // ISSUE: method reference
              Expression<Func<ScriptMetric, double>> valueAccessor4 = Expression.Lambda<Func<ScriptMetric, double>>((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) ScriptCallsStatisticsPage.FamojjECRn85VnRbneGQ(__methodref (CountTimeMetric.get_MaxTime))), parameterExpression4);
              object format1 = ScriptCallsStatisticsPage.mEf2DRECKh4S8RlnJoqO();
              MetricExcelTable<ScriptMetric> metricExcelTable6 = metricExcelTable5.AddColumn<double>(valueAccessor4, format: (IExcelCellFormat) format1);
              // ISSUE: type reference
              ParameterExpression parameterExpression5 = (ParameterExpression) ScriptCallsStatisticsPage.Mb5JGRECig0RtLyFSgDu(ScriptCallsStatisticsPage.DoLmj5ECSZm7JP7LC9tj(__typeref (ScriptMetric)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217418401));
              // ISSUE: method reference
              Expression<Func<ScriptMetric, double>> valueAccessor5 = Expression.Lambda<Func<ScriptMetric, double>>((Expression) ScriptCallsStatisticsPage.kSxRvbECqHDMM9u6Jvxe((object) parameterExpression5, (object) (MethodInfo) ScriptCallsStatisticsPage.FamojjECRn85VnRbneGQ(__methodref (CountTimeMetric.get_AvgTime))), parameterExpression5);
              object format2 = ScriptCallsStatisticsPage.mEf2DRECKh4S8RlnJoqO();
              MetricExcelTable<ScriptMetric> metricExcelTable7 = metricExcelTable6.AddColumn<double>(valueAccessor5, format: (IExcelCellFormat) format2);
              ParameterExpression parameterExpression6 = (ParameterExpression) ScriptCallsStatisticsPage.Mb5JGRECig0RtLyFSgDu(typeof (ScriptMetric), ScriptCallsStatisticsPage.lPw4JAECucKHKxTYMiKv(-244066886 - -48452443 ^ -195652749));
              // ISSUE: method reference
              Expression<Func<ScriptMetric, TimeSpan>> valueAccessor6 = Expression.Lambda<Func<ScriptMetric, TimeSpan>>((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) ScriptCallsStatisticsPage.FamojjECRn85VnRbneGQ(__methodref (MethodMetric.get_ClearTotalTime))), parameterExpression6);
              MetricExcelTable<ScriptMetric> metricExcelTable8 = metricExcelTable7.AddColumn<TimeSpan>(valueAccessor6);
              // ISSUE: type reference
              ParameterExpression parameterExpression7 = (ParameterExpression) ScriptCallsStatisticsPage.Mb5JGRECig0RtLyFSgDu(ScriptCallsStatisticsPage.DoLmj5ECSZm7JP7LC9tj(__typeref (ScriptMetric)), ScriptCallsStatisticsPage.lPw4JAECucKHKxTYMiKv(-1852837372 ^ -1852946334));
              // ISSUE: method reference
              Expression<Func<ScriptMetric, double>> valueAccessor7 = Expression.Lambda<Func<ScriptMetric, double>>((Expression) ScriptCallsStatisticsPage.kSxRvbECqHDMM9u6Jvxe((object) parameterExpression7, (object) (MethodInfo) ScriptCallsStatisticsPage.FamojjECRn85VnRbneGQ(__methodref (MethodMetric.get_ClearMaxTime))), parameterExpression7);
              object format3 = ScriptCallsStatisticsPage.mEf2DRECKh4S8RlnJoqO();
              MetricExcelTable<ScriptMetric> metricExcelTable9 = metricExcelTable8.AddColumn<double>(valueAccessor7, format: (IExcelCellFormat) format3);
              // ISSUE: type reference
              ParameterExpression parameterExpression8 = (ParameterExpression) ScriptCallsStatisticsPage.Mb5JGRECig0RtLyFSgDu(ScriptCallsStatisticsPage.DoLmj5ECSZm7JP7LC9tj(__typeref (ScriptMetric)), ScriptCallsStatisticsPage.lPw4JAECucKHKxTYMiKv(-87337865 ^ -87364079));
              // ISSUE: method reference
              Expression<Func<ScriptMetric, double>> valueAccessor8 = Expression.Lambda<Func<ScriptMetric, double>>((Expression) ScriptCallsStatisticsPage.kSxRvbECqHDMM9u6Jvxe((object) parameterExpression8, (object) (MethodInfo) ScriptCallsStatisticsPage.FamojjECRn85VnRbneGQ(__methodref (MethodMetric.get_ClearAvgTime))), parameterExpression8);
              object format4 = ScriptCallsStatisticsPage.mEf2DRECKh4S8RlnJoqO();
              table = metricExcelTable9.AddColumn<double>(valueAccessor8, format: (IExcelCellFormat) format4);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
              continue;
            case 5:
              num2 = 4;
              continue;
            case 6:
              goto label_9;
            default:
              goto label_10;
          }
        }
label_9:
        table.Items = source != null ? (IEnumerable<KeyValuePair<string, ScriptMetric>>) source.OrderBy<KeyValuePair<string, ScriptMetric>, string>((Func<KeyValuePair<string, ScriptMetric>, string>) (s => s.Key)).ToList<KeyValuePair<string, ScriptMetric>>() : (IEnumerable<KeyValuePair<string, ScriptMetric>>) new List<KeyValuePair<string, ScriptMetric>>();
        num1 = 3;
      }
label_3:
      return;
label_10:;
    }

    internal static object lPw4JAECucKHKxTYMiKv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object XJqsEwECIJ9gmUQRedSL([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool gJnatOEC8bx5HSk8dIXL() => ScriptCallsStatisticsPage.nCCjilECvaSML8uyX52u == null;

    internal static ScriptCallsStatisticsPage SHyghvECZ1Mh6NbgwnAb() => ScriptCallsStatisticsPage.nCCjilECvaSML8uyX52u;

    internal static void T2HdKOECVAh63fbHLmZ9([In] object obj0, [In] int obj1) => ((ExcelTable<KeyValuePair<string, ScriptMetric>>) obj0).FixedRows = obj1;

    internal static Type DoLmj5ECSZm7JP7LC9tj([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Mb5JGRECig0RtLyFSgDu([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object FamojjECRn85VnRbneGQ([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object kSxRvbECqHDMM9u6Jvxe([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object mEf2DRECKh4S8RlnJoqO() => (object) FloatFormat.Default;
  }
}
