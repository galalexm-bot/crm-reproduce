using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.KPI.Common.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("1ee81f80-a113-48be-a5ba-dfd0345d7c76")]
[DisplayName(typeof(__Resources_ScaleValueType), "DisplayName")]
[DefaultValueUid("a6dc091d-cc02-48a4-b4ba-326f6f537d66")]
public enum ScaleValueType
{
	[Uid("8583448b-63df-4b83-8ce8-27699b31e950")]
	[DisplayName(typeof(__Resources_ScaleValueType), "P_Value_DisplayName")]
	Value,
	[Uid("a6dc091d-cc02-48a4-b4ba-326f6f537d66")]
	[DisplayName(typeof(__Resources_ScaleValueType), "P_Percent_DisplayName")]
	Percent,
	[Uid("5d039779-6c4b-4a09-90b5-81ec08836fb6")]
	[DisplayName(typeof(__Resources_ScaleValueType), "P_Offset_DisplayName")]
	Offset
}
