using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Messages.Web.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Components.Feed;

[Component(Order = 100000)]
public class BinaryFileFeedAttachmentsRenderExtension : IFeedAttachmentsRenderExtension
{
	[NotNull]
	private BinaryFileFeedAttachmentsExtension ServerPoint => Locator.GetServiceNotNull<BinaryFileFeedAttachmentsExtension>();

	public Guid TypeUid => ServerPoint.TypeUid;

	public Dictionary<MessageAttachment, object> GetAttachments(List<MessageAttachment> messageAttachments)
	{
		return ServerPoint.GetAttachments(messageAttachments);
	}

	public MvcHtmlString Attachement(HtmlHelper html, MessageAttachment messageAttachment, object attachment)
	{
		if (!(attachment is BinaryFile binaryFile))
		{
			return MvcHtmlString.Empty;
		}
		FileAttachment fileAttachment = new FileAttachment
		{
			AttachmentInfo = new FileAttachmentInfo
			{
				FileId = binaryFile.Id
			},
			Id = messageAttachment.Id,
			Name = messageAttachment.Name,
			TypeUid = messageAttachment.TypeUid
		};
		return PartialExtensions.Partial(html, "FileAttachment", (object)fileAttachment);
	}
}
