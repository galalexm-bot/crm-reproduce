using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[Uid("4b0e5f53-b2a1-46a3-89b8-1a9ded6ce860")]
[DisplayName(typeof(__Resources_ProcessMetricComputationType), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
public enum ProcessMetricComputationType
{
	[Uid("bbc6cc8d-3611-466f-9a3d-bdb82254d12b")]
	[DisplayName(typeof(__Resources_ProcessMetricComputationType), "P_Technical_DisplayName")]
	Technical,
	[DisplayName(typeof(__Resources_ProcessMetricComputationType), "P_Time_DisplayName")]
	[Uid("b06212af-54dc-472a-afda-2f94a2bc1210")]
	Time
}
