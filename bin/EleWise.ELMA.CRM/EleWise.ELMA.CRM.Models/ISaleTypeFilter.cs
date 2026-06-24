using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ISaleType))]
public interface ISaleTypeFilter : IEntityFilter
{
	string Name { get; set; }

	ISaleFunnel SaleFunnel { get; set; }
}
