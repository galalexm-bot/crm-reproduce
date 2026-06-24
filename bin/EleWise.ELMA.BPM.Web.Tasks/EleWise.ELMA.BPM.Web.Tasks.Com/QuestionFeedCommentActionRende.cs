using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components.Feed;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Components.Feed;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 500)]
public class QuestionFeedCommentActionRenderExtension : DefaultFeedCommentActionRenderExtension
{
	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		return Locator.GetServiceNotNull<QuestionFeedCommentActionNameExtension>().IsSupport(objectTypeUid, actionUid);
	}

	public override string ActionName(FeedModel message)
	{
		return Locator.GetServiceNotNull<QuestionFeedCommentActionNameExtension>().ActionName(message);
	}
}
