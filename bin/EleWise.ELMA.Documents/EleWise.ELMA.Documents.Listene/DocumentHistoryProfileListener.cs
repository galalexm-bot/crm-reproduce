using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.History.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
internal sealed class DocumentHistoryProfileListener : PostFlushEventListener
{
	private readonly IEnumerable<InverseRelatedEntityModel> documentTypeUids;

	private readonly IHistoryUpdateQueueItemRepository historyUpdateQueueItemRepository;

	public DocumentHistoryProfileListener(IHistoryUpdateQueueItemRepository historyUpdateQueueItemRepository)
	{
		this.historyUpdateQueueItemRepository = historyUpdateQueueItemRepository;
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(InterfaceActivator.UID<IDocument>(), loadImplementation: true, includeRoot: true);
		documentTypeUids = childClasses.Select((ClassMetadata c) => new InverseRelatedEntityModel(-1L, c.Uid)).ToList();
	}

	public override void OnPostUpdateCollection(PostCollectionUpdateEvent @event)
	{
		if (@event == null || !(((AbstractCollectionEvent)@event).get_AffectedOwnerOrNull() is IDocumentHistoryProfile documentHistoryProfile))
		{
			return;
		}
		Type type = documentHistoryProfile.DocumentProfile?.DocumentType?.EntityType;
		if (type != null)
		{
			Guid objectTypeUid = InterfaceActivator.UID(type);
			historyUpdateQueueItemRepository.DeleteQueueItemsByObjectTypeUid(objectTypeUid);
			historyUpdateQueueItemRepository.InsertQueueItem(-1L, objectTypeUid, forDelete: true);
		}
		else
		{
			historyUpdateQueueItemRepository.DeleteQueueItemsByObjectTypeUids(documentTypeUids.Select((InverseRelatedEntityModel u) => u.TypeUid));
			historyUpdateQueueItemRepository.BulkInsertQueueItems(documentTypeUids, forDelete: true);
		}
	}
}
