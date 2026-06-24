using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("ef316a2c-96d4-4253-86ad-ff73e7fa8fd3")]
[DisplayName(typeof(__Resources_RelationshipCallType), "DisplayName")]
public enum RelationshipCallType
{
	[Uid("b9487357-a77c-46e7-9a41-167a5931d311")]
	[DisplayName(typeof(__Resources_RelationshipCallType), "P_Input_DisplayName")]
	Input,
	[Uid("948a47ce-02cd-47e2-b3fc-80d0823b4ecd")]
	[DisplayName(typeof(__Resources_RelationshipCallType), "P_Output_DisplayName")]
	Output
}
