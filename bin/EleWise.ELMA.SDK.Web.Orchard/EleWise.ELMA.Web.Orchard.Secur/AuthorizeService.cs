using Orchard;
using Orchard.ContentManagement;
using Orchard.Security;
using Orchard.Security.Permissions;

namespace EleWise.ELMA.Web.Orchard.Security;

public class AuthorizeService : IAuthorizationService, IDependency
{
	public void CheckAccess(Permission permission, IUser user, IContent content)
	{
	}

	public bool TryCheckAccess(Permission permission, IUser user, IContent content)
	{
		return true;
	}
}
