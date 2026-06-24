using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("c2b9855b-52e8-4deb-a78a-ca07185ceb1c")]
[DisplayName(typeof(__Resources_ProcessIndicatorTimeScale), "DisplayName")]
public enum ProcessIndicatorTimeScale
{
	[DisplayName(typeof(__Resources_ProcessIndicatorTimeScale), "P_ProcessStartTime_DisplayName")]
	[Uid("367121ef-f857-417d-901b-ae75e2f9829e")]
	ProcessStartTime,
	[Uid("6d29b05c-f3a0-40e5-a7bb-206d78247c11")]
	[DisplayName(typeof(__Resources_ProcessIndicatorTimeScale), "P_ProcessEndTime_DisplayName")]
	ProcessEndTime,
	[DisplayName(typeof(__Resources_ProcessIndicatorTimeScale), "P_ContextVariable_DisplayName")]
	[Uid("9c55bfe9-1734-4c85-bd07-e0de02b7f17c")]
	ContextVariable
}
