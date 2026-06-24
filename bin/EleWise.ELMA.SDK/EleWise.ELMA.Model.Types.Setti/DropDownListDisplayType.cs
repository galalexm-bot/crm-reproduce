using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings;

[Uid("625ae248-fca4-4a41-8b17-a61bb4845844")]
[MetadataType(typeof(EnumMetadata))]
[DefaultValueUid("3d8a5f90-4250-423d-98ef-c03e6c9617c0")]
[DisplayName(typeof(__Resources_DropDownListDisplayType), "DisplayName")]
public enum DropDownListDisplayType
{
	[Uid("3d8a5f90-4250-423d-98ef-c03e6c9617c0")]
	[DisplayName(typeof(__Resources_DropDownListDisplayType), "P_Standard_DisplayName")]
	Standard,
	[Uid("ec09a6ae-ad3d-4df9-b8cb-e37f3512362c")]
	[DisplayName(typeof(__Resources_DropDownListDisplayType), "P_HorizontalGroup_DisplayName")]
	HorizontalGroup,
	[Uid("edb35ba6-e368-40e1-b5b3-8b8cff38be96")]
	[DisplayName(typeof(__Resources_DropDownListDisplayType), "P_VerticalGroup_DisplayName")]
	VerticalGroup
}
