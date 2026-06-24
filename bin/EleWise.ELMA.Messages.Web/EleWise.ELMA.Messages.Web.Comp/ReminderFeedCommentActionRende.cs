using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Components.Feed;

[Component(Order = 500)]
public class ReminderFeedCommentActionRenderExtension : DefaultFeedCommentActionRenderExtension
{
	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		return Locator.GetServiceNotNull<ReminderFeedCommentActionNameExtension>().IsSupport(objectTypeUid, actionUid);
	}

	public override string ActionName(FeedModel message)
	{
		return Locator.GetServiceNotNull<ReminderFeedCommentActionNameExtension>().ActionName(message);
	}
}
