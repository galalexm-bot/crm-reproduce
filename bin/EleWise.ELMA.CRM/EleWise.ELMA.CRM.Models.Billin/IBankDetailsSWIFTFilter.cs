using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models.BillingInformation;

[FilterFor(typeof(IBankDetailsSWIFT))]
public interface IBankDetailsSWIFTFilter : IBankDetailsFilter, IEntityFilter
{
	string NameOfBank { get; set; }

	string SWIFTCode { get; set; }

	string AccountInIntermediaryBank { get; set; }

	string IntermediaryBank { get; set; }
}
