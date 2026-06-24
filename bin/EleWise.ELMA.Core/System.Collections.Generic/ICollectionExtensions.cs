using EleWise.ELMA.Collections;

namespace System.Collections.Generic;

public static class ICollectionExtensions
{
	public static void AddRange<T>(this System.Collections.Generic.ICollection<T> destination, System.Collections.Generic.IEnumerable<T> source)
	{
		if (source == null)
		{
			return;
		}
		if (destination is IReactiveCollection<T> reactiveCollection)
		{
			reactiveCollection.AddRange(source);
			return;
		}
		if (destination is List<T> val)
		{
			val.AddRange(source);
			return;
		}
		System.Collections.Generic.IEnumerator<T> enumerator = source.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				T current = enumerator.get_Current();
				destination.Add(current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}
}
