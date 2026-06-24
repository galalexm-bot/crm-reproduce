using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("d5270cd6-e002-467f-9859-6191c4a45738")]
[DisplayName(typeof(__Resources_RelationshipUserStatus), "DisplayName")]
public enum RelationshipUserStatus
{
	[Uid("d26a7ad4-c368-42cc-9ee2-2ddbe354d53b")]
	[DisplayName(typeof(__Resources_RelationshipUserStatus), "P_Participant_DisplayName")]
	Participant,
	[Uid("bf7664f5-d2d3-4255-8458-188627ab4597")]
	[DisplayName(typeof(__Resources_RelationshipUserStatus), "P_InfromTo_DisplayName")]
	InfromTo
}
