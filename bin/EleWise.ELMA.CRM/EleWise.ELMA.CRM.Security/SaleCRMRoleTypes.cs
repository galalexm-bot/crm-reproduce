using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Security;

[Component]
internal class SaleCRMRoleTypes : IPermissionRoleTypeProvider
{
	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		PermissionRoleType author = CommonRoleTypes.Author;
		PermissionRoleType responsible = CommonRoleTypes.Responsible;
		PermissionRoleType[] roleTypes = new PermissionRoleType[5] { organizationItem, group, user, author, responsible };
		return new PermissionRoleTypeStereotype[5]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<ISale>(), CRMPermissionProvider.ViewSalePermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<ISale>(), CRMPermissionProvider.CRMSaleCreateElementPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<ISale>(), CRMPermissionProvider.EditSalePermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<ISale>(), CRMPermissionProvider.CRMSaleIssuanceElementPermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<ISale>(), CRMPermissionProvider.CRMSaleFullAccessPermission, roleTypes)
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
