using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.CRM.Models.BillingInformation;

[FilterFor(typeof(IBankDetails))]
public interface IBankDetailsFilter : IEntityFilter
{
	string Name { get; set; }

	IFinancialInstitutionBank Bank { get; set; }

	DateTimeRange EndDate { get; set; }
}
