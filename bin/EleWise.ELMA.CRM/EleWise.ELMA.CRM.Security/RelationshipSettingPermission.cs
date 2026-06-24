using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
public class RelationshipSettingPermission : InstanceSettingsPermissionBase<IRelationship, IRelationshipPersonPermission>
{
	public override Permission AdminPermission => CRMPermissionProvider.CRMFullAccessPermission;

	public RelationshipSettingPermission()
		: base((Expression<Func<IRelationshipPersonPermission, IRelationship>>)((IRelationshipPersonPermission access) => access.Relationship))
	{
	}

	protected override ICollection<IRelationshipPersonPermission> GetPermissionHolderCollection(IRelationship target)
	{
		return (ICollection<IRelationshipPersonPermission>)target.Permission;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		IRelationship permissionSubject = (IRelationship)target;
		if (!base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, permissionSubject))
		{
			return base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission);
		}
		return true;
	}

	public override ICollection<Permission> CanGrandLevel(IUser user, object target)
	{
		IRelationship permissionSubject = (IRelationship)target;
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission) || base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMRelationshipFullAccessPermission, permissionSubject))
		{
			return null;
		}
		List<Permission> list = new List<Permission>();
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, permissionSubject))
		{
			list.Add(CRMPermissionProvider.CRMRelationshipIssuanceElementPermission);
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.EditRelationshipPermission, permissionSubject))
			{
				list.AddRange(new List<Permission>
				{
					CRMPermissionProvider.EditRelationshipPermission,
					CRMPermissionProvider.ViewRelationshipPermission,
					CRMPermissionProvider.CRMRelationshipCreateElementPermission
				});
				return list;
			}
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMRelationshipCreateElementPermission, permissionSubject))
			{
				list.AddRange(new List<Permission>
				{
					CRMPermissionProvider.ViewRelationshipPermission,
					CRMPermissionProvider.CRMRelationshipCreateElementPermission
				});
				return list;
			}
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.ViewRelationshipPermission, permissionSubject))
			{
				list.AddRange(new List<Permission> { CRMPermissionProvider.ViewRelationshipPermission });
				return list;
			}
			return new List<Permission>();
		}
		return new List<Permission>();
	}
}
