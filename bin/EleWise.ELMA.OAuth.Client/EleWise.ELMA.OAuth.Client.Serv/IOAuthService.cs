using System;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.OAuth.Client.Services;

public interface IOAuthService
{
	IUser ValidateUser(string token, Guid providerUid);
}
