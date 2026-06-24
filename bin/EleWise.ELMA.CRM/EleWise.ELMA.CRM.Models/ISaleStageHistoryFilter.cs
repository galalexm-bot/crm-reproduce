using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ISaleStageHistory))]
public interface ISaleStageHistoryFilter : IEntityFilter
{
	ISale Sale { get; set; }
}
