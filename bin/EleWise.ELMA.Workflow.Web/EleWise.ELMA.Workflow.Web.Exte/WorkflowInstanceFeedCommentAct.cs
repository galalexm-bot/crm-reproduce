using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components.Feed;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Components.Feed;

namespace EleWise.ELMA.Workflow.Web.ExtensionPoints;

[Component(Order = 500)]
public class WorkflowInstanceFeedCommentActionRenderExtension : DefaultFeedCommentActionRenderExtension
{
	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		return Locator.GetServiceNotNull<WorkflowInstanceFeedCommentActionNameExtension>().IsSupport(objectTypeUid, actionUid);
	}

	public override MvcHtmlString CommentAddInfo(HtmlHelper html, FeedModel message)
	{
		return PartialExtensions.Partial(html, "Feed/WorkflowInstanceAddInfo", (object)message);
	}
}
