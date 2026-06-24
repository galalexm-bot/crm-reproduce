using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Extensions;

[Component]
internal class TaskAttachmentExtension : IObjectAttachmentExtension, IObjectAttachmentSpecified
{
	public bool EntityType(Guid typeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<ITaskBase>(typeUid);
	}

	public bool IsAnyAttachments(IEntity entity)
	{
		if (!(entity is ITaskBase taskBase) || taskBase.Attachments.get_IsEmpty())
		{
			return IsAnyAttachmentsSpecified(entity);
		}
		return true;
	}

	public bool IsAnyAttachmentsSpecified(IEntity entity)
	{
		if (entity is ITaskBase taskBase)
		{
			return !taskBase.AttachmentsSpecified.get_IsEmpty();
		}
		return false;
	}

	public void Copy(IEntity fromEntity, IEntity toEntity)
	{
		ITaskBase taskBase = fromEntity as ITaskBase;
		ITaskBase taskBase2 = toEntity as ITaskBase;
		if (taskBase == null || taskBase2 == null || taskBase.Id == taskBase2.Id)
		{
			return;
		}
		foreach (IAttachment item in (IEnumerable<IAttachment>)taskBase.Attachments)
		{
			((ICollection<IAttachment>)taskBase2.Attachments).AddIfNotContains(item);
		}
		foreach (IAttachment item2 in (IEnumerable<IAttachment>)taskBase.AttachmentsSpecified)
		{
			((ICollection<IAttachment>)taskBase2.AttachmentsSpecified).AddIfNotContains(item2);
		}
		taskBase2.Save();
	}

	public IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity)
	{
		if (!(entity is ITaskBase taskBase))
		{
			return Enumerable.Empty<AttachmentFileModel>();
		}
		List<AttachmentFileModel> result = new List<AttachmentFileModel>();
		AddAttachments((IEnumerable<IAttachment>)taskBase.Attachments, result);
		AddAttachments((IEnumerable<IAttachment>)taskBase.AttachmentsSpecified, result);
		return result;
	}

	private static void AddAttachments(IEnumerable<IAttachment> attachments, ICollection<AttachmentFileModel> result)
	{
		foreach (IAttachment attachment in attachments)
		{
			if (attachment.File != null)
			{
				result.Add(new AttachmentFileModel
				{
					Name = attachment.File.Name,
					Uid = attachment.File.Uid
				});
			}
		}
	}
}
