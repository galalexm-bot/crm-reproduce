using System;
using System.Threading;

namespace EleWise.ELMA.CAB.Utility;

public class WriterLock : LockBase
{
	public WriterLock(ReaderWriterLock rwLock)
		: base(rwLock.AcquireWriterLock, rwLock.ReleaseWriterLock, -1)
	{
	}

	public WriterLock(ReaderWriterLock rwLock, int millisecondsTimeout)
		: base(rwLock.AcquireWriterLock, rwLock.ReleaseWriterLock, millisecondsTimeout)
	{
	}

	public WriterLock(ReaderWriterLock rwLock, TimeSpan timeout)
		: base(rwLock.AcquireWriterLock, rwLock.ReleaseWriterLock, timeout)
	{
	}
}
