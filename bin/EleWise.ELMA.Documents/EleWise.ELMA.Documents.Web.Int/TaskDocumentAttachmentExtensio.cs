using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Web.Integration.Tasks;

[Component]
internal class TaskDocumentAttachmentExtension : IObjectAttachmentExtension, IObjectAttachmentSpecified
{
	public bool EntityType(Guid typeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IAttachmentsTaskBase>(typeUid);
	}

	public bool IsAnyAttachments(IEntity entity)
	{
		if (!(entity is IAttachmentsTaskBase attachmentsTaskBase) || attachmentsTaskBase.DocumentAttachments.get_IsEmpty())
		{
			return IsAnyAttachmentsSpecified(entity);
		}
		return true;
	}

	public bool IsAnyAttachmentsSpecified(IEntity entity)
	{
		if (entity is IAttachmentsTaskBase attachmentsTaskBase)
		{
			return !attachmentsTaskBase.DocumentAttachmentsSpecified.get_IsEmpty();
		}
		return false;
	}

	public void Copy(IEntity fromEntity, IEntity toEntity)
	{
		IAttachmentsTaskBase attachmentsTaskBase = fromEntity as IAttachmentsTaskBase;
		IAttachmentsTaskBase attachmentsTaskBase2 = toEntity as IAttachmentsTaskBase;
		if (attachmentsTaskBase == null || attachmentsTaskBase2 == null || attachmentsTaskBase.Id == attachmentsTaskBase2.Id)
		{
			return;
		}
		foreach (IDocumentAttachment item in (IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachments)
		{
			((ICollection<IDocumentAttachment>)attachmentsTaskBase2.DocumentAttachments).AddIfNotContains(item);
		}
		foreach (IDocumentAttachment item2 in (IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachmentsSpecified)
		{
			((ICollection<IDocumentAttachment>)attachmentsTaskBase2.DocumentAttachmentsSpecified).AddIfNotContains(item2);
		}
		attachmentsTaskBase2.Save();
	}

	public IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity)
	{
		if (!(entity is IAttachmentsTaskBase attachmentsTaskBase))
		{
			return Enumerable.Empty<DocumentFileModel>();
		}
		List<DocumentFileModel> list = new List<DocumentFileModel>();
		AddAttachments((IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachments, list);
		AddAttachments((IEnumerable<IDocumentAttachment>)attachmentsTaskBase.DocumentAttachmentsSpecified, list);
		return list;
	}

	private static void AddAttachments(IEnumerable<IDocumentAttachment> documentAttachments, ICollection<DocumentFileModel> documents)
	{
		foreach (IDocumentAttachment documentAttachment in documentAttachments)
		{
			IDocument document = documentAttachment.Document;
			IDocumentVersion currentVersion = document.CurrentVersion;
			if (currentVersion != null && currentVersion.File != null)
			{
				documents.Add(new DocumentFileModel
				{
					Name = document.Name + " (" + currentVersion.File.Name + ") ",
					Uid = currentVersion.File.Uid,
					IsDocument = true
				});
			}
		}
	}
}
