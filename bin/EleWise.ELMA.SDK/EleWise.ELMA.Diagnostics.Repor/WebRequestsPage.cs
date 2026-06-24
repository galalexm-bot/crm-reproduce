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

[ComponentOrder(10)]
internal class WebRequestsPage : PerformanceReportPage
{
	private static WebRequestsPage Si6FGWECpQAZNyNcSTK7;

	public override string Name => SR.T((string)iBtolnECtY0y1vi6EReV(-740338220 ^ -740593880));

	public WebRequestsPage(IEnumerable<IPerformanceReportPageColumnBuilder> builders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(builders);
	}

	public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		MetricsGroup<WebRequestMetric> metricsGroup = default(MetricsGroup<WebRequestMetric>);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			default:
				builder.RenderTable(_003C_003Ec__DisplayClass3_.table);
				num2 = 5;
				break;
			case 6:
				metricsGroup = metrics.Get<WebRequestMetric>();
				num2 = 4;
				break;
			case 3:
				base.PerformanceReportPageColumnBuilders.ForEach(_003C_003Ec__DisplayClass3_._003CExportExcel_003Eb__8);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			{
				_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_2 = _003C_003Ec__DisplayClass3_;
				MetricExcelTable<WebRequestMetric> metricExcelTable = new MetricExcelTable<WebRequestMetric>();
				UVhq7xECwJhx9Ppg5w57(metricExcelTable, 1);
				MetricExcelTable<WebRequestMetric> metricExcelTable2 = metricExcelTable.AddColumn((string)hYj5BvEC4K357YNKaNbe(iBtolnECtY0y1vi6EReV(-1088304168 ^ -1088332940)), 60.0, (KeyValuePair<string, WebRequestMetric> s) => s.Key);
				ParameterExpression parameterExpression = Expression.Parameter(oAV1aCEC6xmmX6wfC0Jk(typeof(WebRequestMetric).TypeHandle), (string)iBtolnECtY0y1vi6EReV(-309639236 ^ -309658150));
				MetricExcelTable<WebRequestMetric> metricExcelTable3 = metricExcelTable2.AddColumn(Expression.Lambda<Func<WebRequestMetric, long>>(Expression.Property(parameterExpression, (MethodInfo)KSo5SkECHto1oSOxkxBC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)BPV7WZECAeIy7m3DDe0F(oAV1aCEC6xmmX6wfC0Jk(typeof(WebRequestMetric).TypeHandle), iBtolnECtY0y1vi6EReV(-210725949 ^ -210687579));
				MetricExcelTable<WebRequestMetric> metricExcelTable4 = metricExcelTable3.AddColumn(Expression.Lambda<Func<WebRequestMetric, long>>((Expression)uPE8GsEC7wEpWcnhPOV2(parameterExpression, (MethodInfo)KSo5SkECHto1oSOxkxBC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)BPV7WZECAeIy7m3DDe0F(oAV1aCEC6xmmX6wfC0Jk(typeof(WebRequestMetric).TypeHandle), iBtolnECtY0y1vi6EReV(-234299632 ^ -234265226));
				MetricExcelTable<WebRequestMetric> metricExcelTable5 = metricExcelTable4.AddColumn(Expression.Lambda<Func<WebRequestMetric, TimeSpan>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)BPV7WZECAeIy7m3DDe0F(oAV1aCEC6xmmX6wfC0Jk(typeof(WebRequestMetric).TypeHandle), iBtolnECtY0y1vi6EReV(0x4D1C1EE4 ^ 0x4D1DA482));
				MetricExcelTable<WebRequestMetric> metricExcelTable6 = metricExcelTable5.AddColumn(Expression.Lambda<Func<WebRequestMetric, double>>((Expression)uPE8GsEC7wEpWcnhPOV2(parameterExpression, (MethodInfo)KSo5SkECHto1oSOxkxBC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, FloatFormat.Default);
				parameterExpression = (ParameterExpression)BPV7WZECAeIy7m3DDe0F(typeof(WebRequestMetric), iBtolnECtY0y1vi6EReV(-672123589 ^ -672034979));
				MetricExcelTable<WebRequestMetric> metricExcelTable7 = metricExcelTable6.AddColumn(Expression.Lambda<Func<WebRequestMetric, double>>(Expression.Property(parameterExpression, (MethodInfo)KSo5SkECHto1oSOxkxBC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)ccC6ywECxBnAZ4Dgp9jI());
				parameterExpression = (ParameterExpression)BPV7WZECAeIy7m3DDe0F(oAV1aCEC6xmmX6wfC0Jk(typeof(WebRequestMetric).TypeHandle), iBtolnECtY0y1vi6EReV(0x3B36AB09 ^ 0x3B37116F));
				MetricExcelTable<WebRequestMetric> metricExcelTable8 = metricExcelTable7.AddColumn(Expression.Lambda<Func<WebRequestMetric, TimeSpan>>((Expression)uPE8GsEC7wEpWcnhPOV2(parameterExpression, (MethodInfo)KSo5SkECHto1oSOxkxBC((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)BPV7WZECAeIy7m3DDe0F(typeof(WebRequestMetric), iBtolnECtY0y1vi6EReV(0x4785BC0D ^ 0x4784066B));
				_003C_003Ec__DisplayClass3_2.table = metricExcelTable8.AddColumn(Expression.Lambda<Func<WebRequestMetric, TimeSpan>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 4:
				_003C_003Ec__DisplayClass3_.table.Items = ((metricsGroup != null) ? metricsGroup.OrderBy((KeyValuePair<string, WebRequestMetric> s) => s.Key).ToList() : new List<KeyValuePair<string, WebRequestMetric>>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object iBtolnECtY0y1vi6EReV(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool jFJ1UbECaUjZWV9XmAUg()
	{
		return Si6FGWECpQAZNyNcSTK7 == null;
	}

	internal static WebRequestsPage XlHrhaECDH3dRKGdtOw2()
	{
		return Si6FGWECpQAZNyNcSTK7;
	}

	internal static void UVhq7xECwJhx9Ppg5w57(object P_0, int P_1)
	{
		((ExcelTable<KeyValuePair<string, WebRequestMetric>>)P_0).FixedRows = P_1;
	}

	internal static object hYj5BvEC4K357YNKaNbe(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static Type oAV1aCEC6xmmX6wfC0Jk(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object KSo5SkECHto1oSOxkxBC(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object BPV7WZECAeIy7m3DDe0F(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object uPE8GsEC7wEpWcnhPOV2(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object ccC6ywECxBnAZ4Dgp9jI()
	{
		return FloatFormat.Default;
	}
}
