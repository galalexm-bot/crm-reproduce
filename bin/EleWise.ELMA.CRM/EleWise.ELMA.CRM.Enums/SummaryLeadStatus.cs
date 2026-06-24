using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("ab7c728d-3ba6-44ae-8e79-02f02f6ee430")]
[DisplayName(typeof(__Resources_SummaryLeadStatus), "DisplayName")]
[Description(typeof(__Resources_SummaryLeadStatus), "Description")]
public enum SummaryLeadStatus
{
	[Uid("b7af6ba8-9991-434d-95d3-b7ffdfb3d37a")]
	[DisplayName(typeof(__Resources_SummaryLeadStatus), "P_Closed_DisplayName")]
	Closed = -2,
	[Uid("484074f0-1100-47d6-9087-032c884ad17c")]
	[DisplayName(typeof(__Resources_SummaryLeadStatus), "P_Deleted_DisplayName")]
	Deleted,
	[Uid("94c35288-587c-407d-9d97-2203b6a4073e")]
	[DisplayName(typeof(__Resources_SummaryLeadStatus), "P_New_DisplayName")]
	New,
	[Uid("48598754-07d9-41c1-9664-764b53d0a396")]
	[DisplayName(typeof(__Resources_SummaryLeadStatus), "P_InHand_DisplayName")]
	InHand,
	[Uid("d96f8e9e-36d4-4e56-a860-f96f57e372c1")]
	[DisplayName(typeof(__Resources_SummaryLeadStatus), "P_Qualified_DisplayName")]
	Qualified,
	[Uid("1319e8ed-d2d5-4344-9781-70d9efe2d17f")]
	[DisplayName(typeof(__Resources_SummaryLeadStatus), "P_Unqualified_DisplayName")]
	Unqualified,
	[Uid("844ddf8d-b990-44a1-a5f7-b4e64a0000d3")]
	[DisplayName(typeof(__Resources_SummaryLeadStatus), "P_Dublicate_DisplayName")]
	Dublicate
}
