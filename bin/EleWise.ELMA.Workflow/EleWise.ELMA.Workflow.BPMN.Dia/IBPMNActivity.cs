using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities;

public interface IBPMNActivity
{
	IUser[] GetSwimlaneExecutors(IWorkflowInstance instance);

	IUser[] GetSwimlaneExecutors(IWorkflowInstance instance, out bool assignedToResponsible);
}
