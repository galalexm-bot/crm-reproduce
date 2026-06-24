using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

public enum TimespanType
{
	[DisplayName(typeof(__Resources_TimespanType), "P_Minute_DisplayName")]
	Minute,
	[DisplayName(typeof(__Resources_TimespanType), "P_Hour_DisplayName")]
	Hour,
	[DisplayName(typeof(__Resources_TimespanType), "P_Day_DisplayName")]
	Day,
	[DisplayName(typeof(__Resources_TimespanType), "P_Week_DisplayName")]
	Week
}
