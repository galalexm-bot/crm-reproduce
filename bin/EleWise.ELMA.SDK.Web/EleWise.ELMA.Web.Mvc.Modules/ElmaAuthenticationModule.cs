using System.Web;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Modules;

public class ElmaAuthenticationModule : BaseAuthenticationModule
{
	public ElmaAuthenticationModule()
	{
		base.Realm = "Elma Realm";
	}

	protected override bool AuthenticateAgent(HttpApplication app, string username, string password, out string[] groups)
	{
		groups = null;
		IUser user = Locator.GetServiceNotNull<IMembershipService>().ValidateUser(username, password);
		if (user == null)
		{
			return false;
		}
		Locator.GetServiceNotNull<IAuthenticationService>().SetAuthenticatedUserForRequest(user);
		return true;
	}
}
