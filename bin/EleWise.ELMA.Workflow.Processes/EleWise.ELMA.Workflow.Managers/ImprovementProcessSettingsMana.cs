using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class ImprovementProcessSettingsManager : EntityManager<IImprovementProcessSettings, long>
{
	private static ImprovementProcessSettingsManager wDnnICMG69ZxVpTrZP1;

	public new static ImprovementProcessSettingsManager Instance => Locator.GetServiceNotNull<ImprovementProcessSettingsManager>();

	public List<long> GetProcessHeaderIdList()
	{
		return CreateCriteria().CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125832759 ^ -2125854593), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x467974A9 ^ 0x4679216F)).Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1967154668 ^ -1967140924))).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x234241C0 ^ 0x234217D6)) })
			.List<long>()
			.ToList();
	}

	public List<Guid> GetProcessHeaderPropertyUidList()
	{
		return CreateCriteria().SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747C4140 ^ 0x747C1E12)) }).List<Guid>().ToList();
	}

	public List<IProcessHeader> GetProcessHeaderList(string text = null)
	{
		ICriteria val = CreateCriteria().CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-869419654 ^ -869408564), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-869419654 ^ -869408580)).Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1917423727 ^ -1917437375)));
		if (!string.IsNullOrWhiteSpace(text))
		{
			val.Add((ICriterion)(object)ElmaRestrictions.InsensitiveLike(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1164596236 ^ -1164577680), text, MatchMode.Anywhere));
		}
		return val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x138E9AEB ^ 0x138ECF5D)) }).List<IProcessHeader>().ToList();
	}

	public IImprovementProcessSettings GetDefault()
	{
		return ((ICriteria)S7yWgcM0g4FJhD0nJuh(gUt6J7MOfdCWDh5gfF7(this, null), TLdlOQMRBiZEb1b9idZ(mX5UtbM6MbpwsgQk6TA(-1635137248 ^ -1635150152), true))).UniqueResult<IImprovementProcessSettings>();
	}

	public ImprovementProcessSettingsManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		RLtunpMBYe0KgaP4l4R();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object gUt6J7MOfdCWDh5gfF7(object P_0, object P_1)
	{
		return ((EntityManager<IImprovementProcessSettings, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object mX5UtbM6MbpwsgQk6TA(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object TLdlOQMRBiZEb1b9idZ(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object S7yWgcM0g4FJhD0nJuh(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static bool K4Dc5EMn7BUolx5sFuK()
	{
		return wDnnICMG69ZxVpTrZP1 == null;
	}

	internal static ImprovementProcessSettingsManager VUFNQeMyS3VQLqqwbX7()
	{
		return wDnnICMG69ZxVpTrZP1;
	}

	internal static void RLtunpMBYe0KgaP4l4R()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
