using EleWise.ELMA.BPM.Web.Security.Models;

namespace EleWise.ELMA.Documents.Web.Models;

public class BasePermissionModel
{
	public bool InheritPermissions { get; set; }

	public long Id { get; set; }

	public bool Edit { get; set; }

	public EntityPermissionRoleTypeSelectorModel InheritedPermissionsModel { get; set; }

	public EntityPermissionRoleTypeSelectorModel AdditionalPermissionsModel { get; set; }

	public bool InheritAvailable { get; set; }
}
