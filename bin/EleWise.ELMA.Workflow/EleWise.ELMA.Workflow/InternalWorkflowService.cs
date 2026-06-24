using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Impl;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow;

internal class InternalWorkflowService : ComplexLicensedUnit<IInternalWorkflowService>, IInternalWorkflowService, ILicensedUnit
{
	internal static InternalWorkflowService VjacD9OzIPYovpdOXO1;

	public InternalWorkflowService()
	{
		//Discarded unreachable code: IL_0039, IL_003e
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector((IInternalWorkflowService)new InternalWorkflowServiceExpress(), (IInternalWorkflowService)new InternalWorkflowServiceStandart(), (IInternalWorkflowService)new InternalWorkflowServiceOracle());
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

	void IInternalWorkflowService.Run(IWorkflowInstance instance)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				dOfWp1ZZ8bYjrDm2blK(ActiveUnit, instance);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool TCCUNWZKe1hjEIk6rt3()
	{
		return VjacD9OzIPYovpdOXO1 == null;
	}

	internal static InternalWorkflowService zIbtDQZOQIBFUhHD5Pp()
	{
		return VjacD9OzIPYovpdOXO1;
	}

	internal static void dOfWp1ZZ8bYjrDm2blK(object P_0, object P_1)
	{
		((IInternalWorkflowService)P_0).Run((IWorkflowInstance)P_1);
	}
}
