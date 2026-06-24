using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("b75ea773-f7fb-465f-be23-a1c6f3e37a91")]
[DisplayName(typeof(__Resources_LeadDublicateStatus), "DisplayName")]
public enum LeadDublicateStatus
{
	[Uid("fbe21fbe-364a-4ef7-83f7-754f53ae1852")]
	[DisplayName(typeof(__Resources_LeadDublicateStatus), "P_New_DisplayName")]
	New,
	[Uid("a56d6ef1-2ead-4c70-a91e-c0b4f2f54c17")]
	[DisplayName(typeof(__Resources_LeadDublicateStatus), "P_PossibleDublicate_DisplayName")]
	PossibleDublicate,
	[Uid("c09d5e38-22c2-4b4c-b820-a4c1b7163517")]
	[DisplayName(typeof(__Resources_LeadDublicateStatus), "P_NotDublicate_DisplayName")]
	NotDublicate,
	[Uid("5e8b6235-9f17-49d1-840b-45e733e3ab89")]
	[DisplayName(typeof(__Resources_LeadDublicateStatus), "P_Dublicate_DisplayName")]
	Dublicate
}
