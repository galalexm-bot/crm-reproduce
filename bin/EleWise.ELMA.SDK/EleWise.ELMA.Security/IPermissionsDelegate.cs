using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IPermissionsDelegate
{
	bool CanCheckPermissions(Type type, Permission permission);

	bool HasPermission(IUser user, Permission permission, object target, bool skipAdmin = false);
}
