using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.BPM.Web.Calendar.Services;

public interface IProductionScheduleConfigService
{
	IResourceCalendar GetResourceCalendar(CalendarConfigModel model);

	string GetResourceCalendarJson(IResourceCalendar resourceCalendar);

	IEnumerable<IBaseTimeInterval> GetUpdatedBaseTimeIntervalCollection(ConfigDataModel baseConfig, IEnumerable<IBaseTimeInterval> baseTimeIntervalCollection);

	IEnumerable<IWorkTimeInterval> GetUpdatedWeekDayTimeIntervalCollection(ConfigDataModel configDataModel, IEnumerable<IWorkTimeInterval> workingTimeIntervals, IEnumerable<IBaseTimeInterval> baseTimeIntervals);
}
