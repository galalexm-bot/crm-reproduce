using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Messages.Extensions;

[Component]
internal class MessageAttachmentExtension : IObjectAttachmentExtension
{
	public void Copy(IEntity fromEntity, IEntity toEntity)
	{
		IChannelMessage channelMessage = fromEntity as IChannelMessage;
		IChannelMessage channelMessage2 = toEntity as IChannelMessage;
		if (channelMessage == null || channelMessage2 == null || channelMessage.Id == channelMessage2.Id)
		{
			return;
		}
		foreach (IAttachment item in (IEnumerable<IAttachment>)channelMessage.Attachments)
		{
			((ICollection<IAttachment>)channelMessage2.Attachments).AddIfNotContains(item);
		}
		channelMessage2.Save();
	}

	public bool EntityType(Guid TypeUid)
	{
		return TypeUid == InterfaceActivator.UID<IChannelMessage>();
	}

	public IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity)
	{
		if (!(entity is IChannelMessage channelMessage))
		{
			return Enumerable.Empty<AttachmentFileModel>();
		}
		List<AttachmentFileModel> list = new List<AttachmentFileModel>();
		foreach (IAttachment item in (IEnumerable<IAttachment>)channelMessage.Attachments)
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
		if (entity is IChannelMessage channelMessage)
		{
			return !channelMessage.Attachments.get_IsEmpty();
		}
		return false;
	}
}
