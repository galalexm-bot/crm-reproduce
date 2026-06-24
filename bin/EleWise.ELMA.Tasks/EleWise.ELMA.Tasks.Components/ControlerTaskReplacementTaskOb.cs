using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Components;

[Component(Order = 10)]
public class ControlerTaskReplacementTaskObjectsPropertyFilter : ReplacementTaskObjectsPropertyFilterBase<ITask>
{
	protected override Expression<Func<ITask, object>> UserProperty => (ITask m) => m.ControlUser;

	protected override ICriterion CreatePropertyCriteria(IEntity replacementObject)
	{
		IReplacement replacement = (IReplacement)replacementObject;
		DateTime dateTime = ReplacementStartDate(replacement);
		DateTime dateTime2 = ReplacementEndDate(replacement);
		Conjunction obj = Restrictions.Conjunction();
		((Junction)obj).Add((ICriterion)(object)Restrictions.In("Status", TaskBaseExtensions.CurrentControlStatuses.CastToArrayOrNull<object>())).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("EndDate"), (ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Ge("EndDate", (object)dateTime), (ICriterion)(object)Restrictions.Le("EndDate", (object)dateTime2))));
		return (ICriterion)(object)obj;
	}

	protected override IEnumerable<Expression<Func<ITask, object>>> GetProjections()
	{
		yield return (ITask t) => t.Status;
	}

	protected override bool IsReadOnly(IEntity replacementObject, ITask entity)
	{
		IReplacement replacement = (IReplacement)replacementObject;
		DateTime dateTime = ReplacementStartDate(replacement);
		DateTime dateTime2 = ReplacementEndDate(replacement);
		if (entity != null)
		{
			if (((ICollection<TaskBaseStatus>)TaskBaseExtensions.CurrentControlStatuses).Contains(entity.Status))
			{
				if (entity.EndDate.HasValue)
				{
					if (entity.EndDate.Value >= dateTime)
					{
						return !(entity.EndDate.Value <= dateTime2);
					}
					return true;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	private static DateTime ReplacementEndDate(IReplacement replacement)
	{
		return replacement.EndDate.Date.AddDays(1.0).AddSeconds(-10.0);
	}

	private static DateTime ReplacementStartDate(IReplacement replacement)
	{
		return replacement.StartDate.Date.AddDays(-((IReplacementExtension)replacement).ReAssignFinishDays);
	}
}
