using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.BPM.Web.Security.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
internal interface IUnusedPermissions
{
	IEnumerable<Permission> Permissions(object instance);
}
