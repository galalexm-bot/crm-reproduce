using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models.BillingInformation;

[FilterFor(typeof(IBankAccount))]
public interface IBankAccountFilter : IEntityFilter
{
	string Name { get; set; }

	IBankDetails BankDetails { get; set; }

	string AccountNumber { get; set; }

	ICurrency Currency { get; set; }

	AccountStatus? AccountStatus { get; set; }

	string Comment { get; set; }
}
