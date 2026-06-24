using System;
using System.Collections.Generic;

namespace Orchard.Caching;

public interface ITask<T> : IDisposable
{
	IEnumerable<IVolatileToken> Tokens { get; }

	T Execute();

	void Finish();
}
