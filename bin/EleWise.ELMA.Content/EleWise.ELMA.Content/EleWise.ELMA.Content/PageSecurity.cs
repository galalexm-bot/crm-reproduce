using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Managers;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Content;

[Component]
public class PageSecurity : InstanceSettingsPermissionBase<IPortalObject, IPortalObjectPermission>, IPermissionProvider, IEntityInstanceDefaultPermission, IPermissionRoleTypeProvider
{
	public const string Module = "EleWise.ELMA.BPM.Web.Content";

	public const string ViewPagePermissionId = "81346ECB-C58F-4EE2-AF1F-0BEA19153779";

	public const string EditPagePermissionId = "51FBD192-8B86-48A7-8EEC-01AC51EE4648";

	public const string FullPagePermissionId = "C81B5476-9D21-43CD-804A-166F589941E7";

	public static readonly Permission ViewPagePermission = Permission.Create("81346ECB-C58F-4EE2-AF1F-0BEA19153779", SR.M("Просмотр"), string.Empty, SR.M("Портал")).ModuleUid("EleWise.ELMA.BPM.Web.Content").InstancePermission<IPortalObject>()
		.Base(CommonPermissions.View);

	public static readonly Permission EditPagePermission = Permission.Create("51FBD192-8B86-48A7-8EEC-01AC51EE4648", SR.M("Редактирование"), string.Empty, SR.M("Портал")).ModuleUid("EleWise.ELMA.BPM.Web.Content").InstancePermission<IPortalObject>()
		.Base(CommonPermissions.Edit)
		.Dependencies(ViewPagePermission);

	public static readonly Permission FullAccessPagePermission = Permission.Create("C81B5476-9D21-43CD-804A-166F589941E7", SR.M("Полный доступ"), string.Empty, SR.M("Портал")).ModuleUid("EleWise.ELMA.BPM.Web.Content").InstancePermission<IPortalObject>()
		.Dependencies(ViewPagePermission, EditPagePermission);

	public UserGroupManager UserGroupManager { get; set; }

	public UserManager UserManager { get; set; }

	public PortalObjectManager PortalObjectManager { get; set; }

	public new Type EntityType => InterfaceActivator.TypeOf<IPortalObject>();

	public override Permission AdminPermission => PermissionProvider.ContentAdminPermission;

	public List<string> LocalizedItemsNames => null;

	public List<string> LocalizedItemsDescriptions => null;

	public List<string> LocalizedItemsCategories => null;

	public IEnumerable<Permission> GetPermissions()
	{
		return new Permission[3] { ViewPagePermission, EditPagePermission, FullAccessPagePermission };
	}

	public IEnumerable<PermissionStereotype> GetPermissionStereotypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionStereotype>.Instance;
	}

	public PageSecurity()
		: base((Expression<Func<IPortalObjectPermission, IPortalObject>>)((IPortalObjectPermission permission) => permission.PortalObject))
	{
	}

	protected override ICollection<IPortalObjectPermission> GetPermissionHolderCollection(IPortalObject target)
	{
		return (ICollection<IPortalObjectPermission>)target.Permissions;
	}

	public override bool CanGrandPermissions(EleWise.ELMA.Security.IUser user, object target)
	{
		IPortalObject permissionSubject = (IPortalObject)target;
		if (!base.SecurityService.HasPermission(user, PermissionProvider.ContentAdminPermission))
		{
			return base.SecurityService.HasPermission(user, FullAccessPagePermission, permissionSubject);
		}
		return true;
	}

	public void CreatePermissions(IEntity entity)
	{
		IPortalObject portalObject = (IPortalObject)entity;
		if (((ICollection<IPortalObjectPermission>)portalObject.Permissions).Count == 0)
		{
			if (portalObject.InheritPermissions && portalObject.Folder != null)
			{
				PortalObjectManager.AddPermissionsFromParent(portalObject);
			}
			if (portalObject is IPageBase)
			{
				GrandAuthorPermissions(portalObject);
			}
		}
	}

	public static void GrandAllUsersViewPermission(IPortalObject portalObject)
	{
		ISet<IPortalObjectPermission> permissions = portalObject.Permissions;
		InstanceOf<IPortalObjectPermission> instanceOf = new InstanceOf<IPortalObjectPermission>();
		instanceOf.New.PortalObject = portalObject;
		instanceOf.New.PermissionId = ViewPagePermission.Id;
		instanceOf.New.TypeRoleId = CommonRoleTypes.Group.Id;
		instanceOf.New.Group = UserGroupManager.Instance.Load(SecurityConstants.AllUsersGroupUid);
		permissions.Add(instanceOf.New);
	}

	public static void GrandAuthorPermissions(IPortalObject portalObject)
	{
		EleWise.ELMA.Security.Models.IUser user = portalObject.CreationAuthor ?? UserManager.Instance.Find((EleWise.ELMA.Security.Models.IUser u) => u.Uid == SecurityConstants.AdminUserUid).First();
		ISet<IPortalObjectPermission> permissions = portalObject.Permissions;
		InstanceOf<IPortalObjectPermission> instanceOf = new InstanceOf<IPortalObjectPermission>();
		instanceOf.New.PortalObject = portalObject;
		instanceOf.New.PermissionId = ViewPagePermission.Id;
		instanceOf.New.TypeRoleId = CommonRoleTypes.User.Id;
		instanceOf.New.User = user;
		permissions.Add(instanceOf.New);
		ISet<IPortalObjectPermission> permissions2 = portalObject.Permissions;
		InstanceOf<IPortalObjectPermission> instanceOf2 = new InstanceOf<IPortalObjectPermission>();
		instanceOf2.New.PortalObject = portalObject;
		instanceOf2.New.PermissionId = EditPagePermission.Id;
		instanceOf2.New.TypeRoleId = CommonRoleTypes.User.Id;
		instanceOf2.New.User = user;
		permissions2.Add(instanceOf2.New);
		ISet<IPortalObjectPermission> permissions3 = portalObject.Permissions;
		InstanceOf<IPortalObjectPermission> instanceOf3 = new InstanceOf<IPortalObjectPermission>();
		instanceOf3.New.PortalObject = portalObject;
		instanceOf3.New.PermissionId = FullAccessPagePermission.Id;
		instanceOf3.New.TypeRoleId = CommonRoleTypes.User.Id;
		instanceOf3.New.User = user;
		permissions3.Add(instanceOf3.New);
	}

	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		PermissionRoleType[] roleTypes = new PermissionRoleType[3] { organizationItem, group, user };
		return new PermissionRoleTypeStereotype[3]
		{
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IPortalObject>(), ViewPagePermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IPortalObject>(), EditPagePermission, roleTypes),
			new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<IPortalObject>(), FullAccessPagePermission, roleTypes)
		};
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}
}
