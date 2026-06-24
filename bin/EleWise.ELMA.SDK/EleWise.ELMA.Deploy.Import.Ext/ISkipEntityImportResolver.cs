using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface ISkipEntityImportResolver
{
	bool IsSupported(Guid typeGuid);

	bool IsSkip(Dictionary<string, object> propValues, Dictionary<string, string> serviceData);
}
