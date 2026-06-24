using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

[DisplayName(typeof(__Resources_ResponsibilityLevel), "DisplayName")]
[MetadataType(typeof(EnumMetadata))]
[Description(typeof(__Resources_ResponsibilityLevel), "Description")]
[Uid("9484ed1e-3f0a-4570-a720-02069600204a")]
public enum ResponsibilityLevel
{
	[Uid("2991e26b-8021-47a3-be2a-9917f98ecfca")]
	[DisplayName(typeof(__Resources_ResponsibilityLevel), "P_Inform_DisplayName")]
	Inform,
	[Uid("978f4178-7d37-49bc-9aa6-02ed2873d80e")]
	[DisplayName(typeof(__Resources_ResponsibilityLevel), "P_Member_DisplayName")]
	Member,
	[Uid("852a323d-9b77-426c-a4ee-a9933130dd21")]
	[DisplayName(typeof(__Resources_ResponsibilityLevel), "P_Owner_DisplayName")]
	Owner,
	[DisplayName(typeof(__Resources_ResponsibilityLevel), "P_None_DisplayName")]
	[Uid("98dfad42-ee62-45e8-9998-21b1060ff7bf")]
	None
}
