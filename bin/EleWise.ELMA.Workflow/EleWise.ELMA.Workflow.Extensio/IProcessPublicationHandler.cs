using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
internal interface IProcessPublicationHandler
{
	void UpdateProcess(IWorkflowProcess process);
}
