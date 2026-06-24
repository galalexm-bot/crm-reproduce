using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class DoubleDoubleRangeConvertTypeWrapper : IConvertTypeWrapper
{
	internal static DoubleDoubleRangeConvertTypeWrapper yFKYSZbGiueqLbBVFdiS;

	public Type OriginalType => pD5MgJbGKLtymUhU2Sqn(typeof(double).TypeHandle);

	public Type ConvertType => pD5MgJbGKLtymUhU2Sqn(typeof(DoubleRange).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 3;
		int num2 = num;
		DoubleRange doubleRange = default(DoubleRange);
		double value = default(double);
		while (true)
		{
			switch (num2)
			{
			case 2:
				doubleRange = default(DoubleRange);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return doubleRange;
			case 3:
				value = M3PrHxbGX70bcBcdnoIM(obj);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				doubleRange.To = value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 1;
				}
				break;
			default:
				doubleRange.From = value;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public DoubleDoubleRangeConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type pD5MgJbGKLtymUhU2Sqn(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static double M3PrHxbGX70bcBcdnoIM(object P_0)
	{
		return Convert.ToDouble(P_0);
	}

	internal static bool Mhk3RHbGRZZLvdtS4RK3()
	{
		return yFKYSZbGiueqLbBVFdiS == null;
	}

	internal static DoubleDoubleRangeConvertTypeWrapper Q5clMobGqrwk9YsvJ5X8()
	{
		return yFKYSZbGiueqLbBVFdiS;
	}
}
