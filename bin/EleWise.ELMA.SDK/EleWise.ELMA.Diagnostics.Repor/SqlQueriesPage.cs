using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Performance;

[ComponentOrder(400)]
internal class SqlQueriesPage : PerformanceReportPage
{
	internal static SqlQueriesPage H3pruJECXjh117EA8Rln;

	public override string Name => SR.T((string)WhCeJ5ECnCSOqFTAoiOY(0x7459E02 ^ 0x741A4E0));

	public SqlQueriesPage(IEnumerable<IPerformanceReportPageColumnBuilder> builders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(builders);
	}

	public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
	{
		int num = 2;
		int num2 = num;
		MetricsGroup<SqlQueryMetric> metricsGroup = default(MetricsGroup<SqlQueryMetric>);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				metricsGroup = metrics.Get<SqlQueryMetric>();
				num2 = 5;
				break;
			case 6:
				base.PerformanceReportPageColumnBuilders.ForEach(_003C_003Ec__DisplayClass3_._003CExportExcel_003Eb__11);
				num2 = 3;
				break;
			case 4:
				return;
			default:
				builder.RenderTable(_003C_003Ec__DisplayClass3_.table);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_2 = _003C_003Ec__DisplayClass3_;
				MetricExcelTable<SqlQueryMetric> metricExcelTable = new MetricExcelTable<SqlQueryMetric>();
				GWYHBjECOwBJ8tg9gKGW(metricExcelTable, 1);
				MetricExcelTable<SqlQueryMetric> metricExcelTable2 = metricExcelTable.AddColumn((string)XXOKDFEC2b393wVD70OW(WhCeJ5ECnCSOqFTAoiOY(-488881205 ^ -489130781)), 80.0, (KeyValuePair<string, SqlQueryMetric> s) => s.Key);
				ParameterExpression parameterExpression = (ParameterExpression)Y6m1riECPd4rkXJgjnUV(VbZxwRECeTK5n6wcc6Wc(typeof(SqlQueryMetric).TypeHandle), WhCeJ5ECnCSOqFTAoiOY(0x53FA00CE ^ 0x53FBBAA8));
				MetricExcelTable<SqlQueryMetric> metricExcelTable3 = metricExcelTable2.AddColumn(Expression.Lambda<Func<SqlQueryMetric, long>>((Expression)mSvOkLECNtDJ2Ox8JksJ(parameterExpression, (MethodInfo)J4ZnUnEC1HOosEqI3CFj((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)Y6m1riECPd4rkXJgjnUV(VbZxwRECeTK5n6wcc6Wc(typeof(SqlQueryMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088392770));
				MetricExcelTable<SqlQueryMetric> metricExcelTable4 = metricExcelTable3.AddColumn(Expression.Lambda<Func<SqlQueryMetric, long>>(Expression.Property(parameterExpression, (MethodInfo)J4ZnUnEC1HOosEqI3CFj((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = Expression.Parameter(VbZxwRECeTK5n6wcc6Wc(typeof(SqlQueryMetric).TypeHandle), (string)WhCeJ5ECnCSOqFTAoiOY(-1765851862 ^ -1765898420));
				MetricExcelTable<SqlQueryMetric> metricExcelTable5 = metricExcelTable4.AddColumn(Expression.Lambda<Func<SqlQueryMetric, TimeSpan>>((Expression)mSvOkLECNtDJ2Ox8JksJ(parameterExpression, (MethodInfo)J4ZnUnEC1HOosEqI3CFj((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)Y6m1riECPd4rkXJgjnUV(typeof(SqlQueryMetric), WhCeJ5ECnCSOqFTAoiOY(0x571EA399 ^ 0x571F19FF));
				MetricExcelTable<SqlQueryMetric> metricExcelTable6 = metricExcelTable5.AddColumn(Expression.Lambda<Func<SqlQueryMetric, double>>((Expression)mSvOkLECNtDJ2Ox8JksJ(parameterExpression, (MethodInfo)J4ZnUnEC1HOosEqI3CFj((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)UD1gNSEC3wNB10rtTv9U());
				parameterExpression = (ParameterExpression)Y6m1riECPd4rkXJgjnUV(VbZxwRECeTK5n6wcc6Wc(typeof(SqlQueryMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876150583));
				MetricExcelTable<SqlQueryMetric> metricExcelTable7 = metricExcelTable6.AddColumn(Expression.Lambda<Func<SqlQueryMetric, double>>((Expression)mSvOkLECNtDJ2Ox8JksJ(parameterExpression, (MethodInfo)J4ZnUnEC1HOosEqI3CFj((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)UD1gNSEC3wNB10rtTv9U());
				parameterExpression = (ParameterExpression)Y6m1riECPd4rkXJgjnUV(VbZxwRECeTK5n6wcc6Wc(typeof(SqlQueryMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858987065));
				MetricExcelTable<SqlQueryMetric> metricExcelTable8 = metricExcelTable7.AddColumn(Expression.Lambda<Func<SqlQueryMetric, long>>((Expression)mSvOkLECNtDJ2Ox8JksJ(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)Y6m1riECPd4rkXJgjnUV(VbZxwRECeTK5n6wcc6Wc(typeof(SqlQueryMetric).TypeHandle), WhCeJ5ECnCSOqFTAoiOY(0x10E41EDB ^ 0x10E5A4BD));
				MetricExcelTable<SqlQueryMetric> metricExcelTable9 = metricExcelTable8.AddColumn(Expression.Lambda<Func<SqlQueryMetric, double>>((Expression)mSvOkLECNtDJ2Ox8JksJ(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)UD1gNSEC3wNB10rtTv9U());
				parameterExpression = (ParameterExpression)Y6m1riECPd4rkXJgjnUV(VbZxwRECeTK5n6wcc6Wc(typeof(SqlQueryMetric).TypeHandle), WhCeJ5ECnCSOqFTAoiOY(-345420348 ^ -345442398));
				MetricExcelTable<SqlQueryMetric> metricExcelTable10 = metricExcelTable9.AddColumn(Expression.Lambda<Func<SqlQueryMetric, long>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)Y6m1riECPd4rkXJgjnUV(VbZxwRECeTK5n6wcc6Wc(typeof(SqlQueryMetric).TypeHandle), WhCeJ5ECnCSOqFTAoiOY(0x7C1EE318 ^ 0x7C1F597E));
				MetricExcelTable<SqlQueryMetric> metricExcelTable11 = metricExcelTable10.AddColumn(Expression.Lambda<Func<SqlQueryMetric, double>>(Expression.Property(parameterExpression, (MethodInfo)J4ZnUnEC1HOosEqI3CFj((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, FloatFormat.Default);
				parameterExpression = Expression.Parameter(VbZxwRECeTK5n6wcc6Wc(typeof(SqlQueryMetric).TypeHandle), (string)WhCeJ5ECnCSOqFTAoiOY(0x12A5FAC7 ^ 0x12A440A1));
				_003C_003Ec__DisplayClass3_2.table = metricExcelTable11.AddColumn(Expression.Lambda<Func<SqlQueryMetric, long>>((Expression)mSvOkLECNtDJ2Ox8JksJ(parameterExpression, (MethodInfo)J4ZnUnEC1HOosEqI3CFj((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 6;
				break;
			}
			case 5:
				_003C_003Ec__DisplayClass3_.table.Items = ((metricsGroup != null) ? metricsGroup.OrderBy((KeyValuePair<string, SqlQueryMetric> s) => s.Key).ToList() : new List<KeyValuePair<string, SqlQueryMetric>>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object WhCeJ5ECnCSOqFTAoiOY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool HARocxECT3cqG6AfCgiD()
	{
		return H3pruJECXjh117EA8Rln == null;
	}

	internal static SqlQueriesPage p3KpNsECkpg4EvXYtU6N()
	{
		return H3pruJECXjh117EA8Rln;
	}

	internal static void GWYHBjECOwBJ8tg9gKGW(object P_0, int P_1)
	{
		((ExcelTable<KeyValuePair<string, SqlQueryMetric>>)P_0).FixedRows = P_1;
	}

	internal static object XXOKDFEC2b393wVD70OW(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static Type VbZxwRECeTK5n6wcc6Wc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Y6m1riECPd4rkXJgjnUV(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object J4ZnUnEC1HOosEqI3CFj(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object mSvOkLECNtDJ2Ox8JksJ(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object UD1gNSEC3wNB10rtTv9U()
	{
		return FloatFormat.Default;
	}
}
