using System;

namespace EleWise.ELMA.Threading;

public interface IElmaThreadPoolWorkItem : IDisposable
{
	void WaitThread();

	bool WaitExecute(TimeSpan timeout);

	void AbortWorkerThread();
}
