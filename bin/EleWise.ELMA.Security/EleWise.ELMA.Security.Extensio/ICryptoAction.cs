using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Security.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ICryptoAction
{
	ICryptoProviderServiceBase CryptoService { get; }

	Guid ActionUid { get; }

	string Description { get; }
}
