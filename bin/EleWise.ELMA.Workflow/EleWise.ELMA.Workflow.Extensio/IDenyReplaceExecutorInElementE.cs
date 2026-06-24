using System;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

namespace EleWise.ELMA.Workflow.ExtensionPoints;

[Obsolete("Используйте IDenyReplaceExecutorExtention")]
public interface IDenyReplaceExecutorInElementExtentions
{
	[Obsolete("Используйте IDenyReplaceExecutorExtention.DenyReplace")]
	bool DenyReplace(BPMNFlowElement element);
}
