using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
public abstract class BaseTaskModelUpdateActionHandler : IEntityActionHandler, IEventHandler
{
	public TaskBaseManager TaskBaseManager { get; set; }

	public void ActionExecuted(EntityActionEventArgs e)
	{
		if (e != null && e.Object != null && e.Action != null && e.New is ITaskBase task)
		{
			TaskBaseManager.UpdateAttachmentsSpecifiedHash(task, saveAttachments: true);
			if (IsTaskUpdated(e))
			{
				EntityModelHistoryManager.Instance.RecordUpdated(e.New);
			}
		}
	}

	protected abstract bool IsTaskUpdated(EntityActionEventArgs e);
}
