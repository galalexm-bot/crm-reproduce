using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security.Services;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IAuthenticationTokenService
{
	Guid CreateToken([NotNull] IUser user);

	[CanBeNull]
	IUser GetUser(Guid token);

	void RemoveToken(Guid token);
}
