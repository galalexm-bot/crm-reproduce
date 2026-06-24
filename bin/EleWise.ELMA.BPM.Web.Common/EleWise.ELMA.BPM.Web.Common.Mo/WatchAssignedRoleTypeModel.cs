using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class WatchAssignedRoleTypeModel : AssignedRoleTypeModel
{
	public bool DisableDelete { get; set; }

	public WatchAssignedRoleTypeModel(PermissionRoleType permissionRoleType, IEntity value)
		: base(permissionRoleType, value)
	{
	}
}
