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

[ComponentOrder(10)]
internal class WebRequestsPart : CommonInformationPart
{
	internal static WebRequestsPart VbK8WdEvaW6YbsJ1Jvrk;

	public override string Title => (string)YUM9ntEv4BlhVEWnps6m(ftHfbvEvwxxPJIC9QADt(0x12A5FAC7 ^ 0x12A1C03B));

	public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
	{
		MetricsGroup<WebRequestMetric> metricsGroup = metrics.Get<WebRequestMetric>();
		if (metricsGroup == null)
		{
			return new CommonInformationPartItem[0];
		}
		long num = metricsGroup.Sum((KeyValuePair<string, WebRequestMetric> m) => m.Value.CountCall);
		return new CommonInformationPartItem[4]
		{
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC503C4)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, WebRequestMetric> m) => m.Value.CountCall)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -584022958)),
				Value1 = new CellValue(metricsGroup.Sum((KeyValuePair<string, WebRequestMetric> m) => m.Value.TotalTime), new TimeSpanFormat(TimeSpanStyle.HHMMSS))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F1226C)),
				Value1 = ((num == 0L) ? 0 : ((long)metricsGroup.Sum((KeyValuePair<string, WebRequestMetric> m) => (double)m.Value.CountCall * m.Value.AvgTime) / num))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410950015)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, WebRequestMetric> m) => m.Value.CountErrorCall)
			}
		};
	}

	public WebRequestsPart()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YGaFdgEv6dtDNMfjwtce();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object ftHfbvEvwxxPJIC9QADt(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object YUM9ntEv4BlhVEWnps6m(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool tVp2hMEvDZ9KVjmgTwuG()
	{
		return VbK8WdEvaW6YbsJ1Jvrk == null;
	}

	internal static WebRequestsPart EiRBCREvtZQDT1lhUq63()
	{
		return VbK8WdEvaW6YbsJ1Jvrk;
	}

	internal static void YGaFdgEv6dtDNMfjwtce()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
