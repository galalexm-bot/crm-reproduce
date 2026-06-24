using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.Components;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Models;

public class EditCalendarEventHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IAttachedHistoryModel, IEditedHistoryModel<ICalendarEvent>, ICalendarEventHistoryModel
{
	public IComment Comment { get; set; }

	public ICollection<IAttachment> Attachments { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public ICalendarEvent OldEntity { get; set; }

	public ICalendarEvent NewEntity { get; set; }

	public IList<ICalendarEventUser> OldEventUsers { get; set; }

	public IList<ICalendarEventUser> NewEventUsers { get; set; }

	public List<Guid> BaseProperties => CalendarEventActionHelper.BaseProperties();

	public EditCalendarEventHistoryModel(EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
