using EleWise.ELMA.Common.ViewItems;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class ProcessContextHistoryPanelViewItemAvailable : IHistoryPanelViewItemAvailable
{
	internal static ProcessContextHistoryPanelViewItemAvailable iU8sXXOl8MRqeFCFIsgD;

	public bool? IsAvailable(IMetadata metadata)
	{
		if (!(metadata is ProcessContext))
		{
			return null;
		}
		return true;
	}

	public ProcessContextHistoryPanelViewItemAvailable()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		exdCPFOll0FZViiy5NYm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void exdCPFOll0FZViiy5NYm()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool YpJZexOlsOACigURLxFr()
	{
		return iU8sXXOl8MRqeFCFIsgD == null;
	}

	internal static ProcessContextHistoryPanelViewItemAvailable lmSiZCOlJ1yFcBRcOxa9()
	{
		return iU8sXXOl8MRqeFCFIsgD;
	}
}
