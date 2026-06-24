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
internal class QuestionAttachmentExtension : IObjectAttachmentExtension
{
	public void Copy(IEntity fromEntity, IEntity toEntity)
	{
		IQuestion question = fromEntity as IQuestion;
		IQuestion question2 = toEntity as IQuestion;
		if (question == null || question2 == null || question.Id == question2.Id)
		{
			return;
		}
		foreach (IAttachment item in (IEnumerable<IAttachment>)question.Attachments)
		{
			((ICollection<IAttachment>)question2.Attachments).AddIfNotContains(item);
		}
		question2.Save();
	}

	public bool EntityType(Guid TypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IQuestion>(TypeUid);
	}

	public IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity)
	{
		if (!(entity is IQuestion question) || question.Answer == null)
		{
			return Enumerable.Empty<AttachmentFileModel>();
		}
		List<AttachmentFileModel> list = new List<AttachmentFileModel>();
		foreach (IAttachment item in (IEnumerable<IAttachment>)question.Answer.Attachments)
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
		return list;
	}

	public bool IsAnyAttachments(IEntity entity)
	{
		if (entity is IQuestion question && question.Answer != null)
		{
			return !question.Answer.Attachments.get_IsEmpty();
		}
		return false;
	}
}
