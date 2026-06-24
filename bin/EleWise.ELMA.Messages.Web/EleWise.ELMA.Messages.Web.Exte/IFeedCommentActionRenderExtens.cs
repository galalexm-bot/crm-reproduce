using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFeedCommentActionRenderExtension
{
	bool IsSupport(Guid objectTypeUid, Guid actionUid);

	string ActionName(FeedModel message);

	MvcHtmlString CommentAddInfo(HtmlHelper html, FeedModel message);
}
