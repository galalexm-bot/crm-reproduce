namespace Orchard.Security;

public interface IMembershipValidationService : IDependency
{
	bool CanAuthenticateWithCookie(IUser user);
}
