using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IWorkflowClientScriptModuleExtensions
{
	void BuildClientProcessContextScript(IWorkflowProcess process);
}
