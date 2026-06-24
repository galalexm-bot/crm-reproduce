// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Performance.SqlQueriesPage
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
  /// <summary>Страница отчета "SQL-запросы"</summary>
  [ComponentOrder(400)]
  internal class SqlQueriesPage : PerformanceReportPage
  {
    internal static SqlQueriesPage H3pruJECXjh117EA8Rln;

    /// <summary>Ctor</summary>
    /// <param name="builders">Построители колонок</param>
    public SqlQueriesPage(
      IEnumerable<IPerformanceReportPageColumnBuilder> builders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(builders);
    }

    /// <inheritdoc />
    public override string Name => EleWise.ELMA.SR.T((string) SqlQueriesPage.WhCeJ5ECnCSOqFTAoiOY(~-122002947 ^ 121742560));

    /// <inheritdoc />
    public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
    {
      int num1 = 2;
      MetricsGroup<SqlQueryMetric> source;
      MetricExcelTable<SqlQueryMetric> table;
      while (true)
      {
        switch (num1)
        {
          case 1:
            MetricExcelTable<SqlQueryMetric> metricExcelTable1 = new MetricExcelTable<SqlQueryMetric>();
            SqlQueriesPage.GWYHBjECOwBJ8tg9gKGW((object) metricExcelTable1, 1);
            object title = SqlQueriesPage.XXOKDFEC2b393wVD70OW(SqlQueriesPage.WhCeJ5ECnCSOqFTAoiOY(-488881205 ^ -489130781));
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, SqlQueryMetric>, string> func = SqlQueriesPage.\u003C\u003Ec.\u003C\u003E9__3_0;
            Func<KeyValuePair<string, SqlQueryMetric>, string> valueAccessor1;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              SqlQueriesPage.\u003C\u003Ec.\u003C\u003E9__3_0 = valueAccessor1 = (Func<KeyValuePair<string, SqlQueryMetric>, string>) (s => s.Key);
            }
            else
              goto label_11;
label_8:
            MetricExcelTable<SqlQueryMetric> metricExcelTable2 = metricExcelTable1.AddColumn<string>((string) title, 80.0, valueAccessor1);
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = (ParameterExpression) SqlQueriesPage.Y6m1riECPd4rkXJgjnUV(SqlQueriesPage.VbZxwRECeTK5n6wcc6Wc(__typeref (SqlQueryMetric)), SqlQueriesPage.WhCeJ5ECnCSOqFTAoiOY(333888594 ^ 1075625116 ^ 1409006248));
            // ISSUE: method reference
            Expression<Func<SqlQueryMetric, long>> valueAccessor2 = Expression.Lambda<Func<SqlQueryMetric, long>>((Expression) SqlQueriesPage.mSvOkLECNtDJ2Ox8JksJ((object) parameterExpression1, (object) (MethodInfo) SqlQueriesPage.J4ZnUnEC1HOosEqI3CFj(__methodref (CountMetric.get_CountCall))), parameterExpression1);
            MetricExcelTable<SqlQueryMetric> metricExcelTable3 = metricExcelTable2.AddColumn<long>(valueAccessor2);
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) SqlQueriesPage.Y6m1riECPd4rkXJgjnUV(SqlQueriesPage.VbZxwRECeTK5n6wcc6Wc(__typeref (SqlQueryMetric)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088392770));
            // ISSUE: method reference
            Expression<Func<SqlQueryMetric, long>> valueAccessor3 = Expression.Lambda<Func<SqlQueryMetric, long>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) SqlQueriesPage.J4ZnUnEC1HOosEqI3CFj(__methodref (CountMetric.get_CountErrorCall))), parameterExpression2);
            MetricExcelTable<SqlQueryMetric> metricExcelTable4 = metricExcelTable3.AddColumn<long>(valueAccessor3);
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = Expression.Parameter(SqlQueriesPage.VbZxwRECeTK5n6wcc6Wc(__typeref (SqlQueryMetric)), (string) SqlQueriesPage.WhCeJ5ECnCSOqFTAoiOY(-1255365154 ^ 596875508 ^ -1765898420));
            // ISSUE: method reference
            Expression<Func<SqlQueryMetric, TimeSpan>> valueAccessor4 = Expression.Lambda<Func<SqlQueryMetric, TimeSpan>>((Expression) SqlQueriesPage.mSvOkLECNtDJ2Ox8JksJ((object) parameterExpression3, (object) (MethodInfo) SqlQueriesPage.J4ZnUnEC1HOosEqI3CFj(__methodref (CountTimeMetric.get_TotalTime))), parameterExpression3);
            MetricExcelTable<SqlQueryMetric> metricExcelTable5 = metricExcelTable4.AddColumn<TimeSpan>(valueAccessor4);
            ParameterExpression parameterExpression4 = (ParameterExpression) SqlQueriesPage.Y6m1riECPd4rkXJgjnUV(typeof (SqlQueryMetric), SqlQueriesPage.WhCeJ5ECnCSOqFTAoiOY(1461625753 ^ 1461656063));
            // ISSUE: method reference
            Expression<Func<SqlQueryMetric, double>> valueAccessor5 = Expression.Lambda<Func<SqlQueryMetric, double>>((Expression) SqlQueriesPage.mSvOkLECNtDJ2Ox8JksJ((object) parameterExpression4, (object) (MethodInfo) SqlQueriesPage.J4ZnUnEC1HOosEqI3CFj(__methodref (CountTimeMetric.get_MaxTime))), parameterExpression4);
            object format1 = SqlQueriesPage.UD1gNSEC3wNB10rtTv9U();
            MetricExcelTable<SqlQueryMetric> metricExcelTable6 = metricExcelTable5.AddColumn<double>(valueAccessor5, format: (IExcelCellFormat) format1);
            // ISSUE: type reference
            ParameterExpression parameterExpression5 = (ParameterExpression) SqlQueriesPage.Y6m1riECPd4rkXJgjnUV(SqlQueriesPage.VbZxwRECeTK5n6wcc6Wc(__typeref (SqlQueryMetric)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876150583));
            // ISSUE: method reference
            Expression<Func<SqlQueryMetric, double>> valueAccessor6 = Expression.Lambda<Func<SqlQueryMetric, double>>((Expression) SqlQueriesPage.mSvOkLECNtDJ2Ox8JksJ((object) parameterExpression5, (object) (MethodInfo) SqlQueriesPage.J4ZnUnEC1HOosEqI3CFj(__methodref (CountTimeMetric.get_AvgTime))), parameterExpression5);
            object format2 = SqlQueriesPage.UD1gNSEC3wNB10rtTv9U();
            MetricExcelTable<SqlQueryMetric> metricExcelTable7 = metricExcelTable6.AddColumn<double>(valueAccessor6, format: (IExcelCellFormat) format2);
            // ISSUE: type reference
            ParameterExpression parameterExpression6 = (ParameterExpression) SqlQueriesPage.Y6m1riECPd4rkXJgjnUV(SqlQueriesPage.VbZxwRECeTK5n6wcc6Wc(__typeref (SqlQueryMetric)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858987065));
            // ISSUE: method reference
            Expression<Func<SqlQueryMetric, long>> valueAccessor7 = Expression.Lambda<Func<SqlQueryMetric, long>>((Expression) SqlQueriesPage.mSvOkLECNtDJ2Ox8JksJ((object) parameterExpression6, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SqlQueryMetric.get_MaxExecuteTime))), parameterExpression6);
            MetricExcelTable<SqlQueryMetric> metricExcelTable8 = metricExcelTable7.AddColumn<long>(valueAccessor7);
            // ISSUE: type reference
            ParameterExpression parameterExpression7 = (ParameterExpression) SqlQueriesPage.Y6m1riECPd4rkXJgjnUV(SqlQueriesPage.VbZxwRECeTK5n6wcc6Wc(__typeref (SqlQueryMetric)), SqlQueriesPage.WhCeJ5ECnCSOqFTAoiOY(1052221104 - 768835541 ^ 283485373));
            // ISSUE: method reference
            Expression<Func<SqlQueryMetric, double>> valueAccessor8 = Expression.Lambda<Func<SqlQueryMetric, double>>((Expression) SqlQueriesPage.mSvOkLECNtDJ2Ox8JksJ((object) parameterExpression7, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SqlQueryMetric.get_AvgExecuteTime))), parameterExpression7);
            object format3 = SqlQueriesPage.UD1gNSEC3wNB10rtTv9U();
            MetricExcelTable<SqlQueryMetric> metricExcelTable9 = metricExcelTable8.AddColumn<double>(valueAccessor8, format: (IExcelCellFormat) format3);
            // ISSUE: type reference
            ParameterExpression parameterExpression8 = (ParameterExpression) SqlQueriesPage.Y6m1riECPd4rkXJgjnUV(SqlQueriesPage.VbZxwRECeTK5n6wcc6Wc(__typeref (SqlQueryMetric)), SqlQueriesPage.WhCeJ5ECnCSOqFTAoiOY(-345420348 ^ -345442398));
            // ISSUE: method reference
            Expression<Func<SqlQueryMetric, long>> valueAccessor9 = Expression.Lambda<Func<SqlQueryMetric, long>>((Expression) Expression.Property((Expression) parameterExpression8, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SqlQueryMetric.get_MaxPrepareTime))), parameterExpression8);
            MetricExcelTable<SqlQueryMetric> metricExcelTable10 = metricExcelTable9.AddColumn<long>(valueAccessor9);
            // ISSUE: type reference
            ParameterExpression parameterExpression9 = (ParameterExpression) SqlQueriesPage.Y6m1riECPd4rkXJgjnUV(SqlQueriesPage.VbZxwRECeTK5n6wcc6Wc(__typeref (SqlQueryMetric)), SqlQueriesPage.WhCeJ5ECnCSOqFTAoiOY(-1350312861 << 3 ^ 2082429310));
            // ISSUE: method reference
            Expression<Func<SqlQueryMetric, double>> valueAccessor10 = Expression.Lambda<Func<SqlQueryMetric, double>>((Expression) Expression.Property((Expression) parameterExpression9, (MethodInfo) SqlQueriesPage.J4ZnUnEC1HOosEqI3CFj(__methodref (SqlQueryMetric.get_AvgPrepareTime))), parameterExpression9);
            FloatFormat format4 = FloatFormat.Default;
            MetricExcelTable<SqlQueryMetric> metricExcelTable11 = metricExcelTable10.AddColumn<double>(valueAccessor10, format: (IExcelCellFormat) format4);
            // ISSUE: type reference
            ParameterExpression parameterExpression10 = Expression.Parameter(SqlQueriesPage.VbZxwRECeTK5n6wcc6Wc(__typeref (SqlQueryMetric)), (string) SqlQueriesPage.WhCeJ5ECnCSOqFTAoiOY(1251470110 >> 2 ^ 312754337));
            // ISSUE: method reference
            Expression<Func<SqlQueryMetric, long>> valueAccessor11 = Expression.Lambda<Func<SqlQueryMetric, long>>((Expression) SqlQueriesPage.mSvOkLECNtDJ2Ox8JksJ((object) parameterExpression10, (object) (MethodInfo) SqlQueriesPage.J4ZnUnEC1HOosEqI3CFj(__methodref (SqlQueryMetric.get_TotalAffectedRows))), parameterExpression10);
            table = metricExcelTable11.AddColumn<long>(valueAccessor11);
            num1 = 6;
            continue;
label_11:
            valueAccessor1 = func;
            goto label_8;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
            continue;
          case 3:
            source = metrics.Get<SqlQueryMetric>();
            num1 = 5;
            continue;
          case 4:
            goto label_10;
          case 5:
            table.Items = source == null ? (IEnumerable<KeyValuePair<string, SqlQueryMetric>>) new List<KeyValuePair<string, SqlQueryMetric>>() : (IEnumerable<KeyValuePair<string, SqlQueryMetric>>) source.OrderBy<KeyValuePair<string, SqlQueryMetric>, string>((Func<KeyValuePair<string, SqlQueryMetric>, string>) (s => s.Key)).ToList<KeyValuePair<string, SqlQueryMetric>>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 6:
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
                    cb.AddColumn<SqlQueryMetric>(table);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 3;
            continue;
          default:
            builder.RenderTable<KeyValuePair<string, SqlQueryMetric>>((ExcelTable<KeyValuePair<string, SqlQueryMetric>>) table);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 4 : 4;
            continue;
        }
      }
label_10:;
    }

    internal static object WhCeJ5ECnCSOqFTAoiOY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool HARocxECT3cqG6AfCgiD() => SqlQueriesPage.H3pruJECXjh117EA8Rln == null;

    internal static SqlQueriesPage p3KpNsECkpg4EvXYtU6N() => SqlQueriesPage.H3pruJECXjh117EA8Rln;

    internal static void GWYHBjECOwBJ8tg9gKGW([In] object obj0, [In] int obj1) => ((ExcelTable<KeyValuePair<string, SqlQueryMetric>>) obj0).FixedRows = obj1;

    internal static object XXOKDFEC2b393wVD70OW([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static Type VbZxwRECeTK5n6wcc6Wc([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Y6m1riECPd4rkXJgjnUV([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object J4ZnUnEC1HOosEqI3CFj([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object mSvOkLECNtDJ2Ox8JksJ([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object UD1gNSEC3wNB10rtTv9U() => (object) FloatFormat.Default;
  }
}
