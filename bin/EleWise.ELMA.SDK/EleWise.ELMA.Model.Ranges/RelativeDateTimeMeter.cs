using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Ranges;

[MetadataType(typeof(EnumMetadata))]
[DisplayName(typeof(__Resources_RelativeDateTimeMeter), "DisplayName")]
[Uid("3cd25495-942b-477f-997a-76067b541325")]
public enum RelativeDateTimeMeter
{
	[DisplayName(typeof(__Resources_RelativeDateTimeMeter), "P_Hour_DisplayName")]
	[Uid("073bb9e1-4aac-4e8e-aa5a-b80900236ba1")]
	Hour,
	[Uid("065e3fb4-b618-4ea7-b1d0-f164003c8a43")]
	[DisplayName(typeof(__Resources_RelativeDateTimeMeter), "P_Day_DisplayName")]
	Day,
	[DisplayName(typeof(__Resources_RelativeDateTimeMeter), "P_Week_DisplayName")]
	[Uid("1f7b578e-cab9-4b10-881f-79d2007539ad")]
	Week,
	[Uid("d5446538-7ca4-4e40-b242-77913e5846d6")]
	[DisplayName(typeof(__Resources_RelativeDateTimeMeter), "P_Month_DisplayName")]
	Month,
	[DisplayName(typeof(__Resources_RelativeDateTimeMeter), "P_Year_DisplayName")]
	[Uid("3adee897-ae0e-4589-8543-b2ef5628e75a")]
	Year
}
