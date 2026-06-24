using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Common.Listeners;

[Component]
internal class CommentEventsListener : EntityEventsListener
{
	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IComment comment)
		{
			PreUpdate(comment);
		}
		return false;
	}

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IComment comment)
		{
			PreUpdate(comment);
		}
		return base.OnPreInsert(@event);
	}

	private static void PreUpdate(IComment comment)
	{
		if (comment != null)
		{
			comment.Text = CommentManager.Instance.ClearEmptyText(comment.Text);
		}
	}
}
