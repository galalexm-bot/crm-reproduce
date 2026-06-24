using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public class FunctorComparer<T> : IComparer<T>
{
	private readonly Comparison<T> comparison;

	public static FunctorComparer<T> Create(Comparison<T> comparison)
	{
		return new FunctorComparer<T>(comparison);
	}

	public FunctorComparer(Comparison<T> comparison)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		if (comparison == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4781B945));
		}
		this.comparison = comparison;
	}

	public int Compare(T x, T y)
	{
		return comparison(x, y);
	}
}
