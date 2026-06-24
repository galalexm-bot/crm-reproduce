using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Component]
public class TaskWorkLogHistoryObjectExtension : IWorkLogHistoryObjectExtension
{
	public bool CanHandle(IEntity entity)
	{
		return entity is ITask;
	}

	public bool Visible(EntityLastActionInfo entityInfo)
	{
		if (entityInfo.Entity is ITask task)
		{
			return task.Period == CalendarEventPeriod.Once;
		}
		return false;
	}
}
