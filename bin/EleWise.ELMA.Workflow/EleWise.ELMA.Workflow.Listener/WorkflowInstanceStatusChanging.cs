using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal sealed class WorkflowInstanceStatusChangingHandler : IEntityActionHandler, IEventHandler
{
	private readonly string settingsName;

	private static WorkflowInstanceStatusChangingHandler lvfwwQRR7IOrSaCF6cE;

	public void ActionExecuted(EntityActionEventArgs e)
	{
		//Discarded unreachable code: IL_0055, IL_0131
		int num = 10;
		IWorkflowInstance workflowInstance2 = default(IWorkflowInstance);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 7:
					return;
				case 11:
					if (!SR.GetSetting(settingsName, defaultValue: true))
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 10:
					if (e != null)
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
						{
							num2 = 4;
						}
						continue;
					}
					return;
				case 3:
					if (workflowInstance2 != null)
					{
						num2 = 2;
						continue;
					}
					return;
				case 5:
					ckXlOrRCmhS2ocmEBRD(workflowInstance);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (workflowInstance != null)
					{
						num2 = 4;
						continue;
					}
					return;
				case 0:
					return;
				case 2:
					if (c0PVmDR34RRK0HGBLYT(workflowInstance2) != WorkflowInstanceStatus.Running)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					workflowInstance = NFUV2lRTgF9HLRF5d2E(e) as IWorkflowInstance;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
					{
						num2 = 8;
					}
					continue;
				case 6:
				{
					IWorkflowInstanceState state = workflowInstance.State;
					TTajdYRQVsAvZJPSUZA(workflowInstance, null);
					shMq1SRpqJ6j1bwn3nH(state);
					num2 = 5;
					continue;
				}
				case 4:
					if (!WorkflowInstanceChangingVersionHelper.DeleteStatuses.Contains(workflowInstance.Status))
					{
						return;
					}
					num2 = 11;
					continue;
				case 12:
					return;
				case 9:
					break;
				}
				break;
			}
			workflowInstance2 = e.Old as IWorkflowInstance;
			num = 3;
		}
	}

	public WorkflowInstanceStatusChangingHandler()
	{
		//Discarded unreachable code: IL_0046, IL_004b
		lvmgVaRMb6gI7qovRel();
		settingsName = (string)AN7NU1Rkp1CPXBZJocC(-801808857 ^ -801775189);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static WorkflowInstanceStatus c0PVmDR34RRK0HGBLYT(object P_0)
	{
		return ((IWorkflowInstance)P_0).Status;
	}

	internal static object NFUV2lRTgF9HLRF5d2E(object P_0)
	{
		return ((EntityActionEventArgs)P_0).New;
	}

	internal static void TTajdYRQVsAvZJPSUZA(object P_0, object P_1)
	{
		((IWorkflowInstance)P_0).State = (IWorkflowInstanceState)P_1;
	}

	internal static void shMq1SRpqJ6j1bwn3nH(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static void ckXlOrRCmhS2ocmEBRD(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static bool QbTursR6fZhFwWGEOLt()
	{
		return lvfwwQRR7IOrSaCF6cE == null;
	}

	internal static WorkflowInstanceStatusChangingHandler KEqW8JRqgRlpdhuZoSw()
	{
		return lvfwwQRR7IOrSaCF6cE;
	}

	internal static void lvmgVaRMb6gI7qovRel()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object AN7NU1Rkp1CPXBZJocC(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
