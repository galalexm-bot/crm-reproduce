using System;

namespace EleWise.ELMA.Security;

public interface IPropertyPermissionService
{
	PropertyPermissionType CheckPropertyPermission(object dataItem, Guid propertyGuid, IUser user = null);

	PropertyPermissionType CheckPropertyPermissionByGlobalOnly(Type modelType, Guid propertyGuid, IUser user = null);

	PropertyPermissionType CheckPropertyPermissionByRoleOnly(object dataItem, Guid propertyGuid, IUser user = null);

	bool HasPermissionsByRole(Type modelType, Guid propertyGuid, IUser user = null);

	bool HasPermissions(Type modelType);
}
