using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Calendar.Components.Feed;

[Component]
internal class CalendarEventUserFeedUpdateProvider : FeedMessageUpdateProviderBase<ICalendarEventUser>
{
	protected override FeedPriority GetPriorityForRecipient(FeedModel feedModel, IUser recipient, ICalendarEventUser entity)
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
		if (entity.Event.CreationAuthor == recipient)
		{
			return FeedPriority.Urgent;
		}
		return FeedPriority.Normal;
	}

	protected override IEntity GetParentEntity(ICalendarEventUser tEntity, FeedModel model)
	{
		return tEntity.Event;
	}
}
