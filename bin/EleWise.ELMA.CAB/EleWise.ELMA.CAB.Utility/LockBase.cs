using System;

namespace EleWise.ELMA.CAB.Utility;

public abstract class LockBase : IDisposable
{
	private readonly ReleaseMethod release;

	private readonly bool timedOut;

	public bool TimedOut => timedOut;

	internal LockBase(AcquireIntTimeoutMethod acquire, ReleaseMethod release, int timeout)
	{
		this.release = release;
		try
		{
			acquire(timeout);
		}
		catch (ApplicationException)
		{
			timedOut = true;
		}
	}

	internal LockBase(AcquireTimeSpanTimeoutMethod acquire, ReleaseMethod release, TimeSpan timeout)
	{
		this.release = release;
		try
		{
			acquire(timeout);
		}
		catch (ApplicationException)
		{
			timedOut = true;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && !timedOut)
		{
			release();
		}
	}
}
