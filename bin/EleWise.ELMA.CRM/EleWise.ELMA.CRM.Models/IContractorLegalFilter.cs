using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IContractorLegal))]
public interface IContractorLegalFilter : IContractorFilter, IMarketingActivityTargetFilter, IEntityFilter
{
	ILegalForm LegalForm { get; set; }

	Int64Range Staff { get; set; }

	string OGRN { get; set; }

	string KPP { get; set; }
}
