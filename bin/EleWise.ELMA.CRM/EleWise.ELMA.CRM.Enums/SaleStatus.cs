using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("ec17b955-dcbc-41fb-bcfe-d6f483bedfe9")]
[DisplayName(typeof(__Resources_SaleStatus), "DisplayName")]
public enum SaleStatus
{
	[Uid("dc9639f8-734c-4c71-96f9-50a827b1416a")]
	[DisplayName(typeof(__Resources_SaleStatus), "P_Active_DisplayName")]
	Active = 1,
	[Uid("64565053-5aad-4b29-89ac-3b4b52ee1c22")]
	[DisplayName(typeof(__Resources_SaleStatus), "P_Postponed_DisplayName")]
	Postponed,
	[Uid("6edf0616-64e3-45fe-9d9c-4fe876dfcef8")]
	[DisplayName(typeof(__Resources_SaleStatus), "P_PositiveClosed_DisplayName")]
	PositiveClosed,
	[Uid("916bf51e-4627-473f-9d27-905196a2cd2e")]
	[DisplayName(typeof(__Resources_SaleStatus), "P_NegativeClosed_DisplayName")]
	NegativeClosed
}
