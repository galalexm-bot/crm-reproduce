using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowMessageReceviesTerminateData : IWorkflowExecuteData
{
	private readonly IWorkflowBookmark _bookmark;

	private readonly Guid _connectorUid;

	private readonly IWorkflowMessageBookmark _messageBookmark;

	private static WorkflowMessageReceviesTerminateData ybxwoYQCvClLyn29gca;

	public Guid ConnectorUid => _connectorUid;

	public IWorkflowBookmark Bookmark => _bookmark;

	public IWorkflowMessageBookmark MessageBookmark => _messageBookmark;

	public WorkflowMessageReceviesTerminateData(IWorkflowBookmark bookmark, Guid connectorUid, IWorkflowMessageBookmark messageBookmark)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 4:
				Contract.ArgumentNotNull(bookmark, (string)mPxEoNQ39ePf3osqT89(-92270799 ^ -92250541));
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				_connectorUid = connectorUid;
				num = 2;
				break;
			case 1:
				return;
			default:
				_bookmark = bookmark;
				num = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				_messageBookmark = messageBookmark;
				num = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static object mPxEoNQ39ePf3osqT89(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool NucpbJQXGdm68O44PiF()
	{
		return ybxwoYQCvClLyn29gca == null;
	}

	internal static WorkflowMessageReceviesTerminateData b40ZuQQo28sIX5Q2p4d()
	{
		return ybxwoYQCvClLyn29gca;
	}
}
