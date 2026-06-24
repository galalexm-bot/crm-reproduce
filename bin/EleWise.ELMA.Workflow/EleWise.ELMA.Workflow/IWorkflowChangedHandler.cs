using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IWorkflowChangedHandler : IEventHandler
{
	void WorkflowChanged(IWorkflowInstance pInstance);
}
