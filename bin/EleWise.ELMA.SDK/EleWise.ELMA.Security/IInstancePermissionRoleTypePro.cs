using System.Collections.Generic;

namespace EleWise.ELMA.Security;

public interface IInstancePermissionRoleTypeProvider : IPermissionRoleTypeProvider
{
	IEnumerable<PermissionRoleTypeStereotype> GetTypePermissionRoleStereotypes(object instance);
}
