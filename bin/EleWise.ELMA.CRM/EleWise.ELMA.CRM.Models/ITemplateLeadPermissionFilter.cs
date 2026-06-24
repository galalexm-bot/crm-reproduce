using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ITemplateLeadPermission))]
public interface ITemplateLeadPermissionFilter : IEntityFilter
{
	IContLeadPermission ContainerLead { get; set; }

	bool? AddPermission { get; set; }

	bool? DelPermission { get; set; }
}
