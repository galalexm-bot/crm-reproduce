using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Mobile.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IWorkflowTaskElement
{
	bool CanUse(Element element);

	bool HasCustomView(Element element, IWorkflowInstance instance);
}
