using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.WorkLog;

[Component]
internal class CompletedTaskWorkLogExtension : IOvertimeWorkLogWithDraftsExtension
{
	public WorkLogSettingsModule WorkLogSettingsModule { get; set; }

	public IEnumerable<WorkLogItemModel> SupportedModels(IEnumerable<WorkLogItemModel> workLogItemModels)
	{
		return workLogItemModels.Where((WorkLogItemModel m) => m != null && m.WorkLogObject != null && m.WorkLogObject is ITaskBase).ToList();
	}

	public IDictionary<WorkLogItemModel, string> OvertimeDescriptionMap(IEnumerable<WorkLogItemModel> workLogItemModels, IEnumerable<long> selectedIds, bool includeDraft = true)
	{
		if (workLogItemModels == null)
		{
			return new Dictionary<WorkLogItemModel, string>();
		}
		return workLogItemModels.ToDictionary((WorkLogItemModel k) => k, delegate(WorkLogItemModel v)
		{
			IWorkLogItem workLogItem = v.WorkLogItem;
			IEntity workLogObject = v.WorkLogObject;
			if (workLogItem == null || !workLogItem.FactWorkTime.HasValue || workLogItem.WorkLogActivity == null)
			{
				return null;
			}
			if (!(workLogObject is ITaskBase task))
			{
				return null;
			}
			return (!CanSubmitWorkLogItemToClosedTask(task)) ? SR.T("Запрещено подавать трудозатраты по завершенным задачам.") : null;
		});
	}

	private bool CanSubmitWorkLogItemToClosedTask(ITaskBase task)
	{
		if (task.IsComplete())
		{
			return !WorkLogSettingsModule.Settings.DisablePutWorkLogToCompletedTasks;
		}
		return true;
	}
}
