using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components.Feed;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 500)]
public class AnswerFeedCommentActionRenderExtension : DefaultFeedCommentActionRenderExtension
{
	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		if (MetadataLoader.IsBaseOrChildClass<IAnswer>(objectTypeUid))
		{
			return actionUid == DefaultEntityActions.CreateGuid;
		}
		return false;
	}

	public override MvcHtmlString CommentAddInfo(HtmlHelper html, FeedModel message)
	{
		return MvcHtmlString.Empty;
	}
}
