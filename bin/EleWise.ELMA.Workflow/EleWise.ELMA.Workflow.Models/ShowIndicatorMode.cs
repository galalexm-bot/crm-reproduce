using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("bb8d451b-7eb1-4045-9ba0-68e76444a58a")]
[DisplayName(typeof(__Resources_ShowIndicatorMode), "DisplayName")]
[DefaultValueUid("1cb49723-48b3-4931-9ddf-3daecfaef329")]
public enum ShowIndicatorMode
{
	[DisplayName(typeof(__Resources_ShowIndicatorMode), "P_Show_DisplayName")]
	[Uid("1cb49723-48b3-4931-9ddf-3daecfaef329")]
	Show,
	[DisplayName(typeof(__Resources_ShowIndicatorMode), "P_Hide_DisplayName")]
	[Uid("539e007d-4151-4df4-8ab9-a55529a79bfa")]
	Hide
}
