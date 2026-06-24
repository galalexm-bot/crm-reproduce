using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IContractorRegion))]
public interface IContractorRegionFilter : IEntityFilter
{
	string Region { get; set; }
}
