using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ISaleStage))]
public interface ISaleStageFilter : IEntityFilter
{
	ISaleFunnel SaleFunnel { get; set; }
}
