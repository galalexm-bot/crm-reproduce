using EleWise.ELMA.Calendar.Managers;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate.Event;

namespace EleWise.ELMA.Calendar.Listeners;

[Component]
public class UserListener : PostFlushEventListener
{
	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is EleWise.ELMA.Security.Models.IUser user)
		{
			ScheduleManager.Instance.GetUserSchedule(user);
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		EleWise.ELMA.Security.Models.IUser user = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as EleWise.ELMA.Security.Models.IUser;
		if (user == null)
		{
			return;
		}
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			ISchedule userSchedule = ScheduleManager.Instance.GetUserSchedule(user);
			if (userSchedule != null && userSchedule.Name != user.FullName)
			{
				userSchedule.Name = user.FullName;
				userSchedule.Save();
			}
		});
	}
}
