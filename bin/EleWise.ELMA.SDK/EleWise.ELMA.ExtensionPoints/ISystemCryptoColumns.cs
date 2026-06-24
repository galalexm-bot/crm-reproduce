using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ISystemCryptoColumns
{
	IEnumerable<string> PropertyNames { get; }

	bool CheckMetadata(IMetadata metadata);
}
