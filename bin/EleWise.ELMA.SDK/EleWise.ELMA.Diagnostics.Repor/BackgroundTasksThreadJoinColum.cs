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
internal class BackgroundTasksThreadJoinColumnBuilder : IPerformanceReportPageColumnBuilder
{
	private static BackgroundTasksThreadJoinColumnBuilder FYKj9WEvxNj9YUoRRoOX;

	public void AddColumn<TMetric>(MetricExcelTable<TMetric> table) where TMetric : IMetric
	{
		if (!(table is MetricExcelTable<BackgroundTaskMetric> metricExcelTable))
		{
			return;
		}
		metricExcelTable.AddColumn(330L, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87092761)), 10.0, delegate(BackgroundTaskMetric s)
		{
			int num = 3;
			MetricsGroup<ThreadJoinMetric> metricsGroup = default(MetricsGroup<ThreadJoinMetric>);
			TimeSpan timeSpan = default(TimeSpan);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (metricsGroup != null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						return 0.0;
					case 3:
						break;
					default:
						return timeSpan.TotalMilliseconds;
					case 1:
						timeSpan = metricsGroup.Sum((KeyValuePair<string, ThreadJoinMetric> c) => c.Value.TotalTime);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				metricsGroup = s.Metrics.Get<ThreadJoinMetric>();
				num = 2;
			}
		});
	}

	public BackgroundTasksThreadJoinColumnBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool N1i6vHEv0bbWb0vXcsXK()
	{
		return FYKj9WEvxNj9YUoRRoOX == null;
	}

	internal static BackgroundTasksThreadJoinColumnBuilder DFgIVvEvmWp31khZBJxu()
	{
		return FYKj9WEvxNj9YUoRRoOX;
	}
}
