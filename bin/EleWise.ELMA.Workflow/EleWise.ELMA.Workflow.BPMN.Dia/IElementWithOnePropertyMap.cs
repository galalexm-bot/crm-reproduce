using EleWise.ELMA.Model.Mappings;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

public interface IElementWithOnePropertyMap : IElementWithPropertyMap
{
	PropertyMap Map { get; set; }
}
