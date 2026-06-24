using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Types.Settings;

[DisplayName(typeof(__Resources_RelationType), "DisplayName")]
[Uid("e8ad1e72-5c44-4225-a74c-f94c127fd87d")]
[ShowInDesigner(false)]
[MetadataType(typeof(EnumMetadata))]
[ShowInTypeTree(false)]
public enum RelationType
{
	[DisplayName(typeof(__Resources_RelationType), "P_OneToOne_DisplayName")]
	[Uid("19d4a671-de00-4f40-bf34-62b2dfa7827f")]
	OneToOne,
	[Uid("24cb6bb1-77b7-4ca1-aca3-17d5460d582f")]
	[DisplayName(typeof(__Resources_RelationType), "P_OneToMany_DisplayName")]
	OneToMany,
	[Uid("de89cdc4-8f00-4e8a-bb75-9dffa4725818")]
	[DisplayName(typeof(__Resources_RelationType), "P_ManyToMany_DisplayName")]
	ManyToMany,
	[Uid("5389ffbf-9b33-46c8-a2d7-618e034d70d9")]
	[DisplayName(typeof(__Resources_RelationType), "P_ManyToManyInverse_DisplayName")]
	ManyToManyInverse
}
