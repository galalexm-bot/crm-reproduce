using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class WeekDayModel
{
	public IResourceCalendar Entity { get; set; }

	public bool SimpleModeEnable { get; set; }

	public ConfigDataModel BaseConfigDataModel { get; set; }

	public ConfigDataModel WeekDayConfigDataModel { get; set; }

	public WeekDayModel()
	{
	}

	public WeekDayModel(IResourceCalendar productionSchedule, DayOfWeek dayOfWeek)
	{
		if (productionSchedule == null)
		{
			throw new ArgumentNullException("productionSchedule");
		}
		Entity = productionSchedule;
		long workingTimeIntervalNegativeId = (((IEnumerable<IBaseTimeInterval>)Entity.BaseIntervals).Any() ? ((IEnumerable<IWorkTimeInterval>)Entity.WorkIntervals).Min((IWorkTimeInterval bi) => bi.Id) : 0);
		workingTimeIntervalNegativeId = ((workingTimeIntervalNegativeId > 0) ? 0 : workingTimeIntervalNegativeId);
		((IEnumerable<IWorkTimeInterval>)Entity.WorkIntervals).Where((IWorkTimeInterval wi) => wi.Id == 0).ForEach(delegate(IWorkTimeInterval wi)
		{
			wi.Id = --workingTimeIntervalNegativeId;
		});
		BaseConfigDataModel = new ConfigDataModel((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals);
		WeekDayConfigDataModel = new ConfigDataModel((IEnumerable<IBaseTimeInterval>)productionSchedule.BaseIntervals, (IEnumerable<IWorkTimeInterval>)productionSchedule.WorkIntervals, dayOfWeek);
		SimpleModeEnable = BaseConfigDataModel.SimpleModeEnable && WeekDayConfigDataModel.SimpleModeEnable;
		BaseConfigDataModel.SimpleModeEnable = SimpleModeEnable;
		WeekDayConfigDataModel.SimpleModeEnable = SimpleModeEnable;
	}
}
