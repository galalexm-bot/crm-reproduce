using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Service;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.API;

[Uid("{C65A945A-F837-41A5-A4A8-9B5C21CE4498}")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[Component]
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
internal class WorkflowInstanceService : IWorkflowInstanceService, IPublicAPIWebService
{
	public const string GuidS = "{C65A945A-F837-41A5-A4A8-9B5C21CE4498}";

	public static Guid Guid;

	internal static WorkflowInstanceService XOUWpKZnabBO20txDNpV;

	public string GetMapLink(long processId)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 4;
		int num2 = num;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (workflowInstance == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 2:
				return string.Format((string)hK3vciZnxV3XlL2mfdIj(-420003255 ^ -420117297), processId);
			default:
				return null;
			case 1:
				if (weiHZsZnNWcctPsZPSuq(Locator.GetServiceNotNull<ISecurityService>(), WorkflowPermissionProvider.ViewTaskListOfInstance, workflowInstance, false))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 4:
				workflowInstance = WorkflowInstanceManager.Instance.LoadOrNull(processId);
				num2 = 3;
				break;
			}
		}
	}

	public WorkflowInstanceService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LpY4gPZnSyTEivQ7RAL6();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowInstanceService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Guid = new Guid((string)hK3vciZnxV3XlL2mfdIj(-261315199 ^ -261201063));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				LpY4gPZnSyTEivQ7RAL6();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool weiHZsZnNWcctPsZPSuq(object P_0, object P_1, object P_2, bool P_3)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1, P_2, P_3);
	}

	internal static object hK3vciZnxV3XlL2mfdIj(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool PT8YIoZnrU30s2Wf2vN1()
	{
		return XOUWpKZnabBO20txDNpV == null;
	}

	internal static WorkflowInstanceService MfBeFGZneqAGsSK59N8e()
	{
		return XOUWpKZnabBO20txDNpV;
	}

	internal static void LpY4gPZnSyTEivQ7RAL6()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
