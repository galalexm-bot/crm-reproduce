using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
public class LeadSettingsPermission : InstanceSettingsPermissionBase<ILead, ILeadPersonPermission>
{
	public override Permission AdminPermission => CRMPermissionProvider.CRMFullAccessPermission;

	public LeadSettingsPermission()
		: base((Expression<Func<ILeadPersonPermission, ILead>>)((ILeadPersonPermission access) => access.Lead))
	{
	}

	protected override ICollection<ILeadPersonPermission> GetPermissionHolderCollection(ILead target)
	{
		return (ICollection<ILeadPersonPermission>)target.Permission;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		ILead permissionSubject = (ILead)target;
		if (!base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMLeadIssuanceElementPermission, permissionSubject))
		{
			return base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission);
		}
		return true;
	}

	public override ICollection<Permission> CanGrandLevel(IUser user, object target)
	{
		ILead permissionSubject = (ILead)target;
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission) || base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMLeadFullAccessPermission, permissionSubject))
		{
			return null;
		}
		List<Permission> list = new List<Permission>();
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMLeadIssuanceElementPermission, permissionSubject))
		{
			list.Add(CRMPermissionProvider.CRMLeadIssuanceElementPermission);
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.EditLeadPermission, permissionSubject))
			{
				list.AddRange(new List<Permission>
				{
					CRMPermissionProvider.EditLeadPermission,
					CRMPermissionProvider.ViewLeadPermission,
					CRMPermissionProvider.CRMLeadCreateElementPermission
				});
				return list;
			}
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMLeadCreateElementPermission, permissionSubject))
			{
				list.AddRange(new List<Permission>
				{
					CRMPermissionProvider.ViewLeadPermission,
					CRMPermissionProvider.CRMLeadCreateElementPermission
				});
				return list;
			}
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.ViewLeadPermission, permissionSubject))
			{
				list.AddRange(new List<Permission> { CRMPermissionProvider.ViewLeadPermission });
				return list;
			}
			return new List<Permission>();
		}
		return new List<Permission>();
	}
}
