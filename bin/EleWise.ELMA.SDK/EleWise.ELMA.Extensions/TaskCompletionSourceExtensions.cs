using System;
using System.Threading.Tasks;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class TaskCompletionSourceExtensions
{
	public static void SetFromTask<TResult>(this TaskCompletionSource<TResult> resultSetter, Task task)
	{
		switch (task.Status)
		{
		case TaskStatus.RanToCompletion:
			resultSetter.SetResult((task is Task<TResult>) ? ((Task<TResult>)task).Result : default(TResult));
			break;
		case TaskStatus.Faulted:
			resultSetter.SetException(task.Exception.InnerExceptions);
			break;
		case TaskStatus.Canceled:
			resultSetter.SetCanceled();
			break;
		default:
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411305617)));
		}
	}

	public static void SetFromTask<TResult>(this TaskCompletionSource<TResult> resultSetter, Task<TResult> task)
	{
		resultSetter.SetFromTask((Task)task);
	}

	public static bool TrySetFromTask<TResult>(this TaskCompletionSource<TResult> resultSetter, Task task)
	{
		return task.Status switch
		{
			TaskStatus.RanToCompletion => resultSetter.TrySetResult((task is Task<TResult>) ? ((Task<TResult>)task).Result : default(TResult)), 
			TaskStatus.Faulted => resultSetter.TrySetException(task.Exception.InnerExceptions), 
			TaskStatus.Canceled => resultSetter.TrySetCanceled(), 
			_ => throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A6D59C))), 
		};
	}

	public static bool TrySetFromTask<TResult>(this TaskCompletionSource<TResult> resultSetter, Task<TResult> task)
	{
		return resultSetter.TrySetFromTask((Task)task);
	}
}
