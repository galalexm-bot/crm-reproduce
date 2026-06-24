using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Models;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Components;

[Component(Order = 10)]
internal class ControlerTaskBlockUserTaskObjectsPropertyFilter : ReplacementTaskObjectsPropertyFilterBase<ITask>
{
	protected override Expression<Func<ITask, object>> UserProperty => (ITask m) => m.ControlUser;

	protected override ICriterion CreatePropertyCriteria(IEntity replacementObject)
	{
		Conjunction obj = Restrictions.Conjunction();
		((Junction)obj).Add((ICriterion)(object)Restrictions.In("Status", TaskBaseExtensions.CurrentControlStatuses.CastToArrayOrNull<object>()));
		return (ICriterion)(object)obj;
	}

	protected override IEnumerable<Expression<Func<ITask, object>>> GetProjections()
	{
		yield return (ITask t) => t.Status;
	}

	protected override bool IsReadOnly(IEntity replacementObject, ITask entity)
	{
		if (entity != null)
		{
			return !((ICollection<TaskBaseStatus>)TaskBaseExtensions.CurrentControlStatuses).Contains(entity.Status);
		}
		return false;
	}

	public override bool CanUseForReplacementTaskType(IReplacementTask replacementTask)
	{
		return replacementTask.IsBlockUserTask();
	}
}
