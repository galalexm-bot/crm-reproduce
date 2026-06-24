using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.KPI.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("dc077887-179f-4f8a-b794-23e1034c4043")]
[DisplayName(typeof(__Resources_PeriodGroupingType), "DisplayName")]
[DefaultValueUid("d3820f19-ed95-4ae9-9a0e-2e6a6f10e133")]
[NamespaceForDisplay("EleWise.ELMA.Common.Models")]
public enum PeriodGroupingType
{
	[Uid("d3820f19-ed95-4ae9-9a0e-2e6a6f10e133")]
	[DisplayName(typeof(__Resources_PeriodGroupingType), "P_FirstDay_DisplayName")]
	FirstDay,
	[Uid("fd3c3565-4f19-4388-9856-4a46d8a35efe")]
	[DisplayName(typeof(__Resources_PeriodGroupingType), "P_MiddleDay_DisplayName")]
	MiddleDay,
	[Uid("ccdd9343-b483-490b-a352-2d7aead20658")]
	[DisplayName(typeof(__Resources_PeriodGroupingType), "P_LastDay_DisplayName")]
	LastDay
}
