using System;
using EleWise.ELMA.Calendar.Components.Feed;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components.Feed;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Docflow.Web.Components;

[Component(Order = 500)]
public class CalendarEventFeedCommentActionRenderExtension : DefaultFeedCommentActionRenderExtension
{
	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		return Locator.GetServiceNotNull<CalendarEventFeedCommentActionNameExtension>().IsSupport(objectTypeUid, actionUid);
	}

	public override string ActionName(FeedModel message)
	{
		return Locator.GetServiceNotNull<CalendarEventFeedCommentActionNameExtension>().ActionName(message);
	}
}
