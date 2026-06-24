using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Security.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IDigitalSignatureType
{
	Guid Uid { get; }

	string DisplayName { get; }

	string Code { get; }

	IEnumerable<Guid> Providers { get; }
}
