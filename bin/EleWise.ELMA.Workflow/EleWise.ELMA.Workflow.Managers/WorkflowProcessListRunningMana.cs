using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowProcessListRunningManager : EntityManager<IWorkflowProcessListRunning, long>
{
	private static WorkflowProcessListRunningManager MPXp76uYw008HbMqspN;

	public new static WorkflowProcessListRunningManager Instance => Locator.GetServiceNotNull<WorkflowProcessListRunningManager>();

	public IEnumerable<long> FindProcessHeaderIds(Guid objectType)
	{
		return CreateCriteria().SetCacheable(true).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360658443), (object)objectType)).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595C16EC), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483FC6CC))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614C9051)) })
			.List<long>();
	}

	public WorkflowProcessListRunningManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		htv2C0uJxEiZ8RMlXIH();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void htv2C0uJxEiZ8RMlXIH()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool I1yKp6u8AWPA4OaWpBg()
	{
		return MPXp76uYw008HbMqspN == null;
	}

	internal static WorkflowProcessListRunningManager W7JcKEusBAwBfATmfRj()
	{
		return MPXp76uYw008HbMqspN;
	}
}
