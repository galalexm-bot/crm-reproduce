using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface IWorkflowRuntimeService
{
	IWorkflowExecutingContext CreateExecutingContext(IWorkflowInstance instance);

	void Run(IWorkflowInstance instance);

	void Run(IWorkflowInstance instance, bool InitiatorSwimlaneUser);

	void Run(IWorkflowInstance instance, bool InitiatorSwimlaneUser, bool IsEmulation);

	void Terminate(IWorkflowInstance instance, string reason);

	void Execute(IWorkflowExecuteData data);
}
