using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Calendar.Components.Feed;

[Component(Order = 500)]
public class CalendarEventFeedMessageGetDataExtension : IFeedMessageGetData
{
	public string Name => "CalendarEvent";

	public bool IsSupport(Guid objectUid, Guid actionUid)
	{
		CalendarEventFeedCommentActionNameExtension serviceNotNull = Locator.GetServiceNotNull<CalendarEventFeedCommentActionNameExtension>();
		return serviceNotNull.IsSupport(objectUid, actionUid);
	}

	public List<long> GetRecipients(IEntity entity, Guid actionUid)
	{
		if (!(entity is ICalendarEvent calendarEvent) || calendarEvent.EventUsers == null)
		{
			return null;
		}
		return ((IEnumerable<ICalendarEventUser>)calendarEvent.EventUsers).Select((ICalendarEventUser u) => u.User.Id).ToList();
	}

	public List<Pair<long, List<WebDataItem>>> GetData(FeedMessageInfoParameters info, List<long> recipients)
	{
		if (!IsSupport(info.ObjectUid, info.ActionUid))
		{
			return null;
		}
		return CalendarEventManager.Instance.GetMessageObjectInfo(info.ObjectId, recipients);
	}
}
