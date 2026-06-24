using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate;
using NHibernate.Event;

namespace EleWise.ELMA.Calendar.Listeners;

[Component]
public class ScheduleListener : EntityEventsListener
{
	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is ISchedule schedule)
		{
			ISession session = (ISession)(object)((AbstractEvent)@event).get_Session();
			((IQuery)session.CreateSQLQuery("DELETE FROM ScheduleLog WHERE Schedule=:scheduleId")).SetParameter<long>("scheduleId", schedule.Id).ExecuteUpdate(cleanUpCache: false);
			session.CleanUpCache(typeof(IScheduleLog));
		}
		return false;
	}
}
