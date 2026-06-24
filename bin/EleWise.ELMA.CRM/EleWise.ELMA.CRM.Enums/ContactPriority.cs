using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("f85a95b8-b0f4-4bc4-b5b7-21bb466e96e2")]
[DisplayName(typeof(__Resources_ContactPriority), "DisplayName")]
[DefaultValueUid("59b8ff21-3cf8-42b8-8859-f3fd2edd0dcf")]
public enum ContactPriority
{
	[Uid("62c03945-d24e-4cf7-814a-57eb51cc5765")]
	[DisplayName(typeof(__Resources_ContactPriority), "P_High_DisplayName")]
	[Image(typeof(ContactPriority), "thin_arrow_up", 16, ImageFormatType.IconPack, false)]
	High,
	[Uid("59b8ff21-3cf8-42b8-8859-f3fd2edd0dcf")]
	[DisplayName(typeof(__Resources_ContactPriority), "P_Medium_DisplayName")]
	[Image(typeof(ContactPriority), "circle-fill", 16, ImageFormatType.IconPack, false)]
	Medium,
	[Uid("533f8dd2-fb45-4eb2-9592-1799e46d7607")]
	[DisplayName(typeof(__Resources_ContactPriority), "P_Low_DisplayName")]
	[Image(typeof(ContactPriority), "thin_arrow_down", 16, ImageFormatType.IconPack, false)]
	Low
}
