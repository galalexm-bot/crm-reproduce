using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
internal class RelationshipCRMRoleTypes : IPermissionRoleTypeProvider
{
	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		PermissionRoleType author = CommonRoleTypes.Author;
		PermissionRoleType participantWork = CommonRoleTypes.ParticipantWork;
		PermissionRoleType informs = CommonRoleTypes.Informs;
		PermissionRoleType[] roleTypes = new PermissionRoleType[6] { organizationItem, group, user, author, participantWork, informs };
		return new PermissionRoleTypeStereotype[5]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IRelationship>(), CRMPermissionProvider.ViewRelationshipPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IRelationship>(), CRMPermissionProvider.EditRelationshipPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IRelationship>(), CRMPermissionProvider.CRMRelationshipCreateElementPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IRelationship>(), CRMPermissionProvider.CRMRelationshipFullAccessPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IRelationship>(), CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, roleTypes)
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
