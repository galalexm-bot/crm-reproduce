using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IMarketingGroup))]
public interface IMarketingGroupFilter : IMarketingBaseFilter, IEntityFilter
{
	IMarketingGroupType GroupType { get; set; }
}
