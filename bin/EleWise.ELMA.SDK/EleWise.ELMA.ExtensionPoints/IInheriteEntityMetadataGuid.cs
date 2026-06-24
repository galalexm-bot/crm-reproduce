using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IInheriteEntityMetadataGuid
{
	Guid Uid { get; }
}
