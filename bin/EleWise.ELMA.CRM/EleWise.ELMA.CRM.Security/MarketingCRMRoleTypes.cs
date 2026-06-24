using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
internal class MarketingCRMRoleTypes : IPermissionRoleTypeProvider
{
	private readonly Permission[] orderedPermissions = new Permission[6]
	{
		CRMPermissionProvider.ViewMarketingPermission,
		CRMPermissionProvider.CRMMarketingCreateElementPermission,
		CRMPermissionProvider.CRMMarketingBudgetControlPermission,
		CRMPermissionProvider.EditMarketingPermission,
		CRMPermissionProvider.CRMMarketingIssuanceElementPermission,
		CRMPermissionProvider.CRMMarketingFullAccessPermission
	};

	private readonly PermissionRoleType[] permissionRoleTypes = new PermissionRoleType[4]
	{
		CommonRoleTypes.OrganizationItem,
		CommonRoleTypes.Group,
		CommonRoleTypes.User,
		CommonRoleTypes.Author
	};

	private readonly Type entityType = InterfaceActivator.TypeOf<IMarketingBase>();

	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		return orderedPermissions.Select((Permission permission) => new PermissionRoleTypeStereotype(entityType, permission, permissionRoleTypes)).ToArray();
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
