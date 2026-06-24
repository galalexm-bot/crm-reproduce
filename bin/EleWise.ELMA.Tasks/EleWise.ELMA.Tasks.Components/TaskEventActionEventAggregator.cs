using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component(Order = 1000000)]
public class TaskEventActionEventAggregator : IEntityActionEventAggregator
{
	public IEnumerable<ActionEventAggregatorResult> Aggregate(IList<EntityActionEventArgs> eventList, IEnumerable<ActionEventAggregatorResult> previousResults)
	{
		foreach (IGrouping<long, ActionEventAggregatorResult> item in (from e in previousResults
			where e.EventArgs.Action != null && e.EventArgs.Object != null && (e.EventArgs.Action.Uid == DefaultEntityActions.CreateGuid || e.EventArgs.Action.Uid == TaskBaseActions.ActivateGuid) && e.EventArgs.New != null && e.EventArgs.New is IEntity<long> && e.EventArgs.Object.Uid == InterfaceActivator.UID<ITask>()
			group e by ((IEntity<long>)e.EventArgs.New).Id).ToList())
		{
			int num = 0;
			ActionEventAggregatorResult actionEventAggregatorResult = item.FirstOrDefault((ActionEventAggregatorResult e) => e.EventArgs.Action.Uid == DefaultEntityActions.CreateGuid);
			foreach (ActionEventAggregatorResult item2 in item)
			{
				if ((actionEventAggregatorResult == null && num == 0) || (actionEventAggregatorResult != null && actionEventAggregatorResult == item2))
				{
					num++;
					continue;
				}
				item2.Persist = false;
				num++;
			}
		}
		return Enumerable.Empty<ActionEventAggregatorResult>();
	}
}
