using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[DisplayName(typeof(__Resources_ProcessIndicatorFilterType), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
[Uid("d5bb00ba-aafc-4db0-9a50-abe8a56f2267")]
public enum ProcessIndicatorFilterType
{
	[Uid("59faead2-9abc-4796-9524-922d8a4ada5c")]
	[DisplayName(typeof(__Resources_ProcessIndicatorFilterType), "P_ProcessStatus_DisplayName")]
	ProcessStatus,
	[DisplayName(typeof(__Resources_ProcessIndicatorFilterType), "P_ContextVariable_DisplayName")]
	[Uid("93c842ec-19b5-454f-9104-097e16ec5016")]
	ContextVariable,
	[Uid("1ac8d425-7c02-4b31-a246-4474345504ee")]
	[DisplayName(typeof(__Resources_ProcessIndicatorFilterType), "P_Worker_DisplayName")]
	Worker
}
