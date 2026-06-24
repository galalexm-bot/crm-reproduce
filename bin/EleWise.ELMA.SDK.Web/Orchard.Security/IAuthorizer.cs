using Orchard.ContentManagement;
using Orchard.Localization;
using Orchard.Security.Permissions;

namespace Orchard.Security;

public interface IAuthorizer : IDependency
{
	bool Authorize(Permission permission);

	bool Authorize(Permission permission, LocalizedString message);

	bool Authorize(Permission permission, IContent content);

	bool Authorize(Permission permission, IContent content, LocalizedString message);
}
