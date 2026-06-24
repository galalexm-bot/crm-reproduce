using System;
using System.Collections.Generic;

namespace Orchard.Caching;

public interface IParallelCacheContext
{
	ITask<T> CreateContextAwareTask<T>(Func<T> function);

	IEnumerable<TResult> RunInParallel<T, TResult>(IEnumerable<T> source, Func<T, TResult> selector);
}
