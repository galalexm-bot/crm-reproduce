using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

public static class EnumerableExtensions
{
	private sealed class _003C_003Ec__DisplayClass1_0<T>
	{
		public Predicate<T> condition;

		internal bool _003CFirstOrDefaultFromMany_003Eb__0(T t)
		{
			return condition.Invoke(t);
		}
	}

	public static System.Collections.Generic.IEnumerable<T> If<T>(this System.Collections.Generic.IEnumerable<T> instance, bool condition, Func<System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IEnumerable<T>> action)
	{
		if (!condition)
		{
			return instance;
		}
		return action.Invoke(instance);
	}

	public static T FirstOrDefaultFromMany<T>(this System.Collections.Generic.IEnumerable<T> instance, Func<T, System.Collections.Generic.IEnumerable<T>> childrenSelector, Predicate<T> condition)
	{
		_003C_003Ec__DisplayClass1_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0<T>();
		CS_0024_003C_003E8__locals0.condition = condition;
		if (instance == null || !Enumerable.Any<T>(instance))
		{
			return default(T);
		}
		T val = Enumerable.FirstOrDefault<T>(instance, (Func<T, bool>)((T t) => CS_0024_003C_003E8__locals0.condition.Invoke(t)));
		if (!object.Equals((object)val, (object)default(T)))
		{
			return val;
		}
		return ((System.Collections.Generic.IEnumerable<T>)Enumerable.SelectMany<T, T>(instance, childrenSelector)).FirstOrDefaultFromMany(childrenSelector, CS_0024_003C_003E8__locals0.condition);
	}

	public static bool Contains<TSource, TResult>(this System.Collections.Generic.IEnumerable<TSource> source, TResult checkItem, Func<TSource, TResult> predicate, Func<TResult, TResult, bool> compare)
	{
		System.Collections.Generic.IEnumerator<TSource> enumerator = source.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				TSource current = enumerator.get_Current();
				if (compare.Invoke(predicate.Invoke(current), checkItem))
				{
					return true;
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return false;
	}
}
