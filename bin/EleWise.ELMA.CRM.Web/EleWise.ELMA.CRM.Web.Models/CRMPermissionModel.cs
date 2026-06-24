using EleWise.ELMA.BPM.Web.Security.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class CRMPermissionModel
{
	public long Id { get; set; }

	public bool ChangeInherite { get; set; }

	public EntityPermissionRoleTypeSelectorModel AdditionalPermissionsModel { get; set; }

	public EntityPermissionRoleTypeSelectorModel InheritPermissionsModel { get; set; }

	public bool InheritAvailable { get; set; }

	public bool InheritPermissions { get; set; }

	public bool LockEditPermission { get; set; }
}
