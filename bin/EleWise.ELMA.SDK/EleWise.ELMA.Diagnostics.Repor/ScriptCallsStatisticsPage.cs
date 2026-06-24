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
internal class ScriptCallsStatisticsPage : PerformanceReportPage
{
	private static ScriptCallsStatisticsPage nCCjilECvaSML8uyX52u;

	public override string Name => (string)XJqsEwECIJ9gmUQRedSL(lPw4JAECucKHKxTYMiKv(-309639236 ^ -309363342));

	public ScriptCallsStatisticsPage(IEnumerable<IPerformanceReportPageColumnBuilder> builders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(builders);
	}

	public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
	{
		int num = 5;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		MetricsGroup<ScriptMetric> metricsGroup = default(MetricsGroup<ScriptMetric>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 5:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 4;
					continue;
				case 1:
					base.PerformanceReportPageColumnBuilders.ForEach(_003C_003Ec__DisplayClass3_._003CExportExcel_003Eb__9);
					num2 = 2;
					continue;
				case 2:
					metricsGroup = metrics.Get<ScriptMetric>();
					num2 = 6;
					continue;
				case 3:
					builder.RenderTable(_003C_003Ec__DisplayClass3_.table);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 4:
				{
					_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_2 = _003C_003Ec__DisplayClass3_;
					MetricExcelTable<ScriptMetric> metricExcelTable = new MetricExcelTable<ScriptMetric>();
					T2HdKOECVAh63fbHLmZ9(metricExcelTable, 1);
					MetricExcelTable<ScriptMetric> metricExcelTable2 = metricExcelTable.AddColumn((string)XJqsEwECIJ9gmUQRedSL(lPw4JAECucKHKxTYMiKv(-2138160520 ^ -2138409942)), 60.0, delegate(KeyValuePair<string, ScriptMetric> s)
					{
						_003C_003Ec__DisplayClass3_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_1();
						CS_0024_003C_003E8__locals0.s = s;
						return new CellValue(CS_0024_003C_003E8__locals0.s.Key, new CustomCellFormat(delegate(Cell cell, object v)
						{
							int num3 = 1;
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
								{
									Font font = cell.Characters(_003C_003Ec__DisplayClass3_1.xKmmIU8qBabZio77u5gl(CS_0024_003C_003E8__locals0.s.Key, '('), _003C_003Ec__DisplayClass3_1.xKmmIU8qBabZio77u5gl(CS_0024_003C_003E8__locals0.s.Key, ')')).get_Font();
									font.set_Size(8);
									_003C_003Ec__DisplayClass3_1.dAiNJO8qoKCKDswHras8(font, _003C_003Ec__DisplayClass3_1.wBDl0F8qWgRpnqv3nfc2());
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
									{
										num4 = 2;
									}
									break;
								}
								case 2:
									return;
								case 1:
									_003C_003Ec__DisplayClass3_1.ktXFSa8qF3vdMaeXLvth(cell, CS_0024_003C_003E8__locals0.s.Key);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}));
					});
					ParameterExpression parameterExpression = (ParameterExpression)Mb5JGRECig0RtLyFSgDu(DoLmj5ECSZm7JP7LC9tj(typeof(ScriptMetric).TypeHandle), lPw4JAECucKHKxTYMiKv(-521266112 ^ -521165274));
					MetricExcelTable<ScriptMetric> metricExcelTable3 = metricExcelTable2.AddColumn(Expression.Lambda<Func<ScriptMetric, long>>((Expression)kSxRvbECqHDMM9u6Jvxe(parameterExpression, (MethodInfo)FamojjECRn85VnRbneGQ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)Mb5JGRECig0RtLyFSgDu(DoLmj5ECSZm7JP7LC9tj(typeof(ScriptMetric).TypeHandle), lPw4JAECucKHKxTYMiKv(0xA592A41 ^ 0xA589027));
					MetricExcelTable<ScriptMetric> metricExcelTable4 = metricExcelTable3.AddColumn(Expression.Lambda<Func<ScriptMetric, long>>((Expression)kSxRvbECqHDMM9u6Jvxe(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)Mb5JGRECig0RtLyFSgDu(DoLmj5ECSZm7JP7LC9tj(typeof(ScriptMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576119358));
					MetricExcelTable<ScriptMetric> metricExcelTable5 = metricExcelTable4.AddColumn(Expression.Lambda<Func<ScriptMetric, TimeSpan>>(Expression.Property(parameterExpression, (MethodInfo)FamojjECRn85VnRbneGQ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)Mb5JGRECig0RtLyFSgDu(DoLmj5ECSZm7JP7LC9tj(typeof(ScriptMetric).TypeHandle), lPw4JAECucKHKxTYMiKv(-1858887263 ^ -1858987065));
					MetricExcelTable<ScriptMetric> metricExcelTable6 = metricExcelTable5.AddColumn(Expression.Lambda<Func<ScriptMetric, double>>(Expression.Property(parameterExpression, (MethodInfo)FamojjECRn85VnRbneGQ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)mEf2DRECKh4S8RlnJoqO());
					parameterExpression = (ParameterExpression)Mb5JGRECig0RtLyFSgDu(DoLmj5ECSZm7JP7LC9tj(typeof(ScriptMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217418401));
					MetricExcelTable<ScriptMetric> metricExcelTable7 = metricExcelTable6.AddColumn(Expression.Lambda<Func<ScriptMetric, double>>((Expression)kSxRvbECqHDMM9u6Jvxe(parameterExpression, (MethodInfo)FamojjECRn85VnRbneGQ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)mEf2DRECKh4S8RlnJoqO());
					parameterExpression = (ParameterExpression)Mb5JGRECig0RtLyFSgDu(typeof(ScriptMetric), lPw4JAECucKHKxTYMiKv(-195614443 ^ -195652749));
					MetricExcelTable<ScriptMetric> metricExcelTable8 = metricExcelTable7.AddColumn(Expression.Lambda<Func<ScriptMetric, TimeSpan>>(Expression.Property(parameterExpression, (MethodInfo)FamojjECRn85VnRbneGQ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)Mb5JGRECig0RtLyFSgDu(DoLmj5ECSZm7JP7LC9tj(typeof(ScriptMetric).TypeHandle), lPw4JAECucKHKxTYMiKv(-1852837372 ^ -1852946334));
					MetricExcelTable<ScriptMetric> metricExcelTable9 = metricExcelTable8.AddColumn(Expression.Lambda<Func<ScriptMetric, double>>((Expression)kSxRvbECqHDMM9u6Jvxe(parameterExpression, (MethodInfo)FamojjECRn85VnRbneGQ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)mEf2DRECKh4S8RlnJoqO());
					parameterExpression = (ParameterExpression)Mb5JGRECig0RtLyFSgDu(DoLmj5ECSZm7JP7LC9tj(typeof(ScriptMetric).TypeHandle), lPw4JAECucKHKxTYMiKv(-87337865 ^ -87364079));
					_003C_003Ec__DisplayClass3_2.table = metricExcelTable9.AddColumn(Expression.Lambda<Func<ScriptMetric, double>>((Expression)kSxRvbECqHDMM9u6Jvxe(parameterExpression, (MethodInfo)FamojjECRn85VnRbneGQ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)mEf2DRECKh4S8RlnJoqO());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 6:
					_003C_003Ec__DisplayClass3_.table.Items = ((metricsGroup != null) ? metricsGroup.OrderBy((KeyValuePair<string, ScriptMetric> s) => s.Key).ToList() : new List<KeyValuePair<string, ScriptMetric>>());
					num = 3;
					break;
				}
				break;
			}
		}
	}

	internal static object lPw4JAECucKHKxTYMiKv(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object XJqsEwECIJ9gmUQRedSL(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool gJnatOEC8bx5HSk8dIXL()
	{
		return nCCjilECvaSML8uyX52u == null;
	}

	internal static ScriptCallsStatisticsPage SHyghvECZ1Mh6NbgwnAb()
	{
		return nCCjilECvaSML8uyX52u;
	}

	internal static void T2HdKOECVAh63fbHLmZ9(object P_0, int P_1)
	{
		((ExcelTable<KeyValuePair<string, ScriptMetric>>)P_0).FixedRows = P_1;
	}

	internal static Type DoLmj5ECSZm7JP7LC9tj(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Mb5JGRECig0RtLyFSgDu(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object FamojjECRn85VnRbneGQ(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object kSxRvbECqHDMM9u6Jvxe(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object mEf2DRECKh4S8RlnJoqO()
	{
		return FloatFormat.Default;
	}
}
