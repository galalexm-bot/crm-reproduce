using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_ProcessMetricStageCalculationType), "DisplayName")]
[Uid("3bca5ce2-4e3b-4168-ad6d-986c8937169d")]
public enum ProcessMetricStageCalculationType
{
	[Uid("ec215569-ce90-4314-a94b-25481caff667")]
	[DisplayName(typeof(__Resources_ProcessMetricStageCalculationType), "P_FisrtEntry_DisplayName")]
	FisrtEntry,
	[Uid("e249b49e-d672-409d-bbe6-ab3b79f81195")]
	[DisplayName(typeof(__Resources_ProcessMetricStageCalculationType), "P_LastEntry_DisplayName")]
	LastEntry,
	[DisplayName(typeof(__Resources_ProcessMetricStageCalculationType), "P_MaximumTime_DisplayName")]
	[Uid("394fbfd9-9468-4c6a-a1d4-8c0e3fd59bf5")]
	MaximumTime,
	[DisplayName(typeof(__Resources_ProcessMetricStageCalculationType), "P_MinimumTime_DisplayName")]
	[Uid("ce25834e-23a5-400e-8680-14b52f91a89d")]
	MinimumTime
}
