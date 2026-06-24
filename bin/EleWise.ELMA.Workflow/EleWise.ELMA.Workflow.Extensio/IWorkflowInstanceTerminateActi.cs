using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IWorkflowInstanceTerminateAction
{
	void Execute(IWorkflowInstance instance);
}
