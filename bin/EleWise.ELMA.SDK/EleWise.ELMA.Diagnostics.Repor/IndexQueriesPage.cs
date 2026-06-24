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

[ComponentOrder(500)]
internal class IndexQueriesPage : PerformanceReportPage
{
	private static IndexQueriesPage kQppIkEQmX7FdK8niQdP;

	public override string Name => (string)QGt62xEQ9vGVfFpUA36s(n4QPiaEQJ6wBxUT0FhDp(-218496594 ^ -218220886));

	public IndexQueriesPage(IEnumerable<IPerformanceReportPageColumnBuilder> builders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(builders);
	}

	public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
	{
		int num = 6;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		MetricsGroup<IndexQueryMetric> metricsGroup = default(MetricsGroup<IndexQueryMetric>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					base.PerformanceReportPageColumnBuilders.ForEach(_003C_003Ec__DisplayClass3_._003CExportExcel_003Eb__6);
					num2 = 4;
					continue;
				case 2:
					return;
				case 6:
					break;
				case 4:
					metricsGroup = metrics.Get<IndexQueryMetric>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					builder.RenderTable(_003C_003Ec__DisplayClass3_.table);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
				{
					_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_2 = _003C_003Ec__DisplayClass3_;
					MetricExcelTable<IndexQueryMetric> metricExcelTable = new MetricExcelTable<IndexQueryMetric>();
					cSXfAbEQdIvJEkkYhPF0(metricExcelTable, 1);
					MetricExcelTable<IndexQueryMetric> metricExcelTable2 = metricExcelTable.AddColumn(SR.T((string)n4QPiaEQJ6wBxUT0FhDp(-1426094279 ^ -1426345967)), 80.0, (KeyValuePair<string, IndexQueryMetric> s) => s.Key);
					ParameterExpression parameterExpression = Expression.Parameter(awZqhHEQlfVkuQMScHbc(typeof(IndexQueryMetric).TypeHandle), (string)n4QPiaEQJ6wBxUT0FhDp(-675505729 ^ -675470375));
					MetricExcelTable<IndexQueryMetric> metricExcelTable3 = metricExcelTable2.AddColumn(Expression.Lambda<Func<IndexQueryMetric, long>>((Expression)P1rj3SEQg8yBWjBuaAf7(parameterExpression, (MethodInfo)MvwL1LEQrBTHc0ZMawic((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = Expression.Parameter(awZqhHEQlfVkuQMScHbc(typeof(IndexQueryMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852946334));
					MetricExcelTable<IndexQueryMetric> metricExcelTable4 = metricExcelTable3.AddColumn(Expression.Lambda<Func<IndexQueryMetric, long>>((Expression)P1rj3SEQg8yBWjBuaAf7(parameterExpression, (MethodInfo)MvwL1LEQrBTHc0ZMawic((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)QFWd9KEQ5IuG0V33IXUB(typeof(IndexQueryMetric), n4QPiaEQJ6wBxUT0FhDp(-812025778 ^ -812072408));
					MetricExcelTable<IndexQueryMetric> metricExcelTable5 = metricExcelTable4.AddColumn(Expression.Lambda<Func<IndexQueryMetric, TimeSpan>>(Expression.Property(parameterExpression, (MethodInfo)MvwL1LEQrBTHc0ZMawic((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = Expression.Parameter(awZqhHEQlfVkuQMScHbc(typeof(IndexQueryMetric).TypeHandle), (string)n4QPiaEQJ6wBxUT0FhDp(-576149596 ^ -576119358));
					MetricExcelTable<IndexQueryMetric> metricExcelTable6 = metricExcelTable5.AddColumn(Expression.Lambda<Func<IndexQueryMetric, double>>((Expression)P1rj3SEQg8yBWjBuaAf7(parameterExpression, (MethodInfo)MvwL1LEQrBTHc0ZMawic((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)y2CNbUEQjwP0PtAGZRvv());
					parameterExpression = (ParameterExpression)QFWd9KEQ5IuG0V33IXUB(typeof(IndexQueryMetric), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951536768));
					_003C_003Ec__DisplayClass3_2.table = metricExcelTable6.AddColumn(Expression.Lambda<Func<IndexQueryMetric, double>>(Expression.Property(parameterExpression, (MethodInfo)MvwL1LEQrBTHc0ZMawic((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)y2CNbUEQjwP0PtAGZRvv());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 1:
					_003C_003Ec__DisplayClass3_.table.Items = ((metricsGroup != null) ? metricsGroup.OrderBy((KeyValuePair<string, IndexQueryMetric> s) => s.Key).ToList() : new List<KeyValuePair<string, IndexQueryMetric>>());
					num2 = 3;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
			num = 5;
		}
	}

	internal static object n4QPiaEQJ6wBxUT0FhDp(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object QGt62xEQ9vGVfFpUA36s(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool MMsJ8qEQyAciBZIwtRdU()
	{
		return kQppIkEQmX7FdK8niQdP == null;
	}

	internal static IndexQueriesPage qgjdktEQMFm2LnYoYdHT()
	{
		return kQppIkEQmX7FdK8niQdP;
	}

	internal static void cSXfAbEQdIvJEkkYhPF0(object P_0, int P_1)
	{
		((ExcelTable<KeyValuePair<string, IndexQueryMetric>>)P_0).FixedRows = P_1;
	}

	internal static Type awZqhHEQlfVkuQMScHbc(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object MvwL1LEQrBTHc0ZMawic(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object P1rj3SEQg8yBWjBuaAf7(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object QFWd9KEQ5IuG0V33IXUB(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object y2CNbUEQjwP0PtAGZRvv()
	{
		return FloatFormat.Default;
	}
}
