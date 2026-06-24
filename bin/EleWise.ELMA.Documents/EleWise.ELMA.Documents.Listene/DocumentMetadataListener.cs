using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
internal class DocumentMetadataListener : PostFlushEventListener
{
	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IDocumentMetadataProfile documentMetadataProfile && documentMetadataProfile.HistoryViewSettings != null)
		{
			DocumentHistoryProfileManager.Instance.ClearCache();
		}
	}
}
