using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Runtime.NH.Listeners;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component]
public class LifeCycleStatusListener : EntityEventsListener
{
	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		if (((AbstractPreDatabaseOperationEvent)@event).get_Entity() is ILifeCycleStatus status)
		{
			if (LifeCycleManager.Instance.GetCyclies(status).Count > 0)
			{
				throw new Exception(SR.T("Нельзя удалить статус, который участвует в жизненном цикле типа документа"));
			}
			if (LifeCycleTransitionManager.Instance.GetTransitions(status).Count > 0)
			{
				throw new Exception(SR.T("Нельзя удалить статус, который участвует в переходе в жизненном цикле типа документа"));
			}
		}
		return false;
	}
}
