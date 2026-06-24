using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component(Order = 100000)]
public class AttachmentFeedAttachmentsExtension : IFeedAttachmentsExtension
{
	public Guid TypeUid => InterfaceActivator.UID<IAttachment>();

	public Dictionary<MessageAttachment, object> GetAttachments(List<MessageAttachment> messageAttachments)
	{
		Dictionary<MessageAttachment, object> dictionary = new Dictionary<MessageAttachment, object>();
		FileAttachmentInfo[] source = AttachmentManager.Instance.AttachmentsInfo(messageAttachments.Select((MessageAttachment a) => new Guid(a.Id)).ToList()).ToArray();
		foreach (MessageAttachment messageAttachment in messageAttachments)
		{
			MessageAttachment attachCopy = messageAttachment;
			FileAttachmentInfo fileAttachmentInfo = source.FirstOrDefault((FileAttachmentInfo a) => new Guid(attachCopy.Id) == a.AttachmentUid);
			if (fileAttachmentInfo != null)
			{
				dictionary.Add(messageAttachment, fileAttachmentInfo);
			}
		}
		return dictionary;
	}

	public string SerializeAttachment(MessageAttachment messageAttachment)
	{
		List<FileAttachmentInfo> list = AttachmentManager.Instance.AttachmentsInfo(new List<Guid>
		{
			new Guid(messageAttachment.Id)
		}).ToList();
		if (list.Any() && list[0] != null)
		{
			string fileId = list[0].FileId;
			return $"{fileId};{Locator.GetServiceNotNull<IFileManager>().FileSize(fileId)}";
		}
		return string.Empty;
	}
}
