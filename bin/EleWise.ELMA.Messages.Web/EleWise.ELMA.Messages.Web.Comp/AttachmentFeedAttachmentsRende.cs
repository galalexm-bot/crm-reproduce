using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Messages.Web.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Components.Feed;

[Component(Order = 100000)]
public class AttachmentFeedAttachmentsRenderExtension : IFeedAttachmentsRenderExtension
{
	public Guid TypeUid => Locator.GetServiceNotNull<AttachmentFeedAttachmentsExtension>().TypeUid;

	public Dictionary<MessageAttachment, object> GetAttachments(List<MessageAttachment> messageAttachments)
	{
		return Locator.GetServiceNotNull<AttachmentFeedAttachmentsExtension>().GetAttachments(messageAttachments);
	}

	public MvcHtmlString Attachement(HtmlHelper html, MessageAttachment messageAttachment, object attachment)
	{
		if (attachment is FileAttachmentInfo attachmentInfo)
		{
			FileAttachment fileAttachment = new FileAttachment
			{
				AttachmentInfo = attachmentInfo,
				Id = messageAttachment.Id,
				Name = messageAttachment.Name,
				TypeUid = messageAttachment.TypeUid
			};
			return PartialExtensions.Partial(html, "FileAttachment", (object)fileAttachment);
		}
		if (attachment is IAttachment)
		{
			return PartialExtensions.Partial(html, "DisplayTemplates/Entities/Attachment", attachment);
		}
		return MvcHtmlString.Empty;
	}
}
