using EleWise.ELMA.Calendar.ExtensionPoints;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.Calendar.Components;

[Component]
internal class UserResourceCalendarValidator : IResourceCalendarValidator
{
	public bool CanDelete(IResourceCalendar productionSchedule)
	{
		IResourceCalendarUserMapFilter resourceCalendarUserMapFilter = InterfaceActivator.Create<IResourceCalendarUserMapFilter>();
		resourceCalendarUserMapFilter.Calendar = productionSchedule;
		return !EntityManager<IResourceCalendarUserMap>.Instance.Exists(resourceCalendarUserMapFilter);
	}
}
