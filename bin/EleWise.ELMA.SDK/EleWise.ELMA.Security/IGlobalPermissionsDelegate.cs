using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IGlobalPermissionsDelegate
{
	bool HasPermission(IUser user, Permission permission, IEnumerable<Guid> userPermissionUids);
}
