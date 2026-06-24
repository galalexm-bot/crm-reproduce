using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public class FunctorEqualityComparer<T> : IEqualityComparer<T>
{
	private readonly Func<T, T, bool> comparison;

	private readonly Func<T, int> getHashCode;

	public FunctorEqualityComparer(Func<T, T, bool> comparison)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(comparison, (Func<T, int>)((T obj) => obj?.GetHashCode() ?? 0));
	}

	public FunctorEqualityComparer(Func<T, T, bool> comparison, Func<T, int> getHashCode)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.NotNull(comparison, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFAFD22));
		Contract.NotNull(getHashCode, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951251834));
		this.comparison = comparison;
		this.getHashCode = getHashCode;
	}

	public static FunctorEqualityComparer<T> Create(Func<T, T, bool> comparison)
	{
		return new FunctorEqualityComparer<T>(comparison);
	}

	public static FunctorEqualityComparer<T> Create(Func<T, T, bool> comparison, Func<T, int> getHashCode)
	{
		return new FunctorEqualityComparer<T>(comparison, getHashCode);
	}

	public bool Equals(T x, T y)
	{
		return comparison(x, y);
	}

	public int GetHashCode(T obj)
	{
		return getHashCode(obj);
	}
}
public class FunctorEqualityComparer<T, TV> : IEqualityComparer<T>
{
	private readonly Func<T, TV> func;

	public FunctorEqualityComparer(Func<T, TV> func)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.func = func;
	}

	public static FunctorEqualityComparer<T, TV> Create(Func<T, TV> func)
	{
		return new FunctorEqualityComparer<T, TV>(func);
	}

	public bool Equals(T x, T y)
	{
		return object.Equals(func(x), func(y));
	}

	public int GetHashCode(T obj)
	{
		object obj2 = func(obj);
		if (object.Equals(null, obj2))
		{
			return 0;
		}
		return obj2.GetHashCode();
	}
}
