using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class DenyReplaceExecutorUserTaskElement : IDenyReplaceExecutorExtention
{
	private static DenyReplaceExecutorUserTaskElement hfq02rOsLn6gQeVN85wt;

	public bool DenyReplace(BPMNFlowElement element, SwimlaneElement swimlane)
	{
		int num = 5;
		int num2 = num;
		UserTaskElement userTaskElement = default(UserTaskElement);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (Ad4FjPOs6C7ss3fVTTml(swimlane) != SwimlaneType.BusinessRole)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
					{
						num2 = 1;
					}
					break;
				}
				return true;
			case 1:
				if (Ad4FjPOs6C7ss3fVTTml(swimlane) == SwimlaneType.Dynamic)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto IL_0117;
			case 4:
				CjYaPMOsWnLM3epLWkGG(swimlane, vil1suOsjjtRFdUmbKlu(-261315199 ^ -261276423));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				if (userTaskElement != null)
				{
					num2 = 2;
					break;
				}
				goto IL_011b;
			default:
				userTaskElement = element as UserTaskElement;
				num2 = 7;
				break;
			case 5:
				CjYaPMOsWnLM3epLWkGG(element, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057702091));
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
				{
					num2 = 4;
				}
				break;
			case 8:
				return oHG9gaOsq3uhGR05Qpvw(swimlane);
			case 2:
				if (iUqZdpOsRGnYhQaJFiHF(userTaskElement))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto IL_011b;
			case 6:
				{
					if (swimlane.WorkerDetectionType == WorkerDetectionType.WhoFirst)
					{
						num2 = 8;
						break;
					}
					goto IL_0117;
				}
				IL_011b:
				return false;
				IL_0117:
				return false;
			}
		}
	}

	public DenyReplaceExecutorUserTaskElement()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nyLiSyOs3XXyPBDXmW9k();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void CjYaPMOsWnLM3epLWkGG(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object vil1suOsjjtRFdUmbKlu(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool iUqZdpOsRGnYhQaJFiHF(object P_0)
	{
		return ((UserTaskElement)P_0).DenyReplace;
	}

	internal static SwimlaneType Ad4FjPOs6C7ss3fVTTml(object P_0)
	{
		return ((SwimlaneElement)P_0).SwimlaneType;
	}

	internal static bool oHG9gaOsq3uhGR05Qpvw(object P_0)
	{
		return ((SwimlaneElement)P_0).ResetExecutorOnEnter;
	}

	internal static bool qgDAHtOsfAPSGf3ptmGG()
	{
		return hfq02rOsLn6gQeVN85wt == null;
	}

	internal static DenyReplaceExecutorUserTaskElement jPf2y8Os9f1UrIgRuII2()
	{
		return hfq02rOsLn6gQeVN85wt;
	}

	internal static void nyLiSyOs3XXyPBDXmW9k()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
