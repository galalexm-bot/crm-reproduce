namespace Orchard.Security;

public class DefaultMembershipValidationService : IMembershipValidationService, IDependency
{
	public bool CanAuthenticateWithCookie(IUser user)
	{
		return true;
	}
}
