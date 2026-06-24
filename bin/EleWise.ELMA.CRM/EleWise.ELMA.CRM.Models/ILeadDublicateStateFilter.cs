using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ILeadDublicateState))]
public interface ILeadDublicateStateFilter : IEntityFilter
{
	ILead Lead { get; set; }
}
