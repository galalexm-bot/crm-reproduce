using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Calendar.Components.Feed;

[Component]
internal class FeedUpdateProvider : FeedMessageUpdateProviderBase<ICalendarEvent>
{
	protected override FeedPriority GetPriorityForRecipient(FeedModel feedModel, IUser recipient, ICalendarEvent entity)
	{
		if (feedModel == null)
		{
			throw new ArgumentNullException("feedModel");
		}
		if (recipient == null)
		{
			throw new ArgumentNullException("recipient");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		if (feedModel.CreationAuthor == recipient)
		{
			return FeedPriority.Normal;
		}
		if (((IEnumerable<ICalendarEventUser>)entity.EventUsers).Any((ICalendarEventUser eu) => eu.Status == CalendarEventUserStatus.Participant && eu.User == recipient))
		{
			return FeedPriority.High;
		}
		return FeedPriority.Normal;
	}
}
