using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Notifications;

namespace EleWise.ELMA.CRM.Notifications;

[Component]
public class InformToRecipientHandler : UserRecipientHandlerBase, INotificationRecipientTypeHandler
{
	public string Name => "RelationshipInformToRecipients";

	public override bool CheckCondition(IRelationshipUser user)
	{
		return user.Status == RelationshipUserStatus.InfromTo;
	}
}
