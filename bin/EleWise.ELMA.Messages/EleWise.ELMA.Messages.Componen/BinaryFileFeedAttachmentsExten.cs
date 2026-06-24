using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component(Order = 100000)]
public class BinaryFileFeedAttachmentsExtension : IFeedAttachmentsExtension
{
	public Guid TypeUid => BinaryFileDescriptor.UID;

	public Dictionary<MessageAttachment, object> GetAttachments(List<MessageAttachment> messageAttachments)
	{
		Dictionary<MessageAttachment, object> dictionary = new Dictionary<MessageAttachment, object>();
		BinaryFile[] source = DataAccessManager.FileManager.LoadFiles(messageAttachments.Select((MessageAttachment a) => a.Id).ToArray());
		foreach (MessageAttachment messageAttachment in messageAttachments)
		{
			MessageAttachment attachCopy = messageAttachment;
			BinaryFile binaryFile = source.FirstOrDefault((BinaryFile a) => attachCopy.Id == a.Id);
			if (binaryFile != null)
			{
				dictionary.Add(messageAttachment, binaryFile);
			}
		}
		return dictionary;
	}

	public string SerializeAttachment(MessageAttachment messageAttachment)
	{
		return $"{messageAttachment.Id};{Locator.GetServiceNotNull<IFileManager>().FileSize(messageAttachment.Id)}";
	}
}
