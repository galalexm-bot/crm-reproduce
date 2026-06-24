using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
internal class MarketingSettingsPermission : InstanceSettingsPermissionBase<IMarketingBase, IMarketingPersonPermission>
{
	private class AdditionalPermissionsPattern
	{
		public Permission MatchedPermission { get; set; }

		public Permission[] ResultPermissions { get; set; }
	}

	private readonly AdditionalPermissionsPattern[] patterns = new AdditionalPermissionsPattern[4]
	{
		new AdditionalPermissionsPattern
		{
			MatchedPermission = CRMPermissionProvider.EditMarketingPermission,
			ResultPermissions = new Permission[3]
			{
				CRMPermissionProvider.EditMarketingPermission,
				CRMPermissionProvider.ViewMarketingPermission,
				CRMPermissionProvider.CRMMarketingCreateElementPermission
			}
		},
		new AdditionalPermissionsPattern
		{
			MatchedPermission = CRMPermissionProvider.CRMMarketingCreateElementPermission,
			ResultPermissions = new Permission[2]
			{
				CRMPermissionProvider.ViewMarketingPermission,
				CRMPermissionProvider.CRMMarketingCreateElementPermission
			}
		},
		new AdditionalPermissionsPattern
		{
			MatchedPermission = CRMPermissionProvider.CRMMarketingBudgetControlPermission,
			ResultPermissions = new Permission[2]
			{
				CRMPermissionProvider.ViewMarketingPermission,
				CRMPermissionProvider.CRMMarketingBudgetControlPermission
			}
		},
		new AdditionalPermissionsPattern
		{
			MatchedPermission = CRMPermissionProvider.ViewMarketingPermission,
			ResultPermissions = new Permission[1] { CRMPermissionProvider.ViewMarketingPermission }
		}
	};

	public override Permission AdminPermission => CRMPermissionProvider.CRMFullAccessPermission;

	public MarketingSettingsPermission()
		: base((Expression<Func<IMarketingPersonPermission, IMarketingBase>>)((IMarketingPersonPermission access) => access.MarketingObject))
	{
	}

	protected override ICollection<IMarketingPersonPermission> GetPermissionHolderCollection(IMarketingBase target)
	{
		return (ICollection<IMarketingPersonPermission>)target.Permission;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		if (!base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMMarketingIssuanceElementPermission, target))
		{
			return base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission);
		}
		return true;
	}

	public override ICollection<Permission> CanGrandLevel(IUser user, object target)
	{
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMFullAccessPermission) || base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMMarketingFullAccessPermission, target))
		{
			return null;
		}
		List<Permission> list = new List<Permission>();
		if (base.SecurityService.HasPermission(user, CRMPermissionProvider.CRMMarketingIssuanceElementPermission, target))
		{
			list.Add(CRMPermissionProvider.CRMMarketingIssuanceElementPermission);
			list.AddRange(GetAdditionalPermissions(user, target));
		}
		return list;
	}

	private IEnumerable<Permission> GetAdditionalPermissions(IUser user, object target)
	{
		return patterns.SelectMany((AdditionalPermissionsPattern pattern) => (!base.SecurityService.HasPermission(user, pattern.MatchedPermission, target)) ? Enumerable.Empty<Permission>() : pattern.ResultPermissions).Distinct();
	}
}
