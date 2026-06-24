using System;
using EleWise.ELMA.UI.Metadata;

namespace EleWise.ELMA.UI.Descriptors;

public interface IFormPartDescriptor
{
	IFormDescriptor FormDescriptor { get; }

	FormPartMetadata Metadata { get; }

	Type ContextType { get; }
}
