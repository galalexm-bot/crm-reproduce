using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.UI.Descriptors;

[ExtensionPoint(ComponentType.Server)]
public interface IFormDescriptorInfo
{
	Type MetadataType { get; }

	Type DescriptorType { get; }
}
