using System.Activities;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Diagrams.Elements;

namespace EleWise.ELMA.Workflow.Diagrams.Activities;

public interface IActivityWithExceptionFlowsImpl : IWorkflowActivityImpl
{
	IElementWithExceptionFlows Element { get; }

	IUser[] GetSwimlaneExecutors(NativeActivityContext context, out bool assignedToResponsible);
}
