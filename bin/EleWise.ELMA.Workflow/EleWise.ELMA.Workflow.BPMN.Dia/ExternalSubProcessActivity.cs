using System;
using System.Activities;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Mappings;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.SubProcess;

public class ExternalSubProcessActivity : SubProcessActivity<ExternalSubprocessElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		private static object uyQqRpvHWIgwLM36NMl4;

		public Type ActivityType => GQyaiKvH6Gmh9iKI71Fb(typeof(ExternalSubProcessActivity).TypeHandle);

		public Type DiagramElementType => GQyaiKvH6Gmh9iKI71Fb(typeof(ExternalSubprocessElement).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SGAnwEvHqabJflMR2mGt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type GQyaiKvH6Gmh9iKI71Fb(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void SGAnwEvHqabJflMR2mGt()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool UCuL6FvHjSZ6qi44gv8e()
		{
			return uyQqRpvHWIgwLM36NMl4 == null;
		}

		internal static Info yB7aZsvHRuYEquXJIIjp()
		{
			return (Info)uyQqRpvHWIgwLM36NMl4;
		}
	}

	private static ExternalSubProcessActivity IA9no8Zgyl4F0RhsRiGg;

	protected override IWorkflowProcess GetSubProcess(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_00c5, IL_00d4
		int num = 1;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			case 1:
				processHeader = ((AbstractNHEntityManager<IProcessHeader, long>)Jxv98eZgb91vBp2WfVeJ(this)).LoadOrNull(VMDpRGZg5517gq0FuX3T(base.Element));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return null;
			case 2:
				if (PGjcahZgglfJ241soDFF(processHeader) == WorkflowProcessStatus.Published)
				{
					return processHeader.Published;
				}
				num2 = 5;
				break;
			case 3:
				return null;
			case 4:
				if (processHeader.Published != null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			default:
				if (processHeader != null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			}
		}
	}

	protected override void OnSubInstanceRunning(NativeActivityContext context, IWorkflowInstance subInstance, int index)
	{
		//Discarded unreachable code: IL_009c, IL_00ab
		int num = 2;
		int num2 = num;
		WorkflowInstanceContext workflowInstanceContext = default(WorkflowInstanceContext);
		WorkflowInstanceContext workflowInstanceContext2 = default(WorkflowInstanceContext);
		while (true)
		{
			switch (num2)
			{
			case 5:
				EGm5CVZgunKA4vFwC8Yr(workflowInstanceContext, workflowInstanceContext2, PJiFjfZgd6s848ir13gi(dPv58gZgcmLy4afXrAP3(base.Element)));
				num2 = 3;
				break;
			default:
				workflowInstanceContext2 = (WorkflowInstanceContext)xFavIGZgX1IapL6DQiXD(subInstance);
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				return;
			case 6:
				return;
			case 8:
				if (workflowInstanceContext2 == null)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 2:
				uaxEhtZgB7j0PBoxZH13(this, context, subInstance, index);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (dPv58gZgcmLy4afXrAP3(base.Element) == null)
				{
					return;
				}
				num2 = 4;
				break;
			case 7:
				if (workflowInstanceContext == null)
				{
					return;
				}
				num2 = 8;
				break;
			case 4:
				workflowInstanceContext = (WorkflowInstanceContext)xFavIGZgX1IapL6DQiXD(LCnsCjZgPqS1L164cZ5Z(this, context));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void OnSubInstanceCompleted(NativeActivityContext context, IWorkflowInstance subInstance)
	{
		//Discarded unreachable code: IL_00be, IL_00cd, IL_00ef
		int num = 8;
		WorkflowInstanceContext workflowInstanceContext2 = default(WorkflowInstanceContext);
		WorkflowInstanceContext workflowInstanceContext = default(WorkflowInstanceContext);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 6:
					EGm5CVZgunKA4vFwC8Yr(workflowInstanceContext2, workflowInstanceContext, base.Element.OutputContextMap);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					workflowInstanceContext = (WorkflowInstanceContext)xFavIGZgX1IapL6DQiXD(GetInstance(context));
					num2 = 5;
					continue;
				case 7:
					if (yIKOYYZgDa9EBlo1iaVt(base.Element) != TaskMarker.MultiInstance)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
						{
							num2 = 1;
						}
						continue;
					}
					return;
				case 4:
					return;
				case 5:
					workflowInstanceContext2 = (WorkflowInstanceContext)xFavIGZgX1IapL6DQiXD(subInstance);
					num2 = 2;
					continue;
				case 9:
					return;
				case 2:
					if (workflowInstanceContext == null)
					{
						num = 9;
						break;
					}
					goto case 10;
				case 8:
					base.OnSubInstanceCompleted(context, subInstance);
					num = 7;
					break;
				case 10:
					if (workflowInstanceContext2 != null)
					{
						num2 = 6;
						continue;
					}
					return;
				case 0:
					return;
				case 1:
					if (j8CRL1ZgnIpGpOyKQFYO(base.Element) == null)
					{
						num = 4;
						break;
					}
					goto case 3;
				}
				break;
			}
		}
	}

	public ExternalSubProcessActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Jxv98eZgb91vBp2WfVeJ(object P_0)
	{
		return ((SubProcessActivity<ExternalSubprocessElement>)P_0).ProcessHeaderManager;
	}

	internal static long VMDpRGZg5517gq0FuX3T(object P_0)
	{
		return ((SubProcessElement)P_0).ProcessHeaderId;
	}

	internal static WorkflowProcessStatus PGjcahZgglfJ241soDFF(object P_0)
	{
		return ((IProcessHeader)P_0).Status;
	}

	internal static bool Yf2cI4ZgmdRQv6AfUkMF()
	{
		return IA9no8Zgyl4F0RhsRiGg == null;
	}

	internal static ExternalSubProcessActivity GAewOlZgt1lVL8PIwvWE()
	{
		return IA9no8Zgyl4F0RhsRiGg;
	}

	internal static void uaxEhtZgB7j0PBoxZH13(object P_0, object P_1, object P_2, int P_3)
	{
		((SubProcessActivity<ExternalSubprocessElement>)P_0).OnSubInstanceRunning((NativeActivityContext)P_1, (IWorkflowInstance)P_2, P_3);
	}

	internal static object dPv58gZgcmLy4afXrAP3(object P_0)
	{
		return ((ExternalSubprocessElement)P_0).InputContextMap;
	}

	internal static object LCnsCjZgPqS1L164cZ5Z(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static object xFavIGZgX1IapL6DQiXD(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static object PJiFjfZgd6s848ir13gi(object P_0)
	{
		return ((PropertyMap)P_0).Reverse();
	}

	internal static void EGm5CVZgunKA4vFwC8Yr(object P_0, object P_1, object P_2)
	{
		PropertyMapHelper.Map(P_0, P_1, (PropertyMap)P_2);
	}

	internal static TaskMarker yIKOYYZgDa9EBlo1iaVt(object P_0)
	{
		return ((SubProcessElement)P_0).Marker;
	}

	internal static object j8CRL1ZgnIpGpOyKQFYO(object P_0)
	{
		return ((ExternalSubprocessElement)P_0).OutputContextMap;
	}
}
