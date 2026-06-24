using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit.Impl;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Audit;

[Component]
internal class WorkflowInstanceEditActionsEventAggregator : BaseEntityUpdateEventAggregator
{
	internal static WorkflowInstanceEditActionsEventAggregator rZLA7SZDpDlXweGMi7LQ;

	protected override IEnumerable<Guid> ProcessedActions
	{
		[IteratorStateMachine(typeof(_003Cget_ProcessedActions_003Ed__1))]
		get
		{
			//yield-return decompiler failed: Missing enumeratorCtor.Body
			return new _003Cget_ProcessedActions_003Ed__1(-2);
		}
	}

	public WorkflowInstanceEditActionsEventAggregator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lRPDmuZDkmxQOruJmyRD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void lRPDmuZDkmxQOruJmyRD()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool v5GnNOZDC5X6nXb1meGc()
	{
		return rZLA7SZDpDlXweGMi7LQ == null;
	}

	internal static WorkflowInstanceEditActionsEventAggregator skSPh5ZDMR8LFIf5da2e()
	{
		return rZLA7SZDpDlXweGMi7LQ;
	}
}
