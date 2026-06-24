using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint]
public interface IInheriteEntityMetadataGuid
{
	Guid Uid { get; }
}
