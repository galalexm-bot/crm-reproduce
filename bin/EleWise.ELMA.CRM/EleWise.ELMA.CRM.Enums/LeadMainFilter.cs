using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("03b2b949-f6cf-4f5e-9119-e23f0b2e6de6")]
[DisplayName(typeof(__Resources_LeadMainFilter), "DisplayName")]
public enum LeadMainFilter
{
	[Uid("bcc5cc38-c69e-49ab-8082-eb3b7cc7f0b4")]
	[DisplayName(typeof(__Resources_LeadMainFilter), "P_ChangedTime_DisplayName")]
	ChangedTime,
	[Uid("e519d77f-9244-4ba0-b6bf-3fa9dc44ccd2")]
	[DisplayName(typeof(__Resources_LeadMainFilter), "P_Converted_DisplayName")]
	Converted,
	[Uid("7f97ba1c-c87b-46a4-9ecb-4b89f28c00a6")]
	[DisplayName(typeof(__Resources_LeadMainFilter), "P_Failed_DisplayName")]
	Failed
}
