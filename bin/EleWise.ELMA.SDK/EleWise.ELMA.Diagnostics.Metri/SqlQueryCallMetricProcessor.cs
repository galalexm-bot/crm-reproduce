using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Processors;

[Component]
public class SqlQueryCallMetricProcessor : IMetricProcessor
{
	internal static SqlQueryCallMetricProcessor NVJ7sZEIKsNUgDdMT56C;

	public Type[] AggregatorTypes => new Type[1] { TypeOf<SqlQueryCallMetricAggregator>.Raw };

	public void Process(object callInfo, IMetric currentMetric)
	{
		//Discarded unreachable code: IL_005d, IL_006c
		int num = 8;
		SqlQueryMetric sqlQueryMetric = default(SqlQueryMetric);
		SqlQueryInfo sqlQueryInfo = default(SqlQueryInfo);
		TimeSpan totalTime = default(TimeSpan);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					return;
				case 10:
					if ((double)bpoMfOEI1pj9u06CQHK1(sqlQueryMetric) < tPTISAEINWgFWxy4aoCY(sqlQueryInfo).TotalMilliseconds)
					{
						goto end_IL_0012;
					}
					goto case 12;
				case 3:
					if (sqlQueryMetric == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						totalTime = sqlQueryInfo.TotalTime;
						num2 = 6;
					}
					continue;
				case 4:
					if (sqlQueryInfo == null)
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 1:
					return;
				default:
					if (A1YphrEIPars2Wedis11(sqlQueryInfo))
					{
						num2 = 10;
						continue;
					}
					break;
				case 13:
					K00kpgEI32X1l9cQCygC(sqlQueryMetric, (long)tPTISAEINWgFWxy4aoCY(sqlQueryInfo).TotalMilliseconds);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 12;
					}
					continue;
				case 8:
					sqlQueryInfo = callInfo as SqlQueryInfo;
					num2 = 7;
					continue;
				case 9:
					return;
				case 6:
					if ((double)KpcRy4EIkb0Xd8LTuSRt(sqlQueryMetric) < totalTime.TotalMilliseconds)
					{
						num2 = 2;
						continue;
					}
					goto case 11;
				case 2:
					tuDTtwEInj4dgQcuqCDe(sqlQueryMetric, (long)totalTime.TotalMilliseconds);
					num2 = 11;
					continue;
				case 7:
					sqlQueryMetric = currentMetric as SqlQueryMetric;
					num2 = 4;
					continue;
				case 11:
					aWTfiOEIeLLEqn5WoJuG(sqlQueryMetric, (nwi4H3EIOAYSYwshUZFc(sqlQueryMetric) != 0L) ? ((long)(qOOjivEI2WZkfbJEV2uA(sqlQueryMetric) * (double)(nwi4H3EIOAYSYwshUZFc(sqlQueryMetric) - 1) + totalTime.TotalMilliseconds) / sqlQueryMetric.CountCall) : 0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					i6eqYmEIavAO4M1wUgIa(sqlQueryMetric, (nwi4H3EIOAYSYwshUZFc(sqlQueryMetric) != 0L) ? ((long)(mQq0d1EIpfvJsldgGpch(sqlQueryMetric) * (double)(nwi4H3EIOAYSYwshUZFc(sqlQueryMetric) - 1) + tPTISAEINWgFWxy4aoCY(sqlQueryInfo).TotalMilliseconds) / sqlQueryMetric.CountCall) : 0);
					num2 = 5;
					continue;
				case 5:
					break;
				}
				SqlQueryMetric sqlQueryMetric2 = sqlQueryMetric;
				uQky2yEIDqxa0byrbW10(sqlQueryMetric2, sqlQueryMetric2.TotalAffectedRows + (sqlQueryInfo.RowsAffected.HasValue ? sqlQueryInfo.RowsAffected.Value : 0));
				num2 = 9;
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	public SqlQueryCallMetricProcessor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		naSvwmEItxiqAZdoC1UQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zB4NMrEIXVwXIx2wnTE2()
	{
		return NVJ7sZEIKsNUgDdMT56C == null;
	}

	internal static SqlQueryCallMetricProcessor fqU4HyEITf4HM86CBvv3()
	{
		return NVJ7sZEIKsNUgDdMT56C;
	}

	internal static long KpcRy4EIkb0Xd8LTuSRt(object P_0)
	{
		return ((SqlQueryMetric)P_0).MaxExecuteTime;
	}

	internal static void tuDTtwEInj4dgQcuqCDe(object P_0, long value)
	{
		((SqlQueryMetric)P_0).MaxExecuteTime = value;
	}

	internal static long nwi4H3EIOAYSYwshUZFc(object P_0)
	{
		return ((CountMetric)P_0).CountCall;
	}

	internal static double qOOjivEI2WZkfbJEV2uA(object P_0)
	{
		return ((SqlQueryMetric)P_0).AvgExecuteTime;
	}

	internal static void aWTfiOEIeLLEqn5WoJuG(object P_0, double value)
	{
		((SqlQueryMetric)P_0).AvgExecuteTime = value;
	}

	internal static bool A1YphrEIPars2Wedis11(object P_0)
	{
		return ((SqlQueryInfo)P_0).IsPrepare;
	}

	internal static long bpoMfOEI1pj9u06CQHK1(object P_0)
	{
		return ((SqlQueryMetric)P_0).MaxPrepareTime;
	}

	internal static TimeSpan tPTISAEINWgFWxy4aoCY(object P_0)
	{
		return ((AbstractCallInfo)P_0).TotalTime;
	}

	internal static void K00kpgEI32X1l9cQCygC(object P_0, long value)
	{
		((SqlQueryMetric)P_0).MaxPrepareTime = value;
	}

	internal static double mQq0d1EIpfvJsldgGpch(object P_0)
	{
		return ((SqlQueryMetric)P_0).AvgPrepareTime;
	}

	internal static void i6eqYmEIavAO4M1wUgIa(object P_0, double value)
	{
		((SqlQueryMetric)P_0).AvgPrepareTime = value;
	}

	internal static void uQky2yEIDqxa0byrbW10(object P_0, long value)
	{
		((SqlQueryMetric)P_0).TotalAffectedRows = value;
	}

	internal static void naSvwmEItxiqAZdoC1UQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
