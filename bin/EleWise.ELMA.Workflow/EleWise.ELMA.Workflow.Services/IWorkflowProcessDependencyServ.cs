using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

internal interface IWorkflowProcessDependencyService
{
	void CollectDependencies(IWorkflowProcess process);
}
