using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Calendar.Models;

public class ChangeDateCalendarEventHistoryModel : HistoryBaseModel, ICommentedHistoryModel, IHistoryBaseModel, IEditedHistoryModel<ICalendarEvent>, ICalendarEventHistoryModel
{
	public IComment Comment { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public ICalendarEvent OldEntity { get; set; }

	public ICalendarEvent NewEntity { get; set; }

	public ChangeDateCalendarEventHistoryModel(EntityActionEventArgs originalEvent, string actionTheme)
		: base(originalEvent, actionTheme)
	{
	}
}
