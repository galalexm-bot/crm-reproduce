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

[ComponentOrder(100)]
internal class CallsStatisticsPage : PerformanceReportPage
{
	private static CallsStatisticsPage mqnLrTEQEBFdvbhlFJhJ;

	public override string Name => (string)Tc6u44EQvTxtFdOSDs5C(GKJVdZEQCbq7VKdGyiMb(0x3A5D5EF ^ 0x3A1E3DD));

	public CallsStatisticsPage(IEnumerable<IPerformanceReportPageColumnBuilder> builders)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(builders);
	}

	public override void ExportExcel(MetricsContainer metrics, ExcelReportBuilder builder)
	{
		int num = 2;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		MetricsGroup<MethodMetric> metricsGroup = default(MetricsGroup<MethodMetric>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return;
				default:
					metricsGroup = metrics.Get<MethodMetric>();
					num2 = 6;
					continue;
				case 5:
					base.PerformanceReportPageColumnBuilders.ForEach(_003C_003Ec__DisplayClass3_._003CExportExcel_003Eb__9);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					builder.RenderTable(_003C_003Ec__DisplayClass3_.table);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
				{
					_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_2 = _003C_003Ec__DisplayClass3_;
					MetricExcelTable<MethodMetric> metricExcelTable = new MetricExcelTable<MethodMetric>();
					PKYaO9EQ8KIyFxI17e4x(metricExcelTable, 1);
					MetricExcelTable<MethodMetric> metricExcelTable2 = metricExcelTable.AddColumn((string)Tc6u44EQvTxtFdOSDs5C(GKJVdZEQCbq7VKdGyiMb(0x3B36AB09 ^ 0x3B329D5B)), 60.0, delegate(KeyValuePair<string, MethodMetric> s)
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
								case 2:
									return;
								default:
								{
									object obj = _003C_003Ec__DisplayClass3_1.nvlDg68RRBLky0Y6kQdF(_003C_003Ec__DisplayClass3_1.y0Stdm8RiVOFTTI63K28(cell, _003C_003Ec__DisplayClass3_1.pRhYen8RSacRWsZwUKd8(CS_0024_003C_003E8__locals0.s.Key, '('), _003C_003Ec__DisplayClass3_1.pRhYen8RSacRWsZwUKd8(CS_0024_003C_003E8__locals0.s.Key, ')')));
									((Font)obj).set_Size(8);
									_003C_003Ec__DisplayClass3_1.mtH2bv8RKDh1CrfMFNRb(obj, _003C_003Ec__DisplayClass3_1.mXJKR18Rq5vZb7jnHW21());
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
									{
										num4 = 0;
									}
									break;
								}
								case 1:
									_003C_003Ec__DisplayClass3_1.DjHSf78RV5CeTQL60F7F(cell, CS_0024_003C_003E8__locals0.s.Key);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
									{
										num4 = 0;
									}
									break;
								}
							}
						}));
					});
					ParameterExpression parameterExpression = (ParameterExpression)ht2lHQEQuhV1aIvjG2nI(Oo5lv1EQZGkM90Z95rJm(typeof(MethodMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A440A1));
					MetricExcelTable<MethodMetric> metricExcelTable3 = metricExcelTable2.AddColumn(Expression.Lambda<Func<MethodMetric, long>>(Expression.Property(parameterExpression, (MethodInfo)mswLbeEQIu58PoVC1kd9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)ht2lHQEQuhV1aIvjG2nI(Oo5lv1EQZGkM90Z95rJm(typeof(MethodMetric).TypeHandle), GKJVdZEQCbq7VKdGyiMb(-583745292 ^ -583697774));
					MetricExcelTable<MethodMetric> metricExcelTable4 = metricExcelTable3.AddColumn(Expression.Lambda<Func<MethodMetric, long>>((Expression)rI5U0pEQVJjesR9t7S4b(parameterExpression, (MethodInfo)mswLbeEQIu58PoVC1kd9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)ht2lHQEQuhV1aIvjG2nI(Oo5lv1EQZGkM90Z95rJm(typeof(MethodMetric).TypeHandle), GKJVdZEQCbq7VKdGyiMb(0x18A6761F ^ 0x18A7CC79));
					MetricExcelTable<MethodMetric> metricExcelTable5 = metricExcelTable4.AddColumn(Expression.Lambda<Func<MethodMetric, TimeSpan>>((Expression)rI5U0pEQVJjesR9t7S4b(parameterExpression, (MethodInfo)mswLbeEQIu58PoVC1kd9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)ht2lHQEQuhV1aIvjG2nI(Oo5lv1EQZGkM90Z95rJm(typeof(MethodMetric).TypeHandle), GKJVdZEQCbq7VKdGyiMb(-672123589 ^ -672034979));
					MetricExcelTable<MethodMetric> metricExcelTable6 = metricExcelTable5.AddColumn(Expression.Lambda<Func<MethodMetric, double>>((Expression)rI5U0pEQVJjesR9t7S4b(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)y5L7RlEQSbsXxsEibblF());
					parameterExpression = (ParameterExpression)ht2lHQEQuhV1aIvjG2nI(Oo5lv1EQZGkM90Z95rJm(typeof(MethodMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951536768));
					MetricExcelTable<MethodMetric> metricExcelTable7 = metricExcelTable6.AddColumn(Expression.Lambda<Func<MethodMetric, double>>(Expression.Property(parameterExpression, (MethodInfo)mswLbeEQIu58PoVC1kd9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, FloatFormat.Default);
					parameterExpression = (ParameterExpression)ht2lHQEQuhV1aIvjG2nI(Oo5lv1EQZGkM90Z95rJm(typeof(MethodMetric).TypeHandle), GKJVdZEQCbq7VKdGyiMb(0x20261A4F ^ 0x2027A029));
					MetricExcelTable<MethodMetric> metricExcelTable8 = metricExcelTable7.AddColumn(Expression.Lambda<Func<MethodMetric, TimeSpan>>((Expression)rI5U0pEQVJjesR9t7S4b(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					parameterExpression = (ParameterExpression)ht2lHQEQuhV1aIvjG2nI(Oo5lv1EQZGkM90Z95rJm(typeof(MethodMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BA0F58));
					MetricExcelTable<MethodMetric> metricExcelTable9 = metricExcelTable8.AddColumn(Expression.Lambda<Func<MethodMetric, double>>((Expression)rI5U0pEQVJjesR9t7S4b(parameterExpression, (MethodInfo)mswLbeEQIu58PoVC1kd9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)y5L7RlEQSbsXxsEibblF());
					parameterExpression = Expression.Parameter(Oo5lv1EQZGkM90Z95rJm(typeof(MethodMetric).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099647183));
					_003C_003Ec__DisplayClass3_2.table = metricExcelTable9.AddColumn(Expression.Lambda<Func<MethodMetric, double>>((Expression)rI5U0pEQVJjesR9t7S4b(parameterExpression, (MethodInfo)mswLbeEQIu58PoVC1kd9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), 10.0, (IExcelCellFormat)y5L7RlEQSbsXxsEibblF());
					num2 = 5;
					continue;
				}
				case 6:
					_003C_003Ec__DisplayClass3_.table.Items = ((metricsGroup != null) ? metricsGroup.OrderBy((KeyValuePair<string, MethodMetric> s) => s.Key).ToList() : new List<KeyValuePair<string, MethodMetric>>());
					num = 3;
					break;
				}
				break;
			}
		}
	}

	internal static object GKJVdZEQCbq7VKdGyiMb(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Tc6u44EQvTxtFdOSDs5C(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool P2esNfEQf6oCVu10P23S()
	{
		return mqnLrTEQEBFdvbhlFJhJ == null;
	}

	internal static CallsStatisticsPage FxxGgNEQQ7qLTuETJKya()
	{
		return mqnLrTEQEBFdvbhlFJhJ;
	}

	internal static void PKYaO9EQ8KIyFxI17e4x(object P_0, int P_1)
	{
		((ExcelTable<KeyValuePair<string, MethodMetric>>)P_0).FixedRows = P_1;
	}

	internal static Type Oo5lv1EQZGkM90Z95rJm(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object ht2lHQEQuhV1aIvjG2nI(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object mswLbeEQIu58PoVC1kd9(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object rI5U0pEQVJjesR9t7S4b(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object y5L7RlEQSbsXxsEibblF()
	{
		return FloatFormat.Default;
	}
}
