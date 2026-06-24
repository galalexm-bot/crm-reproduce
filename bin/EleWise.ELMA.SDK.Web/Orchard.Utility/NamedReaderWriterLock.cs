using System;
using System.Collections.Concurrent;
using System.Threading;

namespace Orchard.Utility;

public class NamedReaderWriterLock : IDisposable
{
	private readonly ConcurrentDictionary<string, ReaderWriterLockSlim> _lockDictonary = new ConcurrentDictionary<string, ReaderWriterLockSlim>();

	public ReaderWriterLockSlim GetLock(string name)
	{
		return _lockDictonary.GetOrAdd(name, new ReaderWriterLockSlim());
	}

	public TResult RunWithReadLock<TResult>(string name, Func<TResult> body)
	{
		ReaderWriterLockSlim @lock = GetLock(name);
		try
		{
			@lock.EnterReadLock();
			return body();
		}
		finally
		{
			@lock.ExitReadLock();
		}
	}

	public void RunWithReadLock(string name, Action body)
	{
		ReaderWriterLockSlim @lock = GetLock(name);
		try
		{
			@lock.EnterReadLock();
			body();
		}
		finally
		{
			@lock.ExitReadLock();
		}
	}

	public TResult RunWithWriteLock<TResult>(string name, Func<TResult> body)
	{
		ReaderWriterLockSlim @lock = GetLock(name);
		try
		{
			@lock.EnterWriteLock();
			return body();
		}
		finally
		{
			@lock.ExitWriteLock();
		}
	}

	public void RunWithWriteLock(string name, Action body)
	{
		ReaderWriterLockSlim @lock = GetLock(name);
		try
		{
			@lock.EnterWriteLock();
			body();
		}
		finally
		{
			@lock.ExitWriteLock();
		}
	}

	public void RemoveLock(string name)
	{
		_lockDictonary.TryRemove(name, out var _);
	}

	public void Dispose()
	{
		foreach (ReaderWriterLockSlim value in _lockDictonary.Values)
		{
			value.Dispose();
		}
	}
}
