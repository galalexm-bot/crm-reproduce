using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Security.Code;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class CrmCustomPermissionsModel
{
	public static readonly string ModelTypeLead = "Lead";

	public static readonly string ModelTypeContractor = "Contractor";

	public ICategory Category { get; set; }

	public IEnumerable<AssignedRoleTypeModel> AssignedRoleTypeModels { get; set; }

	public IEnumerable<CrmPermissionData> SelectedPermissionsData { get; set; }

	public string ModelType { get; set; }

	public CrmCustomPermissionsModel(ICategory category, string modelType, IEnumerable<AssignedRoleTypeModel> assignedRoleTypeModels, IEnumerable<CrmPermissionData> leadPermissionData)
	{
		Category = category;
		ModelType = modelType;
		AssignedRoleTypeModels = assignedRoleTypeModels;
		SelectedPermissionsData = leadPermissionData;
	}
}
