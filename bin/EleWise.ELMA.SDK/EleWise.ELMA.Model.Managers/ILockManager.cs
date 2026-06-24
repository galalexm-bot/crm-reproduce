using System;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Managers;

[DeveloperApi(DeveloperApiType.Service)]
public interface ILockManager
{
	IDisposable Lock(string lockName);

	IDisposable Lock(string lockName, int timeout);

	bool TryLock(string lockName, out IDisposable @lock);

	bool TryLock(string lockName, int timeout, out IDisposable @lock);

	Task<IDisposable> LockAsync(string lockName, CancellationToken token = default(CancellationToken));

	Task<IDisposable> LockAsync(string lockName, int timeout, CancellationToken token = default(CancellationToken));

	Task<IDisposable> TryLockAsync(string lockName, CancellationToken token = default(CancellationToken));

	Task<IDisposable> TryLockAsync(string lockName, int timeout, CancellationToken token = default(CancellationToken));
}
