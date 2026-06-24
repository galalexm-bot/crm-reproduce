using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Audit;

[Component]
internal sealed class ReplacementUserActionsEventAggregator : IEntityActionEventAggregator
{
	public IEnumerable<ActionEventAggregatorResult> Aggregate(IList<EntityActionEventArgs> eventList, IEnumerable<ActionEventAggregatorResult> previousResults)
	{
		ActionEventAggregatorResult[] array = previousResults.ToArray();
		ActionEventAggregatorResult[] array2 = array;
		foreach (ActionEventAggregatorResult actionEventAggregatorResult in array2)
		{
			ReplacementTaskActionEventArgs replacementEntity = actionEventAggregatorResult.EventArgs as ReplacementTaskActionEventArgs;
			if (replacementEntity == null)
			{
				continue;
			}
			ActionEventAggregatorResult actionEventAggregatorResult2 = array.FirstOrDefault(delegate(ActionEventAggregatorResult i)
			{
				if (!(i.EventArgs is EditEntityActionEventArgs editEntityActionEventArgs))
				{
					return false;
				}
				return editEntityActionEventArgs.New == replacementEntity.New && CheckChangedProperties(editEntityActionEventArgs);
			});
			if (actionEventAggregatorResult2 != null)
			{
				EntityActionEventArgs eventArgs = actionEventAggregatorResult2.EventArgs;
				replacementEntity.SetAdditionalData(eventArgs.GetAdditionalData());
				actionEventAggregatorResult2.Persist = false;
			}
		}
		return Enumerable.Empty<ActionEventAggregatorResult>();
	}

	private static bool CheckChangedProperties(EditEntityActionEventArgs entityActionEventArgs)
	{
		if (entityActionEventArgs.ChangedProperties != null && entityActionEventArgs.ChangedProperties.Count != 0)
		{
			return entityActionEventArgs.ChangedProperties.Any((PropertyMetadata x) => x.Name == LinqUtils.NameOf((Expression<Func<ITask, object>>)((ITask u) => u.ControlUserReplaced)) || x.Name == LinqUtils.NameOf((Expression<Func<ITask, object>>)((ITask u) => u.Harmonizator)) || x.Name == LinqUtils.NameOf((Expression<Func<ITask, object>>)((ITask u) => u.Executor)));
		}
		return false;
	}
}
