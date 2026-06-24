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
internal class WebRequestCacheCallColumnBuilder : IPerformanceReportPageColumnBuilder
{
	internal static WebRequestCacheCallColumnBuilder CUe8u1EvdtBpPMlttUWZ;

	public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
	{
		if (!(table is MetricExcelTable<WebRequestMetric> metricExcelTable))
		{
			return;
		}
		metricExcelTable.AddColumn(1000L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103BAC8B)), 12.0, delegate(WebRequestMetric s)
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num18 = 1;
			int num19 = num18;
			MetricsGroup<CacheMetric> metricsGroup9 = default(MetricsGroup<CacheMetric>);
			while (true)
			{
				switch (num19)
				{
				default:
					if (metricsGroup9 == null)
					{
						num19 = 3;
						break;
					}
					goto case 2;
				case 1:
					metricsGroup9 = s.Metrics.Get<CacheMetric>();
					num19 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num19 = 0;
					}
					break;
				case 2:
					return metricsGroup9.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.ReadTotalTime);
				case 3:
					return TimeSpan.Zero;
				}
			}
		}).AddColumn(1100L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C4004F)), 10.0, delegate(WebRequestMetric s)
		{
			//Discarded unreachable code: IL_0054, IL_0085, IL_0094
			int num16 = 5;
			int num17 = num16;
			MetricsGroup<CacheMetric> metricsGroup8 = default(MetricsGroup<CacheMetric>);
			TimeSpan totalTime2 = default(TimeSpan);
			while (true)
			{
				switch (num17)
				{
				case 5:
					metricsGroup8 = s.Metrics.Get<CacheMetric>();
					num17 = 4;
					break;
				case 1:
					totalTime2 = s.TotalTime;
					num17 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num17 = 0;
					}
					break;
				case 4:
					if (metricsGroup8 == null)
					{
						num17 = 3;
						break;
					}
					goto case 1;
				default:
					if (totalTime2.Ticks == 0L)
					{
						num17 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num17 = 2;
						}
						break;
					}
					goto case 6;
				case 6:
					return (double)metricsGroup8.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.ReadTotalTime.Ticks) / (double)s.TotalTime.Ticks;
				case 2:
				case 3:
					return 0.0;
				}
			}
		}, PercentFormat.Default).AddColumn(1200L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE79BEF)), 10.0, delegate(WebRequestMetric s)
		{
			//Discarded unreachable code: IL_0064, IL_0073, IL_00a4
			int num13 = 2;
			int num14 = num13;
			MetricsGroup<CacheMetric> metricsGroup7 = default(MetricsGroup<CacheMetric>);
			long num15 = default(long);
			while (true)
			{
				switch (num14)
				{
				case 2:
					metricsGroup7 = s.Metrics.Get<CacheMetric>();
					num14 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num14 = 1;
					}
					break;
				case 1:
					if (metricsGroup7 != null)
					{
						num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
						{
							num14 = 5;
						}
						break;
					}
					goto case 4;
				default:
					if (num15 == 0L)
					{
						num14 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num14 = 3;
						}
						break;
					}
					goto case 6;
				case 4:
					return 0.0;
				case 5:
					num15 = metricsGroup7.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.ReadTotalCount);
					num14 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num14 = 0;
					}
					break;
				case 6:
					return (double)metricsGroup7.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.SuccesReadTotalCount) / (double)num15;
				case 3:
					return 0.0;
				}
			}
		}, PercentFormat.Default)
			.AddColumn(1300L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637A6F2F)), 10.0, delegate(WebRequestMetric s)
			{
				//Discarded unreachable code: IL_0048, IL_0057
				int num11 = 3;
				int num12 = num11;
				MetricsGroup<CacheMetric> metricsGroup6 = default(MetricsGroup<CacheMetric>);
				while (true)
				{
					switch (num12)
					{
					case 3:
						metricsGroup6 = s.Metrics.Get<CacheMetric>();
						num12 = 2;
						break;
					case 2:
						if (metricsGroup6 == null)
						{
							num12 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
							{
								num12 = 1;
							}
							break;
						}
						goto default;
					default:
						return metricsGroup6.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.ReadTotalCount);
					case 1:
						return 0L;
					}
				}
			})
			.AddColumn(1400L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459313807)), 10.0, delegate(WebRequestMetric s)
			{
				int num9 = 2;
				MetricsGroup<CacheMetric> metricsGroup5 = default(MetricsGroup<CacheMetric>);
				while (true)
				{
					int num10 = num9;
					while (true)
					{
						switch (num10)
						{
						case 3:
							if (s.CountCall != 0L)
							{
								num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num10 = 0;
								}
								continue;
							}
							break;
						case 2:
							metricsGroup5 = s.Metrics.Get<CacheMetric>();
							num10 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num10 = 0;
							}
							continue;
						case 1:
							if (metricsGroup5 == null)
							{
								break;
							}
							goto end_IL_0012;
						default:
							return metricsGroup5.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.ReadTotalCount) / s.CountCall;
						}
						return 0L;
						continue;
						end_IL_0012:
						break;
					}
					num9 = 3;
				}
			})
			.AddColumn(1500L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1AA456)), 12.0, delegate(WebRequestMetric s)
			{
				//Discarded unreachable code: IL_0031, IL_0040
				int num7 = 2;
				int num8 = num7;
				MetricsGroup<CacheMetric> metricsGroup4 = default(MetricsGroup<CacheMetric>);
				while (true)
				{
					switch (num8)
					{
					case 2:
						metricsGroup4 = s.Metrics.Get<CacheMetric>();
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num8 = 1;
						}
						break;
					case 1:
						if (metricsGroup4 == null)
						{
							num8 = 3;
							break;
						}
						goto default;
					default:
						return metricsGroup4.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.WriteTotalTime);
					case 3:
						return TimeSpan.Zero;
					}
				}
			})
			.AddColumn(1600L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A2319B)), 10.0, delegate(WebRequestMetric s)
			{
				//Discarded unreachable code: IL_0076, IL_0085, IL_0095, IL_00a4
				int num5 = 1;
				int num6 = num5;
				MetricsGroup<CacheMetric> metricsGroup3 = default(MetricsGroup<CacheMetric>);
				TimeSpan totalTime = default(TimeSpan);
				while (true)
				{
					switch (num6)
					{
					case 1:
						metricsGroup3 = s.Metrics.Get<CacheMetric>();
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num6 = 0;
						}
						break;
					case 2:
						totalTime = s.TotalTime;
						num6 = 3;
						break;
					case 3:
						if (totalTime.Ticks == 0L)
						{
							num6 = 4;
							break;
						}
						goto case 5;
					default:
						if (metricsGroup3 == null)
						{
							num6 = 6;
							break;
						}
						goto case 2;
					case 5:
						return (double)metricsGroup3.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.WriteTotalTime.Ticks) / (double)s.TotalTime.Ticks;
					case 4:
					case 6:
						return 0.0;
					}
				}
			}, PercentFormat.Default)
			.AddColumn(1700L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289469988)), 10.0, delegate(WebRequestMetric s)
			{
				//Discarded unreachable code: IL_0042, IL_0051
				int num3 = 2;
				int num4 = num3;
				MetricsGroup<CacheMetric> metricsGroup2 = default(MetricsGroup<CacheMetric>);
				while (true)
				{
					switch (num4)
					{
					case 1:
						if (metricsGroup2 == null)
						{
							num4 = 3;
							break;
						}
						goto default;
					case 2:
						metricsGroup2 = s.Metrics.Get<CacheMetric>();
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num4 = 0;
						}
						break;
					default:
						return metricsGroup2.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.WriteTotalCount);
					case 3:
						return 0L;
					}
				}
			})
			.AddColumn(1800L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548FE620)), 10.0, delegate(WebRequestMetric s)
			{
				int num = 3;
				int num2 = num;
				MetricsGroup<CacheMetric> metricsGroup = default(MetricsGroup<CacheMetric>);
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (s.CountCall != 0L)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 2:
						if (metricsGroup != null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 3:
						metricsGroup = s.Metrics.Get<CacheMetric>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 2;
						}
						continue;
					default:
						return metricsGroup.Sum((KeyValuePair<string, CacheMetric> c) => c.Value.WriteTotalCount) / s.CountCall;
					}
					break;
				}
				return 0L;
			});
	}

	public WebRequestCacheCallColumnBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool lDkgljEvllQFoXtTfc8A()
	{
		return CUe8u1EvdtBpPMlttUWZ == null;
	}

	internal static WebRequestCacheCallColumnBuilder SW4BBkEvrMgkBotvahYD()
	{
		return CUe8u1EvdtBpPMlttUWZ;
	}
}
