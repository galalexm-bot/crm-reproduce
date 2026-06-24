using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogItemEditModel : EntityModel<IWorkLogItem>
{
	private bool? canCreateTask;

	public string PopupId { get; set; }

	public string CallBackScript { get; set; }

	public string CallBackScriptParam { get; set; }

	public WorkTime? FactWorkTime { get; set; }

	public IWorkLogActivity Activity { get; set; }

	public bool CanCreateTask
	{
		get
		{
			if (!canCreateTask.HasValue)
			{
				canCreateTask = WorkLogItemManager.Instance.CanCreateWorkLogForObjectType(InterfaceActivator.UID<ITask>());
			}
			return canCreateTask.Value;
		}
	}

	public string Name { get; set; }

	public long? WorkLogId { get; set; }
}
