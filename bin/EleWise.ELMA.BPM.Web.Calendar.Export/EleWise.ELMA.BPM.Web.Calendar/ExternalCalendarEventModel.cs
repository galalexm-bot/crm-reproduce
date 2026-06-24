using EleWise.ELMA.Calendar.Export.Models;

namespace EleWise.ELMA.BPM.Web.Calendar.Export.Models;

public class ExternalCalendarEventModel
{
	public IExternalCalendar Calendar { get; set; }

	public ExternalCalendarItem Item { get; set; }
}
