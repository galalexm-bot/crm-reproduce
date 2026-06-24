using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Components.Feed;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Messages.Web.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Web.Components.Feed;

[Component(Order = 100000)]
public class DocumentAttachmentFeedAttachmentsRenderExtension : IFeedAttachmentsRenderExtension
{
	public Guid TypeUid => Locator.GetServiceNotNull<DocumentAttachmentFeedAttachmentsExtension>().TypeUid;

	public Dictionary<MessageAttachment, object> GetAttachments(List<MessageAttachment> messageAttachments)
	{
		return Locator.GetServiceNotNull<DocumentAttachmentFeedAttachmentsExtension>().GetAttachments(messageAttachments);
	}

	public MvcHtmlString Attachement(HtmlHelper html, MessageAttachment messageAttachment, object attachment)
	{
		IDocumentAttachment documentAttachment = ((attachment is DocumentCompactInfoModel documentCompactInfoModel && documentCompactInfoModel.DocumentAttachmentUid != Guid.Empty) ? DocumentAttachmentManager.Instance.LoadOrNull(documentCompactInfoModel.DocumentAttachmentUid) : ((attachment is IDocumentAttachment) ? (attachment as IDocumentAttachment) : null));
		if (documentAttachment != null)
		{
			return PartialExtensions.Partial(html, "DisplayTemplates/Entities/DocumentAttachment", (object)documentAttachment);
		}
		return MvcHtmlString.Empty;
	}
}
