using System;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks.ExtensionPoints;

namespace EleWise.ELMA.CRM.Components.WorkLog;

public abstract class CRMWorkLogObjectSearchExtensionBase : WorkLogObjectSearchExtensionBase
{
	public ISecurityService SecurityService { get; set; }

	public override bool HasPermission(Guid typeUid)
	{
		return SecurityService.HasPermission(CRMPermissionProvider.CRMAccessPermission);
	}
}
