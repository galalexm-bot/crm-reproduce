using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowExternalSubProcessTerminateData : IWorkflowExecuteData
{
	private readonly IWorkflowBookmark _bookmark;

	private readonly Guid _connectorUid;

	private readonly IWorkflowInstance _subInstance;

	internal static WorkflowExternalSubProcessTerminateData CFB4cKOWBZi33JPsw8A7;

	public Guid ConnectorUid => _connectorUid;

	public IWorkflowBookmark Bookmark => _bookmark;

	public IWorkflowInstance SubInstance => _subInstance;

	public WorkflowExternalSubProcessTerminateData(IWorkflowBookmark bookmark, Guid connectorUid, IWorkflowInstance subInstance)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				F29hXoOWdAlpFEJmJfvA(bookmark, pMBHgaOWXtGtNis71uRj(-885093259 ^ -885225367));
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				_subInstance = subInstance;
				num = 3;
				break;
			case 2:
				_connectorUid = connectorUid;
				num = 4;
				break;
			default:
				_bookmark = bookmark;
				num = 2;
				break;
			case 3:
				return;
			}
		}
	}

	internal static object pMBHgaOWXtGtNis71uRj(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void F29hXoOWdAlpFEJmJfvA(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool wuI7PjOWcjV9PmkMhcog()
	{
		return CFB4cKOWBZi33JPsw8A7 == null;
	}

	internal static WorkflowExternalSubProcessTerminateData cmCrVcOWPtM3TJHalFuq()
	{
		return CFB4cKOWBZi33JPsw8A7;
	}
}
