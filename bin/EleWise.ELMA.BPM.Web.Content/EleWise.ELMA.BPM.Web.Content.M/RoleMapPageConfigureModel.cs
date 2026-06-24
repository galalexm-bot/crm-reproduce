using System.Collections.Generic;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class RoleMapPageConfigureModel : EntityModel<IRoleMapPage>
{
	public Dictionary<IRoleMapPageItem, IEnumerable<AssignedRoleTypeModel>> MapItems { get; set; }
}
