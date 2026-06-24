using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Deploy.ExtensionPoints;

[ExtensionPoint(ComponentType.Server)]
public interface IIgnoreIsUniqueMetadata
{
	List<Guid> GetIgnoredUids();
}
