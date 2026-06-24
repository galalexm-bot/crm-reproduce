using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Documents;

[Component]
public class DocumentMetadataProfileRoleTypes : IPermissionRoleTypeProvider
{
	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		PermissionRoleType author = CommonRoleTypes.Author;
		PermissionRoleType[] roleTypes = new PermissionRoleType[4] { organizationItem, group, user, author };
		return new PermissionRoleTypeStereotype[6]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDocumentMetadataProfile>(), PermissionProvider.DocumentViewPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDocumentMetadataProfile>(), PermissionProvider.DocumentLoadPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDocumentMetadataProfile>(), PermissionProvider.DocumentEditPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDocumentMetadataProfile>(), PermissionProvider.DocumentFullAccessPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDocumentMetadataProfile>(), PermissionProvider.DocumentManagerAccessPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IDocumentMetadataProfile>(), PermissionProvider.DocumentMetadataCreateInstance, roleTypes)
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
