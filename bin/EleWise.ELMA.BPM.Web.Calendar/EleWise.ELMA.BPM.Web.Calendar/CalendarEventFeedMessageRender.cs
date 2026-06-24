using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.Calendar.Components.Feed;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components.Feed;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Calendar.Components.Feed;

[Component(Order = 495)]
public class CalendarEventFeedMessageRender : DefaultFeedMessageRenderBase
{
	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		return Locator.GetServiceNotNull<CalendarEventFeedCommentActionNameExtension>().IsSupport(objectTypeUid, actionUid);
	}

	public override string ActionName(FeedModel message)
	{
		return Locator.GetServiceNotNull<CalendarEventFeedCommentActionNameExtension>().ActionName(message);
	}

	public override MvcHtmlString ParentAddInfo(HtmlHelper html, FeedModel message, List<Pair<string, List<WebDataItem>>> dataList)
	{
		Pair<string, List<WebDataItem>> pair = dataList.FirstOrDefault((Pair<string, List<WebDataItem>> m) => m.First == "CalendarEvent");
		if (pair == null || pair.Second == null)
		{
			return MvcHtmlString.Empty;
		}
		CalendarEventAddInfo calendarEventAddInfo = new CalendarEventAddInfo();
		WebDataItem webDataItem = pair.Second.FirstOrDefault((WebDataItem m) => m.Name == CalendarEventManager.NeedConfirmParticipationKeyName);
		bool result = false;
		if (webDataItem != null && !string.IsNullOrEmpty(webDataItem.Value) && bool.TryParse(webDataItem.Value, out result))
		{
			calendarEventAddInfo.NeedConfirmParticipation = result;
		}
		WebDataItem webDataItem2 = pair.Second.FirstOrDefault((WebDataItem m) => m.Name == CalendarEventManager.EventStartDateKeyName);
		if (webDataItem2 != null && !string.IsNullOrEmpty(webDataItem2.Value) && long.TryParse(webDataItem2.Value, out var result2))
		{
			DateTime runtimeDateTime = new DateTime(result2);
			runtimeDateTime = runtimeDateTime.ToClientDateTime();
			calendarEventAddInfo.StartDate = runtimeDateTime;
		}
		return PartialExtensions.Partial(html, "Feed/CalendarEventParentAddInfo", (object)calendarEventAddInfo);
	}
}
