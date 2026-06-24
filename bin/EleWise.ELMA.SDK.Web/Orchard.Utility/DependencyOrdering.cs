using System;
using System.Collections.Generic;
using System.Linq;

namespace Orchard.Utility;

public static class DependencyOrdering
{
	private class Linkage<T>
	{
		public T Element { get; set; }

		public bool Used { get; set; }
	}

	public static IEnumerable<T> OrderByDependenciesAndPriorities<T>(this IEnumerable<T> elements, Func<T, T, bool> hasDependency, Func<T, int> getPriority)
	{
		Linkage<T>[] array = (from d in elements
			select new Linkage<T>
			{
				Element = d
			} into item
			orderby getPriority(item.Element)
			select item).ToArray();
		List<T> list = new List<T>();
		Linkage<T>[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			Add(array2[i], list, array, hasDependency, getPriority);
		}
		for (int j = 1; j < list.Count; j++)
		{
			int finalPosition = BestPriorityPosition(list, j, hasDependency, getPriority);
			SwitchAndShift(list, j, finalPosition);
		}
		return list;
	}

	private static void Add<T>(Linkage<T> item, ICollection<T> list, IEnumerable<Linkage<T>> population, Func<T, T, bool> hasDependency, Func<T, int> getPriority)
	{
		if (item.Used)
		{
			return;
		}
		item.Used = true;
		foreach (Linkage<T> item2 in population.Where((Linkage<T> dep) => hasDependency(item.Element, dep.Element)))
		{
			Add(item2, list, population, hasDependency, getPriority);
		}
		list.Add(item.Element);
	}

	private static int BestPriorityPosition<T>(List<T> list, int index, Func<T, T, bool> hasDependency, Func<T, int> getPriority)
	{
		int num = getPriority(list[index]);
		int result = index;
		for (int num2 = index - 1; num2 >= 0; num2--)
		{
			if (hasDependency(list[index], list[num2]))
			{
				return result;
			}
			if (getPriority(list[num2]) > num)
			{
				result = num2;
			}
		}
		return result;
	}

	private static bool SwitchAndShift<T>(List<T> list, int initialPosition, int finalPosition)
	{
		if (initialPosition < finalPosition)
		{
			throw new ArgumentException("finalPosition");
		}
		if (initialPosition != finalPosition)
		{
			T value = list[initialPosition];
			while (initialPosition > finalPosition)
			{
				list[initialPosition] = list[initialPosition - 1];
				initialPosition--;
			}
			list[finalPosition] = value;
			return true;
		}
		return false;
	}
}
