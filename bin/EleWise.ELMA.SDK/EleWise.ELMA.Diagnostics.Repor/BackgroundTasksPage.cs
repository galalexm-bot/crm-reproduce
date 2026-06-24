using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Performance;

[ComponentOrder(20)]
internal class BackgroundTasksPage : PerformanceReportPage
{
	internal static BackgroundTasksPage QmrxdHEfUnFdHADhFiOo;

	public override string Name => (string)aQYsLlEfzJr21tTRsycH(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979502143));

	public BackgroundTasksPage(IEnumerable<IPerformanceReportPageColumnBuilder> builders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(builders);
	}

	public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
	{
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		MetricsGroup<BackgroundTaskMetric> metricsGroup = default(MetricsGroup<BackgroundTaskMetric>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				base.PerformanceReportPageColumnBuilders.ForEach(_003C_003Ec__DisplayClass3_._003CExportExcel_003Eb__8);
				num2 = 2;
				break;
			default:
				builder.RenderTable(_003C_003Ec__DisplayClass3_.table);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				metricsGroup = metrics.Get<BackgroundTaskMetric>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 6:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 5;
				break;
			case 5:
			{
				_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_2 = _003C_003Ec__DisplayClass3_;
				MetricExcelTable<BackgroundTaskMetric> metricExcelTable = new MetricExcelTable<BackgroundTaskMetric>();
				CrxMqhEQFoFLQL83BDdr(metricExcelTable, 1);
				MetricExcelTable<BackgroundTaskMetric> metricExcelTable2 = metricExcelTable.AddColumn((string)aQYsLlEfzJr21tTRsycH(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16488201)), 60.0, delegate(KeyValuePair<string, BackgroundTaskMetric> s)
				{
					_003C_003Ec__DisplayClass3_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_1();
					CS_0024_003C_003E8__locals0.s = s;
					return new CellValue(CS_0024_003C_003E8__locals0.s.Key, new CustomCellFormat(delegate(Cell cell, object v)
					{
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 1:
							{
								object obj = _003C_003Ec__DisplayClass3_1.M3BpDP8RBoBNk5qGdteB(_003C_003Ec__DisplayClass3_1.cVHqo58RFaudwIHNi0J5(cell, _003C_003Ec__DisplayClass3_1.RcWZf88izA3GjEnZ4o2g(CS_0024_003C_003E8__locals0.s.Key, '('), CS_0024_003C_003E8__locals0.s.Key.LastIndexOf(')')));
								((Font)obj).set_Size(8);
								_003C_003Ec__DisplayClass3_1.SQAFuG8RooRjnLeiCc8u(obj, _003C_003Ec__DisplayClass3_1.wk9yxD8RWdmxpX473Z2h());
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
								{
									num4 = 0;
								}
								break;
							}
							case 0:
								return;
							case 2:
								_003C_003Ec__DisplayClass3_1.Hv0e3w8ictVc9LO0IZX7(cell, CS_0024_003C_003E8__locals0.s.Key);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
								{
									num4 = 1;
								}
								break;
							}
						}
					}));
				});
				ParameterExpression parameterExpression = (ParameterExpression)Ostp1ZEQWQvCogXaJI1X(IwgtgCEQBXLFOTew42vP(typeof(BackgroundTaskMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822860162));
				MetricExcelTable<BackgroundTaskMetric> metricExcelTable3 = metricExcelTable2.AddColumn(Expression.Lambda<Func<BackgroundTaskMetric, long>>((Expression)E6cm4YEQbRDGmUZMTgrU(parameterExpression, (MethodInfo)bMJr4nEQotuNNwwHGL1Z((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)Ostp1ZEQWQvCogXaJI1X(typeof(BackgroundTaskMetric), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE1393A9));
				MetricExcelTable<BackgroundTaskMetric> metricExcelTable4 = metricExcelTable3.AddColumn(Expression.Lambda<Func<BackgroundTaskMetric, long>>(Expression.Property(parameterExpression, (MethodInfo)bMJr4nEQotuNNwwHGL1Z((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)Ostp1ZEQWQvCogXaJI1X(IwgtgCEQBXLFOTew42vP(typeof(BackgroundTaskMetric).TypeHandle), mPmVGQEQhwXeiGoPGGMJ(0x5A4C7B29 ^ 0x5A4DC14F));
				MetricExcelTable<BackgroundTaskMetric> metricExcelTable5 = metricExcelTable4.AddColumn(Expression.Lambda<Func<BackgroundTaskMetric, TimeSpan>>((Expression)E6cm4YEQbRDGmUZMTgrU(parameterExpression, (MethodInfo)bMJr4nEQotuNNwwHGL1Z((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = Expression.Parameter(IwgtgCEQBXLFOTew42vP(typeof(BackgroundTaskMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FBBAA8));
				MetricExcelTable<BackgroundTaskMetric> metricExcelTable6 = metricExcelTable5.AddColumn(Expression.Lambda<Func<BackgroundTaskMetric, double>>((Expression)E6cm4YEQbRDGmUZMTgrU(parameterExpression, (MethodInfo)bMJr4nEQotuNNwwHGL1Z((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)GEbJSPEQGhtwI80h8Xdf());
				parameterExpression = (ParameterExpression)Ostp1ZEQWQvCogXaJI1X(IwgtgCEQBXLFOTew42vP(typeof(BackgroundTaskMetric).TypeHandle), mPmVGQEQhwXeiGoPGGMJ(-1767720453 ^ -1767701603));
				MetricExcelTable<BackgroundTaskMetric> metricExcelTable7 = metricExcelTable6.AddColumn(Expression.Lambda<Func<BackgroundTaskMetric, double>>((Expression)E6cm4YEQbRDGmUZMTgrU(parameterExpression, (MethodInfo)bMJr4nEQotuNNwwHGL1Z((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)GEbJSPEQGhtwI80h8Xdf());
				parameterExpression = (ParameterExpression)Ostp1ZEQWQvCogXaJI1X(IwgtgCEQBXLFOTew42vP(typeof(BackgroundTaskMetric).TypeHandle), mPmVGQEQhwXeiGoPGGMJ(-1921202237 ^ -1921155675));
				MetricExcelTable<BackgroundTaskMetric> metricExcelTable8 = metricExcelTable7.AddColumn(Expression.Lambda<Func<BackgroundTaskMetric, TimeSpan>>((Expression)E6cm4YEQbRDGmUZMTgrU(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				parameterExpression = (ParameterExpression)Ostp1ZEQWQvCogXaJI1X(IwgtgCEQBXLFOTew42vP(typeof(BackgroundTaskMetric).TypeHandle), mPmVGQEQhwXeiGoPGGMJ(--1333735954 ^ 0x4F7E8874));
				_003C_003Ec__DisplayClass3_2.table = metricExcelTable8.AddColumn(Expression.Lambda<Func<BackgroundTaskMetric, TimeSpan>>((Expression)E6cm4YEQbRDGmUZMTgrU(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 4;
				break;
			}
			case 1:
				_003C_003Ec__DisplayClass3_.table.Items = ((metricsGroup != null) ? metricsGroup.OrderBy((KeyValuePair<string, BackgroundTaskMetric> s) => s.Key).ToList() : new List<KeyValuePair<string, BackgroundTaskMetric>>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object aQYsLlEfzJr21tTRsycH(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool VAlkgdEfs3EMFsyOflO8()
	{
		return QmrxdHEfUnFdHADhFiOo == null;
	}

	internal static BackgroundTasksPage RGJ1wsEfcm0VwQCFc0x4()
	{
		return QmrxdHEfUnFdHADhFiOo;
	}

	internal static void CrxMqhEQFoFLQL83BDdr(object P_0, int P_1)
	{
		((ExcelTable<KeyValuePair<string, BackgroundTaskMetric>>)P_0).FixedRows = P_1;
	}

	internal static Type IwgtgCEQBXLFOTew42vP(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Ostp1ZEQWQvCogXaJI1X(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object bMJr4nEQotuNNwwHGL1Z(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object E6cm4YEQbRDGmUZMTgrU(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object mPmVGQEQhwXeiGoPGGMJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GEbJSPEQGhtwI80h8Xdf()
	{
		return FloatFormat.Default;
	}
}
