using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("9d06806e-a170-472a-b3b0-07f316333629")]
[DisplayName(typeof(__Resources_CategoryType), "DisplayName")]
[DefaultValueUid("a75285ae-7eaa-4155-bcd4-1eaf9ad91abb")]
public enum CategoryType
{
	[Uid("a75285ae-7eaa-4155-bcd4-1eaf9ad91abb")]
	[DisplayName(typeof(__Resources_CategoryType), "P_Normal_DisplayName")]
	[Description(typeof(__Resources_CategoryType), "P_Normal_Description")]
	Normal,
	[Uid("b4fcbb50-7ada-4aa2-a03f-51fc9863d344")]
	[DisplayName(typeof(__Resources_CategoryType), "P_Exclusive_DisplayName")]
	[Description(typeof(__Resources_CategoryType), "P_Exclusive_Description")]
	Exclusive
}
