using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Models.BillingInformation;

[FilterFor(typeof(IFinancialInstitutionBank))]
public interface IFinancialInstitutionBankFilter : IEntityFilter
{
	string Name { get; set; }

	string FullName { get; set; }

	string Location { get; set; }

	IAddressFilter Address { get; set; }

	ISet<IBankDetails> BankDetails { get; set; }
}
