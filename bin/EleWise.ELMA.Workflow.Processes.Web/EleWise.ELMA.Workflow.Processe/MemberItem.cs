using System.Collections.Generic;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class MemberItem
{
	public IUser User { get; set; }

	public List<RoleItem> Members { get; set; }
}
