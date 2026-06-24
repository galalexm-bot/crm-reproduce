using System;
using System.Collections.Generic;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.BPM.Web.Common.Security;

[Component]
public class CatalogRoleTypes : IPermissionRoleTypeProvider, IInstancePermissionRoleTypeProvider
{
	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes(object instance)
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		_ = CommonRoleTypes.AllUsers;
		PermissionRoleType[] allTypes = new PermissionRoleType[3] { user, group, organizationItem };
		Func<Permission, PermissionRoleTypeStereotype> func = (Permission p) => new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<ICatalogProfile>(), p, allTypes);
		return new List<PermissionRoleTypeStereotype>
		{
			func(EleWise.ELMA.Common.PermissionProvider.CatalogViewPermission),
			func(EleWise.ELMA.Common.PermissionProvider.CatalogEditPermission),
			func(EleWise.ELMA.Common.PermissionProvider.CatalogAddPermission),
			func(EleWise.ELMA.Common.PermissionProvider.CatalogDeletePermission),
			func(EleWise.ELMA.Common.PermissionProvider.CatalogExportPermission),
			func(EleWise.ELMA.Common.PermissionProvider.CatalogEditGlobalFiltersPermission)
		};
	}

	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		return GetTypePermissionRoleStereotypes(null);
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
