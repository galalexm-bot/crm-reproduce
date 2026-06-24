using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("70afc9e6-2dbf-4159-9bbe-e5fc29fcd9aa")]
[DisplayName(typeof(__Resources_SalePriority), "DisplayName")]
[DefaultValueUid("02700e79-265b-4003-86a4-59759811296c")]
public enum SalePriority
{
	[Uid("77af56b4-2b3a-4c0f-a0a6-bda3257ad18c")]
	[DisplayName(typeof(__Resources_SalePriority), "P_High_DisplayName")]
	High = 1,
	[Uid("02700e79-265b-4003-86a4-59759811296c")]
	[DisplayName(typeof(__Resources_SalePriority), "P_Medium_DisplayName")]
	Medium,
	[Uid("5bf4a880-1445-4eee-9e2d-d8d60b6a5629")]
	[DisplayName(typeof(__Resources_SalePriority), "P_Low_DisplayName")]
	Low
}
