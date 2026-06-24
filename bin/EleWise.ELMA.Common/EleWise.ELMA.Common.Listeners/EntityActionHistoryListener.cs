using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Common.Listeners;

[Component]
internal class EntityActionHistoryListener : EntityEventsListener
{
	public ILogger Logger { get; set; }

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IEntityActionHistory)
		{
			IEntity entity = (IEntity)((AbstractPreDatabaseOperationEvent)@event).get_Entity();
			Logger.Warn(SR.T("Невозможно обновление истории активности объекта. Тип {0}, Ид = {1}", entity.GetType().FullName, entity.GetId()));
			return true;
		}
		return false;
	}

	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IEntityActionHistory)
		{
			IEntity entity = (IEntity)((AbstractPreDatabaseOperationEvent)@event).get_Entity();
			Logger.Warn(SR.T("Невозможно удаление истории активности объекта. Тип {0}, Ид = {1}", entity.GetType().FullName, entity.GetId()));
			return true;
		}
		return false;
	}
}
