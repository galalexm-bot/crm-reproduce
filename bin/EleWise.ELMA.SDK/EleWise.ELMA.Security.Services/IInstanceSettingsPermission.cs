using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Security.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IInstanceSettingsPermission
{
	Type EntityType { get; }

	bool Filtering { get; }

	string TargetPropetyName { get; }

	Type PermissionHolderType { get; }

	Permission AdminPermission { get; }

	ICollection<IInstanceSettingsPermissionHolder> GetPermissionCollection(object target);

	bool CanGrandPermissions(IUser user, object target);

	ICollection<Permission> CanGrandLevel(IUser user, object target);

	bool CanGrandToElement(Permission[] elementPermission, Permission[] userPermission, Permission permissionToCheck, Guid permissionRoleTypeId, IEntity permissionRole, object target);

	bool IsSystemRole(Guid permissionRoleTypeId, IEntity permissionRole, object target);
}
