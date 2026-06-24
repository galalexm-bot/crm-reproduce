using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ISaleProduct))]
public interface ISaleProductFilter : IEntityFilter
{
	ISale Sale { get; set; }
}
