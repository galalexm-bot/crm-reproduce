using System;

namespace Orchard;

public interface IWorkContextScope : IDisposable
{
	WorkContext WorkContext { get; }

	TService Resolve<TService>();

	bool TryResolve<TService>(out TService service);
}
