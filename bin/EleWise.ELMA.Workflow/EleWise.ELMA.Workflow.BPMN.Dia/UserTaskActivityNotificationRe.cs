using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;
using EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints.ActivityNotificationRecipients.Implementations;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.WorkflowTaskActivityNotificationRecipients;

[Component(Order = 100)]
internal sealed class UserTaskActivityNotificationRecipients : BaseWorkflowActivityGetNotificationRecipientsComponent<UserTaskActivity>
{
	private static UserTaskActivityNotificationRecipients h5dBFPZDOkk43HEljf8B;

	protected override IEnumerable<IUser> GetRecipientsByOrganizationItem(GetRecipientsParameters parameters, IEnumerable<Recipient> recipients)
	{
		List<long> list = recipients.Select((Recipient x) => x.RecipientId).ToList();
		if (list.Count == 0)
		{
			return Enumerable.Empty<IUser>();
		}
		IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
		if (parameters.ElementWithNotification != null)
		{
			userFilter.OrganizationItemFindMode = ((!parameters.ElementWithNotification.NoCheckOrganizationItem) ? OrganizationItemFindMode.ByItem : OrganizationItemFindMode.ByTree);
		}
		userFilter.OrganizationItemIds = list;
		return UserManager.Instance.Find(userFilter, null);
	}

	public UserTaskActivityNotificationRecipients()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MU5nwNZDYlnjplgyEqCm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void MU5nwNZDYlnjplgyEqCm()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool cmpHYBZDZeh53lhUFxZZ()
	{
		return h5dBFPZDOkk43HEljf8B == null;
	}

	internal static UserTaskActivityNotificationRecipients BfmDL8ZDvbN7dVpfOTU5()
	{
		return h5dBFPZDOkk43HEljf8B;
	}
}
