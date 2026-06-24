namespace EleWise.ELMA.Security;

public interface IMembershipService
{
	MembershipSettings GetSettings();

	MembershipSettings GetSettings(IUser user);

	IUser CreateUser(CreateUserParams createUserParams);

	IUser GetUser(string username);

	IUser GetUser(object userId);

	IUser ValidateUser(string userNameOrEmail, string password);

	void SetPassword(IUser user, string password);

	long GetFailedLogon(string userName);

	void CheckRequireChangePassword(object userId);
}
