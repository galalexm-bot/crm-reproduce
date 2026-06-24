using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Tasks.Models;
using NHibernate.Event;

namespace EleWise.ELMA.Tasks.Listeners;

[Component]
internal class TaskBaseRecoveryFactWorkLogListener : EntityEventsListener
{
	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		RecoveryFactWorkLog(@event, ((AbstractPreDatabaseOperationEvent)@event).get_Entity() as ITaskBase);
		return base.OnPreUpdate(@event);
	}

	private static void RecoveryFactWorkLog(PreUpdateEvent @event, ITaskBase taskBase)
	{
		if (taskBase != null)
		{
			int num = Array.IndexOf(((AbstractPreDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), "FactWorkLog");
			if (num >= 0)
			{
				taskBase.FactWorkLog = (WorkTime?)@event.get_OldState()[num];
			}
		}
	}
}
