using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.ExtensionPoints;
using EleWise.ELMA.Messages.Web.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Components.Feed;

[Component(Order = 100000)]
public class DefaultFeedCommentActionRenderExtension : IFeedCommentActionRenderExtension
{
	public virtual bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		return Locator.GetServiceNotNull<DefaultFeedCommentActionNameExtension>().IsSupport(objectTypeUid, actionUid);
	}

	public virtual string ActionName(FeedModel message)
	{
		return Locator.GetServiceNotNull<DefaultFeedCommentActionNameExtension>().ActionName(message);
	}

	public virtual MvcHtmlString CommentAddInfo(HtmlHelper html, FeedModel message)
	{
		if (!string.IsNullOrWhiteSpace(ActionName(message)))
		{
			return PartialExtensions.Partial(html, "Feed/Partial/CommentAddInfoDefault", (object)new CommentAddInfoDefaultModel
			{
				Message = message,
				ActionName = ActionName(message)
			});
		}
		return MvcHtmlString.Empty;
	}
}
