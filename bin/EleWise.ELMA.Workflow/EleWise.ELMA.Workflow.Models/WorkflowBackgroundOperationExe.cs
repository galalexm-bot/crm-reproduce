using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.Models.BackgroundOperations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowBackgroundOperationExecuteData : IWorkflowExecuteData
{
	private readonly IBackgroundOperationInfo operationInfo;

	private readonly IBackgroundOperationResult backgroundOperationResult;

	private static WorkflowBackgroundOperationExecuteData uA9xrhOD8eWCYO0j4g5E;

	public IWorkflowBookmark Bookmark => (IWorkflowBookmark)A9jH29ODyANqAB8k2Iuy(operationInfo);

	public IBackgroundOperationInfo BackgroundOperation => operationInfo;

	public IBackgroundOperationResult BackgroundOperationResult => backgroundOperationResult;

	public WorkflowBackgroundOperationExecuteData(IBackgroundOperationInfo operationInfo)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				backgroundOperationResult = KhYgQlOD0F9MQA33i8It(puxmVTODl6U30rSVoMNC(operationInfo)) as IBackgroundOperationResult;
				num = 2;
				continue;
			case 2:
				return;
			}
			this.operationInfo = operationInfo;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
			{
				num = 1;
			}
		}
	}

	internal static object puxmVTODl6U30rSVoMNC(object P_0)
	{
		return ((IBackgroundOperationInfo)P_0).Result;
	}

	internal static object KhYgQlOD0F9MQA33i8It(object P_0)
	{
		return ClassSerializationHelper.DeserializeObject((byte[])P_0);
	}

	internal static bool L3SGIlODsvpWXGaFHTO1()
	{
		return uA9xrhOD8eWCYO0j4g5E == null;
	}

	internal static WorkflowBackgroundOperationExecuteData a3DpfwODJppUHYvL1iUs()
	{
		return uA9xrhOD8eWCYO0j4g5E;
	}

	internal static object A9jH29ODyANqAB8k2Iuy(object P_0)
	{
		return ((IBackgroundOperationInfo)P_0).BoundBookmark;
	}
}
