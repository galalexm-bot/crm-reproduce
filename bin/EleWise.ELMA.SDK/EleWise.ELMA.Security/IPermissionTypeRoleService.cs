using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security;

public interface IPermissionTypeRoleService
{
	IEnumerable<PermissionRoleType> All();

	PermissionRoleType Get(Guid id);

	PermissionRoleType Load(Guid id);

	IEnumerable<Tuple<Permission, PermissionRoleType[]>> GetPermissionRoles(Type type);
}
