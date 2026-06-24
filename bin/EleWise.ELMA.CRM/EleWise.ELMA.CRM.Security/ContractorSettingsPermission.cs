using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
public class ContractorSettingsPermission : InstanceSettingsPermissionBase<IContractor, IContractorPersonPermission>
{
	public override Permission AdminPermission => CRMPermissionProvider.CRMFullAccessPermission;

	public ContractorSettingsPermission()
		: base((Expression<Func<IContractorPersonPermission, IContractor>>)((IContractorPersonPermission access) => access.Contractor))
	{
	}

	protected override ICollection<IContractorPersonPermission> GetPermissionHolderCollection(IContractor target)
	{
		return (ICollection<IContractorPersonPermission>)target.Permission;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		IContractor permissionSubject = (IContractor)target;
		if (!base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMContractorIssuanceElementPermission, permissionSubject))
		{
			return base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission);
		}
		return true;
	}

	public override ICollection<Permission> CanGrandLevel(IUser user, object target)
	{
		IContractor permissionSubject = (IContractor)target;
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission) || base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMContractorFullAccessPermission, permissionSubject))
		{
			return null;
		}
		List<Permission> list = new List<Permission>();
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMContractorIssuanceElementPermission, permissionSubject))
		{
			list.Add(CRMPermissionProvider.CRMContractorIssuanceElementPermission);
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.EditContractorPermission, permissionSubject))
			{
				list.AddRange(new List<Permission>
				{
					CRMPermissionProvider.EditContractorPermission,
					CRMPermissionProvider.ViewContractorPermission,
					CRMPermissionProvider.CRMContractorCreateElementPermission
				});
				return list;
			}
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMContractorCreateElementPermission, permissionSubject))
			{
				list.AddRange(new List<Permission>
				{
					CRMPermissionProvider.ViewContractorPermission,
					CRMPermissionProvider.CRMContractorCreateElementPermission
				});
				return list;
			}
			if (base.SecurityService.HasPermission(user, CRMPermissionProvider.ViewContractorPermission, permissionSubject))
			{
				list.AddRange(new List<Permission> { CRMPermissionProvider.ViewContractorPermission });
				return list;
			}
			return new List<Permission>();
		}
		return new List<Permission>();
	}
}
