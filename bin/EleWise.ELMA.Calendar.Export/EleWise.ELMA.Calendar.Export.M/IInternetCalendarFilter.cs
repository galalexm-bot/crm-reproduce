using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar.Export.Models;

[FilterFor(typeof(IInternetCalendar))]
public interface IInternetCalendarFilter : IEntityFilter
{
	InternetCalendarPeriod? Period { get; set; }

	ISchedule Calendar { get; set; }

	IUser CreationAuthor { get; set; }

	bool? QuickConnection { get; set; }
}
