using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Extensions;

[Component]
internal class ContractorAttachmentExtension : IObjectAttachmentExtension
{
	public void Copy(IEntity fromEntity, IEntity toEntity)
	{
		ICRMAttachment iCRMAttachment = fromEntity as ICRMAttachment;
		ICRMAttachment iCRMAttachment2 = toEntity as ICRMAttachment;
		if (iCRMAttachment == null || iCRMAttachment2 == null || iCRMAttachment.Id == iCRMAttachment2.Id)
		{
			return;
		}
		foreach (IAttachment item in (IEnumerable<IAttachment>)iCRMAttachment.Files)
		{
			((ICollection<IAttachment>)iCRMAttachment2.Files).AddIfNotContains(item);
		}
		iCRMAttachment2.Save();
	}

	public bool EntityType(Guid TypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IContractor>(TypeUid);
	}

	public IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity)
	{
		if (!(entity is IContractor contractor))
		{
			return Enumerable.Empty<AttachmentFileModel>();
		}
		ICRMAttachmentFilter iCRMAttachmentFilter = InterfaceActivator.Create<ICRMAttachmentFilter>();
		iCRMAttachmentFilter.Contractor = contractor;
		ICollection<ICRMAttachment> source = CrmAttachmentManager.Instance.Find(iCRMAttachmentFilter, null);
		IEnumerable<IAttachment> enumerable = source.SelectMany((ICRMAttachment x) => (IEnumerable<IAttachment>)x.Files);
		IEnumerable<IDocument> enumerable2 = source.SelectMany((ICRMAttachment x) => (IEnumerable<IDocument>)x.Documents);
		List<AttachmentFileModel> list = new List<AttachmentFileModel>();
		foreach (IAttachment item in enumerable)
		{
			if (item.File != null)
			{
				list.Add(new AttachmentFileModel
				{
					Name = item.File.Name,
					Uid = item.File.Uid
				});
			}
		}
		foreach (IDocument item2 in enumerable2)
		{
			if (item2.CurrentVersion != null && item2.CurrentVersion.File != null)
			{
				list.Add(new DocumentFileModel
				{
					Name = item2.Name + " (" + item2.CurrentVersion.File.Name + ") ",
					Uid = item2.CurrentVersion.File.Uid,
					IsDocument = true
				});
			}
		}
		return list;
	}

	public bool IsAnyAttachments(IEntity entity)
	{
		if (!(entity is IContractor contractor))
		{
			return false;
		}
		ICRMAttachmentFilter iCRMAttachmentFilter = InterfaceActivator.Create<ICRMAttachmentFilter>();
		iCRMAttachmentFilter.Contractor = contractor;
		ICollection<ICRMAttachment> source = CrmAttachmentManager.Instance.Find(iCRMAttachmentFilter, null);
		IEnumerable<BinaryFile> first = from x in source.SelectMany((ICRMAttachment x) => (IEnumerable<IAttachment>)x.Files)
			select x.File;
		IEnumerable<BinaryFile> second = from x in source.SelectMany((ICRMAttachment x) => (IEnumerable<IDocument>)x.Documents)
			where x.CurrentVersion != null
			select x.CurrentVersion.File;
		return first.Union(second).Any();
	}
}
