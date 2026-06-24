using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
internal class DocumentLastObjectsListener : EntityEventsListener
{
	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is IDocument document)
		{
			LastObjectInfoManager.Instance.RemoveInfo(new ReferenceOnEntity
			{
				ObjectTypeUId = InterfaceActivator.UID<IDocument>(),
				ObjectId = document.Id
			});
		}
		return base.OnPreDelete(@event);
	}
}
