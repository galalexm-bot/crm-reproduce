using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

public interface IElementWithView
{
	FormView View { get; set; }
}
