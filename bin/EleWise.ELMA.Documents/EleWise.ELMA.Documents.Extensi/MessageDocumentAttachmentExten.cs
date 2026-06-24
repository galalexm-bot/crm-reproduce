using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Messages;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Extensions;

[Component]
internal class MessageDocumentAttachmentExtension : IObjectAttachmentExtension
{
	public bool EntityType(Guid TypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IChannelMessageDocumentsExtension>(TypeUid);
	}

	public bool IsAnyAttachments(IEntity entity)
	{
		if (entity is IChannelMessageDocumentsExtension channelMessageDocumentsExtension)
		{
			return !channelMessageDocumentsExtension.DocumentAttachments.get_IsEmpty();
		}
		return false;
	}

	public void Copy(IEntity fromEntity, IEntity toEntity)
	{
		IChannelMessageDocumentsExtension channelMessageDocumentsExtension = fromEntity as IChannelMessageDocumentsExtension;
		IChannelMessageDocumentsExtension channelMessageDocumentsExtension2 = toEntity as IChannelMessageDocumentsExtension;
		if (channelMessageDocumentsExtension == null || channelMessageDocumentsExtension2 == null || channelMessageDocumentsExtension.Id == channelMessageDocumentsExtension2.Id)
		{
			return;
		}
		foreach (IDocumentAttachment item in (IEnumerable<IDocumentAttachment>)channelMessageDocumentsExtension.DocumentAttachments)
		{
			((ICollection<IDocumentAttachment>)channelMessageDocumentsExtension2.DocumentAttachments).AddIfNotContains(item);
		}
		channelMessageDocumentsExtension2.Save();
	}

	public IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity)
	{
		if (!(entity is IChannelMessageDocumentsExtension channelMessageDocumentsExtension))
		{
			return Enumerable.Empty<DocumentFileModel>();
		}
		List<DocumentFileModel> list = new List<DocumentFileModel>();
		foreach (IDocumentAttachment item in (IEnumerable<IDocumentAttachment>)channelMessageDocumentsExtension.DocumentAttachments)
		{
			if (item.Document.CurrentVersion != null && item.Document.CurrentVersion.File != null)
			{
				list.Add(new DocumentFileModel
				{
					Name = item.Document.Name + " (" + item.Document.CurrentVersion.File.Name + ") ",
					Uid = item.Document.CurrentVersion.File.Uid,
					IsDocument = true
				});
			}
		}
		return list;
	}
}
