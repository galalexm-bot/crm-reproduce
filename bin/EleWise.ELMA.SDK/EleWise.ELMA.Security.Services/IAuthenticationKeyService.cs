using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Security.Services;

[ExtensionPoint(ComponentType.Server)]
public interface IAuthenticationKeyService
{
	string SecretKeyName { get; }

	string LoginName { get; }

	bool SignIn(string secretKey, string userName);
}
