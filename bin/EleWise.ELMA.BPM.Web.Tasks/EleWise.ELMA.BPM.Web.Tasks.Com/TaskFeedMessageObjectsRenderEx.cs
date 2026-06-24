using System;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.Web.Components.Feed;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component]
public class TaskFeedMessageObjectsRenderExtension : FeedMessageObjectsRenderExtension
{
	public override bool IsSupport(Guid objectTypeUid, MessageObject messageObject)
	{
		return messageObject.TypeUid == InterfaceActivator.UID<IWatch>();
	}

	public override MvcHtmlString MessageObject(HtmlHelper html, MessageObject messageObject, object objectModel)
	{
		MessageObject messageObject2 = (MessageObject)objectModel;
		return MvcHtmlString.Create($"<div style=\"padding-bottom: 2px\"><a href=\"javascript:showUserInfo('{messageObject2.Id}');\">{messageObject2.Name.HtmlEncode()}</a></div>");
	}
}
