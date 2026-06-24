using System.Collections;
using System.Collections.Generic;

namespace System.Linq;

internal static class EnumerableExtensions
{
	public static TSource[] ToArrayOrNull<TSource>(this IEnumerable<TSource> source)
	{
		return source?.ToArray();
	}

	public static TSource[] ToArrayOrEmpty<TSource>(this IEnumerable<TSource> source)
	{
		if (source == null)
		{
			return new TSource[0];
		}
		return source.ToArray();
	}

	public static IEnumerable<TResult> CastOrNull<TResult>(this IEnumerable source)
	{
		return source?.Cast<TResult>();
	}
}
