using System;

namespace EleWise.ELMA.Security.Services;

public interface IPropertyExpressionDescriptor
{
	string Name { get; }

	Func<object, object> Accessor { get; }

	bool AllowChief { get; }
}
