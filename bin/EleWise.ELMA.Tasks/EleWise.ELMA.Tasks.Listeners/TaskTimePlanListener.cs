using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using NHibernate.Event;

namespace EleWise.ELMA.Tasks.Listeners;

[Component]
internal class TaskTimePlanListener : PostFlushEventListener
{
	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is ITaskBase task)
		{
			TaskTimePlanManager instance = TaskTimePlanManager.Instance;
			InstanceOf<ITaskTimePlanFilter> instanceOf = new InstanceOf<ITaskTimePlanFilter>();
			instanceOf.New.Task = task;
			instance.Find(instanceOf.New, FetchOptions.All).ForEach(delegate(ITaskTimePlan p)
			{
				EntityModelHistoryManager.Instance.RecordUpdated(p);
			});
		}
	}
}
