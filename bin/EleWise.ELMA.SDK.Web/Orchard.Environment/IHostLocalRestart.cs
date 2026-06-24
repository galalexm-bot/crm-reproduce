using System;
using Orchard.Caching;

namespace Orchard.Environment;

public interface IHostLocalRestart
{
	void Monitor(Action<IVolatileToken> monitor);
}
