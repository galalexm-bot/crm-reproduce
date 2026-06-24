using System;

namespace Orchard.Caching;

public class AcquireContext<TKey> : IAcquireContext
{
	public TKey Key { get; private set; }

	public Action<IVolatileToken> Monitor { get; private set; }

	public AcquireContext(TKey key, Action<IVolatileToken> monitor)
	{
		Key = key;
		Monitor = monitor;
	}
}
