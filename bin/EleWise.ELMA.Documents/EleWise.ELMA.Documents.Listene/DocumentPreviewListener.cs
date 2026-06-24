using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
public class DocumentPreviewListener : PostFlushEventListener
{
	public override void OnPostInsert(PostInsertEvent @event)
	{
		IFilePreviewService serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IDocumentAttachment documentAttachment && documentAttachment.Document != null && documentAttachment.Document.CurrentVersion != null && documentAttachment.Document.CurrentVersion.File != null)
		{
			serviceNotNull.HasPreview(documentAttachment.Document.CurrentVersion.File, 3L);
		}
		if (!(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IChannelMessage channelMessage) || channelMessage.DiscussionObjects == null || ((ICollection<IDiscussionObject>)channelMessage.DiscussionObjects).Count <= 0)
		{
			return;
		}
		List<Guid> list = (from m in MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>()
			select m.Uid).ToList();
		list.Add(InterfaceActivator.UID<IDocument>());
		foreach (IDiscussionObject discussionObject in (IEnumerable<IDiscussionObject>)channelMessage.DiscussionObjects)
		{
			if (list.Any((Guid t) => t == discussionObject.ObjectType))
			{
				IDocument document = DocumentManager.Instance.LoadOrNull(discussionObject.ObjectId);
				if (document != null && document.CurrentVersion != null && document.CurrentVersion.File != null)
				{
					serviceNotNull.HasPreview(document.CurrentVersion.File, 3L);
				}
			}
		}
	}
}
