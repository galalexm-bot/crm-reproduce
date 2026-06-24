using System;
using System.Web.Security;
using Orchard;
using Orchard.Security;

namespace EleWise.ELMA.Web.Orchard.Security;

public class AuthService : IAuthenticationService, IDependency
{
	public void SignIn(IUser user, bool createPersistentCookie)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		FormsAuthentication.SetAuthCookie(user.UserName, createPersistentCookie);
	}

	public void SignOut()
	{
		FormsAuthentication.SignOut();
	}

	public void SetAuthenticatedUserForRequest(IUser user)
	{
	}

	public IUser GetAuthenticatedUser()
	{
		MembershipUser user = Membership.GetUser(userIsOnline: true);
		if (user == null)
		{
			return null;
		}
		return new OrchardUser(user);
	}
}
