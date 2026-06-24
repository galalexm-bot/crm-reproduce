using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Comparers;

public class Comparer<TSource, TKey> : IComparer<TSource>, IComparer
{
	private readonly Func<TSource, TKey> propertyFunc;

	private readonly ListSortDirection order;

	private readonly int orderInt;

	internal static object aR5spNoUp83Nn8fuHGLI;

	public Comparer(Func<TSource, TKey> propertyFunc, ListSortDirection order)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.propertyFunc = propertyFunc;
		this.order = order;
		orderInt = ((this.order != ListSortDirection.Descending) ? 1 : (-1));
	}

	public Comparer(LambdaExpression expression, ListSortDirection order)
	{
		//Discarded unreachable code: IL_0036, IL_003b
		SingletonReader.JJCZtPuTvSt();
		this._002Ector((Func<TSource, TKey>)expression.Compile(), order);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected virtual int Compare(TKey keyX, TKey keyY)
	{
		if (keyX == null)
		{
			return 1;
		}
		if (!(keyX is IComparable))
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E0DE1C), typeof(TKey).FullName));
		}
		int num = ((IComparable)(object)keyX).CompareTo(keyY);
		if (num != 0)
		{
			return num;
		}
		return 1;
	}

	public virtual int Compare(TSource x, TSource y)
	{
		if (object.Equals(x, y))
		{
			return 0;
		}
		TKey keyX = propertyFunc(x);
		TKey keyY = propertyFunc(y);
		return orderInt * Compare(keyX, keyY);
	}

	public int Compare(object x, object y)
	{
		return Compare((TSource)x, (TSource)y);
	}

	internal static bool vIjMVYoUaMLbFDjgxa02()
	{
		return aR5spNoUp83Nn8fuHGLI == null;
	}

	internal static object UsSnMLoUDI0kNpyYquob()
	{
		return aR5spNoUp83Nn8fuHGLI;
	}
}
