using System;
using System.Threading;

namespace EleWise.ELMA.Threading;

public interface IThreadSubPool : IThreadPool
{
	void Queue(ThreadStart task, Action<Exception> exceptionHandler, Action finallyHandler);

	void Queue(ThreadStart task, string taskName, Action<Exception> exceptionHandler, Action finallyHandler);
}
