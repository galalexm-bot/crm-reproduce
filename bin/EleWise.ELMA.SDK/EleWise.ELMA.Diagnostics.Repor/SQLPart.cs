using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts;

[ComponentOrder(40)]
internal class SQLPart : CommonInformationPart
{
	internal static SQLPart M5Rl1lEvXEjUH8LTcYT5;

	public override string Title => (string)qeVhp7EvOy8CrEhJTUlf(mm9duBEvnEanup7bNaKv(0x66F566B6 ^ 0x66F14D88));

	public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
	{
		MetricsGroup<SqlQueryMetric> metricsGroup = metrics.Get<SqlQueryMetric>();
		if (metricsGroup == null)
		{
			return new CommonInformationPartItem[0];
		}
		MetricsGroup<WebRequestMetric> metricsGroup2 = metrics.Get<WebRequestMetric>();
		MetricsGroup<BackgroundTaskMetric> metricsGroup3 = metrics.Get<BackgroundTaskMetric>();
		long num = (metricsGroup2?.Sum((KeyValuePair<string, WebRequestMetric> m) => m.Value.TotalTime.Ticks) ?? 0) + (metricsGroup3?.Sum((KeyValuePair<string, BackgroundTaskMetric> m) => m.Value.TotalTime.Ticks) ?? 0);
		return new CommonInformationPartItem[3]
		{
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7E85631)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, SqlQueryMetric> m) => m.Value.CountCall)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F49B2B3)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, SqlQueryMetric> m) => m.Value.CountErrorCall)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099506127)),
				Value1 = new CellValue(metricsGroup.Sum((KeyValuePair<string, SqlQueryMetric> m) => m.Value.TotalTime), new TimeSpanFormat(TimeSpanStyle.HHMMSS)),
				Value2 = new CellValue((num == 0L) ? 0.0 : ((double)metricsGroup.Sum((KeyValuePair<string, SqlQueryMetric> m) => m.Value.TotalTime.Ticks) / (double)num), PercentFormat.Default)
			}
		};
	}

	public SQLPart()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AQIbefEv24lwIsjkU44S();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object mm9duBEvnEanup7bNaKv(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qeVhp7EvOy8CrEhJTUlf(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool XrDxNbEvTnLVH4MH6swC()
	{
		return M5Rl1lEvXEjUH8LTcYT5 == null;
	}

	internal static SQLPart c00nhfEvkSDYMRoMiqBv()
	{
		return M5Rl1lEvXEjUH8LTcYT5;
	}

	internal static void AQIbefEv24lwIsjkU44S()
	{
		SingletonReader.PushGlobal();
	}
}
