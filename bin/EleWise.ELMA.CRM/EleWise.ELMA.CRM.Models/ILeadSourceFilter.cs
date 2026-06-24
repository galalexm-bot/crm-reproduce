using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ILeadSource))]
public interface ILeadSourceFilter : IEntityFilter
{
	string Name { get; set; }
}
