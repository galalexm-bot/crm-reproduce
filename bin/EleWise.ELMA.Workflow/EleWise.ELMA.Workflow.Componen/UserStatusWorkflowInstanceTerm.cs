using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class UserStatusWorkflowInstanceTerminateAction : IWorkflowInstanceTerminateAction
{
	private static UserStatusWorkflowInstanceTerminateAction PlnTQ3OBsHFsyTpvcB6L;

	public void Execute(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_0045, IL_011f, IL_012e
		int num = 4;
		int num2 = num;
		IStatusWorkflowProcessTerminateAction statusWorkflowProcessTerminateAction = default(IStatusWorkflowProcessTerminateAction);
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			default:
				kO1oDNOBbW1TWhVCrXW2(statusWorkflowProcessTerminateAction, _003C_003Ec__DisplayClass0_.instance);
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 8;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass0_.instance = instance;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (statusWorkflowProcessTerminateAction == null)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 5:
				return;
			case 8:
				return;
			case 2:
				if (!CxbvrSOBmrX3ZtG7BHUm(lDrbEsOByoNrbQ3N45y2(M8NXaYOB0VkOuIOemEyL(_003C_003Ec__DisplayClass0_.instance)), Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 4:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				return;
			case 1:
				statusWorkflowProcessTerminateAction = ((ComponentManager)wYNjIEOBt7xxR4RUsc3U()).GetExtensionPoints<IStatusWorkflowProcessTerminateAction>().FirstOrDefault(_003C_003Ec__DisplayClass0_._003CExecute_003Eb__0);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public UserStatusWorkflowInstanceTerminateAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GTrnH3OB54CIQy7JaXkt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object M8NXaYOB0VkOuIOemEyL(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static Guid lDrbEsOByoNrbQ3N45y2(object P_0)
	{
		return ((IWorkflowProcess)P_0).StatusTerminateActionUid;
	}

	internal static bool CxbvrSOBmrX3ZtG7BHUm(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object wYNjIEOBt7xxR4RUsc3U()
	{
		return ComponentManager.Current;
	}

	internal static void kO1oDNOBbW1TWhVCrXW2(object P_0, object P_1)
	{
		((IStatusWorkflowProcessTerminateAction)P_0).Execute((IWorkflowInstance)P_1);
	}

	internal static bool bEVoqPOBJbAnXFLKeunY()
	{
		return PlnTQ3OBsHFsyTpvcB6L == null;
	}

	internal static UserStatusWorkflowInstanceTerminateAction cwiL73OBl6nqsArNlHBB()
	{
		return PlnTQ3OBsHFsyTpvcB6L;
	}

	internal static void GTrnH3OB54CIQy7JaXkt()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
