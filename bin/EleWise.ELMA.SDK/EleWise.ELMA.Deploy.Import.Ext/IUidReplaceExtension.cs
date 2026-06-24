using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IUidReplaceExtension
{
	bool IsSupported(Guid typeUid);

	IDictionary<Guid, Guid> Replace(Dictionary<string, object> propValuesR);
}
