using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("11216bb4-8fce-4100-81fc-172031a4a7aa")]
[DisplayName(typeof(__Resources_RelationshipPriority), "DisplayName")]
[DefaultValueUid("4d95fc5a-5ce9-412c-8c14-a43d070446a0")]
public enum RelationshipPriority
{
	[Uid("ee935dae-d3fc-40a4-a7e4-9e8cc0c6e540")]
	[DisplayName(typeof(__Resources_RelationshipPriority), "P_High_DisplayName")]
	[Image(typeof(RelationshipPriority), "thin_arrow_up", 16, ImageFormatType.IconPack, false)]
	High = 1,
	[Uid("4d95fc5a-5ce9-412c-8c14-a43d070446a0")]
	[DisplayName(typeof(__Resources_RelationshipPriority), "P_Medium_DisplayName")]
	[Image(typeof(RelationshipPriority), "circle-fill", 16, ImageFormatType.IconPack, false)]
	Medium,
	[Uid("3c2d634a-7432-47a4-a5d9-7baf0a7bcc16")]
	[DisplayName(typeof(__Resources_RelationshipPriority), "P_Low_DisplayName")]
	[Image(typeof(RelationshipPriority), "thin_arrow_down", 16, ImageFormatType.IconPack, false)]
	Low
}
