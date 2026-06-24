using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;

namespace EleWise.ELMA.Calendar.Notifications;

public abstract class UserRecipientHandlerBase
{
	public IEnumerable<object> GetRecipients(object value)
	{
		if (value == null)
		{
			return new object[0];
		}
		if (!(value is ICalendarEvent calendarEvent) || !((IEnumerable<ICalendarEventUser>)calendarEvent.EventUsers).Any())
		{
			return new object[0];
		}
		return (from eu in ((IEnumerable<ICalendarEventUser>)calendarEvent.EventUsers).Where(CheckCondition)
			select eu.User).ToList();
	}

	public abstract bool CheckCondition(ICalendarEventUser user);
}
