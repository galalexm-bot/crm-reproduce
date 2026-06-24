using System;
using System.Threading;

namespace EleWise.ELMA.CAB.Utility;

public class ReaderLock : LockBase
{
	public ReaderLock(ReaderWriterLock rwLock)
		: base(rwLock.AcquireReaderLock, rwLock.ReleaseReaderLock, -1)
	{
	}

	public ReaderLock(ReaderWriterLock rwLock, int millisecondsTimeout)
		: base(rwLock.AcquireReaderLock, rwLock.ReleaseReaderLock, millisecondsTimeout)
	{
	}

	public ReaderLock(ReaderWriterLock rwLock, TimeSpan timeout)
		: base(rwLock.AcquireReaderLock, rwLock.ReleaseReaderLock, timeout)
	{
	}
}
