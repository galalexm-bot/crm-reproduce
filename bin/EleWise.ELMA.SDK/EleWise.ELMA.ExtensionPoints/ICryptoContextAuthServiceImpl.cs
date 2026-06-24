using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ICryptoContextAuthServiceImpl
{
	bool CheckType(IEntity entity);

	bool SignInForEntity(IEntity entity, string password);

	bool IsSignForEntity(IEntity entity);

	void SignOutForEntity(IEntity entity);

	IEntity DecryptFromContext(IEntity entity);

	string GetPasswordFromContext(IEntity entity);
}
