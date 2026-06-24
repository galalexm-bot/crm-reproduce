using System;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Locking;

public interface IAsyncLockService : ILockService
{
	Task<ILock> TryAcquireLockAsync(string name, TimeSpan? maxValidFor, TimeSpan? timeout, CancellationToken token = default(CancellationToken));

	Task<ILock> AcquireLockAsync(string name, TimeSpan? maxValidFor, TimeSpan? timeout, CancellationToken token = default(CancellationToken));
}
