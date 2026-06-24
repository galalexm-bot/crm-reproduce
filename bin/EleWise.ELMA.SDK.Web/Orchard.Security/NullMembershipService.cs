using System;

namespace Orchard.Security;

public class NullMembershipService : IMembershipService, IDependency
{
	public IUser CreateUser(CreateUserParams createUserParams)
	{
		throw new NotImplementedException();
	}

	public IMembershipSettings GetSettings()
	{
		throw new NotImplementedException();
	}

	public IUser GetUser(string username)
	{
		throw new NotImplementedException();
	}

	public void SetPassword(IUser user, string password)
	{
		throw new NotImplementedException();
	}

	public IUser ValidateUser(string userNameOrEmail, string password)
	{
		throw new NotImplementedException();
	}

	public bool PasswordIsExpired(IUser user, int weeks)
	{
		throw new NotImplementedException();
	}
}
