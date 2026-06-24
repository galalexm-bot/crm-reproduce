using System;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Projects.Models.Resources;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class ProductionScheduleUserSettingModel
{
	public IUser User { get; set; }

	public ProductionScheduleType ProductionScheduleType { get; set; }

	public IResourceCalendar CommonProductionSchedule { get; set; }

	public IResourceCalendar PersonalProductionSchedule { get; set; }

	public string WorkIntervalsJsonData { get; set; }

	public string HolidayIntervalsJsonData { get; set; }

	public ProductionScheduleUserSettingModel()
	{
	}

	public ProductionScheduleUserSettingModel([NotNull] IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		User = user;
		IResourceCalendar byUser = ResourceCalendarManager.Instance.GetByUser(user);
		ProductionScheduleType = ((!(byUser.Uid == CalendarConstants.GlobalProductionScheduleEntityUid)) ? ((byUser.IsCatalog.HasValue && byUser.IsCatalog.Value) ? ProductionScheduleType.Common : ProductionScheduleType.Personal) : ProductionScheduleType.Global);
		switch (ProductionScheduleType)
		{
		case ProductionScheduleType.Common:
			CommonProductionSchedule = byUser;
			break;
		case ProductionScheduleType.Personal:
			PersonalProductionSchedule = byUser;
			break;
		}
	}
}
