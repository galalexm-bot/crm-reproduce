using System;

namespace Orchard;

public interface IWorkContextStateProvider : IDependency
{
	Func<WorkContext, T> Get<T>(string name);
}
