using System.Collections.Generic;
using Orchard.Environment.Extensions.Models;

namespace Orchard.Security.Permissions;

public interface IPermissionProvider : IDependency
{
	Feature Feature { get; }

	IEnumerable<Permission> GetPermissions();

	IEnumerable<PermissionStereotype> GetDefaultStereotypes();
}
