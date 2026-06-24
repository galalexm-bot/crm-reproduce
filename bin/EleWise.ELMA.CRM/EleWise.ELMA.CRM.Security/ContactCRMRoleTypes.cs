using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
internal class ContactCRMRoleTypes : IPermissionRoleTypeProvider
{
	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		PermissionRoleType author = CommonRoleTypes.Author;
		PermissionRoleType[] roleTypes = new PermissionRoleType[4] { organizationItem, group, user, author };
		return new PermissionRoleTypeStereotype[5]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContact>(), CRMPermissionProvider.ViewContactPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContact>(), CRMPermissionProvider.CRMContactCreateElementPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContact>(), CRMPermissionProvider.EditContactPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContact>(), CRMPermissionProvider.CRMContactIssuanceElementPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IContact>(), CRMPermissionProvider.CRMContactFullAccessPermission, roleTypes)
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
