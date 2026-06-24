using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Component(Order = 300)]
public class UserGroupRecipientForNotification : RecipientForNotificationWithObjectGuid
{
	internal static UserGroupRecipientForNotification K62htyZtwuGLbYtdKkmG;

	public override IEnumerable<object> GetRecipients(IWorkflowInstance instance)
	{
		if (!(base.RecipientValue is Guid))
		{
			return null;
		}
		if ((Guid)base.RecipientValue == Guid.Empty)
		{
			throw new GetRecipientsException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x1437886)));
		}
		return RecipientInfoForNotificationHelper.GetUsersFromUserGroup((Guid)base.RecipientValue);
	}

	public UserGroupRecipientForNotification()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xQdlrXZbKqoCAFCLuGMA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void xQdlrXZbKqoCAFCLuGMA()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool cbG0NcZt4W4a7Ls4HbRD()
	{
		return K62htyZtwuGLbYtdKkmG == null;
	}

	internal static UserGroupRecipientForNotification ehrNXsZtzp3fK7jLG1Uo()
	{
		return K62htyZtwuGLbYtdKkmG;
	}
}
