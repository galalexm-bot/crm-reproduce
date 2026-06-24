using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Components.Feed;

[Component(Order = 100000)]
public class DocumentAttachmentFeedAttachmentsExtension : IFeedAttachmentsExtension
{
	private List<Guid> typeWebDocGuids;

	public Guid TypeUid => InterfaceActivator.UID<IDocumentAttachment>();

	private bool IsWebDocument(Guid uid)
	{
		if (typeWebDocGuids == null)
		{
			typeWebDocGuids = (from m in WebDocumentManager.Instance.GetWebDocumentTypes(onlyChild: false)
				where m != null
				select m.Uid).ToList();
		}
		return typeWebDocGuids.Contains(uid);
	}

	public Dictionary<MessageAttachment, object> GetAttachments(List<MessageAttachment> messageAttachments)
	{
		Dictionary<MessageAttachment, object> dictionary = new Dictionary<MessageAttachment, object>();
		DocumentCompactInfoModel[] source = DocumentManager.Instance.DocumentCompactInfoForAttachments(messageAttachments.Select((MessageAttachment a) => new Guid(a.Id)).ToList()).ToArray();
		foreach (MessageAttachment messageAttachment in messageAttachments)
		{
			MessageAttachment attachCopy = messageAttachment;
			DocumentCompactInfoModel documentCompactInfoModel = source.FirstOrDefault((DocumentCompactInfoModel a) => new Guid(attachCopy.Id) == a.DocumentAttachmentUid);
			if (documentCompactInfoModel != null)
			{
				dictionary.Add(messageAttachment, documentCompactInfoModel);
			}
		}
		return dictionary;
	}

	public string SerializeAttachment(MessageAttachment messageAttachment)
	{
		List<DocumentCompactInfoModel> list = DocumentManager.Instance.DocumentCompactInfoForAttachments(new List<Guid>
		{
			new Guid(messageAttachment.Id)
		}).ToList();
		if (list.Any() && list[0] != null)
		{
			DocumentCompactInfoModel documentCompactInfoModel = list[0];
			long documentId = documentCompactInfoModel.DocumentId;
			long num = documentCompactInfoModel.CurrentVersion ?? 0;
			Guid documentTypeUid = documentCompactInfoModel.DocumentTypeUid;
			bool flag = IsWebDocument(documentCompactInfoModel.DocumentTypeUid);
			return $"{documentId};{num};{documentTypeUid};{(flag ? 1 : 0)}";
		}
		return string.Empty;
	}
}
