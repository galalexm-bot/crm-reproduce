using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Performance.ColumnBuilders;

[Component]
internal class WebRequestThreadJoinColumnBuilder : IPerformanceReportPageColumnBuilder
{
	internal static WebRequestThreadJoinColumnBuilder mDh1laEvH5MBqOVIiEri;

	public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
	{
		if (!(table is MetricExcelTable<WebRequestMetric> metricExcelTable))
		{
			return;
		}
		metricExcelTable.AddColumn(330L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D185B74)), 10.0, delegate(WebRequestMetric s)
		{
			int num = 2;
			int num2 = num;
			TimeSpan timeSpan = default(TimeSpan);
			MetricsGroup<ThreadJoinMetric> metricsGroup = default(MetricsGroup<ThreadJoinMetric>);
			while (true)
			{
				switch (num2)
				{
				default:
					return timeSpan.TotalMilliseconds;
				case 2:
					metricsGroup = s.Metrics.Get<ThreadJoinMetric>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (metricsGroup == null)
					{
						return 0.0;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					timeSpan = metricsGroup.Sum((KeyValuePair<string, ThreadJoinMetric> c) => c.Value.TotalTime);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	public WebRequestThreadJoinColumnBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool qLTjwUEvAcMHvEX5RR06()
	{
		return mDh1laEvH5MBqOVIiEri == null;
	}

	internal static WebRequestThreadJoinColumnBuilder uILbsGEv7uWvM3Ba8qHc()
	{
		return mDh1laEvH5MBqOVIiEri;
	}
}
