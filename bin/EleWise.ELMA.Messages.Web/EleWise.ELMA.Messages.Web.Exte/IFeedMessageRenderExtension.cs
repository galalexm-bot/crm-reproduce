using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Messages.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFeedMessageRenderExtension : IFeedCommentActionRenderExtension
{
	MvcHtmlString ParentAddInfo(HtmlHelper html, FeedModel message, List<Pair<string, List<WebDataItem>>> dataList);
}
