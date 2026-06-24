using System;
using System.Threading;

namespace EleWise.ELMA.Threading;

public interface IElmaThreadPool
{
	IElmaThreadPoolWorkItem Push(ThreadStart callback);

	IElmaThreadPoolWorkItem Push(ThreadStart callback, Action<Exception> exceptionHandler, Action finallyHandler);
}
