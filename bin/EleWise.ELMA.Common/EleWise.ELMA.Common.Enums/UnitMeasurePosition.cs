using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("f971a135-a8d1-46d4-8193-b3860eac6d8e")]
[DisplayName(typeof(__Resources_UnitMeasurePosition), "DisplayName")]
[DefaultValueUid("7c982e69-c6d5-4ff1-adf8-31d368b3bc19")]
public enum UnitMeasurePosition
{
	[Uid("7c982e69-c6d5-4ff1-adf8-31d368b3bc19")]
	[DisplayName(typeof(__Resources_UnitMeasurePosition), "P_Right_DisplayName")]
	Right,
	[Uid("83b15d52-f528-43a1-bf8b-a15b69687e58")]
	[DisplayName(typeof(__Resources_UnitMeasurePosition), "P_Left_DisplayName")]
	Left
}
