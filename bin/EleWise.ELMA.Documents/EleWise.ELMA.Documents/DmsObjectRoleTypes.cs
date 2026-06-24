using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Documents;

[Component]
public class DmsObjectRoleTypes : IPermissionRoleTypeProvider
{
	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		PermissionRoleType author = CommonRoleTypes.Author;
		PermissionRoleType[] roleTypes = new PermissionRoleType[4] { organizationItem, group, user, author };
		return new PermissionRoleTypeStereotype[8]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDmsObject>(), PermissionProvider.DocumentViewPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDmsObject>(), PermissionProvider.DocumentLoadPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDmsObject>(), PermissionProvider.DocumentEditPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDmsObject>(), PermissionProvider.DocumentFullAccessPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDmsObject>(), PermissionProvider.DocumentManagerAccessPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IFolder>(), PermissionProvider.DocumentCreatePermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDocumentVersion>(), PermissionProvider.DocumentVersionViewPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDocumentVersion>(), PermissionProvider.DocumentVersionLoadPermission, roleTypes)
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
