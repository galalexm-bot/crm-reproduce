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

[ComponentOrder(60)]
internal class IndexPart : CommonInformationPart
{
	internal static IndexPart FLy586EvvhbuSpvPlg54;

	public override string Title => SR.T((string)vKy3R8Evuy6CmqWOW3Xr(-889460160 ^ -889203386));

	public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
	{
		MetricsGroup<IndexQueryMetric> source = metrics.Get<IndexQueryMetric>() ?? new MetricsGroup<IndexQueryMetric>();
		MetricsGroup<IndexCallMetric> source2 = metrics.Get<IndexCallMetric>() ?? new MetricsGroup<IndexCallMetric>();
		return new CommonInformationPartItem[6]
		{
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD39D058)),
				Value1 = source2.Sum((KeyValuePair<string, IndexCallMetric> m) => m.Value.CountCall)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x769EBE8)),
				Value1 = source2.Sum((KeyValuePair<string, IndexCallMetric> m) => m.Value.CountCancelCall)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112451798)),
				Value1 = new CellValue(source2.Sum((KeyValuePair<string, IndexCallMetric> m) => m.Value.TotalTime), new TimeSpanFormat(TimeSpanStyle.HHMMSS))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FBF4AB)),
				Value1 = source.Sum((KeyValuePair<string, IndexQueryMetric> m) => m.Value.CountCall)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20225A61)),
				Value1 = source.Sum((KeyValuePair<string, IndexQueryMetric> m) => m.Value.CountErrorCall)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x538ECDD)),
				Value1 = new CellValue(source.Sum((KeyValuePair<string, IndexQueryMetric> m) => m.Value.TotalTime), new TimeSpanFormat(TimeSpanStyle.HHMMSS))
			}
		};
	}

	public IndexPart()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CmWZQsEvIqXX9MJaQMpJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object vKy3R8Evuy6CmqWOW3Xr(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool W0bEZnEv8n3Qn4DIvwmY()
	{
		return FLy586EvvhbuSpvPlg54 == null;
	}

	internal static IndexPart grMVOcEvZw7gxp4FHRhR()
	{
		return FLy586EvvhbuSpvPlg54;
	}

	internal static void CmWZQsEvIqXX9MJaQMpJ()
	{
		SingletonReader.PushGlobal();
	}
}
