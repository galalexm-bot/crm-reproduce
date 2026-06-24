using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IMetadataTypeInfo
{
	string Name { get; }

	string Description { get; }

	Type MetadataType { get; }

	Type GeneratorType { get; }
}
