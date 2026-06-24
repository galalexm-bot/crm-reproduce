using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Security.Extensions;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ISystemRolePermissions
{
	Type EntityType { get; }

	bool IsSystem(Guid permissionRoleTypeId, IEntity permissionRole, object target, Type entityType, Permission permissionToCheck);

	bool IsSystemRole(Guid permissionRoleTypeId, IEntity permissionRole, object target, Type entityType);
}
