using System.Collections.Generic;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class UserGroupModel
{
	public bool IsPopup { get; set; }

	public IUserGroup Group { get; set; }

	public PermissionRoleTypeSelectorModel PermissionRoleTypeSelectorModel { get; set; }

	public IEnumerable<AssignedRoleTypeModel> AssignedRoleTypeModels { get; set; }

	public bool ShowPermissions { get; set; }

	public Permission[] Permissions { get; set; }

	public int? LicenseTotalCount { get; set; }

	public int? LicenseUsedCount { get; set; }

	public UserGroupModel(IUserGroup group, PermissionRoleTypeSelectorModel permissionRoleTypeSelectorModel, IEnumerable<AssignedRoleTypeModel> assignedRoleTypeModels)
	{
		Group = group;
		PermissionRoleTypeSelectorModel = permissionRoleTypeSelectorModel;
		AssignedRoleTypeModels = assignedRoleTypeModels;
	}
}
