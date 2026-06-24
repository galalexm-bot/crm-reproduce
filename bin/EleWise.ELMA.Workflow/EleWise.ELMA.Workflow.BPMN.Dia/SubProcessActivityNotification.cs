using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;
using EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints.ActivityNotificationRecipients.Implementations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.WorkflowTaskActivityNotificationRecipients;

[Component(Order = 100)]
internal sealed class SubProcessActivityNotificationRecipients : ProcessActivityNotificationRecipientsByExecutors<ISubProcessActivityNotificationRecipients>
{
	private static SubProcessActivityNotificationRecipients oNc5DtZuw4iRPdvBm5Zh;

	protected override IEnumerable<IUser> GetRecipientsByResponsibleForProcess(GetRecipientsParameters parameters, IEnumerable<Recipient> recipients)
	{
		return Enumerable.Empty<IUser>();
	}

	public SubProcessActivityNotificationRecipients()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		InFKIBZDKPGi1QerB5kA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void InFKIBZDKPGi1QerB5kA()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool in9rMTZu47kVlump1fTm()
	{
		return oNc5DtZuw4iRPdvBm5Zh == null;
	}

	internal static SubProcessActivityNotificationRecipients cUpORNZuzA6mPY5R9YDw()
	{
		return oNc5DtZuw4iRPdvBm5Zh;
	}
}
