using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ILeadType))]
public interface ILeadTypeFilter : IEntityFilter
{
	string Type { get; set; }
}
