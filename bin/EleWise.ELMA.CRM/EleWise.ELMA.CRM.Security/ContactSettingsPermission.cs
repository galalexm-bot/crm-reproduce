using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
public class ContactSettingsPermission : InstanceSettingsPermissionBase<IContact, IContactPersonPermission>
{
	public override Permission AdminPermission => CRMPermissionProvider.CRMFullAccessPermission;

	public ContactSettingsPermission()
		: base((Expression<Func<IContactPersonPermission, IContact>>)((IContactPersonPermission access) => access.Contact))
	{
	}

	protected override ICollection<IContactPersonPermission> GetPermissionHolderCollection(IContact target)
	{
		return (ICollection<IContactPersonPermission>)target.Permission;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		IContact permissionSubject = (IContact)target;
		if (!base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMContactIssuanceElementPermission, permissionSubject))
		{
			return base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission);
		}
		return true;
	}

	public override ICollection<Permission> CanGrandLevel(IUser user, object target)
	{
		IContact permissionSubject = (IContact)target;
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission) || base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMContactFullAccessPermission, permissionSubject))
		{
			return null;
		}
		List<Permission> list = new List<Permission>();
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMContactIssuanceElementPermission, permissionSubject))
		{
			list.Add(CRMPermissionProvider.CRMContactIssuanceElementPermission);
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.EditContactPermission, permissionSubject))
			{
				list.AddRange(new List<Permission>
				{
					CRMPermissionProvider.EditContactPermission,
					CRMPermissionProvider.ViewContactPermission,
					CRMPermissionProvider.CRMContactCreateElementPermission
				});
				return list;
			}
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMContactCreateElementPermission, permissionSubject))
			{
				list.AddRange(new List<Permission>
				{
					CRMPermissionProvider.ViewContactPermission,
					CRMPermissionProvider.CRMContactCreateElementPermission
				});
				return list;
			}
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.ViewContactPermission, permissionSubject))
			{
				list.AddRange(new List<Permission> { CRMPermissionProvider.ViewContactPermission });
				return list;
			}
			return new List<Permission>();
		}
		return new List<Permission>();
	}
}
