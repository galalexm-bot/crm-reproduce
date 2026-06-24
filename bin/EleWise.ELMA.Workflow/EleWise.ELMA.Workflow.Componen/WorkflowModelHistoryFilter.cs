using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal class WorkflowModelHistoryFilter : EntityModelHistoryEventsFilterBase
{
	private static WorkflowModelHistoryFilter zLZAWLOm3UQ7P708QBUx;

	protected override Type[] ExcludeTypes => new Type[2]
	{
		O6lgSVOmpUsqtKOexam2(typeof(IWorkflowBookmark).TypeHandle),
		O6lgSVOmpUsqtKOexam2(typeof(IWorkflowQueueItem).TypeHandle)
	};

	public WorkflowModelHistoryFilter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AeE0I0OmCU04Gm1tPv7O();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type O6lgSVOmpUsqtKOexam2(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool v4lUsnOmTJDxBDhDPwUa()
	{
		return zLZAWLOm3UQ7P708QBUx == null;
	}

	internal static WorkflowModelHistoryFilter mdhVgOOmQgYg4sVydymi()
	{
		return zLZAWLOm3UQ7P708QBUx;
	}

	internal static void AeE0I0OmCU04Gm1tPv7O()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
