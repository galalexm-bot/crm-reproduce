using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Type;

namespace EleWise.ELMA.Runtime.NH;

[Serializable]
public class ElmaGenericSortedSetType<T> : GenericSetType<T>
{
	private readonly IComparer<T> comparer;

	private static object V6DA5xWpesoKljIjxOsm;

	public IComparer<T> Comparer => comparer;

	public ElmaGenericSortedSetType(string role, string propertyRef, IComparer<T> comparer)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(role, propertyRef);
		this.comparer = comparer;
	}

	public override object Instantiate(int anticipatedSize)
	{
		return new IesiSortedSet<T>(comparer);
	}

	internal static bool tYZfvQWpPMHANc9CDuv5()
	{
		return V6DA5xWpesoKljIjxOsm == null;
	}

	internal static object f7Fon9Wp1r9jEoUjJVSJ()
	{
		return V6DA5xWpesoKljIjxOsm;
	}
}
