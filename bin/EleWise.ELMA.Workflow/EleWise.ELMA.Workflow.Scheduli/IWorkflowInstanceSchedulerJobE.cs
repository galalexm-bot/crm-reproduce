using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Scheduling;

public interface IWorkflowInstanceSchedulerJobExecutor
{
	void CloseActiveJobs(IWorkflowInstance instance);
}
