using System;
using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Helpers;

internal class Comparer : IEqualityComparer<object>
{
	protected Func<object, object, bool> Expression;

	internal static Comparer XYPdishczP9UDLqJNmoY;

	public Comparer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		laA5w5hzWNsSNbCvkRgx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public Comparer(Func<object, object, bool> expression)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Expression = expression;
	}

	bool IEqualityComparer<object>.Equals(object x, object y)
	{
		//Discarded unreachable code: IL_003d, IL_004c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return Expression(x, y);
			default:
				return false;
			case 1:
				if (Expression == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public int GetHashCode(object x)
	{
		return x.GetHashCode();
	}

	internal static void laA5w5hzWNsSNbCvkRgx()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool c8NMrshzFkRUQlDqTWHJ()
	{
		return XYPdishczP9UDLqJNmoY == null;
	}

	internal static Comparer QF1dRmhzBTFvDTwHXZQq()
	{
		return XYPdishczP9UDLqJNmoY;
	}
}
