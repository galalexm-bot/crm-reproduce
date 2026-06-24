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
internal class BackgroundTasksCacheCallColumnBuilder : IPerformanceReportPageColumnBuilder
{
	internal static BackgroundTasksCacheCallColumnBuilder Ttb03UEvywiR7mKT40jV;

	public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
	{
		if (!(table is MetricExcelTable<BackgroundTaskMetric> metricExcelTable))
		{
			return;
		}
		metricExcelTable.AddColumn(1000L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7B77EC)), 12.0, delegate(BackgroundTaskMetric s)
		{
			int num18 = 2;
			int num19 = num18;
			MetricsGroup<CacheMetric> metricsGroup9 = default(MetricsGroup<CacheMetric>);
			while (true)
			{
				switch (num19)
				{
				case 1:
					if (metricsGroup9 == null)
					{
						return TimeSpan.Zero;
					}
					num19 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num19 = 0;
					}
					break;
				case 2:
					metricsGroup9 = s.Metrics.Get<CacheMetric>();
					num19 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num19 = 1;
					}
					break;
				default:
					return metricsGroup9.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.ReadTotalTime);
				}
			}
		}).AddColumn(1100L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8353206)), 10.0, delegate(BackgroundTaskMetric s)
		{
			//Discarded unreachable code: IL_0075, IL_0084, IL_00aa, IL_00b9
			int num16 = 5;
			int num17 = num16;
			MetricsGroup<CacheMetric> metricsGroup8 = default(MetricsGroup<CacheMetric>);
			TimeSpan totalTime2 = default(TimeSpan);
			while (true)
			{
				switch (num17)
				{
				case 4:
					if (metricsGroup8 == null)
					{
						num17 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num17 = 0;
						}
						break;
					}
					goto case 1;
				case 5:
					metricsGroup8 = s.Metrics.Get<CacheMetric>();
					num17 = 4;
					break;
				case 6:
					if (totalTime2.Ticks == 0L)
					{
						num17 = 2;
						break;
					}
					goto case 3;
				case 1:
					totalTime2 = s.TotalTime;
					num17 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num17 = 6;
					}
					break;
				case 3:
					return (double)metricsGroup8.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.ReadTotalTime.Ticks) / (double)s.TotalTime.Ticks;
				default:
					return 0.0;
				}
			}
		}, PercentFormat.Default).AddColumn(1200L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A23079)), 10.0, delegate(BackgroundTaskMetric s)
		{
			//Discarded unreachable code: IL_0092
			int num13 = 3;
			int num14 = num13;
			MetricsGroup<CacheMetric> metricsGroup7 = default(MetricsGroup<CacheMetric>);
			long num15 = default(long);
			while (true)
			{
				switch (num14)
				{
				case 2:
					if (metricsGroup7 == null)
					{
						num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
						{
							num14 = 0;
						}
					}
					else
					{
						num15 = metricsGroup7.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.ReadTotalCount);
						num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num14 = 1;
						}
					}
					break;
				case 3:
					metricsGroup7 = s.Metrics.Get<CacheMetric>();
					num14 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num14 = 2;
					}
					break;
				case 1:
					if (num15 == 0L)
					{
						num14 = 4;
						break;
					}
					goto case 5;
				default:
					return 0.0;
				case 5:
					return (double)metricsGroup7.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.SuccesReadTotalCount) / (double)num15;
				case 4:
					return 0.0;
				}
			}
		}, PercentFormat.Default)
			.AddColumn(1300L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x511144A9)), 10.0, delegate(BackgroundTaskMetric s)
			{
				//Discarded unreachable code: IL_0079
				int num11 = 1;
				int num12 = num11;
				MetricsGroup<CacheMetric> metricsGroup6 = default(MetricsGroup<CacheMetric>);
				while (true)
				{
					switch (num12)
					{
					default:
						if (metricsGroup6 == null)
						{
							num12 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
							{
								num12 = 1;
							}
							break;
						}
						goto case 3;
					case 1:
						metricsGroup6 = s.Metrics.Get<CacheMetric>();
						num12 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num12 = 0;
						}
						break;
					case 3:
						return metricsGroup6.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.ReadTotalCount);
					case 2:
						return 0L;
					}
				}
			})
			.AddColumn(1400L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35748057)), 10.0, delegate(BackgroundTaskMetric s)
			{
				//Discarded unreachable code: IL_0082, IL_0091
				int num9 = 3;
				int num10 = num9;
				MetricsGroup<CacheMetric> metricsGroup5 = default(MetricsGroup<CacheMetric>);
				while (true)
				{
					switch (num10)
					{
					default:
						if (s.CountCall != 0L)
						{
							num10 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num10 = 0;
							}
							continue;
						}
						break;
					case 2:
						if (metricsGroup5 == null)
						{
							num10 = 4;
							continue;
						}
						goto default;
					case 3:
						metricsGroup5 = s.Metrics.Get<CacheMetric>();
						num10 = 2;
						continue;
					case 1:
						return metricsGroup5.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.ReadTotalCount) / s.CountCall;
					case 4:
						break;
					}
					break;
				}
				return 0L;
			})
			.AddColumn(1500L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675750159)), 12.0, delegate(BackgroundTaskMetric s)
			{
				int num7 = 1;
				int num8 = num7;
				MetricsGroup<CacheMetric> metricsGroup4 = default(MetricsGroup<CacheMetric>);
				while (true)
				{
					switch (num8)
					{
					case 1:
						metricsGroup4 = s.Metrics.Get<CacheMetric>();
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num8 = 0;
						}
						break;
					default:
						if (metricsGroup4 == null)
						{
							return TimeSpan.Zero;
						}
						num8 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
						{
							num8 = 2;
						}
						break;
					case 2:
						return metricsGroup4.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.WriteTotalTime);
					}
				}
			})
			.AddColumn(1600L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341C19D1)), 10.0, delegate(BackgroundTaskMetric s)
			{
				//Discarded unreachable code: IL_0074, IL_0083
				int num5 = 1;
				MetricsGroup<CacheMetric> metricsGroup3 = default(MetricsGroup<CacheMetric>);
				TimeSpan totalTime = default(TimeSpan);
				while (true)
				{
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						default:
							if (metricsGroup3 == null)
							{
								break;
							}
							goto end_IL_0012;
						case 4:
							if (totalTime.Ticks == 0L)
							{
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num6 = 2;
								}
								continue;
							}
							goto case 5;
						case 3:
							totalTime = s.TotalTime;
							num6 = 4;
							continue;
						case 1:
							metricsGroup3 = s.Metrics.Get<CacheMetric>();
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num6 = 0;
							}
							continue;
						case 5:
							return (double)metricsGroup3.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.WriteTotalTime.Ticks) / (double)s.TotalTime.Ticks;
						case 2:
							break;
						}
						return 0.0;
						continue;
						end_IL_0012:
						break;
					}
					num5 = 3;
				}
			}, PercentFormat.Default)
			.AddColumn(1700L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307AD867)), 10.0, delegate(BackgroundTaskMetric s)
			{
				int num3 = 1;
				int num4 = num3;
				MetricsGroup<CacheMetric> metricsGroup2 = default(MetricsGroup<CacheMetric>);
				while (true)
				{
					switch (num4)
					{
					default:
						if (metricsGroup2 == null)
						{
							return 0L;
						}
						num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num4 = 2;
						}
						break;
					case 1:
						metricsGroup2 = s.Metrics.Get<CacheMetric>();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num4 = 0;
						}
						break;
					case 2:
						return metricsGroup2.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.WriteTotalCount);
					}
				}
			})
			.AddColumn(1800L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7243457C)), 10.0, delegate(BackgroundTaskMetric s)
			{
				//Discarded unreachable code: IL_0039, IL_006d
				int num = 2;
				int num2 = num;
				MetricsGroup<CacheMetric> metricsGroup = default(MetricsGroup<CacheMetric>);
				while (true)
				{
					switch (num2)
					{
					case 4:
						if (s.CountCall == 0L)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 5;
					case 1:
						if (metricsGroup == null)
						{
							num2 = 3;
							break;
						}
						goto case 4;
					case 2:
						metricsGroup = s.Metrics.Get<CacheMetric>();
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 1;
						}
						break;
					case 5:
						return metricsGroup.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.WriteTotalCount) / s.CountCall;
					default:
						return 0L;
					}
				}
			});
	}

	public BackgroundTasksCacheCallColumnBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RtWXKEEv9o2JIOJddS2q();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void RtWXKEEv9o2JIOJddS2q()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool tcGmWaEvMpu8erOZHSy7()
	{
		return Ttb03UEvywiR7mKT40jV == null;
	}

	internal static BackgroundTasksCacheCallColumnBuilder vJufgOEvJLIk4IjPBvkY()
	{
		return Ttb03UEvywiR7mKT40jV;
	}
}
