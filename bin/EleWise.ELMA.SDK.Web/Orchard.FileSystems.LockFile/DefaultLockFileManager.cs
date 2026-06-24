using System;
using System.Globalization;
using System.Threading;
using Orchard.Caching;
using Orchard.FileSystems.AppData;
using Orchard.Services;

namespace Orchard.FileSystems.LockFile;

public class DefaultLockFileManager : ILockFileManager, IVolatileProvider, ISingletonDependency, IDependency
{
	private readonly IAppDataFolder _appDataFolder;

	private readonly IClock _clock;

	private readonly ReaderWriterLockSlim _rwLock = new ReaderWriterLockSlim();

	public static TimeSpan Expiration { get; private set; }

	public DefaultLockFileManager(IAppDataFolder appDataFolder, IClock clock)
	{
		_appDataFolder = appDataFolder;
		_clock = clock;
		Expiration = TimeSpan.FromMinutes(10.0);
	}

	public bool TryAcquireLock(string path, ref ILockFile lockFile)
	{
		if (!_rwLock.TryEnterWriteLock(0))
		{
			return false;
		}
		try
		{
			if (IsLockedImpl(path))
			{
				return false;
			}
			lockFile = new LockFile(_appDataFolder, path, _clock.UtcNow.ToString("u"), _rwLock);
			return true;
		}
		catch
		{
			return false;
		}
		finally
		{
			_rwLock.ExitWriteLock();
		}
	}

	public bool IsLocked(string path)
	{
		_rwLock.EnterWriteLock();
		try
		{
			return IsLockedImpl(path);
		}
		catch
		{
			return true;
		}
		finally
		{
			_rwLock.ExitWriteLock();
		}
	}

	private bool IsLockedImpl(string path)
	{
		if (_appDataFolder.FileExists(path) && DateTime.TryParse(_appDataFolder.ReadFile(path), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out var result))
		{
			return result.ToUniversalTime().Add(Expiration) > _clock.UtcNow;
		}
		return false;
	}
}
