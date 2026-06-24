using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[Uid("ea072f6e-68d9-4679-9541-6a10db99c5d4")]
[DisplayName(typeof(__Resources_ProcessIndicatorPlanCalculationType), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
public enum ProcessIndicatorPlanCalculationType
{
	[Uid("86b0d415-19a8-456c-985c-8da93bdec0fa")]
	[DisplayName(typeof(__Resources_ProcessIndicatorPlanCalculationType), "P_Value_DisplayName")]
	Value,
	[DisplayName(typeof(__Resources_ProcessIndicatorPlanCalculationType), "P_ProcessParameter_DisplayName")]
	[Uid("086c6b8b-1ad5-4da2-a6b6-cf4ef210824b")]
	ProcessParameter
}
