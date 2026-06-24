using System.Security.Principal;

namespace EleWise.ELMA.Packaging.Server.Infrastructure;

public class PackageAuthenticationService : IPackageAuthenticationService
{
	private static PackageAuthenticationService _instance;

	public static PackageAuthenticationService Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = new PackageAuthenticationService();
			}
			return _instance;
		}
		set
		{
			_instance = value;
		}
	}

	public bool IsAuthenticated(IPrincipal user, string apiKey, string packageId)
	{
		return true;
	}
}
