using System;
using System.Activities;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Plugins;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Plugins;

public class WorkflowInstanceStatusActivity : BPMNActivity<WorkflowInstanceStatusElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		private static object lt5Y4wvLFknatmFTHucy;

		public Type ActivityType => VW10EpvLaqYpiq2s829e(typeof(WorkflowInstanceStatusActivity).TypeHandle);

		public Type DiagramElementType => VW10EpvLaqYpiq2s829e(typeof(WorkflowInstanceStatusElement).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type VW10EpvLaqYpiq2s829e(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool k2LtHnvLi03NlUtyNgR4()
		{
			return lt5Y4wvLFknatmFTHucy == null;
		}

		internal static Info wmDLUovLImToMkwC0r8t()
		{
			return (Info)lt5Y4wvLFknatmFTHucy;
		}
	}

	private static WorkflowInstanceStatusActivity tClSXVZPJVRTG9duL9ty;

	protected override void Execute(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_006b, IL_009e, IL_00e6, IL_00f5
		int num = 1;
		int num2 = num;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				try
				{
					((Entity<long>)WRaYsDZPmxbHZXE4bnCf(workflowInstance)).SetPropertyValue(IFcflRZPbF1rPKWdC2Io(fsoSPmZPtI8DhFrVLJFN(workflowInstance)), GsxRSDZP5i8FOcxPOFwc(base.Element));
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							((ILogger)biPQ5KZPgEJ4OJ7qSVGd()).Error(PJCXg7ZPBEW7SG9w4TXU(ex), ex);
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 3;
			case 3:
				ContinueOnDefaultConnector(context);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				workflowInstance = (IWorkflowInstance)EZb3APZPy1USPVa2eIOQ(this, context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public WorkflowInstanceStatusActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rSSBRhZPcs5E8UoZTBTL();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object EZb3APZPy1USPVa2eIOQ(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static object WRaYsDZPmxbHZXE4bnCf(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static object fsoSPmZPtI8DhFrVLJFN(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static Guid IFcflRZPbF1rPKWdC2Io(object P_0)
	{
		return ((IWorkflowProcess)P_0).StatusContextVar;
	}

	internal static object GsxRSDZP5i8FOcxPOFwc(object P_0)
	{
		return ((WorkflowInstanceStatusElement)P_0).Status;
	}

	internal static object biPQ5KZPgEJ4OJ7qSVGd()
	{
		return Logger.Log;
	}

	internal static object PJCXg7ZPBEW7SG9w4TXU(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static bool DETagoZPljgRFsIyiPOy()
	{
		return tClSXVZPJVRTG9duL9ty == null;
	}

	internal static WorkflowInstanceStatusActivity nYiZtjZP0xInuhKn4rvF()
	{
		return tClSXVZPJVRTG9duL9ty;
	}

	internal static void rSSBRhZPcs5E8UoZTBTL()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
