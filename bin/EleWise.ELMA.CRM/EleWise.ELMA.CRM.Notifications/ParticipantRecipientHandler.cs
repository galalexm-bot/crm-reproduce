using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Notifications;

namespace EleWise.ELMA.CRM.Notifications;

[Component]
public class ParticipantRecipientHandler : UserRecipientHandlerBase, INotificationRecipientTypeHandler
{
	public string Name => "RelationshipParticipantRecipients";

	public override bool CheckCondition(IRelationshipUser user)
	{
		return user.Status == RelationshipUserStatus.Participant;
	}
}
