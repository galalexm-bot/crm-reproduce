using System;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Locking;

public static class LockServiceExtensions
{
	private static LockServiceExtensions C0xerthrYuoY4yYOyrOq;

	public static bool TryAcquireLock(this ILockService service, string name, TimeSpan? maxValidFor, out ILock @lock)
	{
		return service.TryAcquireLock(name, maxValidFor, TimeSpan.Zero, out @lock);
	}

	public static bool TryAcquireLock(this ILockService service, string name, out ILock @lock)
	{
		return service.TryAcquireLock(name, null, TimeSpan.Zero, out @lock);
	}

	public static ILock AcquireLock(this ILockService service, string name, TimeSpan? maxValidFor)
	{
		return service.AcquireLock(name, maxValidFor, null);
	}

	public static ILock AcquireLock(this ILockService service, string name)
	{
		return service.AcquireLock(name, null, null);
	}

	public static Task<ILock> TryAcquireLockAsync(this IAsyncLockService service, string name, TimeSpan? maxValidFor, CancellationToken token = default(CancellationToken))
	{
		return service.TryAcquireLockAsync(name, maxValidFor, TimeSpan.Zero, token);
	}

	public static Task<ILock> TryAcquireLockAsync(this IAsyncLockService service, string name, CancellationToken token = default(CancellationToken))
	{
		return service.TryAcquireLockAsync(name, null, TimeSpan.Zero, token);
	}

	public static Task<ILock> AcquireLockAsync(this IAsyncLockService service, string name, TimeSpan? maxValidFor, CancellationToken token = default(CancellationToken))
	{
		return service.AcquireLockAsync(name, maxValidFor, null, token);
	}

	public static Task<ILock> AcquireLockAsync(this IAsyncLockService service, string name, CancellationToken token = default(CancellationToken))
	{
		return service.AcquireLockAsync(name, null, null, token);
	}

	internal static bool UTagE9hrLtB7pouRBvRM()
	{
		return C0xerthrYuoY4yYOyrOq == null;
	}

	internal static LockServiceExtensions rrwNxmhrU0G3SOSY12X6()
	{
		return C0xerthrYuoY4yYOyrOq;
	}
}
