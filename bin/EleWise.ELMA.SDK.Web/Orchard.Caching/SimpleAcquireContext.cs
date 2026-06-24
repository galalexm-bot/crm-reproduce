using System;

namespace Orchard.Caching;

public class SimpleAcquireContext : IAcquireContext
{
	private readonly Action<IVolatileToken> _monitor;

	public Action<IVolatileToken> Monitor => _monitor;

	public SimpleAcquireContext(Action<IVolatileToken> monitor)
	{
		_monitor = monitor;
	}
}
