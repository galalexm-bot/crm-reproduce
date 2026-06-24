using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

[Serializable]
[Component]
public abstract class StartEventTriggerSettings : IXsiType
{
	internal static StartEventTriggerSettings eFh3ZmZyZyBPg0QpHuIB;

	public abstract Guid EventTriggerUid { get; }

	public abstract string DisplayName { get; }

	public override string ToString()
	{
		return DisplayName;
	}

	protected StartEventTriggerSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool i1RgMIZyvA9EZcjmJNcl()
	{
		return eFh3ZmZyZyBPg0QpHuIB == null;
	}

	internal static StartEventTriggerSettings AvILcSZyYcUAovcZS9pY()
	{
		return eFh3ZmZyZyBPg0QpHuIB;
	}
}
