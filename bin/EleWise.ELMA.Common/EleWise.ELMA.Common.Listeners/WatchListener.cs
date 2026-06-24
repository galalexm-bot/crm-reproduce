using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using NHibernate.Event;

namespace EleWise.ELMA.Common.Listeners;

[Component]
public class WatchListener : EntityEventsListener
{
	public override void OnPostInsert(PostInsertEvent @event)
	{
		IWatch obj = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IWatch;
		Clear(obj);
	}

	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		IWatch obj = ((AbstractPreDatabaseOperationEvent)@event).get_Entity() as IWatch;
		Clear(obj);
		return false;
	}

	private void Clear(IWatch obj)
	{
		if (obj != null)
		{
			Locator.GetServiceNotNull<IWatchEntityService>().ClearForObject(obj.TypeUid, ModelHelper.TryConvertEntityId(obj.TypeUid, obj.EntityId));
		}
	}
}
