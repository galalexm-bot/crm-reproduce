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

namespace EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts;

[ComponentOrder(50)]
internal class CachePart : CommonInformationPart
{
	internal static CachePart msk9wEEvEEKgaerwewjl;

	public override string Title => (string)D3tkuqEvCuUWpm6AQ2Sf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886898597));

	public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
	{
		MetricsGroup<CacheMetric> metricsGroup = metrics.Get<CacheMetric>();
		if (metricsGroup == null)
		{
			return new CommonInformationPartItem[0];
		}
		MetricsGroup<WebRequestMetric> metricsGroup2 = metrics.Get<WebRequestMetric>();
		MetricsGroup<BackgroundTaskMetric> metricsGroup3 = metrics.Get<BackgroundTaskMetric>();
		long num = (metricsGroup2?.Sum((KeyValuePair<string, WebRequestMetric> m) => m.Value.TotalTime.Ticks) ?? 0) + (metricsGroup3?.Sum((KeyValuePair<string, BackgroundTaskMetric> m) => m.Value.TotalTime.Ticks) ?? 0);
		long num2 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.CountCall);
		long num3 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.ReadTotalCount);
		long num4 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.WriteTotalCount);
		long num5 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.LockTotalCount);
		return new CommonInformationPartItem[17]
		{
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x426009DD)),
				Value1 = ((num2 == 0L) ? 0.0 : Math.Round(metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.AvgTime * (double)m.Value.CountCall) / (double)num2, 3))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC57BA8)),
				Value1 = new CellValue(metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.TotalTime), new TimeSpanFormat(TimeSpanStyle.HHMMSS)),
				Value2 = new CellValue((double)metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.TotalTime.Ticks) / (double)num, PercentFormat.Default)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853108682)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.CountCall)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335254951)),
				Value1 = ((num3 == 0L) ? 0.0 : Math.Round(metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.AvgReadTime * (double)m.Value.ReadTotalCount) / (double)num3, 3))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978209198)),
				Value1 = new CellValue(metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.ReadTotalTime), new TimeSpanFormat(TimeSpanStyle.HHMMSS)),
				Value2 = new CellValue((num == 0L) ? 0.0 : ((double)metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.ReadTotalTime.Ticks) / (double)num), PercentFormat.Default)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72433E40)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.ReadTotalCount)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459300397)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.ReadErrorTotalCount),
				Value2 = new CellValue((num3 == 0L) ? 0.0 : ((double)metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.ReadErrorTotalCount) / (double)num3), PercentFormat.Default)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710322216)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.SuccesReadTotalCount),
				Value2 = new CellValue((num3 == 0L) ? 0.0 : ((double)metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.SuccesReadTotalCount) / (double)num3), PercentFormat.Default)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6384A8A9)),
				Value1 = ((num4 == 0L) ? 0.0 : Math.Round(metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.AvgWriteTime * (double)m.Value.WriteTotalCount) / (double)num4, 3))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A3DEC6)),
				Value1 = new CellValue(metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.WriteTotalTime), new TimeSpanFormat(TimeSpanStyle.HHMMSS)),
				Value2 = new CellValue((num == 0L) ? 0.0 : ((double)metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.WriteTotalTime.Ticks) / (double)num), PercentFormat.Default)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F15B00)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.WriteTotalCount)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767472091)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.WriteErrorTotalCount),
				Value2 = new CellValue((num4 == 0L) ? 0.0 : ((double)metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.WriteErrorTotalCount) / (double)num4), PercentFormat.Default)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7B0FEC)),
				Value1 = ((num5 == 0L) ? 0.0 : Math.Round(metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.AvgLockTime * (double)m.Value.LockTotalCount) / (double)num5, 3))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x124022F4)),
				Value1 = new CellValue(metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.LockTotalTime), new TimeSpanFormat(TimeSpanStyle.HHMMSS)),
				Value2 = new CellValue((num == 0L) ? 0.0 : ((double)metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.LockTotalTime.Ticks) / (double)num), PercentFormat.Default)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767471239)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.LockTotalCount)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281587190)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.LockErrorTotalCount),
				Value2 = new CellValue((num5 == 0L) ? 0.0 : ((double)metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.LockErrorTotalCount) / (double)num5), PercentFormat.Default)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104924872)),
				Value1 = metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.LockSuccesTotalCount),
				Value2 = new CellValue((num5 == 0L) ? 0.0 : ((double)metricsGroup.Sum((KeyValuePair<string, CacheMetric> m) => m.Value.LockSuccesTotalCount) / (double)num5), PercentFormat.Default)
			}
		};
	}

	public CachePart()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object D3tkuqEvCuUWpm6AQ2Sf(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool TFoW78EvfQS7C0bAGfo3()
	{
		return msk9wEEvEEKgaerwewjl == null;
	}

	internal static CachePart vCS6sAEvQSAAcJJ9broR()
	{
		return msk9wEEvEEKgaerwewjl;
	}
}
