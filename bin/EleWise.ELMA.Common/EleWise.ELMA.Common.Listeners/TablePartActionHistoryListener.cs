using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Audit;
using EleWise.ELMA.Common.Models.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Engine;
using NHibernate.Event;

namespace EleWise.ELMA.Common.Listeners;

[Component]
internal sealed class TablePartActionHistoryListener : EntityEventsListener
{
	private IEntityActionHandler entityActionHandler;

	public TablePartActionHistoryListener(IEntityActionHandler entityActionHandler)
	{
		this.entityActionHandler = entityActionHandler;
	}

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		if (((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IEntity entity && MetadataLoader.LoadMetadata(entity.GetType()) is EntityMetadata)
		{
			Type type = ((object)((AbstractCollectionEvent)@event).get_Collection()).GetType();
			Type[] genericArguments = type.GetGenericArguments();
			if (type.IsGenericType && genericArguments.Any() && MetadataLoader.LoadMetadata(genericArguments[0]) is TablePartMetadata tablePartMetadata && tablePartMetadata.SaveHistory)
			{
				CollectionEntry collectionEntry = ((ISessionImplementor)((AbstractEvent)@event).get_Session()).get_PersistenceContext().GetCollectionEntry(((AbstractCollectionEvent)@event).get_Collection());
				IEnumerable<IEntity> newState = (((AbstractCollectionEvent)@event).get_Collection() as IEnumerable).Cast<IEntity>();
				IEnumerable<IEntity> oldState = (collectionEntry.get_Snapshot() as IEnumerable).Cast<IEntity>();
				EditCollectionActionEventArgs e = new EditCollectionActionEventArgs(entity, entity, DefaultTablePartActions.UpdateCollectionGuid, newState, oldState);
				entityActionHandler.ActionExecuted(e);
			}
		}
	}
}
