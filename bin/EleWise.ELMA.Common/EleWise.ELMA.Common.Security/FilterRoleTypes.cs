using System.Collections.Generic;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Common.Security;

[Component]
public class FilterRoleTypes : IPermissionRoleTypeProvider
{
	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		PermissionRoleType author = CommonRoleTypes.Author;
		PermissionRoleType[] roleTypes = new PermissionRoleType[4] { organizationItem, group, user, author };
		return new PermissionRoleTypeStereotype[3]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IFilter>(), PermissionProvider.FilterViewPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IFilter>(), PermissionProvider.FilterEditPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IFilter>(), PermissionProvider.FilterFullAccessPermission, roleTypes)
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
