using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IDublicateLead))]
public interface IDublicateLeadFilter : IEntityFilter
{
	ILead Lead { get; set; }
}
