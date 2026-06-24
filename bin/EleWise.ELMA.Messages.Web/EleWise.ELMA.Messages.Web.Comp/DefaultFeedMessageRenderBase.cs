using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.ExtensionPoints;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Messages.Web.Components.Feed;

public abstract class DefaultFeedMessageRenderBase : DefaultFeedCommentActionRenderExtension, IFeedMessageRenderExtension, IFeedCommentActionRenderExtension
{
	public virtual MvcHtmlString ParentAddInfo(HtmlHelper html, FeedModel message, List<Pair<string, List<WebDataItem>>> dataList)
	{
		return MvcHtmlString.Empty;
	}
}
