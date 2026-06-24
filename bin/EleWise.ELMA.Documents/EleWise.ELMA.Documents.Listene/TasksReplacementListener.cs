using System;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;
using NHibernate.Event;

namespace EleWise.ELMA.Documents.Listeners;

[Component(Order = 20)]
internal class TasksReplacementListener : PostFlushEventListener
{
	public ISecurityService SecurityService { get; set; }

	public ReplacementManager ReplacementManager { get; set; }

	public DocumentManager DocumentManager { get; set; }

	public override void OnPostInsert(PostInsertEvent @event)
	{
		ITaskBase task = ((AbstractPostDatabaseOperationEvent)@event).get_Entity() as ITaskBase;
		PostInsertTask(task, @event.get_State(), ((AbstractPostDatabaseOperationEvent)@event).get_Persister().get_PropertyNames());
	}

	private void PostInsertTask(ITaskBase task, object[] state, string[] propertyNames)
	{
		if (task == null)
		{
			return;
		}
		string value = LinqUtils.NameOf((Expression<Func<ITaskBase, object>>)((ITaskBase f) => f.Executor));
		string value2 = LinqUtils.NameOf((Expression<Func<ITaskBase, object>>)((ITaskBase f) => f.ExecutorReplaced));
		int num = Array.IndexOf(propertyNames, value);
		int num2 = Array.IndexOf(propertyNames, value2);
		EleWise.ELMA.Security.Models.IUser obj = (EleWise.ELMA.Security.Models.IUser)state[num];
		EleWise.ELMA.Security.Models.IUser user = (EleWise.ELMA.Security.Models.IUser)state[num2];
		if (obj != user && user != null)
		{
			IReplacement replacement = ReplacementManager.FindPlannedReplacement(user, null, task.StartDate.HasValue ? new DateTime?(task.StartDate.Value.Date) : null, task.EndDate.HasValue ? new DateTime?(task.EndDate.Value.Date) : null).FirstOrDefault();
			if (replacement != null && replacement is IReplacementTaskDocumentPermission replacementTaskDocumentPermission && (replacementTaskDocumentPermission.TaskDocumentsManagePermissions || replacementTaskDocumentPermission.TaskDocumentsPermissions) && replacementTaskDocumentPermission.SourceUser != null && ReplacementManager.CheckReplacementnData(replacementTaskDocumentPermission))
			{
				DocumentManager.ReplacementTaskSetPermissionAction(task, replacementTaskDocumentPermission);
			}
		}
	}
}
