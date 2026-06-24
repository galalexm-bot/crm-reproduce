using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings;

[DisplayName(typeof(__Resources_EnumDisplayType), "DisplayName")]
[Uid("ace00fad-4f16-4032-b361-e4e23bd4bd5b")]
[MetadataType(typeof(EnumMetadata))]
public enum EnumDisplayType
{
	[Uid("be081635-e111-4471-b66c-523e086971a8")]
	[DisplayName(typeof(__Resources_EnumDisplayType), "P_Standard_DisplayName")]
	Standard,
	[Uid("7ac2f816-6f9c-45bc-af09-37861879c13b")]
	[DisplayName(typeof(__Resources_EnumDisplayType), "P_HorizontalGroup_DisplayName")]
	HorizontalGroup,
	[Uid("b1a3832f-fe70-432a-8ad8-a04563475499")]
	[DisplayName(typeof(__Resources_EnumDisplayType), "P_VerticalGroup_DisplayName")]
	VerticalGroup,
	[Uid("e5a50137-51cc-4523-84dd-46162ec738e4")]
	[DisplayName(typeof(__Resources_EnumDisplayType), "P_Switch_DisplayName")]
	Switch
}
