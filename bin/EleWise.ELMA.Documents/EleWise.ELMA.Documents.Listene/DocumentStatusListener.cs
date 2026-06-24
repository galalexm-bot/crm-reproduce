using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
internal class DocumentStatusListener : PostFlushEventListener
{
	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IDocument document)
		{
			IMetadata metadata = MetadataLoader.LoadMetadata(((EntityMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID(document.GetType()))).ImplementationUid, inherit: true, loadImplementation: false);
			ILifeCycle lifeCycle = LifeCycleManager.Instance.LoadOrNull(metadata.Uid);
			if (lifeCycle != null && document.Status == null && lifeCycle.DefaultStatus != null)
			{
				document.Status = lifeCycle.DefaultStatus;
			}
		}
	}
}
