using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IDenyReplaceExecutorExtention
{
	bool DenyReplace(BPMNFlowElement element, SwimlaneElement swimlane);
}
