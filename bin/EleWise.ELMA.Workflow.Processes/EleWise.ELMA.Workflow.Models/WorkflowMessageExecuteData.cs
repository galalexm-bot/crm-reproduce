using EleWise.ELMA.Common.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowMessageExecuteData : IWorkflowExecuteData
{
	private readonly IWorkflowMessageBookmark _messageBookmark;

	private readonly WebData _data;

	private static WorkflowMessageExecuteData lkpJicqgIZd70uj42OM;

	public IWorkflowMessageBookmark MessageBookmark => _messageBookmark;

	public IWorkflowBookmark Bookmark => (IWorkflowBookmark)VMZCSJQE3bGjhOKSRYZ(_messageBookmark);

	public WebData Data => _data;

	public WorkflowMessageExecuteData(IWorkflowMessageBookmark messageBookmark, WebData data = null)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				_data = data;
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c != 0)
				{
					num = 0;
				}
				break;
			case 1:
				NkF1KsqzodJMrHA0d4t(messageBookmark, QEfAgsqZi16ftvlndCn(-1737696342 ^ -1737717082));
				num = 2;
				break;
			case 4:
				_messageBookmark = messageBookmark;
				num = 3;
				break;
			case 2:
				NkF1KsqzodJMrHA0d4t(VMZCSJQE3bGjhOKSRYZ(messageBookmark), QEfAgsqZi16ftvlndCn(0x32F3F75 ^ 0x32F6E5B));
				num = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
				{
					num = 4;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override string ToString()
	{
		return _messageBookmark.Bookmark.ToString();
	}

	internal static object QEfAgsqZi16ftvlndCn(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void NkF1KsqzodJMrHA0d4t(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object VMZCSJQE3bGjhOKSRYZ(object P_0)
	{
		return ((IWorkflowMessageBookmark)P_0).Bookmark;
	}

	internal static bool ee6WKYq1t8DwXb8gnXo()
	{
		return lkpJicqgIZd70uj42OM == null;
	}

	internal static WorkflowMessageExecuteData v2cKbmqI2ahbtoLcibt()
	{
		return lkpJicqgIZd70uj42OM;
	}
}
