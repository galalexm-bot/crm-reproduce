using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowScriptTerminateData : IWorkflowExecuteData
{
	private readonly IWorkflowBookmark _bookmark;

	private readonly Guid _connectorUid;

	private readonly TimeSpan _escalationScript;

	internal static WorkflowScriptTerminateData zRy0uLQT1pPjZTVQrJx;

	public Guid ConnectorUid => _connectorUid;

	public IWorkflowBookmark Bookmark => _bookmark;

	public TimeSpan escalationScript => _escalationScript;

	public WorkflowScriptTerminateData(IWorkflowBookmark bookmark, Guid connectorUid, TimeSpan escalationScript)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		Rtxem4Qdx4ftRVRcQna();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				_escalationScript = escalationScript;
				num = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5158ff5e06d54ab9b6f7b04c47b15f73 == 0)
				{
					num = 1;
				}
				break;
			case 4:
				_connectorUid = connectorUid;
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea != 0)
				{
					num = 0;
				}
				break;
			case 2:
				JnR9JXQSy2YhrxrQern(bookmark, V8ivLxQjkGO8yJchrEZ(0xFAE81C9 ^ 0xFAED0AB));
				num = 3;
				break;
			case 3:
				_bookmark = bookmark;
				num = 4;
				break;
			case 1:
				return;
			}
		}
	}

	internal static void Rtxem4Qdx4ftRVRcQna()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object V8ivLxQjkGO8yJchrEZ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void JnR9JXQSy2YhrxrQern(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool srZfQnQc8yHNUMm8cA8()
	{
		return zRy0uLQT1pPjZTVQrJx == null;
	}

	internal static WorkflowScriptTerminateData uo2rb1QNcC8fZ7yE4NY()
	{
		return zRy0uLQT1pPjZTVQrJx;
	}
}
