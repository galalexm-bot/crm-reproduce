using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class MessageAttachmentInfo
{
	[DataMember]
	public Guid TypeUid;

	[DataMember]
	public string ObjectId;

	[DataMember]
	public string Name;

	[DataMember]
	public string RenderInfo;

	public static MessageAttachmentInfo CreateMessageAttachmentInfo(MessageAttachment model)
	{
		MessageAttachmentInfo messageAttachmentInfo = new MessageAttachmentInfo
		{
			ObjectId = model.Id,
			Name = model.Name,
			TypeUid = model.TypeUid
		};
		IEnumerable<IFeedAttachmentsExtension> source = from p in ComponentManager.Current.GetExtensionPoints<IFeedAttachmentsExtension>()
			where p.TypeUid == model.TypeUid
			select p;
		if (source.Any())
		{
			string text = (messageAttachmentInfo.RenderInfo = source.First().SerializeAttachment(model));
		}
		return messageAttachmentInfo;
	}

	public static MessageAttachment CreateMessageAttachmenttModel(MessageAttachmentInfo info)
	{
		MessageAttachment result = default(MessageAttachment);
		result.Id = info.ObjectId;
		result.Name = info.Name;
		result.TypeUid = info.TypeUid;
		return result;
	}
}
