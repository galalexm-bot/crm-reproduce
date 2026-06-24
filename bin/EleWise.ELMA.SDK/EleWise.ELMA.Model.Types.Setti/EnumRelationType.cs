using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings;

[MetadataType(typeof(EnumMetadata))]
[Uid("0b9f4a56-fc45-43fe-b88b-fcc0b59fc15e")]
[DefaultValueUid("386659e9-c682-47cc-af70-dd8b94ca0eac")]
[DisplayName(typeof(__Resources_EnumRelationType), "DisplayName")]
public enum EnumRelationType
{
	[Uid("1d491eba-23c2-4900-82a2-45ba13edcd1a")]
	[DisplayName(typeof(__Resources_EnumRelationType), "P_One_DisplayName")]
	One,
	[Uid("a52f2632-6774-44d4-a1a1-ca60b7e95d49")]
	[DisplayName(typeof(__Resources_EnumRelationType), "P_Many_DisplayName")]
	Many
}
