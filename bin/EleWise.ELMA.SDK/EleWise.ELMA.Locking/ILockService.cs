using System;

namespace EleWise.ELMA.Locking;

public interface ILockService
{
	bool TryAcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout, out ILock @lock);

	ILock AcquireLock(string name, TimeSpan? maxValidFor, TimeSpan? timeout);
}
