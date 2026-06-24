using System;

namespace Orchard.Caching;

public interface IAcquireContext
{
	Action<IVolatileToken> Monitor { get; }
}
