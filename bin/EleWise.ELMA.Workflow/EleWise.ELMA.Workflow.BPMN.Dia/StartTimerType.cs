using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

public enum StartTimerType
{
	[DisplayName(typeof(__Resources_StartTimerType), "P_ExactTime_DisplayName")]
	ExactTime,
	[DisplayName(typeof(__Resources_StartTimerType), "P_RelativeTime_DisplayName")]
	RelativeTime,
	[DisplayName(typeof(__Resources_StartTimerType), "P_СycleStart_DisplayName")]
	СycleStart
}
