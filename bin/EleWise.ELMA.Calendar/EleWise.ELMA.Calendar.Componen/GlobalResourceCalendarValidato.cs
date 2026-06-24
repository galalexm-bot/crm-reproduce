using EleWise.ELMA.Calendar.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.Calendar.Components;

[Component]
internal class GlobalResourceCalendarValidator : IResourceCalendarValidator
{
	public bool CanDelete(IResourceCalendar productionSchedule)
	{
		return productionSchedule.Uid != CalendarConstants.GlobalProductionScheduleEntityUid;
	}
}
