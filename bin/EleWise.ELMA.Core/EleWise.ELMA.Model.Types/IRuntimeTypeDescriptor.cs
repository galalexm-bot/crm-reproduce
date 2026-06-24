using System;

namespace EleWise.ELMA.Model.Types;

public interface IRuntimeTypeDescriptor
{
	System.Type RuntimeType { get; }

	bool IsRuntimeType { get; }
}
