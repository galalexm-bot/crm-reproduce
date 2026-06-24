using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

[Component(Order = 100)]
public class ContextVarRecipientForNotification : RecipientForNotificationWithObjectGuid
{
	private static ContextVarRecipientForNotification mrRbG0ZtbgOG81m96eup;

	public override IEnumerable<object> GetRecipients(IWorkflowInstance instance)
	{
		if (!(base.RecipientValue is Guid))
		{
			return null;
		}
		List<IUser> result = new List<IUser>();
		if (instance != null)
		{
			return RecipientInfoForNotificationHelper.GetUsersFromVariable(instance, (Guid)base.RecipientValue);
		}
		return result;
	}

	public ContextVarRecipientForNotification()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OCA86AZtBBeWchevvoGE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void OCA86AZtBBeWchevvoGE()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool C5prgYZt5KQhPLIxPCIS()
	{
		return mrRbG0ZtbgOG81m96eup == null;
	}

	internal static ContextVarRecipientForNotification khrJ15ZtgRlRZTNGDJJ7()
	{
		return mrRbG0ZtbgOG81m96eup;
	}
}
