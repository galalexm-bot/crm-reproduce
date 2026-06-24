using System;
using System.Threading;
using Orchard.FileSystems.AppData;

namespace Orchard.FileSystems.LockFile;

public class LockFile : ILockFile, IDisposable
{
	private readonly IAppDataFolder _appDataFolder;

	private readonly string _path;

	private readonly string _content;

	private readonly ReaderWriterLockSlim _rwLock;

	private bool _released;

	public LockFile(IAppDataFolder appDataFolder, string path, string content, ReaderWriterLockSlim rwLock)
	{
		_appDataFolder = appDataFolder;
		_path = path;
		_content = content;
		_rwLock = rwLock;
		_appDataFolder.CreateFile(path, content);
	}

	public void Dispose()
	{
		Release();
	}

	public void Release()
	{
		_rwLock.EnterWriteLock();
		try
		{
			if (!_released && _appDataFolder.FileExists(_path))
			{
				_released = true;
				if (_appDataFolder.ReadFile(_path) == _content)
				{
					_appDataFolder.DeleteFile(_path);
				}
			}
		}
		finally
		{
			_rwLock.ExitWriteLock();
		}
	}
}
