using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA;

public static class ISetExtensions
{
	public static bool AddAll<T>(this ISet<T> source, IEnumerable<T> newElements)
	{
		_003C_003Ec__DisplayClass0_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0<T>();
		CS_0024_003C_003E8__locals0.source = source;
		return newElements.Aggregate(seed: false, (bool current, T o) => current | CS_0024_003C_003E8__locals0.source.Add(o));
	}

	public static bool RemoveAll<T>(this ISet<T> source, IEnumerable<T> removedElements)
	{
		_003C_003Ec__DisplayClass1_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0<T>();
		CS_0024_003C_003E8__locals0.source = source;
		return removedElements.Aggregate(seed: false, (bool current, T o) => current | CS_0024_003C_003E8__locals0.source.Remove(o));
	}

	public static bool ContainsAll<T>(this ISet<T> source, IEnumerable<T> collection)
	{
		return collection.All(source.Contains);
	}
}
