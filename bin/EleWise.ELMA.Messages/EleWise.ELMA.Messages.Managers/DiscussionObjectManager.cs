using System;
using System.Collections.Generic;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Messages.Managers;

public class DiscussionObjectManager : EntityManager<IDiscussionObject, long>, IDiscussionObjectManager
{
	internal ICriteria GetDiscussionCriteria(long objectId, Guid objectType)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("ObjectId", (object)objectId)).Add((ICriterion)(object)Restrictions.Eq("ObjectType", (object)objectType));
	}

	public IEnumerable<IDiscussionObject> GetDiscussionObjects(long objectId, Guid objectType)
	{
		return GetDiscussionCriteria(objectId, objectType).List<IDiscussionObject>();
	}

	internal EntityActionEventArgs DiscussionRendererEvent(EntityActionEventArgs @event)
	{
		if (@event.New is IDiscussionObject discussionObject)
		{
			IChannelMessage message = discussionObject.Message;
			if (message != null)
			{
				EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(message, message, DefaultEntityActions.CreateGuid);
				if (entityActionEventArgs != null)
				{
					entityActionEventArgs.ActionAuthor = message.CreationAuthor;
					entityActionEventArgs.ActionDate = (message.CreationDate.HasValue ? message.CreationDate.Value : DateTime.Now);
					return entityActionEventArgs;
				}
			}
		}
		return null;
	}
}
