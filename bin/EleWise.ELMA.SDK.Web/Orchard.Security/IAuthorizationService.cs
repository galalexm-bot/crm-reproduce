using Orchard.ContentManagement;
using Orchard.Security.Permissions;

namespace Orchard.Security;

public interface IAuthorizationService : IDependency
{
	void CheckAccess(Permission permission, IUser user, IContent content);

	bool TryCheckAccess(Permission permission, IUser user, IContent content);
}
