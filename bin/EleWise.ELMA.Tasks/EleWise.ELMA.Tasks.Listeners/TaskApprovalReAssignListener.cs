using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;
using NHibernate.Event;

namespace EleWise.ELMA.Tasks.Listeners;

[Component]
internal class TaskApprovalReAssignListener : PostFlushEventListener
{
	private static string propertyName = LinqUtils.NameOf((Expression<Func<IApprovalTask, object>>)((IApprovalTask oi) => oi.Executor));

	private static Expression<Func<IApprovalTask, object>> harmonizatorExpression = (IApprovalTask t) => t.Harmonizator;

	private static string harmonizatorTypeRole = harmonizatorExpression.ToString();

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (!(((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IApprovalTask))
		{
			return;
		}
		IApprovalTask approvalTask = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IApprovalTask;
		int num = Array.IndexOf(((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames(), propertyName);
		if (num <= -1 || object.Equals(@event.get_OldState()[num], @event.get_State()[num]))
		{
			return;
		}
		ITaskBase taskBase = approvalTask.ParentTask.CastAsRealType();
		if (taskBase != null)
		{
			taskBase.Harmonizator = approvalTask.Executor;
			taskBase.Permissions.RemoveAll((ICollection<ITaskBasePermission>)((IEnumerable<ITaskBasePermission>)taskBase.Permissions).Where((ITaskBasePermission p) => p.TypeRole == harmonizatorTypeRole).ToList());
			ISet<ITaskBasePermission> permissions = taskBase.Permissions;
			InstanceOf<ITaskBasePermission> instanceOf = new InstanceOf<ITaskBasePermission>();
			instanceOf.New.Target = taskBase;
			instanceOf.New.TypeRole = harmonizatorTypeRole;
			instanceOf.New.User = approvalTask.Executor;
			instanceOf.New.Uid = Guid.NewGuid();
			instanceOf.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(approvalTask.Executor.Id);
			permissions.Add(instanceOf.New);
		}
	}
}
