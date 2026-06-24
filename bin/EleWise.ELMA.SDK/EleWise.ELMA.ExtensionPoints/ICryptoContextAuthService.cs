using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.ExtensionPoints;

public interface ICryptoContextAuthService
{
	bool SignInForEntity(IEntity entity, string password);

	bool IsSignForEntity(IEntity entity);

	void SignOutForEntity(IEntity entity);

	IEntity DecryptFromContext(IEntity entity);

	string GetPasswordFromContext(IEntity entity);
}
