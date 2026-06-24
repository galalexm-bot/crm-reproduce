using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Notifications;

namespace EleWise.ELMA.Calendar.Notifications;

[Component]
public class ParticipantRecipientHandler : UserRecipientHandlerBase, INotificationRecipientTypeHandler
{
	public string Name => "ParticipantRecipients";

	public override bool CheckCondition(ICalendarEventUser user)
	{
		return user.Status == CalendarEventUserStatus.Participant;
	}
}
