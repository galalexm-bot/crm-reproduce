using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Models;

[MetadataType(typeof(EnumMetadata))]
[Uid("8e68974f-052a-45fb-b9d1-fa6b0033f63a")]
[DisplayName(typeof(__Resources_InpaymentStatus), "DisplayName")]
public enum InpaymentStatus
{
	[Uid("4b041fa1-72cd-465b-9d92-665eeadf02e5")]
	[DisplayName(typeof(__Resources_InpaymentStatus), "P_InPlan_DisplayName")]
	InPlan,
	[Uid("a463a77b-3992-4c8d-8b48-baefd1700c1f")]
	[DisplayName(typeof(__Resources_InpaymentStatus), "P_Received_DisplayName")]
	Received,
	[Uid("dd948931-714c-48b5-b78d-ae04f92fd63f")]
	[DisplayName(typeof(__Resources_InpaymentStatus), "P_Cancelled_DisplayName")]
	Cancelled
}
