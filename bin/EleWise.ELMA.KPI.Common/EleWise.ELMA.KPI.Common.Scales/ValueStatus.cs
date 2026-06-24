using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.KPI.Common.Scales;

[MetadataType(typeof(EnumMetadata))]
[Uid("d2de317a-859a-4f52-831f-0cd33bfba016")]
[DisplayName(typeof(__Resources_ValueStatus), "DisplayName")]
[DefaultValueUid("c7bfef3c-00f4-44df-b103-9622ff48a426")]
public enum ValueStatus
{
	[Uid("c7bfef3c-00f4-44df-b103-9622ff48a426")]
	[DisplayName(typeof(__Resources_ValueStatus), "P_Unavailable_DisplayName")]
	Unavailable,
	[Uid("5256d044-df85-4d9d-96f7-43f7d06dd6a5")]
	[DisplayName(typeof(__Resources_ValueStatus), "P_Critical_DisplayName")]
	Critical,
	[Uid("1f96c083-3024-4266-bdda-12ff9458f3f8")]
	[DisplayName(typeof(__Resources_ValueStatus), "P_Normal_DisplayName")]
	Normal,
	[Uid("3add4882-6da0-48ef-98cf-f3f2c05a6239")]
	[DisplayName(typeof(__Resources_ValueStatus), "P_Good_DisplayName")]
	Good
}
