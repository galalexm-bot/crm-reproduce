using EleWise.ELMA.Model.Mappings;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

public interface IElementWithPropertyMap
{
	PropertyMap[] UsingPropertyMap { get; }
}
