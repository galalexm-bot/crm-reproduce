using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
public class SaleSettingsPermission : InstanceSettingsPermissionBase<ISale, ISalePersonPermission>
{
	public override Permission AdminPermission => CRMPermissionProvider.CRMFullAccessPermission;

	public SaleSettingsPermission()
		: base((Expression<Func<ISalePersonPermission, ISale>>)((ISalePersonPermission access) => access.Sale))
	{
	}

	protected override ICollection<ISalePersonPermission> GetPermissionHolderCollection(ISale target)
	{
		return (ICollection<ISalePersonPermission>)target.Permission;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		ISale permissionSubject = (ISale)target;
		if (!base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMSaleIssuanceElementPermission, permissionSubject))
		{
			return base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission);
		}
		return true;
	}

	public override ICollection<Permission> CanGrandLevel(IUser user, object target)
	{
		ISale permissionSubject = (ISale)target;
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission) || base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMSaleFullAccessPermission, permissionSubject))
		{
			return null;
		}
		List<Permission> list = new List<Permission>();
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMSaleIssuanceElementPermission, permissionSubject))
		{
			list.Add(CRMPermissionProvider.CRMSaleIssuanceElementPermission);
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.EditSalePermission, permissionSubject))
			{
				list.AddRange(new List<Permission>
				{
					CRMPermissionProvider.EditSalePermission,
					CRMPermissionProvider.ViewSalePermission,
					CRMPermissionProvider.CRMSaleCreateElementPermission
				});
				return list;
			}
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMSaleCreateElementPermission, permissionSubject))
			{
				list.AddRange(new List<Permission>
				{
					CRMPermissionProvider.ViewSalePermission,
					CRMPermissionProvider.CRMSaleCreateElementPermission
				});
				return list;
			}
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.ViewSalePermission, permissionSubject))
			{
				list.AddRange(new List<Permission> { CRMPermissionProvider.ViewSalePermission });
				return list;
			}
			return new List<Permission>();
		}
		return new List<Permission>();
	}
}
