using System;

namespace Orchard.Tasks.Locking.Services;

public static class DistributedLockServiceExtensions
{
	public static bool TryAcquireLock(this IDistributedLockService service, string name, TimeSpan? maxValidFor, out IDistributedLock @lock)
	{
		return service.TryAcquireLock(name, maxValidFor, TimeSpan.Zero, out @lock);
	}

	public static bool TryAcquireLock(this IDistributedLockService service, string name, out IDistributedLock @lock)
	{
		return service.TryAcquireLock(name, null, TimeSpan.Zero, out @lock);
	}

	public static IDistributedLock AcquireLock(this IDistributedLockService service, string name, TimeSpan? maxValidFor)
	{
		return service.AcquireLock(name, maxValidFor, null);
	}

	public static IDistributedLock AcquireLock(this IDistributedLockService service, string name)
	{
		return service.AcquireLock(name, null, null);
	}
}
