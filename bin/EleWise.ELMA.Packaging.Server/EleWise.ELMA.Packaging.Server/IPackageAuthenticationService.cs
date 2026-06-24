using System.Security.Principal;

namespace EleWise.ELMA.Packaging.Server.Infrastructure;

public interface IPackageAuthenticationService
{
	bool IsAuthenticated(IPrincipal user, string apiKey, string packageId);
}
