using System;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.ExtensionPoints;

[ExtensionPoint]
public interface IMetadataTypeInfo
{
	string Name { get; }

	string Description { get; }

	System.Type MetadataType { get; }
}
