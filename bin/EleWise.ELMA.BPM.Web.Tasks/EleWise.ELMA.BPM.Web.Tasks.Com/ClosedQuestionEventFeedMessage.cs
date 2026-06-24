using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components.Feed;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Components.Feed;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

[Component(Order = 500)]
public class ClosedQuestionEventFeedMessageRender : DefaultFeedMessageRenderBase
{
	public IAuditManager AuditManager { get; set; }

	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		return MetadataLoader.IsBaseOrChildClass<IQuestion>(objectTypeUid);
	}

	public override string ActionName(FeedModel message)
	{
		return string.Empty;
	}

	public override MvcHtmlString ParentAddInfo(HtmlHelper html, FeedModel message, List<Pair<string, List<WebDataItem>>> dataList)
	{
		string eventName = ClosedQuestionFeedMessageGetDataExtension.EventName;
		string actionDisplayName = AuditManager.GetAction(QuestionActions.CloseGuid).DisplayName;
		Pair<string, List<WebDataItem>> pair = dataList.FirstOrDefault((Pair<string, List<WebDataItem>> m) => m.First == eventName);
		if (pair == null || pair.Second == null)
		{
			return MvcHtmlString.Empty;
		}
		if (pair.Second.FirstOrDefault((WebDataItem m) => m.Name == actionDisplayName) == null)
		{
			return MvcHtmlString.Empty;
		}
		return PartialExtensions.Partial(html, "Question/ClosedQuestionParentAddInfo", (object)message);
	}
}
