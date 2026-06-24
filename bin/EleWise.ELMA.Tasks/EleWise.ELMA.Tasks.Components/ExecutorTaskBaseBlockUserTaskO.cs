using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Extensions;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using NHibernate.Criterion;

namespace EleWise.ELMA.Tasks.Components;

[Component(Order = 10)]
internal class ExecutorTaskBaseBlockUserTaskObjectsPropertyFilter : ReplacementTaskObjectsPropertyFilterBase<ITaskBase>
{
	protected override Expression<Func<ITaskBase, object>> UserProperty => (ITaskBase m) => m.Executor;

	protected override ICriterion CreatePropertyCriteria(IEntity replacementObject)
	{
		Conjunction obj = Restrictions.Conjunction();
		((Junction)obj).Add((ICriterion)(object)Restrictions.In("Status", TaskBaseExtensions.ActiveTaskStatuses.CastToArrayOrNull<object>()));
		return (ICriterion)(object)obj;
	}

	protected override IEnumerable<Expression<Func<ITaskBase, object>>> GetProjections()
	{
		yield return (ITaskBase t) => t.Status;
	}

	protected override bool IsReadOnly(IEntity replacementObject, ITaskBase entity)
	{
		if (entity != null)
		{
			return !((ICollection<TaskBaseStatus>)TaskBaseExtensions.ActiveTaskStatuses).Contains(entity.Status);
		}
		return false;
	}

	protected override bool ReplaceProperty(ITaskBase entity, EleWise.ELMA.Security.Models.IUser newUser)
	{
		IReAssignTaskActionModel reAssignActionModel = InterfaceActivator.Create<IReAssignTaskActionModel>();
		reAssignActionModel.TaskId = entity.Id;
		reAssignActionModel.Executor = newUser;
		reAssignActionModel.Priority = entity.Priority;
		if (entity.StartDate.HasValue)
		{
			reAssignActionModel.StartDate = entity.StartDate.Value;
		}
		if (entity.EndDate.HasValue)
		{
			reAssignActionModel.EndDate = entity.EndDate.Value;
		}
		bool ignoreRedirectActionExecute = TaskBaseManager<ITaskBase>.IgnoreRedirectActionExecute;
		TaskBaseManager<ITaskBase>.IgnoreRedirectActionExecute = true;
		try
		{
			Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
			{
				TaskBaseManager.Instance.InvokeAction((TaskBaseManager m) => m.ReAssign(reAssignActionModel), entity.GetType());
			});
		}
		finally
		{
			TaskBaseManager<ITaskBase>.IgnoreRedirectActionExecute = ignoreRedirectActionExecute;
		}
		return true;
	}

	public override bool CanUseForReplacementTaskType(IReplacementTask replacementTask)
	{
		return replacementTask.IsBlockUserTask();
	}
}
