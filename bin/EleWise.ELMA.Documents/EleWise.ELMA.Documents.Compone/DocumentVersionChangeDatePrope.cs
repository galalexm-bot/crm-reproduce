using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.PropertyHandlers;
using EleWise.ELMA.Model.Services;
using NHibernate.Engine;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class DocumentVersionChangeDatePropertyHandlerIgnoreProvider : IChangePropertyHandlerIgnoreProvider
{
	public bool CheckType(Guid typeUid)
	{
		return typeUid == InterfaceActivator.UID<IDocumentVersion>();
	}

	public bool Ignore(PreUpdateEvent @event)
	{
		if (!(((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IDocumentVersion))
		{
			return false;
		}
		int[] array = ((AbstractPreDatabaseOperationEvent)@event).get_Persister().FindDirty(@event.get_State(), @event.get_OldState(), ((AbstractPreDatabaseOperationEvent)@event).get_Entity(), (ISessionImplementor)(object)((AbstractEvent)@event).get_Session());
		if (array == null || array.Length != 1)
		{
			return false;
		}
		return ((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames()[array[0]].Equals("Status");
	}
}
