using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Diagnostics.Reports.Excel;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Stat;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Reports.Performance.CommonParts;

[ComponentOrder(30)]
internal class NHStatisticsPart : CommonInformationPart
{
	internal static NHStatisticsPart IPFEsKEvVxyfN4g3Pqio;

	public override string Title => (string)E8MleVEvqKWKgueM0pgv(tVnduKEvRYZDO27Rv8d2(-675505729 ^ -675762553));

	public override IEnumerable<CommonInformationPartItem> GetItems(MetricsContainer metrics)
	{
		IStatistics statistics = Locator.GetServiceNotNull<SessionFactoryHolder>().SessionFactory.get_Statistics();
		double num = ((statistics.get_EntityFetchFromCacheCount() == 0L) ? 0.0 : ((double)statistics.get_EntityFetchFromCacheSuccessCount() / (double)statistics.get_EntityFetchFromCacheCount()));
		return new CommonInformationPartItem[16]
		{
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4ED8FA80)),
				Value1 = statistics.get_EntityLoadCount()
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87092065)),
				Value1 = statistics.get_EntityFetchCount()
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740597144)),
				Value1 = new CellValue(statistics.get_EntityFetchTime(), new TimeSpanFormat(TimeSpanStyle.HHMMSS))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC506AC)),
				Value1 = statistics.get_EntityFetchFromCacheCount()
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606900152)),
				Value1 = statistics.get_EntityFetchFromCacheSuccessCount(),
				Value2 = new CellValue(num, PercentFormat.Default)
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463E3740)),
				Value1 = new CellValue(statistics.get_EntityFetchFromCacheTime(), new TimeSpanFormat(TimeSpanStyle.HHMMSS))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548FEF20)),
				Value1 = statistics.get_EntityQueryCount()
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978603543)),
				Value1 = new CellValue(statistics.get_EntityQueryTime(), new TimeSpanFormat(TimeSpanStyle.HHMMSS))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410951053)),
				Value1 = statistics.get_EntityQueryFromCacheCount()
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426342273)),
				Value1 = new CellValue(statistics.get_EntityQueryFromCacheTime(), new TimeSpanFormat(TimeSpanStyle.HHMMSS))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410950215)),
				Value1 = statistics.get_EntityInsertCount()
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA17980)),
				Value1 = new CellValue(statistics.get_EntityInsertTime(), new TimeSpanFormat(TimeSpanStyle.HHMMSS))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459312257)),
				Value1 = statistics.get_EntityUpdateCount()
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61E8368E)),
				Value1 = new CellValue(statistics.get_EntityUpdateTime(), new TimeSpanFormat(TimeSpanStyle.HHMMSS))
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112424404)),
				Value1 = statistics.get_EntityDeleteCount()
			},
			new CommonInformationPartItem
			{
				Name = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31365BA8)),
				Value1 = new CellValue(statistics.get_EntityDeleteTime(), new TimeSpanFormat(TimeSpanStyle.HHMMSS))
			}
		};
	}

	public NHStatisticsPart()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CQr5bmEvKbVynthRdKIZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object tVnduKEvRYZDO27Rv8d2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object E8MleVEvqKWKgueM0pgv(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool u03HdjEvSDkKnPBcUvGo()
	{
		return IPFEsKEvVxyfN4g3Pqio == null;
	}

	internal static NHStatisticsPart JnxgeqEvix5i4PxdjMUF()
	{
		return IPFEsKEvVxyfN4g3Pqio;
	}

	internal static void CQr5bmEvKbVynthRdKIZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
