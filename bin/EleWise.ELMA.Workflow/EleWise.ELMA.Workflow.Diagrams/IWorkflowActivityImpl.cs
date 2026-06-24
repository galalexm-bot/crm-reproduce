using System.Activities;
using EleWise.ELMA.Diagrams;

namespace EleWise.ELMA.Workflow.Diagrams.Activities;

public interface IWorkflowActivityImpl
{
	void ContinueOnDefaultConnector(NativeActivityContext context);

	void ContinueOnConnector(NativeActivityContext context, Connector connector);
}
