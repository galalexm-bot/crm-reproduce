using System.Collections.Generic;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.BPM.Web.Common.Security;

[Component]
public class PropertyRoleTypes : IPermissionRoleTypeProvider
{
	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		_ = CommonRoleTypes.AllUsers;
		PermissionRoleType[] roleTypes = new PermissionRoleType[4]
		{
			user,
			group,
			organizationItem,
			CommonRoleTypes.Property
		};
		return new PermissionRoleTypeStereotype[3]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IPropertyProfile>(), EleWise.ELMA.Common.PermissionProvider.PropertyViewPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IPropertyProfile>(), EleWise.ELMA.Common.PermissionProvider.PropertyEditPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IPropertyProfile>(), EleWise.ELMA.Common.PermissionProvider.PropertyHidePermission, roleTypes)
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
