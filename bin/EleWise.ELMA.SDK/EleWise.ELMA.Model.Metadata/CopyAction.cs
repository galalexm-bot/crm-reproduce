using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Metadata;

[Uid("ded50eaa-8f9d-4457-b083-60b8b721705b")]
[DisplayName(typeof(__Resources_CopyAction), "DisplayName")]
[DefaultValueUid("d161a296-99ee-4e01-93e3-225a4a8cfdb1")]
[MetadataType(typeof(EnumMetadata))]
public enum CopyAction
{
	[Uid("d161a296-99ee-4e01-93e3-225a4a8cfdb1")]
	[DisplayName(typeof(__Resources_CopyAction), "P_Default_DisplayName")]
	[Description(typeof(__Resources_CopyAction), "P_Default_Description")]
	Default = 0,
	[Uid("e4c54db1-acdc-49ef-82e9-c836d1df8eb9")]
	[DisplayName(typeof(__Resources_CopyAction), "P_SaveRef_DisplayName")]
	[Description(typeof(__Resources_CopyAction), "P_SaveRef_Description")]
	SaveRef = 4,
	[Uid("8b18eee9-0990-4c36-a011-ebc0ee4d4068")]
	[Description(typeof(__Resources_CopyAction), "P_ByRef_Description")]
	[DisplayName(typeof(__Resources_CopyAction), "P_ByRef_DisplayName")]
	ByRef = 1,
	[Uid("2424ee20-46cd-448a-91eb-7f7dd6d0df22")]
	[DisplayName(typeof(__Resources_CopyAction), "P_Clone_DisplayName")]
	[Description(typeof(__Resources_CopyAction), "P_Clone_Description")]
	Clone = 2,
	[Uid("c4b194eb-4316-4249-9078-3b91343890e3")]
	[DisplayName(typeof(__Resources_CopyAction), "P_Ignore_DisplayName")]
	[Description(typeof(__Resources_CopyAction), "P_Ignore_Description")]
	Ignore = 3
}
