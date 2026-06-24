using System;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

public interface IMessageRelatedElement
{
	bool HasMessageType(Guid msgTypeUid);
}
