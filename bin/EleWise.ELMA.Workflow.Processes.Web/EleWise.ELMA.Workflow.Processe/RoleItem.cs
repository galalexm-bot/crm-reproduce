using EleWise.ELMA.Security;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Models;

public class RoleItem
{
	public IWorkflowInstanceMember Member { get; set; }

	public PermissionRoleType PermissionRoleType { get; set; }
}
