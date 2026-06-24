using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IExternalClusterInfo
{
	IEnumerable<Guid> GetActiveConnectionUids();
}
