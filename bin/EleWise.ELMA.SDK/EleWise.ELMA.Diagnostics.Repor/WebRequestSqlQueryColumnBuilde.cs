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
internal class WebRequestSqlQueryColumnBuilder : IPerformanceReportPageColumnBuilder
{
	internal static WebRequestSqlQueryColumnBuilder JbcHcOEvs6c4Pva7m54y;

	public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
	{
		if (!(table is MetricExcelTable<WebRequestMetric> metricExcelTable))
		{
			return;
		}
		metricExcelTable.AddColumn(600L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x7699EFC)), 10.0, delegate(WebRequestMetric s)
		{
			int num7 = 2;
			int num8 = num7;
			MetricsGroup<SqlQueryMetric> metricsGroup4 = default(MetricsGroup<SqlQueryMetric>);
			while (true)
			{
				switch (num8)
				{
				case 1:
					if (metricsGroup4 == null)
					{
						return TimeSpan.Zero;
					}
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num8 = 0;
					}
					break;
				case 2:
					metricsGroup4 = s.Metrics.Get<SqlQueryMetric>();
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num8 = 1;
					}
					break;
				default:
					return metricsGroup4.Sum((KeyValuePair<string, SqlQueryMetric> c) => c.Value.TotalTime);
				}
			}
		}).AddColumn(700L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CF0CF9)), 10.0, delegate(WebRequestMetric s)
		{
			//Discarded unreachable code: IL_00a9
			int num5 = 2;
			int num6 = num5;
			TimeSpan totalTime = default(TimeSpan);
			MetricsGroup<SqlQueryMetric> metricsGroup3 = default(MetricsGroup<SqlQueryMetric>);
			while (true)
			{
				switch (num6)
				{
				case 3:
					totalTime = s.TotalTime;
					num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num6 = 0;
					}
					continue;
				case 1:
					if (metricsGroup3 == null)
					{
						num6 = 4;
						continue;
					}
					goto case 3;
				case 2:
					metricsGroup3 = s.Metrics.Get<SqlQueryMetric>();
					num6 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num6 = 1;
					}
					continue;
				default:
					if (totalTime.Ticks != 0L)
					{
						num6 = 5;
						continue;
					}
					break;
				case 5:
					return (double)metricsGroup3.Sum((KeyValuePair<string, SqlQueryMetric> c) => c.Value.TotalTime.Ticks) / (double)s.TotalTime.Ticks;
				case 4:
					break;
				}
				break;
			}
			return 0.0;
		}, PercentFormat.Default).AddColumn(800L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542968977)), 10.0, delegate(WebRequestMetric s)
		{
			//Discarded unreachable code: IL_0058, IL_0067
			int num3 = 2;
			MetricsGroup<SqlQueryMetric> metricsGroup2 = default(MetricsGroup<SqlQueryMetric>);
			while (true)
			{
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 2:
						metricsGroup2 = s.Metrics.Get<SqlQueryMetric>();
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num4 = 1;
						}
						continue;
					case 1:
						if (metricsGroup2 == null)
						{
							break;
						}
						goto default;
					default:
						return metricsGroup2.Sum((KeyValuePair<string, SqlQueryMetric> c) => c.Value.CountCall);
					case 3:
						return 0L;
					}
					break;
				}
				num3 = 3;
			}
		})
			.AddColumn(900L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341C15FB)), 10.0, delegate(WebRequestMetric s)
			{
				int num = 3;
				int num2 = num;
				MetricsGroup<SqlQueryMetric> metricsGroup = default(MetricsGroup<SqlQueryMetric>);
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (metricsGroup != null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						break;
					case 1:
						if (s.CountCall != 0L)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 3:
						metricsGroup = s.Metrics.Get<SqlQueryMetric>();
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 2;
						}
						continue;
					default:
						return metricsGroup.Sum((KeyValuePair<string, SqlQueryMetric> c) => c.Value.CountCall) / s.CountCall;
					}
					break;
				}
				return 0L;
			});
	}

	public WebRequestSqlQueryColumnBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool AisNwJEvcO9KNiHyqZO7()
	{
		return JbcHcOEvs6c4Pva7m54y == null;
	}

	internal static WebRequestSqlQueryColumnBuilder JwfbNsEvzverX27bkW4O()
	{
		return JbcHcOEvs6c4Pva7m54y;
	}
}
