using System.Linq;
using EleWise.ELMA.BPM.Web.Security.Components;
using EleWise.ELMA.Security;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;

namespace EleWise.ELMA.Workflow.Processes.Web.Components;

public class ProcessPermissionsPageProvider : EntityPermissionsPageProvider<IProcessHeader>
{
	protected override Permission[] AccessPermissions => base.AccessPermissions.Union(new Permission[1] { WorkflowGlobalPermissionProvider.AccessManagmentPermission }).ToArray();
}
