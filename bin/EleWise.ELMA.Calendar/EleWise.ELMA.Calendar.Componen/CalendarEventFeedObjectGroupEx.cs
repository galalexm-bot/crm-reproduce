using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Components.Feed;

[Component(Order = 500)]
public class CalendarEventFeedObjectGroupExtension : DefaultFeedObjectGroupExtension
{
	public override string MessageTypeCssClass => "FeedTypeCalendarEvent";

	public override bool IsSupport(Guid objectTypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<ICalendarEvent>(objectTypeUid);
	}

	public override string MessageTypeName(Guid objectTypeUid)
	{
		return SR.T("Событие в календаре");
	}
}
