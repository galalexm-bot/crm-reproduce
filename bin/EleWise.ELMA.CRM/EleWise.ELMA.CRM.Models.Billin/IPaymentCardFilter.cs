using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.CRM.Models.BillingInformation;

[FilterFor(typeof(IPaymentCard))]
public interface IPaymentCardFilter : IEntityFilter
{
	string Name { get; set; }

	IPaymentSystem PaymentSystem { get; set; }

	string Number { get; set; }

	DateTimeRange ValidTo { get; set; }

	AccountStatus? Status { get; set; }
}
