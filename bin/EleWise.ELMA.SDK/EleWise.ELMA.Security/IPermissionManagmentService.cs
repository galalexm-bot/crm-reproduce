using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security;

public interface IPermissionManagmentService
{
	IEnumerable<Permission> GetPermissions();

	Permission GetPermission(Guid permissionId);

	Permission GetPermissionForBase(Permission permission, Type entityType);

	Permission GetModuleAccessPermission(string moduleUid);
}
