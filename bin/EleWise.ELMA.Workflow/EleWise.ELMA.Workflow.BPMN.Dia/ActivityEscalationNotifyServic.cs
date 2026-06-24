using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints.ActivityNotificationRecipients.Implementations;

[DeveloperApi(DeveloperApiType.Service)]
[Service]
internal sealed class ActivityEscalationNotifyService : IActivityEscalationNotifyService
{
	private readonly IEnumerable<IWorkflowActivityGetNotificationRecipients> extensionPoints;

	public ActivityEscalationNotifyService(IEnumerable<IWorkflowActivityGetNotificationRecipients> extensionPoints)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		this.extensionPoints = extensionPoints;
	}

	IEnumerable<IUser> IActivityEscalationNotifyService.GetRecipientsForNotification(GetRecipientsParameters getRecipientsParameters)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.activityType = getRecipientsParameters.Activity.GetType();
		IEnumerable<IUser> enumerable = extensionPoints.FirstOrDefault((IWorkflowActivityGetNotificationRecipients x) => x.ActivityType.IsAssignableFrom(CS_0024_003C_003E8__locals0.activityType))?.GetRecipients(getRecipientsParameters);
		return enumerable ?? Enumerable.Empty<IUser>();
	}
}
