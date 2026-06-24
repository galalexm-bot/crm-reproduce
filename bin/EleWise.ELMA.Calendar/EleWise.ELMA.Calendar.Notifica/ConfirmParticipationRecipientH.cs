using System.Collections.Generic;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Notifications;

namespace EleWise.ELMA.Calendar.Notifications;

[Component]
public class ConfirmParticipationRecipientHandler : INotificationRecipientTypeHandler
{
	public string Name => "ConfirmParticipationRecipient";

	public IEnumerable<object> GetRecipients(object value)
	{
		if (value == null)
		{
			return new object[0];
		}
		ICalendarEvent @event = value as ICalendarEvent;
		return CalendarEventManager.Instance.ConfirmParticipationRecipient(@event);
	}
}
