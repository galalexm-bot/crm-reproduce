using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IFilterPortletCheckPermission
{
	bool AvailablePermissionType(Guid TypeUid);

	bool HasPermission(Guid TypeUid);
}
