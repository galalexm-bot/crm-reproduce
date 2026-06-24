using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

public enum EventType
{
	[DisplayName(typeof(__Resources_EventType), "P_Start_DisplayName")]
	Start,
	[DisplayName(typeof(__Resources_EventType), "P_Intermediate_DisplayName")]
	Intermediate,
	[DisplayName(typeof(__Resources_EventType), "P_End_DisplayName")]
	End
}
