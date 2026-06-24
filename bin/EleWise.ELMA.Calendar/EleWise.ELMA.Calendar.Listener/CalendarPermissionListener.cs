using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Calendar.Listeners;

[Component]
internal class CalendarPermissionListener : UserGroupListener
{
	public override void DeletePermissions(PreDeleteEvent @event)
	{
		DeletePermission(@event, (ISchedulePermission a) => a.Group);
	}
}
