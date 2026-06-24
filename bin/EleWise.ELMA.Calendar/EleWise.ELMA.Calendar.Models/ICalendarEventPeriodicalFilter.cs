using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.Calendar.Models;

[FilterFor(typeof(ICalendarEventPeriodical))]
public interface ICalendarEventPeriodicalFilter : ICalendarEventFilter, IEntityFilter
{
	DateTimeRange UntilDate { get; set; }

	bool? Closed { get; set; }
}
