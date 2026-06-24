using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFeedAttachmentsRenderExtension
{
	Guid TypeUid { get; }

	Dictionary<MessageAttachment, object> GetAttachments(List<MessageAttachment> messageAttachments);

	MvcHtmlString Attachement(HtmlHelper html, MessageAttachment messageAttachment, object attachment);
}
