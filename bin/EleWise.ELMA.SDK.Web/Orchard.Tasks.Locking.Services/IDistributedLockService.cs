using System;

namespace Orchard.Tasks.Locking.Services;

public interface IDistributedLockService : IDependency
{
	bool TryAcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout, out IDistributedLock @lock);

	IDistributedLock AcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout);
}
