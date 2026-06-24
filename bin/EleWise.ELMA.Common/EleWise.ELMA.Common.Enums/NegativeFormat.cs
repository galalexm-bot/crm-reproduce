using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("58e4e46a-2219-49eb-adaf-ec85e1fd5d4b")]
[DisplayName(typeof(__Resources_NegativeFormat), "DisplayName")]
[ShowInDesigner(false)]
[DefaultValueUid("9f2e24c6-70ff-49d4-ba48-bcce9eb1e3a6")]
public enum NegativeFormat
{
	[Uid("5b2ca851-c700-451e-b803-dc09803601f6")]
	[DisplayName(typeof(__Resources_NegativeFormat), "P_Bracers_DisplayName")]
	Bracers,
	[Uid("017e8098-2c2b-4ad0-8a7b-34f4d0b81cb5")]
	[DisplayName(typeof(__Resources_NegativeFormat), "P_LeftMinus_DisplayName")]
	LeftMinus,
	[Uid("9f2e24c6-70ff-49d4-ba48-bcce9eb1e3a6")]
	[DisplayName(typeof(__Resources_NegativeFormat), "P_LeftMinusWithSpace_DisplayName")]
	LeftMinusWithSpace,
	[Uid("57aea214-5303-4127-9ebb-37a93305eb07")]
	[DisplayName(typeof(__Resources_NegativeFormat), "P_RigthMinus_DisplayName")]
	RigthMinus,
	[Uid("56e71535-03dc-4064-9ffb-bc337061a371")]
	[DisplayName(typeof(__Resources_NegativeFormat), "P_RigthMinusWithSpace_DisplayName")]
	RigthMinusWithSpace
}
