using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Audit;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Audit;

[Component(Order = 9000)]
public class WorkflowInstanceQuestionHistoryCollector : QuestionHistoryCollectorBase
{
	private readonly Guid collectorGuid;

	private IEnumerable<Guid> supportTypeGuids;

	internal static WorkflowInstanceQuestionHistoryCollector LtMAmJZDUlKUb7VkA4Wo;

	public override IEnumerable<Guid> SupportTypeGuids
	{
		get
		{
			IEnumerable<Guid> enumerable = supportTypeGuids;
			if (enumerable == null)
			{
				Guid[] obj = new Guid[1] { InterfaceActivator.UID<IWorkflowInstance>() };
				IEnumerable<Guid> enumerable2 = obj;
				supportTypeGuids = obj;
				enumerable = enumerable2;
			}
			return enumerable;
		}
	}

	public override Guid CollectorGuid => collectorGuid;

	public WorkflowInstanceQuestionHistoryCollector()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			collectorGuid = new Guid((string)aoso9dZDGxKuwx5WRxED(-885093259 ^ -885239811));
			num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
			{
				num = 1;
			}
		}
	}

	internal static object aoso9dZDGxKuwx5WRxED(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool lFQHRSZDVY993nbGIqZV()
	{
		return LtMAmJZDUlKUb7VkA4Wo == null;
	}

	internal static WorkflowInstanceQuestionHistoryCollector DFLOqBZDAKY3DacYtWXF()
	{
		return LtMAmJZDUlKUb7VkA4Wo;
	}
}
