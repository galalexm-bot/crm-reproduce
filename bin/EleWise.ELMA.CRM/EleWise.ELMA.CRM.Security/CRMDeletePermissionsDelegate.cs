using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.CRM.Security;

[Component]
internal class CRMDeletePermissionsDelegate : IPermissionsDelegate
{
	public ISecurityService SecurityService { get; set; }

	public bool CanCheckPermissions(Type type, Permission permission)
	{
		if (type != null && permission != null && (type.IsInheritOrSame<IContractor>() || type.IsInheritOrSame<ISale>() || type.IsInheritOrSame<ILead>() || type.IsInheritOrSame<IContact>() || type.IsInheritOrSame<IMarketingBase>() || type.IsInheritOrSame<IMarketingPayment>() || type.IsInheritOrSame<IRelationship>()))
		{
			return permission == CommonPermissions.Delete;
		}
		return false;
	}

	public bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false)
	{
		if (target == null || permission == null)
		{
			return false;
		}
		return SecurityService.HasPermission(user, CRMPermissionProvider.CRMDeletePermission, target);
	}
}
