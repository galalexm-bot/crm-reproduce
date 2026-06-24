using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

public enum TimeSetType
{
	[DisplayName(typeof(__Resources_TimeSetType), "P_ExactValue_DisplayName")]
	ExactValue,
	[DisplayName(typeof(__Resources_TimeSetType), "P_ContextVar_DisplayName")]
	ContextVar
}
