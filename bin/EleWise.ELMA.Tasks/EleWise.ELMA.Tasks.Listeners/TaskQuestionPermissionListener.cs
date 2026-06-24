using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using Iesi.Collections.Generic;
using NHibernate.Event;

namespace EleWise.ELMA.Tasks.Listeners;

[Component]
internal class TaskQuestionPermissionListener : PostFlushEventListener
{
	public override void OnPostInsert(PostInsertEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IQuestion)
		{
			UpdatePermissions(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IQuestion);
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IQuestion)
		{
			UpdatePermissions(((AbstractPostDatabaseOperationEvent)@event).get_Entity() as IQuestion);
		}
	}

	private static void UpdatePermissions(IQuestion question)
	{
		if (question != null && question.RefObject != null && typeof(ITaskBase).IsAssignableFrom(question.RefObject.ObjectType) && question.RefObject.Object is ITaskBase taskBase)
		{
			taskBase.Permissions.RemoveAll((ICollection<ITaskBasePermission>)((IEnumerable<ITaskBasePermission>)taskBase.Permissions).Where((ITaskBasePermission p) => p.TypeRole == "Question.Executor_" + question.Id).ToList());
			if (question.Answer == null && question.Status != TaskBaseStatus.Complete)
			{
				ISet<ITaskBasePermission> permissions = taskBase.Permissions;
				InstanceOf<ITaskBasePermission> instanceOf = new InstanceOf<ITaskBasePermission>();
				instanceOf.New.Target = taskBase;
				instanceOf.New.TypeRole = "Question.Executor_" + question.Id;
				instanceOf.New.User = question.Executor;
				instanceOf.New.Uid = Guid.NewGuid();
				instanceOf.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(question.Executor.Id);
				permissions.Add(instanceOf.New);
			}
		}
	}
}
