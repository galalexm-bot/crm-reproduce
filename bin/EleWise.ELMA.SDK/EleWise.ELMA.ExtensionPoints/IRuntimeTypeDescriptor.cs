using System;

namespace EleWise.ELMA.ExtensionPoints;

public interface IRuntimeTypeDescriptor
{
	Type RuntimeType { get; }

	bool IsRuntimeType { get; }
}
