using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.CRM.Enums;

[MetadataType(typeof(EnumMetadata))]
[Uid("666c9973-8610-4c4c-a85e-fb416eb06427")]
[DisplayName(typeof(__Resources_PaymentStatus), "DisplayName")]
public enum PaymentStatus
{
	[Uid("46c94a30-4821-47cf-a48d-c530e244f47c")]
	[DisplayName(typeof(__Resources_PaymentStatus), "P_Planned_DisplayName")]
	Planned = 1,
	[Uid("d0ef59af-4e86-44c3-a802-587da12729df")]
	[DisplayName(typeof(__Resources_PaymentStatus), "P_Billed_DisplayName")]
	Billed,
	[Uid("acaca4c1-802b-4727-9f97-05642c54087a")]
	[DisplayName(typeof(__Resources_PaymentStatus), "P_Paid_DisplayName")]
	Paid,
	[Uid("d11144fb-0545-4ab5-907c-2268c616ea62")]
	[DisplayName(typeof(__Resources_PaymentStatus), "P_Canceled_DisplayName")]
	Canceled
}
