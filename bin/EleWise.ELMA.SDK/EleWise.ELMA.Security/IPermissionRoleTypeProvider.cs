using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
public interface IPermissionRoleTypeProvider
{
	IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes();

	IEnumerable<PermissionRoleType> GetRoleTypes();
}
