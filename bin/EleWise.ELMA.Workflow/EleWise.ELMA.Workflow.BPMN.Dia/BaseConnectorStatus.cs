using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;

public abstract class BaseConnectorStatus : IConnectorStatus
{
	private static BaseConnectorStatus TOkcWeZyU915LbRq2Hxn;

	public abstract Guid Uid { get; }

	public abstract string DisplayName { get; }

	public virtual bool DefaultFirstConnector => false;

	public virtual bool DefaultSecondConnector => false;

	public abstract List<Type> ElementTypes { get; }

	public virtual string DefaultConnectorDisplayName => (string)X2vt5MZyGOApc8iSrUBw(this);

	public virtual bool DefaultNthConnector(int nth)
	{
		return false;
	}

	protected BaseConnectorStatus()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hGaRSbZy7p4XmRIHqcJZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object X2vt5MZyGOApc8iSrUBw(object P_0)
	{
		return ((BaseConnectorStatus)P_0).DisplayName;
	}

	internal static void hGaRSbZy7p4XmRIHqcJZ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool tsjN0fZyVtIs3YcH8giy()
	{
		return TOkcWeZyU915LbRq2Hxn == null;
	}

	internal static BaseConnectorStatus J7HndsZyAumub1qppsx6()
	{
		return TOkcWeZyU915LbRq2Hxn;
	}
}
