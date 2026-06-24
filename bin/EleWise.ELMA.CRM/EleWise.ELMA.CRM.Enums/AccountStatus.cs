using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("b11f8f16-a2ec-45ae-a8e8-e7aee6c6e444")]
[DisplayName(typeof(__Resources_AccountStatus), "DisplayName")]
[DefaultValueUid("0a3e253b-8baf-41b3-bbc9-efd77e7be670")]
public enum AccountStatus
{
	[Uid("f918d847-f72b-4807-821b-c497bef9cde2")]
	[DisplayName(typeof(__Resources_AccountStatus), "P_Main_DisplayName")]
	Main,
	[Uid("0a3e253b-8baf-41b3-bbc9-efd77e7be670")]
	[DisplayName(typeof(__Resources_AccountStatus), "P_NotMain_DisplayName")]
	NotMain,
	[Uid("d3a6b62c-0ec6-4e5f-804d-6cabb8e83f42")]
	[DisplayName(typeof(__Resources_AccountStatus), "P_Closed_DisplayName")]
	Closed
}
