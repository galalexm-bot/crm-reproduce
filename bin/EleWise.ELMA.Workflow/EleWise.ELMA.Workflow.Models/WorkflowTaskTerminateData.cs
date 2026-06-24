using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowTaskTerminateData : IWorkflowExecuteData
{
	private readonly IWorkflowBookmark _bookmark;

	private readonly Guid _connectorUid;

	internal static WorkflowTaskTerminateData eLMGDWO3RVLTM8nce3on;

	public Guid ConnectorUid => _connectorUid;

	public IWorkflowBookmark Bookmark => _bookmark;

	public WorkflowTaskTerminateData(IWorkflowBookmark bookmark, Guid connectorUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AcBCibO33J863KmnqOTZ();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				_connectorUid = connectorUid;
				num = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
				{
					num = 0;
				}
				break;
			case 1:
				_bookmark = bookmark;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				return;
			case 2:
				YaCh1UO3QRriedgRUXNw(bookmark, xME4FvO3TKr9jKNcT708(-1516552726 ^ -1516684810));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void AcBCibO33J863KmnqOTZ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object xME4FvO3TKr9jKNcT708(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void YaCh1UO3QRriedgRUXNw(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool nN3Px7O363aCIsWlsrkF()
	{
		return eLMGDWO3RVLTM8nce3on == null;
	}

	internal static WorkflowTaskTerminateData yVdx2iO3qijusZWPx993()
	{
		return eLMGDWO3RVLTM8nce3on;
	}
}
