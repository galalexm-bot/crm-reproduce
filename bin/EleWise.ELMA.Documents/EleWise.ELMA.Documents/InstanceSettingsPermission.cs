using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Documents;

[Component]
public class InstanceSettingsPermission : InstanceSettingsPermissionBase<IDmsObject, IDmsObjectPermission>
{
	public override Permission AdminPermission => PermissionProvider.DocumentsFullAccessToAllObjectsPermission;

	public InstanceSettingsPermission()
		: base((Expression<Func<IDmsObjectPermission, IDmsObject>>)((IDmsObjectPermission access) => access.DmsObject))
	{
	}

	protected override ICollection<IDmsObjectPermission> GetPermissionHolderCollection(IDmsObject target)
	{
		return (ICollection<IDmsObjectPermission>)target.Permissions;
	}

	public override bool CanGrandPermissions(IUser user, object target)
	{
		IDmsObject permissionSubject = (IDmsObject)target;
		if (!base.SecurityService.HasPermission(user, PermissionProvider.DocumentFullAccessPermission, permissionSubject))
		{
			return base.SecurityService.HasPermission(user, PermissionProvider.DocumentManagerAccessPermission, permissionSubject);
		}
		return true;
	}

	public override ICollection<Permission> CanGrandLevel(IUser user, object target)
	{
		IDmsObject dmsObject = (IDmsObject)target;
		if (!base.SecurityService.HasPermission(user, PermissionProvider.DocumentsFullAccessToAllObjectsPermission) && !base.SecurityService.HasPermission(user, PermissionProvider.DocumentFullAccessPermission, dmsObject))
		{
			if (!base.SecurityService.HasPermission(user, PermissionProvider.DocumentManagerAccessPermission, dmsObject) || !base.SecurityService.HasPermission(user, PermissionProvider.DocumentViewPermission, dmsObject))
			{
				return new List<Permission>();
			}
			return CreatePermissionsWhenCanGrandLevel(user, dmsObject);
		}
		return null;
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
		if (userPermission.Any((Permission p) => p.Id == PermissionProvider.DocumentFullAccessPermission.Id))
		{
			return true;
		}
		if (permissionToCheck.Id == PermissionProvider.DocumentFullAccessPermission.Id)
		{
			return false;
		}
		if (userPermission.All((Permission p) => p.Id != PermissionProvider.DocumentManagerAccessPermission.Id))
		{
			return false;
		}
		if (permissionToCheck.Id == PermissionProvider.DocumentEditPermission.Id)
		{
			if (elementPermission.All((Permission p) => p.Id != PermissionProvider.DocumentFullAccessPermission.Id))
			{
				return userPermission.Any((Permission p) => p.Id == PermissionProvider.DocumentEditPermission.Id);
			}
			return false;
		}
		if (permissionToCheck.Id == PermissionProvider.DocumentCreatePermission.Id)
		{
			if (elementPermission.All((Permission p) => p.Id != PermissionProvider.DocumentFullAccessPermission.Id))
			{
				return userPermission.Any((Permission p) => p.Id == PermissionProvider.DocumentCreatePermission.Id);
			}
			return false;
		}
		if (permissionToCheck.Id == PermissionProvider.DocumentViewPermission.Id)
		{
			if (elementPermission.Any((Permission p) => p.Id == PermissionProvider.DocumentFullAccessPermission.Id))
			{
				return false;
			}
			if (elementPermission.Any((Permission p) => p.Id == PermissionProvider.DocumentEditPermission.Id) && userPermission.All((Permission p) => p.Id != PermissionProvider.DocumentEditPermission.Id))
			{
				return false;
			}
			return true;
		}
		if (permissionToCheck.Id == PermissionProvider.DocumentManagerAccessPermission.Id)
		{
			if (elementPermission.All((Permission p) => p.Id != PermissionProvider.DocumentFullAccessPermission.Id))
			{
				return userPermission.Any((Permission p) => p.Id == PermissionProvider.DocumentManagerAccessPermission.Id);
			}
			return false;
		}
		if (permissionToCheck.Id == PermissionProvider.DocumentLoadPermission.Id)
		{
			if (elementPermission.All((Permission p) => p.Id != PermissionProvider.DocumentFullAccessPermission.Id))
			{
				return userPermission.Any((Permission p) => p.Id == PermissionProvider.DocumentLoadPermission.Id);
			}
			return false;
		}
		return false;
	}

	private ICollection<Permission> CreatePermissionsWhenCanGrandLevel(IUser user, IDmsObject dmsObject)
	{
		List<Permission> list = new List<Permission>
		{
			PermissionProvider.DocumentViewPermission,
			PermissionProvider.DocumentManagerAccessPermission
		};
		if (base.SecurityService.HasPermission(user, PermissionProvider.DocumentEditPermission, dmsObject))
		{
			list.Add(PermissionProvider.DocumentEditPermission);
		}
		if (base.SecurityService.HasPermission(user, PermissionProvider.DocumentLoadPermission, dmsObject))
		{
			list.Add(PermissionProvider.DocumentLoadPermission);
		}
		if (dmsObject is IFolder && base.SecurityService.HasPermission(user, PermissionProvider.DocumentCreatePermission, dmsObject))
		{
			list.Add(PermissionProvider.DocumentCreatePermission);
		}
		return list;
	}
}
