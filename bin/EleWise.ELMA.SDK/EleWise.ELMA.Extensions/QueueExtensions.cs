using System.Collections.Generic;

namespace EleWise.ELMA.Extensions;

public static class QueueExtensions
{
	public static bool LockTryDequeue<T>(this Queue<T> queue, out T result)
	{
		lock (queue)
		{
			result = default(T);
			if (queue.Count == 0)
			{
				return false;
			}
			result = queue.Dequeue();
			return true;
		}
	}

	public static void LockEnqueue<T>(this Queue<T> queue, T item)
	{
		lock (queue)
		{
			queue.Enqueue(item);
		}
	}

	public static void LockClear<T>(this Queue<T> queue)
	{
		lock (queue)
		{
			queue.Clear();
		}
	}
}
