using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Helpers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Security;

internal static class MarketingObjectPermissionsCreator
{
	private static readonly Permission[] AllPermissions = new Permission[6]
	{
		CRMPermissionProvider.ViewMarketingPermission,
		CRMPermissionProvider.EditMarketingPermission,
		CRMPermissionProvider.CRMMarketingCreateElementPermission,
		CRMPermissionProvider.CRMMarketingBudgetControlPermission,
		CRMPermissionProvider.CRMMarketingIssuanceElementPermission,
		CRMPermissionProvider.CRMMarketingFullAccessPermission
	};

	public static IEnumerable<IMarketingPersonPermission> GetAuthorFullPermissions(IMarketingBase marketingObj)
	{
		return AllPermissions.Select(delegate(Permission permission)
		{
			InstanceOf<IMarketingPersonPermission> instanceOf = new InstanceOf<IMarketingPersonPermission>();
			instanceOf.New.MarketingObject = marketingObj;
			instanceOf.New.User = marketingObj.CreationAuthor;
			instanceOf.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetUserMask(marketingObj.CreationAuthor.Id);
			instanceOf.New.PermissionId = permission.Id;
			instanceOf.New.PermissionRole = CommonRoleTypes.Author.UID;
			return instanceOf.New;
		});
	}

	private static IEnumerable<IMarketingPersonPermission> GetReadOnlyAccessGroupsPermissions(IMarketingBase targetMarketingObj, IEnumerable<IUserGroup> marketingReadOnlyAccessGroups)
	{
		return marketingReadOnlyAccessGroups.Select(delegate(IUserGroup g)
		{
			InstanceOf<IMarketingPersonPermission> instanceOf = new InstanceOf<IMarketingPersonPermission>();
			instanceOf.New.MarketingObject = targetMarketingObj;
			instanceOf.New.Group = g;
			instanceOf.New.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(g.Id);
			instanceOf.New.PermissionId = CRMPermissionProvider.ViewMarketingPermission.Id;
			instanceOf.New.PermissionRole = CommonRoleTypes.Group.UID;
			return instanceOf.New;
		});
	}

	public static IEnumerable<IMarketingPersonPermission> GetDefaultPermissions(IMarketingBase marketingObj, IEnumerable<IUserGroup> marketingReadOnlyAccessGroups)
	{
		Contract.ArgumentNotNull(marketingObj, "marketingObj");
		return GetAuthorFullPermissions(marketingObj).Concat(GetReadOnlyAccessGroupsPermissions(marketingObj, marketingReadOnlyAccessGroups));
	}

	public static IEnumerable<IMarketingPersonPermission> GetInheritedPermissions(IMarketingBase targetObj)
	{
		Contract.ArgumentNotNull(targetObj, "targetObj");
		IMarketingBase parent = MarketingObjectsWalker.GetParent(targetObj);
		Contract.CheckArgument(parent != null, "targetObj must have parent");
		return ((IEnumerable<IMarketingPersonPermission>)parent.Permission).Select((IMarketingPersonPermission permission) => CreateInheritedPermission(permission, targetObj));
	}

	public static IMarketingPersonPermission CreateInheritedPermission(IMarketingPersonPermission sourcePermission, IMarketingBase targetObj)
	{
		Contract.ArgumentNotNull(sourcePermission, "sourcePermission");
		Contract.ArgumentNotNull(targetObj, "targetObj");
		IMarketingBase parent = MarketingObjectsWalker.GetParent(targetObj);
		Contract.CheckArgument(sourcePermission.MarketingObject == parent, "sourcePermission.MarketingObject == parentObj");
		InstanceOf<IMarketingPersonPermission> instanceOf = new InstanceOf<IMarketingPersonPermission>();
		instanceOf.New.MarketingObject = targetObj;
		instanceOf.New.User = ((sourcePermission.TypeRoleId == CommonRoleTypes.Author.Id) ? targetObj.CreationAuthor : sourcePermission.User);
		instanceOf.New.Group = sourcePermission.Group;
		instanceOf.New.OrganizationItemEmployee = sourcePermission.OrganizationItemEmployee;
		instanceOf.New.OrganizationItemPosition = sourcePermission.OrganizationItemPosition;
		instanceOf.New.UserSecuritySetCacheId = ((sourcePermission.TypeRoleId == CommonRoleTypes.Author.Id) ? new long?(UserSecuritySetHelper.GetUserMask(targetObj.CreationAuthor.Id)) : sourcePermission.UserSecuritySetCacheId);
		instanceOf.New.PermissionId = sourcePermission.PermissionId;
		instanceOf.New.TypeRoleId = sourcePermission.TypeRoleId;
		instanceOf.New.PermissionRole = sourcePermission.PermissionRole;
		instanceOf.New.PermissionSource = sourcePermission.PermissionSource ?? parent;
		return instanceOf.New;
	}
}
