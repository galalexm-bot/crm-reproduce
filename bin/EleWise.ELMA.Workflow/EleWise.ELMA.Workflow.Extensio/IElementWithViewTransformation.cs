using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IElementWithViewTransformation
{
	bool AcceptableElement(IElementWithView element);

	FormView GetFormView(IElementWithView element, IWorkflowTaskBase task);
}
