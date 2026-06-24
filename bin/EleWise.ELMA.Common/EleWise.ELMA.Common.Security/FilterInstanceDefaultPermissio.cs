using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Common.Security;

[Component]
public class FilterInstanceDefaultPermission : IEntityInstanceDefaultPermission
{
	public Type EntityType => InterfaceActivator.TypeOf<IFilter>();

	public void CreatePermissions(IEntity entity)
	{
		if (entity is IFilter filter && ((ICollection<IFilterPermission>)filter.Permissions).Count == 0)
		{
			ISet<IFilterPermission> permissions = filter.Permissions;
			InstanceOf<IFilterPermission> instanceOf = new InstanceOf<IFilterPermission>();
			instanceOf.New.Filter = filter;
			instanceOf.New.PermissionId = PermissionProvider.FilterViewPermission.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.Author.Id;
			instanceOf.New.User = filter.CreationAuthor;
			permissions.Add(instanceOf.New);
			ISet<IFilterPermission> permissions2 = filter.Permissions;
			InstanceOf<IFilterPermission> instanceOf2 = new InstanceOf<IFilterPermission>();
			instanceOf2.New.Filter = filter;
			instanceOf2.New.PermissionId = PermissionProvider.FilterEditPermission.Id;
			instanceOf2.New.TypeRoleId = CommonRoleTypes.Author.Id;
			instanceOf2.New.User = filter.CreationAuthor;
			permissions2.Add(instanceOf2.New);
			ISet<IFilterPermission> permissions3 = filter.Permissions;
			InstanceOf<IFilterPermission> instanceOf3 = new InstanceOf<IFilterPermission>();
			instanceOf3.New.Filter = filter;
			instanceOf3.New.PermissionId = PermissionProvider.FilterFullAccessPermission.Id;
			instanceOf3.New.TypeRoleId = CommonRoleTypes.Author.Id;
			instanceOf3.New.User = filter.CreationAuthor;
			permissions3.Add(instanceOf3.New);
			ISet<IFilterPermission> permissions4 = filter.Permissions;
			InstanceOf<IFilterPermission> instanceOf4 = new InstanceOf<IFilterPermission>();
			instanceOf4.New.Filter = filter;
			instanceOf4.New.PermissionId = PermissionProvider.FilterViewPermission.Id;
			instanceOf4.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf4.New.Group = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
			permissions4.Add(instanceOf4.New);
		}
	}
}
