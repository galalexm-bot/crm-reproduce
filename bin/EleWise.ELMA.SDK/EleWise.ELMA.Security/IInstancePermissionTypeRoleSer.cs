using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security;

public interface IInstancePermissionTypeRoleService : IPermissionTypeRoleService
{
	IEnumerable<Tuple<Permission, PermissionRoleType[]>> GetInstancePermissionRoles(object instance);
}
