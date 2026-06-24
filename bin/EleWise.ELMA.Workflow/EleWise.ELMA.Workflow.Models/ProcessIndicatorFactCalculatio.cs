using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_ProcessIndicatorFactCalculationType), "DisplayName")]
[Uid("3441022e-fe10-4904-a749-4306512ef0cf")]
public enum ProcessIndicatorFactCalculationType
{
	[DisplayName(typeof(__Resources_ProcessIndicatorFactCalculationType), "P_ProcessInstancesCount_DisplayName")]
	[Uid("e8421ce9-e4a7-41bb-8930-b0698157f5db")]
	ProcessInstancesCount,
	[Uid("4ca03916-d76b-485a-aeb1-8bd573bb1969")]
	[DisplayName(typeof(__Resources_ProcessIndicatorFactCalculationType), "P_Formula_DisplayName")]
	Formula
}
