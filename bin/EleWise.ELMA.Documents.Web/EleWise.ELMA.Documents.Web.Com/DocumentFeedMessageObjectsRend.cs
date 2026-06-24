using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Models;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components.Feed;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 90000)]
public class DocumentFeedMessageObjectsRenderExtension : FeedMessageObjectsRenderExtension
{
	public override bool IsSupport(Guid objectTypeUid, MessageObject messageObject)
	{
		return MetadataLoader.IsBaseOrChildClass<IDocument>(messageObject.TypeUid);
	}

	public override string Name(Guid objectTypeUid, MessageObject messageObject)
	{
		if (!(objectTypeUid == InterfaceActivator.UID<IChannelMessage>()))
		{
			return base.Name(objectTypeUid, messageObject);
		}
		return SR.T("Обсуждение");
	}

	public override MvcHtmlString MessageObject(HtmlHelper html, MessageObject messageObject, object objectModel)
	{
		if (!(objectModel is DocumentCompactInfoModel documentInfo))
		{
			return MvcHtmlString.Empty;
		}
		DocumentCompactInfoView documentCompactInfoView = new DocumentCompactInfoView
		{
			DocumentInfo = documentInfo,
			FullView = false
		};
		return PartialExtensions.Partial(html, "DocumentButtons", (object)documentCompactInfoView);
	}
}
