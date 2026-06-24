using System;

namespace Orchard.Tasks.Locking.Services;

public interface IDistributedLock : IDisposable
{
	string Name { get; }
}
