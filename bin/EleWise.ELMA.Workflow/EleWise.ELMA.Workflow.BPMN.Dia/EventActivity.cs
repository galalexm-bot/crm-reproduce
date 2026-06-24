using System.Activities;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Events;

public abstract class EventActivity<TElement> : BPMNActivity<TElement> where TElement : EventElement
{
	internal static object UlLAqJZPAx79iD3CJUti;

	protected override void Execute(NativeActivityContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				ContinueOnDefaultConnector(context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected EventActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool FJRgl6ZPGBMbkAjaJXX0()
	{
		return UlLAqJZPAx79iD3CJUti == null;
	}

	internal static object nd1ektZP7SN4Nxl6S1Dy()
	{
		return UlLAqJZPAx79iD3CJUti;
	}
}
