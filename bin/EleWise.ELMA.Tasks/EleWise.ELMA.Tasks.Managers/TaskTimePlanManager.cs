using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Tasks.Managers;

public class TaskTimePlanManager : EntityManager<ITaskTimePlan, long>
{
	public new static TaskTimePlanManager Instance => Locator.GetServiceNotNull<TaskTimePlanManager>();

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (!(filter is ITaskTimePlanFilter taskTimePlanFilter))
		{
			return;
		}
		if (taskTimePlanFilter.Executors != null && ((IEnumerable<IUser>)taskTimePlanFilter.Executors).Any())
		{
			criteria.CreateAlias("Task", "task", (JoinType)0).Add((ICriterion)(object)Restrictions.In("task.Executor.Id", (ICollection)((IEnumerable<IUser>)taskTimePlanFilter.Executors).Select((IUser e) => e.Id).ToArray())).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("task.NotShowInLists"), (ICriterion)(object)Restrictions.Eq("task.NotShowInLists", (object)false)));
		}
		if (taskTimePlanFilter.Period.From.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Ge("EndTime", (object)taskTimePlanFilter.Period.From));
		}
		if (taskTimePlanFilter.Period.To.HasValue)
		{
			criteria.Add((ICriterion)(object)Restrictions.Le("StartTime", (object)taskTimePlanFilter.Period.To));
		}
	}
}
