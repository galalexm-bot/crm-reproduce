using System.Collections.Generic;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class RoleMapPageItemCreateModel : EntityModel<IRoleMapPageItem>
{
	public PermissionRoleTypeSelectorModel MapItemRoleTypeSelectorModel { get; set; }

	public IEnumerable<AssignedRoleTypeModel> AssignedRoleTypeModels { get; set; }
}
