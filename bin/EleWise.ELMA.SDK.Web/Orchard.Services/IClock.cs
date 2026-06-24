using System;
using Orchard.Caching;

namespace Orchard.Services;

public interface IClock : IVolatileProvider, ISingletonDependency, IDependency
{
	DateTime UtcNow { get; }

	IVolatileToken When(TimeSpan duration);

	IVolatileToken WhenUtc(DateTime absoluteUtc);
}
