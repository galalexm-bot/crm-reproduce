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
internal class WebRequestIndexCallColumnBuilder : IPerformanceReportPageColumnBuilder
{
	private static WebRequestIndexCallColumnBuilder fecG1GEvg5nMhAyr14q3;

	public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
	{
		if (!(table is MetricExcelTable<WebRequestMetric> metricExcelTable))
		{
			return;
		}
		metricExcelTable.AddColumn(1900L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16508957)), 12.0, delegate(WebRequestMetric s)
		{
			int num7 = 1;
			int num8 = num7;
			MetricsGroup<IndexQueryMetric> metricsGroup4 = default(MetricsGroup<IndexQueryMetric>);
			while (true)
			{
				switch (num8)
				{
				default:
					if (metricsGroup4 == null)
					{
						return TimeSpan.Zero;
					}
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num8 = 2;
					}
					break;
				case 1:
					metricsGroup4 = s.Metrics.Get<IndexQueryMetric>();
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num8 = 0;
					}
					break;
				case 2:
					return metricsGroup4.Sum((KeyValuePair<string, IndexQueryMetric> c) => c.Value.TotalTime);
				}
			}
		}).AddColumn(2000L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87089885)), 10.0, delegate(WebRequestMetric s)
		{
			//Discarded unreachable code: IL_0086, IL_0095
			int num5 = 1;
			MetricsGroup<IndexQueryMetric> metricsGroup3 = default(MetricsGroup<IndexQueryMetric>);
			TimeSpan totalTime = default(TimeSpan);
			while (true)
			{
				int num6 = num5;
				while (true)
				{
					switch (num6)
					{
					case 1:
						metricsGroup3 = s.Metrics.Get<IndexQueryMetric>();
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num6 = 0;
						}
						continue;
					case 5:
						if (totalTime.Ticks == 0L)
						{
							num6 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num6 = 4;
							}
							continue;
						}
						goto case 3;
					case 2:
						goto end_IL_0012;
					default:
						if (metricsGroup3 != null)
						{
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num6 = 2;
							}
							continue;
						}
						break;
					case 3:
						return (double)metricsGroup3.Sum((KeyValuePair<string, IndexQueryMetric> c) => c.Value.TotalTime.Ticks) / (double)s.TotalTime.Ticks;
					case 4:
						break;
					}
					return 0.0;
					continue;
					end_IL_0012:
					break;
				}
				totalTime = s.TotalTime;
				num5 = 5;
			}
		}, PercentFormat.Default).AddColumn(2100L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867479503)), 10.0, delegate(WebRequestMetric s)
		{
			int num3 = 1;
			int num4 = num3;
			MetricsGroup<IndexQueryMetric> metricsGroup2 = default(MetricsGroup<IndexQueryMetric>);
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num4 = 0;
					}
					break;
				case 1:
					metricsGroup2 = s.Metrics.Get<IndexQueryMetric>();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num4 = 0;
					}
					break;
				case 2:
					return metricsGroup2.Sum((KeyValuePair<string, IndexQueryMetric> c) => c.Value.CountCall);
				}
			}
		})
			.AddColumn(2200L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309391806)), 10.0, delegate(WebRequestMetric s)
			{
				//Discarded unreachable code: IL_0035, IL_0044
				int num = 1;
				int num2 = num;
				MetricsGroup<IndexQueryMetric> metricsGroup = default(MetricsGroup<IndexQueryMetric>);
				while (true)
				{
					switch (num2)
					{
					default:
						if (metricsGroup == null)
						{
							num2 = 4;
							continue;
						}
						goto case 3;
					case 3:
						if (s.CountCall != 0L)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
							{
								num2 = 2;
							}
							continue;
						}
						break;
					case 1:
						metricsGroup = s.Metrics.Get<IndexQueryMetric>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						return metricsGroup.Sum((KeyValuePair<string, IndexQueryMetric> c) => c.Value.CountCall) / s.CountCall;
					case 4:
						break;
					}
					break;
				}
				return 0L;
			});
	}

	public WebRequestIndexCallColumnBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.PushGlobal();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool LATYvAEv5ltNkn61DPXX()
	{
		return fecG1GEvg5nMhAyr14q3 == null;
	}

	internal static WebRequestIndexCallColumnBuilder aEQBs0EvjHZYTd2y0kQp()
	{
		return fecG1GEvg5nMhAyr14q3;
	}
}
