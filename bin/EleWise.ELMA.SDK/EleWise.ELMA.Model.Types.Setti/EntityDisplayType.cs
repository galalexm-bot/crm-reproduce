using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings;

[DefaultValueUid("57e25a65-8a49-4760-95af-922286a8351c")]
[DisplayName(typeof(__Resources_EntityDisplayType), "DisplayName")]
[Uid("b1401619-1df9-4d97-a2d8-c426abc127cc")]
[MetadataType(typeof(EnumMetadata))]
public enum EntityDisplayType
{
	[DisplayName(typeof(__Resources_EntityDisplayType), "P_Standard_DisplayName")]
	[Uid("57e25a65-8a49-4760-95af-922286a8351c")]
	Standard,
	[Uid("bafc1f65-4278-4751-b465-d62807f88cf1")]
	[DisplayName(typeof(__Resources_EntityDisplayType), "P_HorizontalGroup_DisplayName")]
	HorizontalGroup,
	[DisplayName(typeof(__Resources_EntityDisplayType), "P_VerticalGroup_DisplayName")]
	[Uid("80dfca25-5bad-48c9-b6e0-4dbf180d3212")]
	VerticalGroup
}
