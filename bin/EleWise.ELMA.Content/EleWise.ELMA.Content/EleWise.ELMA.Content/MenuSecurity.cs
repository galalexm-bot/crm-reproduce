using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Content;

[Component]
public class MenuSecurity : InstanceSettingsPermissionBase<IMenuItem, IMenuItemPermission>, IPermissionProvider, IEntityInstanceDefaultPermission, IPermissionRoleTypeProvider
{
	public const string Module = "EleWise.ELMA.BPM.Web.Contant";

	public const string ViewMenuItemPermissionId = "57FAEA96-0DC5-4845-8310-6523A0A3A909";

	public static readonly Permission ViewMenuItemPermission = Permission.Create("57FAEA96-0DC5-4845-8310-6523A0A3A909", SR.M("Просмотр элемента меню"), string.Empty, SR.M("Портал")).ModuleUid("EleWise.ELMA.BPM.Web.Contant").InstancePermission<IMenuItem>();

	public UserGroupManager UserGroupManager { get; set; }

	public override bool Filtering => false;

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public MenuSecurity()
		: base((Expression<Func<IMenuItemPermission, IMenuItem>>)((IMenuItemPermission p) => p.MenuItem))
	{
	}

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[1] { ViewMenuItemPermission };
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionStereotype>.Instance;
	}

	public void CreatePermissions(IEntity entity)
	{
		IMenuItem menuItem = (IMenuItem)entity;
		AddDefaultPermissions(menuItem);
	}

	private void AddDefaultPermissions(IMenuItem menuItem)
	{
		if (((ICollection<IMenuItemPermission>)menuItem.Permissions).Count == 0)
		{
			ISet<IMenuItemPermission> permissions = menuItem.Permissions;
			InstanceOf<IMenuItemPermission> instanceOf = new InstanceOf<IMenuItemPermission>();
			instanceOf.New.MenuItem = menuItem;
			instanceOf.New.PermissionId = ViewMenuItemPermission.Id;
			instanceOf.New.TypeRoleId = CommonRoleTypes.Group.Id;
			instanceOf.New.Group = UserGroupManager.Load(SecurityConstants.AllUsersGroupUid);
			permissions.Add(instanceOf.New);
		}
	}

	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		return new PermissionRoleTypeStereotype[1]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IMenuItem>(), ViewMenuItemPermission, new PermissionRoleType[3] { organizationItem, group, user })
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		return base.SecurityService.HasPermission(user, PermissionProvider.ContentAdminPermission);
	}

	protected override ICollection<IMenuItemPermission> GetPermissionHolderCollection(IMenuItem target)
	{
		return (ICollection<IMenuItemPermission>)target.Permissions;
	}
}
