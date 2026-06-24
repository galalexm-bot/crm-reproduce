using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IContractorIndustry))]
public interface IContractorIndustryFilter : IEntityFilter
{
	string Industry { get; set; }
}
