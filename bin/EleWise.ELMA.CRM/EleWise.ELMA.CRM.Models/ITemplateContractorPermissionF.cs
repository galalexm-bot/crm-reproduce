using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ITemplateContractorPermission))]
public interface ITemplateContractorPermissionFilter : IEntityFilter
{
	IContContractorPermission ContainerContractor { get; set; }

	bool? AddPermission { get; set; }

	bool? DelPermission { get; set; }
}
