using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IDublicateContractor))]
public interface IDublicateContractorFilter : IEntityFilter
{
	ILead Lead { get; set; }
}
