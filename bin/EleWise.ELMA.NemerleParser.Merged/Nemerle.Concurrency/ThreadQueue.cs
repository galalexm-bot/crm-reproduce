using System.Threading;

namespace Nemerle.Concurrency;

public class ThreadQueue
{
	private bool signaled = false;

	private int count = 0;

	public bool Empty => count == 0;

	public void Yield(object currentLock)
	{
		checked
		{
			count++;
			Monitor.Exit(currentLock);
			lock (this)
			{
				while (!signaled)
				{
					Monitor.Wait(this);
				}
				signaled = false;
			}
			Monitor.Enter(currentLock);
			count--;
		}
	}

	public void Wakeup()
	{
		lock (this)
		{
			if (!signaled)
			{
				signaled = true;
				Monitor.Pulse(this);
			}
		}
	}
}
