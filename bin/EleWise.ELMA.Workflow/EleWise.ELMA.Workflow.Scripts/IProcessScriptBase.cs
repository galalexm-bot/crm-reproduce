using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Workflow.Scripts;

internal interface IProcessScriptBase
{
	void OnTaskCreate(ITaskBase task, object context);

	void OnTaskUpdate(ITaskBase oldTask, ITaskBase newTask, object context);
}
