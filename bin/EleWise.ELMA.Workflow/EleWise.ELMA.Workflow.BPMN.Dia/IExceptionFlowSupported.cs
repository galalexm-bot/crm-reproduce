using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;

public interface IExceptionFlowSupported
{
	EventTrigger[] SupportedTriggers { get; }
}
