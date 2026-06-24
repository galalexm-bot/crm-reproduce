using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Messages;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.API.Extensions;
using EleWise.ELMA.Messages.API.Feed.Models;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.API.Components;

[Component]
internal class DocumentAttachmentChannelMessageHandler : IChannelMessageHandler
{
	private readonly DocumentManager documentManager;

	private readonly Guid documentAttachment;

	public Guid TypeUid => documentAttachment;

	public DocumentAttachmentChannelMessageHandler(DocumentManager documentManager)
	{
		this.documentManager = documentManager;
		documentAttachment = InterfaceActivator.UID<IDocumentAttachment>();
	}

	internal DocumentAttachmentChannelMessageHandler(DocumentManager documentManager, Guid? typeUid)
	{
		this.documentManager = documentManager;
		documentAttachment = typeUid ?? InterfaceActivator.UID<IDocumentAttachment>();
	}

	public void Handle(IChannelMessage channelMessage, MessageAttachmentInfo[] attachments)
	{
		if (channelMessage == null || attachments == null || !attachments.Any())
		{
			return;
		}
		IEnumerable<string> enumerable = from a in attachments
			where a.TypeUid == TypeUid
			select a.ObjectId;
		List<long> list = new List<long>();
		List<Guid> list2 = new List<Guid>();
		foreach (string item in enumerable)
		{
			long result2;
			if (Guid.TryParse(item, out var result))
			{
				list2.Add(result);
			}
			else if (long.TryParse(item, out result2))
			{
				list.Add(result2);
			}
		}
		ICollection<IDocument> collection = documentManager.FindByIdArray(list.ToArray());
		collection.AddRange(documentManager.FindByIdArray(list2.ToArray()));
		ISet<IDocumentAttachment> documentAttachments = ((IChannelMessageDocumentsExtension)channelMessage).DocumentAttachments;
		foreach (IDocument item2 in collection)
		{
			IDocumentAttachment documentAttachment = InterfaceActivator.Create<IDocumentAttachment>();
			documentAttachment.Document = item2;
			documentAttachments.Add(documentAttachment);
		}
	}
}
