using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;

[DisplayName(typeof(__Resources_SwimlaneType), "DisplayName")]
public enum SwimlaneType
{
	[DisplayName(typeof(__Resources_SwimlaneType), "P_Static_DisplayName")]
	Static,
	[DisplayName(typeof(__Resources_SwimlaneType), "P_Dynamic_DisplayName")]
	Dynamic,
	[DisplayName(typeof(__Resources_SwimlaneType), "P_DynamicScript_DisplayName")]
	DynamicScript,
	[DisplayName(typeof(__Resources_SwimlaneType), "P_BusinessRole_DisplayName")]
	BusinessRole
}
