using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using NHibernate;
using NHibernate.Event;

namespace EleWise.ELMA.Common.Listeners;

[Component]
internal class EntityModelHistoryListener : PostFlushEventListener
{
	private static IEnumerable<IEntityModelHistoryEventsFilter> _filters;

	private static IEnumerable<IEntityModelHistoryEventsFilter> Filters => _filters ?? (_filters = ComponentManager.Current.GetExtensionPoints<IEntityModelHistoryEventsFilter>());

	public ISecurityService SecurityService { get; set; }

	public override void OnPostInsert(PostInsertEvent @event)
	{
		ProcessEvent(((AbstractPostDatabaseOperationEvent)@event).get_Entity(), (ISession)(object)((AbstractEvent)@event).get_Session(), DefaultEntityActions.CreateGuid);
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		ProcessEvent(((AbstractPostDatabaseOperationEvent)@event).get_Entity(), (ISession)(object)((AbstractEvent)@event).get_Session(), DefaultEntityActions.UpdateGuid);
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		ProcessEvent(((AbstractPostDatabaseOperationEvent)@event).get_Entity(), (ISession)(object)((AbstractEvent)@event).get_Session(), DefaultEntityActions.DeleteGuid);
	}

	public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
	{
		ProcessEvent(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull(), (ISession)(object)((AbstractEvent)@event).get_Session(), DefaultEntityActions.UpdateGuid);
	}

	private void ProcessEvent(object entity, ISession session, Guid actionGuid)
	{
		if (entity is IEntityModelHistory)
		{
			return;
		}
		IEntity asEntity = entity as IEntity;
		if (asEntity == null)
		{
			return;
		}
		Action action = delegate
		{
			IEntityModelHistory entityModelHistory = EntityModelHistoryManager.Instance.RecordAction(asEntity, actionGuid, save: false);
			if (entityModelHistory != null)
			{
				session.Save((object)entityModelHistory);
			}
		};
		if (EntityActionEventArgs.TryGetUserForHistory(asEntity, out var user))
		{
			SecurityService.RunByUser(user, action);
		}
		else
		{
			action();
		}
	}
}
