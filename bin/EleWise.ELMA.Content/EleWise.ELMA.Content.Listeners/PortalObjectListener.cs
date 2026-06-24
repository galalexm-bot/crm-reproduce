using System;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Content.Listeners;

[Component]
internal class PortalObjectListener : EntityEventsListener
{
	private readonly string nameOfSortTypeId = LinqUtils.NameOf((Expression<Func<IPortalObject, object>>)((IPortalObject o) => o.SortTypeId));

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IPortalObject portalObject)
		{
			long? num = portalObject.SortTypeId;
			if (!num.HasValue)
			{
				int num2 = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), nameOfSortTypeId);
				object[] state = @event.get_State();
				num = (portalObject.SortTypeId = ((!(portalObject is IPageFolder)) ? 1 : 0));
				state[num2] = num;
			}
		}
		return false;
	}
}
