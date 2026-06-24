using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Common;

[Component]
public class CatalogDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<ICatalogProfile>();

	public void CreatePermissions(IEntity entity)
	{
		IUserGroup group = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		IUserGroup group2 = UserGroupManager.Instance.Load(SecurityConstants.AdminGroupUid);
		ICatalogProfile catalogProfile = (ICatalogProfile)entity;
		if (((ICollection<ICatalogAccess>)catalogProfile.Permission).Count == 0)
		{
			ISet<ICatalogAccess> permission = catalogProfile.Permission;
			InstanceOf<ICatalogAccess> instanceOf = new InstanceOf<ICatalogAccess>();
			instanceOf.New.CatalogProfile = catalogProfile;
			instanceOf.New.PermissionId = PermissionProvider.CatalogViewPermission.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf.New.Group = group;
			permission.Add(instanceOf.New);
			ISet<ICatalogAccess> permission2 = catalogProfile.Permission;
			InstanceOf<ICatalogAccess> instanceOf2 = new InstanceOf<ICatalogAccess>();
			instanceOf2.New.CatalogProfile = catalogProfile;
			instanceOf2.New.PermissionId = PermissionProvider.CatalogAddPermission.Id;
			instanceOf2.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf2.New.Group = group2;
			permission2.Add(instanceOf2.New);
			ISet<ICatalogAccess> permission3 = catalogProfile.Permission;
			InstanceOf<ICatalogAccess> instanceOf3 = new InstanceOf<ICatalogAccess>();
			instanceOf3.New.CatalogProfile = catalogProfile;
			instanceOf3.New.PermissionId = PermissionProvider.CatalogEditPermission.Id;
			instanceOf3.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf3.New.Group = group2;
			permission3.Add(instanceOf3.New);
			ISet<ICatalogAccess> permission4 = catalogProfile.Permission;
			InstanceOf<ICatalogAccess> instanceOf4 = new InstanceOf<ICatalogAccess>();
			instanceOf4.New.CatalogProfile = catalogProfile;
			instanceOf4.New.PermissionId = PermissionProvider.CatalogDeletePermission.Id;
			instanceOf4.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf4.New.Group = group2;
			permission4.Add(instanceOf4.New);
			ISet<ICatalogAccess> permission5 = catalogProfile.Permission;
			InstanceOf<ICatalogAccess> instanceOf5 = new InstanceOf<ICatalogAccess>();
			instanceOf5.New.CatalogProfile = catalogProfile;
			instanceOf5.New.PermissionId = PermissionProvider.CatalogExportPermission.Id;
			instanceOf5.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf5.New.Group = group2;
			permission5.Add(instanceOf5.New);
			ISet<ICatalogAccess> permission6 = catalogProfile.Permission;
			InstanceOf<ICatalogAccess> instanceOf6 = new InstanceOf<ICatalogAccess>();
			instanceOf6.New.CatalogProfile = catalogProfile;
			instanceOf6.New.PermissionId = PermissionProvider.CatalogEditGlobalFiltersPermission.Id;
			instanceOf6.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf6.New.Group = group2;
			permission6.Add(instanceOf6.New);
		}
	}
}
