using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Messages.Listeners;

[Component]
public class MessageListener : PostFlushEventListener
{
	public IUnionComplexCacheService UnionComplexCacheService { get; set; }

	public IComplexCacheService ComplexCacheService { get; set; }

	public override void OnPostInsert(PostInsertEvent @event)
	{
		ProduceMessageException(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IMessageException);
		ProduceMessageNotAssignedUser(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IMessageNotAssignedUser);
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		ProduceMessageException(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IMessageException);
		ProduceMessageNotAssignedUser(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IMessageNotAssignedUser);
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		ProduceMessageException(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IMessageException);
		ProduceMessageNotAssignedUser(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IMessageNotAssignedUser);
	}

	private void ProduceMessageException(IMessageException messageException)
	{
		if (messageException != null && messageException.Author != null)
		{
			UnionComplexCacheService.RefreshTimestamp("MessageExceptionAuthorTimestamp_" + messageException.Author.Id);
		}
	}

	private void ProduceMessageNotAssignedUser(IMessageNotAssignedUser messageNotAssignedUser)
	{
		if (messageNotAssignedUser != null && messageNotAssignedUser.ChannelMessage != null)
		{
			ComplexCacheService.RefreshTimestamp("MessageNotAssignedRecipientsTimestamp_" + messageNotAssignedUser.ChannelMessage.Id);
		}
	}
}
