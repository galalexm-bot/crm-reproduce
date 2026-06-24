using System;
using System.Threading;

namespace EleWise.ELMA.WebCompiler;

public static class ReaderWriterLockSlimHelper
{
	private class LockExiter : IDisposable
	{
		private readonly ReaderWriterLockSlim _lock;

		private readonly Action<ReaderWriterLockSlim> _exitLock;

		public LockExiter(ReaderWriterLockSlim @lock, Action<ReaderWriterLockSlim> enterLock, Action<ReaderWriterLockSlim> exitLock)
		{
			_lock = @lock;
			enterLock(_lock);
			_exitLock = exitLock;
		}

		public void Dispose()
		{
			_exitLock(_lock);
		}
	}

	public static IDisposable ReadLock(this ReaderWriterLockSlim @lock)
	{
		return new LockExiter(@lock, delegate(ReaderWriterLockSlim l)
		{
			l.EnterReadLock();
		}, delegate(ReaderWriterLockSlim l)
		{
			l.ExitReadLock();
		});
	}

	public static IDisposable WriteLock(this ReaderWriterLockSlim @lock)
	{
		return new LockExiter(@lock, delegate(ReaderWriterLockSlim l)
		{
			l.EnterWriteLock();
		}, delegate(ReaderWriterLockSlim l)
		{
			l.ExitWriteLock();
		});
	}
}
