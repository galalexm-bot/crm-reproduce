using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Common.Security;

public class CatalogInstancesPermissionBase<TEntity, TPermission> : InstanceSettingsPermissionBase<TEntity, TPermission>, IEntityInstanceDefaultPermission, IPermissionRoleTypeProvider where TEntity : class, IEntity where TPermission : class, IInstanceSettingsPermissionHolder, IEntityPermissionExtension
{
	public UserGroupManager UserGroupManager { get; set; }

	public override string TargetPropetyName => "Parent";

	public CatalogInstancesPermissionBase()
		: base((Expression<Func<TPermission, TEntity>>)((TPermission access) => (TEntity)access.Instance))
	{
	}

	protected override ICollection<TPermission> GetPermissionHolderCollection(TEntity target)
	{
		EntityMetadata metadata = MetadataLoader.LoadMetadata(target.CastAsRealType().GetType()) as EntityMetadata;
		TablePartMetadata activePermissionMetadata = metadata.GetActivePermissionMetadata();
		if (activePermissionMetadata != null && metadata.CanUsePermissions() && target.GetPropertyValue(((IPropertyMetadata)activePermissionMetadata).PropertyUid) is ISet<TPermission> result)
		{
			return result;
		}
		return new HashSet<TPermission>();
	}

	public override bool CanGrandToElement(Permission[] elementPermission, Permission[] userPermission, Permission permissionToCheck, Guid permissionRoleTypeId, IEntity permissionRole, object target)
	{
		if (IsSystemDefaultPermission(permissionToCheck, permissionRoleTypeId, permissionRole, target))
		{
			return false;
		}
		if (userPermission == null)
		{
			return true;
		}
		if (permissionToCheck.Id == PermissionProvider.CatalogInstancePowerPermission.Id)
		{
			if (elementPermission.All((Permission p) => p.Id != PermissionProvider.CatalogInstanceGrantAccessPermission.Id))
			{
				return userPermission.Any((Permission p) => p.Id == PermissionProvider.CatalogInstancePowerPermission.Id);
			}
			return false;
		}
		if (permissionToCheck.Id == PermissionProvider.CatalogInstanceViewPermission.Id)
		{
			if (elementPermission.Any((Permission p) => p.Id == PermissionProvider.CatalogInstanceGrantAccessPermission.Id))
			{
				return false;
			}
			if (elementPermission.Any((Permission p) => p.Id == PermissionProvider.CatalogInstancePowerPermission.Id) && userPermission.All((Permission p) => p.Id != PermissionProvider.CatalogInstancePowerPermission.Id))
			{
				return false;
			}
			return true;
		}
		if (permissionToCheck.Id == PermissionProvider.CatalogInstanceGrantAccessPermission.Id)
		{
			if (elementPermission.All((Permission p) => p.Id != PermissionProvider.CatalogInstanceGrantAccessPermission.Id))
			{
				return userPermission.Any((Permission p) => p.Id == PermissionProvider.CatalogInstanceGrantAccessPermission.Id);
			}
			return false;
		}
		return false;
	}

	public void CreatePermissions(IEntity entity)
	{
		IUserGroup adminGroup = UserGroupManager.Load(SecurityConstants.AdminGroupUid);
		EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser() as EleWise.ELMA.Security.Models.IUser;
		foreach (Permission item in CatalogInstancePermissions())
		{
			CreatePermission(entity, item, CommonRoleTypes.Group, delegate(IEntityPermissionExtension p)
			{
				p.Group = adminGroup;
			});
			CreatePermission(entity, item, CommonRoleTypes.User, delegate(IEntityPermissionExtension p)
			{
				p.User = currentUser;
			});
		}
	}

	private void CreatePermission(IEntity entity, Permission permission, PermissionRoleType roleType, Action<IEntityPermissionExtension> action)
	{
		if (MetadataLoader.LoadMetadata(entity.CastAsRealType().GetType()) is EntityMetadata metadata)
		{
			TablePartMetadata activePermissionMetadata = metadata.GetActivePermissionMetadata();
			if (activePermissionMetadata != null)
			{
				IEntityManager entityManager = ModelHelper.GetEntityManager(ModelHelper.GetEntityType(activePermissionMetadata.Uid));
				IEntityPermissionExtension entityPermissionExtension = (IEntityPermissionExtension)entityManager.Create();
				entityPermissionExtension.PermissionId = permission.Id;
				entityPermissionExtension.PermissionRole = roleType.Id;
				entityPermissionExtension.Instance = entity;
				action?.Invoke(entityPermissionExtension);
				entityManager.Save(entityPermissionExtension);
			}
		}
	}

	public IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes()
	{
		IEnumerable<Permission> enumerable = CatalogInstancePermissions();
		if (!enumerable.Any())
		{
			return Enumerable.Empty<PermissionRoleTypeStereotype>();
		}
		PermissionRoleType organizationItem = CommonRoleTypes.OrganizationItem;
		PermissionRoleType group = CommonRoleTypes.Group;
		PermissionRoleType user = CommonRoleTypes.User;
		_ = CommonRoleTypes.AllUsers;
		PermissionRoleType[] roleTypes = new PermissionRoleType[3] { user, group, organizationItem };
		List<PermissionRoleTypeStereotype> list = new List<PermissionRoleTypeStereotype>();
		foreach (Permission item in enumerable)
		{
			list.Add(new PermissionRoleTypeStereotype(InterfaceActivator.TypeOf<TEntity>(), item, roleTypes));
		}
		return list;
	}

	public IEnumerable<PermissionRoleType> GetRoleTypes()
	{
		return EleWise.ELMA.Helpers.EmptyArray<PermissionRoleType>.Instance;
	}

	private static IEnumerable<Permission> CatalogInstancePermissions()
	{
		return new Permission[3]
		{
			PermissionProvider.CatalogInstanceViewPermission,
			PermissionProvider.CatalogInstancePowerPermission,
			PermissionProvider.CatalogInstanceGrantAccessPermission
		};
	}
}
