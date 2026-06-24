using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_ProcessIndicatorScaleType), "DisplayName")]
[Uid("66489b46-226e-4afd-b57e-afd604a8904b")]
public enum ProcessIndicatorScaleType
{
	[DisplayName(typeof(__Resources_ProcessIndicatorScaleType), "P_PlanAndHigher_DisplayName")]
	[Uid("d173f578-76f1-42ad-a92a-ac71b0d62fdf")]
	PlanAndHigher,
	[Uid("bd3422f1-4739-4087-a486-8ef6c0f0c1dd")]
	[DisplayName(typeof(__Resources_ProcessIndicatorScaleType), "P_PlanAndLower_DisplayName")]
	PlanAndLower,
	[DisplayName(typeof(__Resources_ProcessIndicatorScaleType), "P_Stabilization_DisplayName")]
	[Uid("0bd7ce3e-ebf5-4fe0-b525-16f4f3bb6b7b")]
	Stabilization
}
