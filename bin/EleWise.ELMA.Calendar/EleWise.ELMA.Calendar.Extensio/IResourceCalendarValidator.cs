using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.Calendar.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IResourceCalendarValidator
{
	bool CanDelete(IResourceCalendar productionSchedule);
}
