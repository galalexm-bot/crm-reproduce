using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Tasks;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

public enum TaskMarker
{
	[DisplayName(typeof(__Resources_TaskMarker), "P_None_DisplayName")]
	[ShapeImage(typeof(MarkerShape), 32)]
	None,
	[DisplayName(typeof(__Resources_TaskMarker), "P_Loop_DisplayName")]
	[ShapeImage(typeof(MarkerLoopShape), 32)]
	Loop,
	[ShapeImage(typeof(MarkerConditionShape), 32)]
	[DisplayName(typeof(__Resources_TaskMarker), "P_Condition_DisplayName")]
	Condition,
	[ShapeImage(typeof(MarkerMultiInstanceShape), 32)]
	[DisplayName(typeof(__Resources_TaskMarker), "P_MultiInstance_DisplayName")]
	MultiInstance
}
