using System;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Components.Feed;

[Component(Order = 500)]
public class CalendarEventPeriodicalFeedObjectGroupExtension : DefaultFeedObjectGroupExtension
{
	public override string MessageTypeCssClass => "FeedTypeCalendarEventPeriodical";

	public override bool IsSupport(Guid objectTypeUid)
	{
		return MetadataLoader.IsBaseOrChildClass<ICalendarEventPeriodical>(objectTypeUid);
	}

	public override string MessageTypeName(Guid objectTypeUid)
	{
		return SR.T("Периодическое событие");
	}
}
