using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar.Models;

[FilterFor(typeof(IScheduleLog))]
public interface IScheduleLogFilter : IEntityFilter
{
	IUser User { get; set; }

	DateTimeRange ViewDate { get; set; }

	ISchedule Schedule { get; set; }

	bool? Favorite { get; set; }
}
