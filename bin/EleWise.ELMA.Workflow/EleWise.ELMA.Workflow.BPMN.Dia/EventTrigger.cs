using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Shapes.Events;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;

public enum EventTrigger
{
	[TriggerUsage(Start = true, Intermediate = true, End = true, BoundaryInterrupting = true)]
	[ShapeImage(typeof(TriggerShape), 32)]
	[DisplayName(typeof(__Resources_EventTrigger), "P_None_DisplayName")]
	None,
	[DisplayName(typeof(__Resources_EventTrigger), "P_MessageReceive_DisplayName")]
	[TriggerUsage(Start = false, Intermediate = false, BoundaryInterrupting = false)]
	[ShapeImage(typeof(TriggerMessageReceiveShape), 32)]
	MessageReceive,
	[TriggerUsage(Intermediate = false, End = false)]
	[ShapeImage(typeof(TriggerMessageSendShape), 32)]
	[DisplayName(typeof(__Resources_EventTrigger), "P_MessageSend_DisplayName")]
	MessageSend,
	[DisplayName(typeof(__Resources_EventTrigger), "P_Timer_DisplayName")]
	[TriggerUsage(Start = true, Intermediate = true, BoundaryInterrupting = true)]
	[ShapeImage(typeof(TriggerTimerShape), 32)]
	Timer,
	[DisplayName(typeof(__Resources_EventTrigger), "P_Script_DisplayName")]
	[TriggerUsage(BoundaryInterrupting = true)]
	[ShapeImage(typeof(TriggerScriptShape), 32)]
	Script,
	[DisplayName(typeof(__Resources_EventTrigger), "P_ErrorCatch_DisplayName")]
	[ShapeImage(typeof(TriggerErrorCatchShape), 32)]
	[TriggerUsage(Start = false, BoundaryInterrupting = true)]
	ErrorCatch,
	[ShapeImage(typeof(TriggerErrorThrowShape), 32)]
	[TriggerUsage(End = false)]
	[DisplayName(typeof(__Resources_EventTrigger), "P_ErrorThrow_DisplayName")]
	ErrorThrow,
	[ShapeImage(typeof(TriggerIndicatorShape), 32)]
	[DisplayName(typeof(__Resources_EventTrigger), "P_Metric_DisplayName")]
	[TriggerUsage(Start = false, Intermediate = true, End = false, BoundaryInterrupting = true)]
	Metric,
	[ShapeImage(typeof(TriggerEventShape), 32)]
	[DisplayName(typeof(__Resources_EventTrigger), "P_Event_DisplayName")]
	[TriggerUsage(Start = true, Intermediate = true, End = false, BoundaryInterrupting = false)]
	Event
}
