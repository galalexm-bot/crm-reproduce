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

[ComponentOrder(20)]
internal class BackgroundTasksPart : CommonInformationPart
{
	internal static BackgroundTasksPart dDIXMkEveieq48MHUXZa;

	public override string Title => (string)AoXZwBEv3C0jWGbkVNev(ju9JRyEvNV0VSExLDq6W(-675505729 ^ -675763121));

	public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
	{
		MetricsGroup<BackgroundTaskMetric> metricsGroup = metrics.Get<BackgroundTaskMetric>();
		if (metricsGroup == null)
		{
			return new CommonInformationPartItem[0];
		}
		return new CommonInformationPartItem[3]
		{
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195859813)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, BackgroundTaskMetric> m) => m.Value.CountCall)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1871171083)),
				Value1 = new CellValue(metricsGroup.Sum((KeyValuePair<string, BackgroundTaskMetric> m) => m.Value.TotalTime), new TimeSpanFormat(TimeSpanStyle.HHMMSS))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A85FDBA)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, BackgroundTaskMetric> m) => m.Value.CountErrorCall)
			}
		};
	}

	public BackgroundTasksPart()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ps2TluEvpdroRRmZbAIO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object ju9JRyEvNV0VSExLDq6W(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object AoXZwBEv3C0jWGbkVNev(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool X3gtN1EvPd3KTuGFuW9H()
	{
		return dDIXMkEveieq48MHUXZa == null;
	}

	internal static BackgroundTasksPart cI3QemEv1e6GNsCdMPwZ()
	{
		return dDIXMkEveieq48MHUXZa;
	}

	internal static void Ps2TluEvpdroRRmZbAIO()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
