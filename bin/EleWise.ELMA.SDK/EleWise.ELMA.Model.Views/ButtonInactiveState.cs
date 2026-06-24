using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Views;

[MetadataType(typeof(EnumMetadata))]
[DefaultValueUid("016f4741-aed7-4560-8b54-418b8b43bae5")]
[Description(typeof(__Resources_ButtonInactiveState), "Description")]
[DisplayName(typeof(__Resources_ButtonInactiveState), "DisplayName")]
[Uid("9341073b-746c-4804-8f60-c3449773b64d")]
public enum ButtonInactiveState
{
	[Uid("016f4741-aed7-4560-8b54-418b8b43bae5")]
	[DisplayName(typeof(__Resources_ButtonInactiveState), "P_Active_DisplayName")]
	Active,
	[Uid("14f0811d-080c-4e56-91dc-0861435a14af")]
	[DisplayName(typeof(__Resources_ButtonInactiveState), "P_Inactive_DisplayName")]
	Inactive,
	[DisplayName(typeof(__Resources_ButtonInactiveState), "P_Hide_DisplayName")]
	[Uid("7adf95af-bd2a-4cdf-beca-71750a201d56")]
	Hide
}
