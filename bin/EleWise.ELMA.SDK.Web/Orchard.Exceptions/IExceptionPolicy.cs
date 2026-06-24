using System;

namespace Orchard.Exceptions;

public interface IExceptionPolicy : ISingletonDependency, IDependency
{
	bool HandleException(object sender, Exception exception);
}
