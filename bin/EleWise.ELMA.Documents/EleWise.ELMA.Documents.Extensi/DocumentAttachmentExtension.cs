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

namespace EleWise.ELMA.Documents.Extensions;

[Component]
internal class DocumentAttachmentExtension : IObjectAttachmentExtension
{
	public void Copy(IEntity fromEntity, IEntity toEntity)
	{
		IDocument document = fromEntity as IDocument;
		IDocument document2 = toEntity as IDocument;
		if (document == null || document2 == null || document.Id == document2.Id)
		{
			return;
		}
		foreach (IDocumentAttachment item in (IEnumerable<IDocumentAttachment>)document.DocumentAttachments)
		{
			((ICollection<IDocumentAttachment>)document2.DocumentAttachments).AddIfNotContains(item);
		}
		document2.Save();
	}

	public bool EntityType(Guid typeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IDocument>(typeUid);
	}

	public IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity)
	{
		if (!(entity is IDocument document))
		{
			return Enumerable.Empty<DocumentFileModel>();
		}
		List<AttachmentFileModel> list = new List<AttachmentFileModel>();
		foreach (IAttachment item in (IEnumerable<IAttachment>)document.Attachments)
		{
			if (item != null && item.File != null)
			{
				list.Add(new AttachmentFileModel
				{
					Name = item.File.Name,
					Uid = item.File.Uid
				});
			}
		}
		if (document != null && document.Versions != null)
		{
			foreach (IDocumentVersion item2 in (IEnumerable<IDocumentVersion>)document.Versions)
			{
				if (item2 != null && item2.File != null)
				{
					list.Add(new DocumentFileModel
					{
						Name = SR.T($"Версия: №{item2.Version} {item2.File.Name}"),
						Uid = item2.File.Uid,
						IsDocument = true
					});
				}
			}
			return list;
		}
		return list;
	}

	public bool IsAnyAttachments(IEntity entity)
	{
		if (entity is IDocument document)
		{
			if (document.Attachments.get_IsEmpty())
			{
				if (!document.Versions.get_IsEmpty())
				{
					return ((IEnumerable<IDocumentVersion>)document.Versions).Any((IDocumentVersion x) => x.File != null);
				}
				return false;
			}
			return true;
		}
		return false;
	}
}
