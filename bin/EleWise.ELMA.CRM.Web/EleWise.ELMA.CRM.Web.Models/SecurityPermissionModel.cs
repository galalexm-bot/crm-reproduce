using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Security.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class SecurityPermissionModel
{
	public IEnumerable<CrmCustomPermissionsModel> LeadPermissionsModels { get; set; }

	public IEnumerable<CrmCustomPermissionsModel> ContractorPermissionsModels { get; set; }

	public GlobalPermissionsModel GlobalPermissionsModel { get; set; }

	public SecurityPermissionModel(IEnumerable<CrmCustomPermissionsModel> leadPermissionsModels, IEnumerable<CrmCustomPermissionsModel> contractorPermissionsModels, GlobalPermissionsModel globalPermissionsModel)
	{
		LeadPermissionsModels = leadPermissionsModels;
		ContractorPermissionsModels = contractorPermissionsModels;
		GlobalPermissionsModel = globalPermissionsModel;
	}
}
