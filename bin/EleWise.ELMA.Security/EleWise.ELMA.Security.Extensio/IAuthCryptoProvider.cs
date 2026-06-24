using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Security.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IAuthCryptoProvider : ICryptoProviderBase
{
}
