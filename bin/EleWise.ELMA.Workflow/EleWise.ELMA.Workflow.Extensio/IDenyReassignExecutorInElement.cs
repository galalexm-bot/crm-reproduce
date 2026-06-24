using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IDenyReassignExecutorInElementExtentions
{
	bool DenyReassign(BPMNFlowElement element);
}
