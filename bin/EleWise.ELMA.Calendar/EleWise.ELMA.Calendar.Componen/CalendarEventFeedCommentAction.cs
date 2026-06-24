using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Components.Feed;

[Component(Order = 500)]
public class CalendarEventFeedCommentActionNameExtension : DefaultFeedCommentActionNameExtension
{
	public override bool IsSupport(Guid objectTypeUid, Guid actionUid)
	{
		return MetadataLoader.IsBaseOrChildClass<ICalendarEvent>(objectTypeUid) && (actionUid == DefaultEntityActions.CreateGuid || actionUid == CalendarEventActions.EditGuid || actionUid == CalendarEventActions.CompleteGuid || actionUid == DefaultEntityActions.DeleteGuid);
	}

	public override string ActionName(FeedModel message)
	{
		if (message != null && message.ActionUid == CalendarEventActions.CompleteGuid)
		{
			return SR.T("Событие завершено");
		}
		if (message != null && message.ActionUid == DefaultEntityActions.DeleteGuid)
		{
			return SR.T("Событие удалено");
		}
		return base.ActionName(message);
	}
}
