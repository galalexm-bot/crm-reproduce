using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface ILinkedTaskCloseChecker
{
	bool CanUse(ITask task);

	ICollection<ITask> GetTasksForClose(ITask task);
}
