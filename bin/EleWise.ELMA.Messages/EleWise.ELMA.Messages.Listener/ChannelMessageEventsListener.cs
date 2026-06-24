using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Messages.Listeners;

[Component]
internal class ChannelMessageEventsListener : EntityEventsListener
{
	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IChannelMessage message)
		{
			PreUpdate(message);
		}
		return false;
	}

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IChannelMessage message)
		{
			PreUpdate(message);
		}
		return base.OnPreInsert(@event);
	}

	private static void PreUpdate(IChannelMessage message)
	{
		if (message != null)
		{
			message.FullMessage = CommentManager.Instance.ClearEmptyText(message.FullMessage);
		}
	}
}
