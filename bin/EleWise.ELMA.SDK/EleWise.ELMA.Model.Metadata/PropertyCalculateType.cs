using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Metadata;

[ShowInDesigner(false)]
[MetadataType(typeof(EnumMetadata))]
[Uid("{EFE13E18-65B4-4ABE-8D27-53C94571DE75}")]
[ShowInTypeTree(false)]
public enum PropertyCalculateType
{
	[DisplayName(typeof(__Resources_PropertyCalculateType), "P_None_DisplayName")]
	None = 0,
	[DisplayName(typeof(__Resources_PropertyCalculateType), "P_CSScript_DisplayName")]
	CSScript = 10,
	[DisplayName(typeof(__Resources_PropertyCalculateType), "P_SQLFormula_DisplayName")]
	SQLFormula = 20
}
