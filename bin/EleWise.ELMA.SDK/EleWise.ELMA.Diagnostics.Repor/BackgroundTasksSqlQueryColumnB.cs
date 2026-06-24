using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders;

[Component]
internal class BackgroundTasksSqlQueryColumnBuilder : IPerformanceReportPageColumnBuilder
{
	private static BackgroundTasksSqlQueryColumnBuilder Pqs2kwEvY9hZintW3qX3;

	public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
	{
		if (!(table is MetricExcelTable<BackgroundTaskMetric> metricExcelTable))
		{
			return;
		}
		metricExcelTable.AddColumn(600L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107734420)), 10.0, delegate(BackgroundTaskMetric s)
		{
			int num7 = 2;
			int num8 = num7;
			MetricsGroup<SqlQueryMetric> metricsGroup4 = default(MetricsGroup<SqlQueryMetric>);
			while (true)
			{
				switch (num8)
				{
				case 2:
					metricsGroup4 = s.Metrics.Get<SqlQueryMetric>();
					num8 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num8 = 0;
					}
					break;
				case 1:
					if (metricsGroup4 == null)
					{
						return TimeSpan.Zero;
					}
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num8 = 0;
					}
					break;
				default:
					return metricsGroup4.Sum((KeyValuePair<string, SqlQueryMetric> c) => c.Value.TotalTime);
				}
			}
		}).AddColumn(700L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE16637D)), 10.0, delegate(BackgroundTaskMetric s)
		{
			//Discarded unreachable code: IL_00a9, IL_00b8
			int num5 = 4;
			int num6 = num5;
			TimeSpan totalTime = default(TimeSpan);
			MetricsGroup<SqlQueryMetric> metricsGroup3 = default(MetricsGroup<SqlQueryMetric>);
			while (true)
			{
				switch (num6)
				{
				case 5:
					if (totalTime.Ticks == 0L)
					{
						num6 = 2;
						continue;
					}
					goto case 1;
				case 3:
					if (metricsGroup3 != null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num6 = 0;
						}
						continue;
					}
					break;
				case 4:
					metricsGroup3 = s.Metrics.Get<SqlQueryMetric>();
					num6 = 3;
					continue;
				default:
					totalTime = s.TotalTime;
					num6 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num6 = 0;
					}
					continue;
				case 1:
					return (double)metricsGroup3.Sum((KeyValuePair<string, SqlQueryMetric> c) => c.Value.TotalTime.Ticks) / (double)s.TotalTime.Ticks;
				case 2:
					break;
				}
				break;
			}
			return 0.0;
		}, PercentFormat.Default).AddColumn(800L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675753139)), 10.0, delegate(BackgroundTaskMetric s)
		{
			//Discarded unreachable code: IL_0079, IL_0088
			int num3 = 1;
			int num4 = num3;
			MetricsGroup<SqlQueryMetric> metricsGroup2 = default(MetricsGroup<SqlQueryMetric>);
			while (true)
			{
				switch (num4)
				{
				case 1:
					metricsGroup2 = s.Metrics.Get<SqlQueryMetric>();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num4 = 0;
					}
					break;
				default:
					if (metricsGroup2 == null)
					{
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num4 = 2;
						}
						break;
					}
					goto case 3;
				case 3:
					return metricsGroup2.Sum((KeyValuePair<string, SqlQueryMetric> c) => c.Value.CountCall);
				case 2:
					return 0L;
				}
			}
		})
			.AddColumn(900L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BFFE02)), 10.0, delegate(BackgroundTaskMetric s)
			{
				//Discarded unreachable code: IL_0092, IL_00a1
				int num = 4;
				int num2 = num;
				MetricsGroup<SqlQueryMetric> metricsGroup = default(MetricsGroup<SqlQueryMetric>);
				while (true)
				{
					switch (num2)
					{
					default:
						if (s.CountCall != 0L)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
							{
								num2 = 2;
							}
							continue;
						}
						break;
					case 3:
						if (metricsGroup == null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto default;
					case 4:
						metricsGroup = s.Metrics.Get<SqlQueryMetric>();
						num2 = 3;
						continue;
					case 2:
						return metricsGroup.Sum((KeyValuePair<string, SqlQueryMetric> c) => c.Value.CountCall) / s.CountCall;
					case 1:
						break;
					}
					break;
				}
				return 0L;
			});
	}

	public BackgroundTasksSqlQueryColumnBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool sbdC24EvLuuXJu9igy4q()
	{
		return Pqs2kwEvY9hZintW3qX3 == null;
	}

	internal static BackgroundTasksSqlQueryColumnBuilder QDlc4ZEvUS5PcgrX3yx4()
	{
		return Pqs2kwEvY9hZintW3qX3;
	}
}
