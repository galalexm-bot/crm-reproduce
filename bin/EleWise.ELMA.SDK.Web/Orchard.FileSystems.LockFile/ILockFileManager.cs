using Orchard.Caching;

namespace Orchard.FileSystems.LockFile;

public interface ILockFileManager : IVolatileProvider, ISingletonDependency, IDependency
{
	bool TryAcquireLock(string path, ref ILockFile lockFile);

	bool IsLocked(string path);
}
