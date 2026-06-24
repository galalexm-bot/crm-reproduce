using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Messages.Security;

[Component]
public class ChannelRoleTypes : IPermissionRoleTypeProvider
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
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IInformationChannel>(), PermissionProvider.ChannelViewPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IInformationChannel>(), PermissionProvider.ChannelEditPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IInformationChannel>(), PermissionProvider.ChannelFullAccessPermission, roleTypes)
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
