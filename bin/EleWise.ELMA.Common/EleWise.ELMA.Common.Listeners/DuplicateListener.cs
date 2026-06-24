using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Common.Listeners;

[Component]
internal class DuplicateListener : EntityEventsListener
{
	public IDuplicateService DuplicateService { get; set; }

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IEntity entity)
		{
			DuplicateService.ProcessEntity(entity);
		}
		return false;
	}
}
