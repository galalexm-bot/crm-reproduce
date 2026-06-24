using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.KPI.Common.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("928decc5-a391-458f-8650-a2f8e2b5a356")]
[DisplayName(typeof(__Resources_IndicatorGrowthDirection), "DisplayName")]
[DefaultValueUid("c0a63eed-7feb-486f-ac10-effe905b404c")]
public enum IndicatorGrowthDirection
{
	[Uid("c0a63eed-7feb-486f-ac10-effe905b404c")]
	[DisplayName(typeof(__Resources_IndicatorGrowthDirection), "P_Normal_DisplayName")]
	Normal,
	[Uid("586da76a-7833-4848-8c0d-6ea312c0a970")]
	[DisplayName(typeof(__Resources_IndicatorGrowthDirection), "P_Minimization_DisplayName")]
	Minimization,
	[Uid("19e0904a-2b98-4037-b364-2732067c38d1")]
	[DisplayName(typeof(__Resources_IndicatorGrowthDirection), "P_Maximization_DisplayName")]
	Maximization
}
