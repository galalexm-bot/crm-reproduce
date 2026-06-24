using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Activities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints.ActivityNotificationRecipients.Implementations;

internal class ProcessActivityNotificationRecipientsByExecutors<TActivity> : BaseWorkflowActivityGetNotificationRecipientsComponent<TActivity> where TActivity : IActivityNotificationRecipientsByExecutors
{
	internal static object aIGGPoZOV7NkKmJ1sVfT;

	protected override IEnumerable<IUser> GetRecipientsByInitiator(GetRecipientsParameters parameters, IEnumerable<Recipient> recipients)
	{
		List<IUser> list = new List<IUser>();
		if (parameters.Executors != null && recipients.Any())
		{
			list.AddRange(parameters.Executors);
		}
		return list;
	}

	protected override IEnumerable<IUser> GetRecipientsByProcessOwner(GetRecipientsParameters parameters, IEnumerable<Recipient> recipients)
	{
		List<IUser> list = new List<IUser>();
		if (parameters.Executors != null && recipients.Any())
		{
			list.AddRange(parameters.Executors);
		}
		return list;
	}

	public ProcessActivityNotificationRecipientsByExecutors()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool x3MMfXZOAYHnG50j9dn5()
	{
		return aIGGPoZOV7NkKmJ1sVfT == null;
	}

	internal static object bHSBCLZOG6fho3iaAUO4()
	{
		return aIGGPoZOV7NkKmJ1sVfT;
	}
}
[Component(Order = 200)]
internal sealed class ProcessActivityNotificationRecipientsByExecutors : ProcessActivityNotificationRecipientsByExecutors<IActivityNotificationRecipientsByExecutors>
{
	internal static ProcessActivityNotificationRecipientsByExecutors yf45GHZO77prdRbE09DO;

	public ProcessActivityNotificationRecipientsByExecutors()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PXZFySZOFCGptvnVE7UY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void PXZFySZOFCGptvnVE7UY()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool lwmPY9ZO2qcBResuNsox()
	{
		return yf45GHZO77prdRbE09DO == null;
	}

	internal static ProcessActivityNotificationRecipientsByExecutors AQNCVOZOo3M2vYbTHtb7()
	{
		return yf45GHZO77prdRbE09DO;
	}
}
