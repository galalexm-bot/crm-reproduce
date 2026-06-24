using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Security;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IFunctionPermissionProvider
{
	Guid Uid { get; }

	void CheckPermission(Type entityType, long id, Guid permisssionId);
}
