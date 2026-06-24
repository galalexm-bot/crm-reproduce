using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ISaleFunnel))]
public interface ISaleFunnelFilter : IEntityFilter
{
	string Name { get; set; }
}
