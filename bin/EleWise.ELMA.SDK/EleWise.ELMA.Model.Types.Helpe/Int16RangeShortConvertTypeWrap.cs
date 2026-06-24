using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class Int16RangeShortConvertTypeWrapper : IConvertTypeWrapper
{
	internal static Int16RangeShortConvertTypeWrapper gcjiwmbEICsXjSoGCkUB;

	public Type OriginalType => OwO1UxbEigXD8v1ie5DD(typeof(Int16Range).TypeHandle);

	public Type ConvertType => OwO1UxbEigXD8v1ie5DD(typeof(short).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		//Discarded unreachable code: IL_0059
		int num = 1;
		int num2 = num;
		Int16Range int16Range = default(Int16Range);
		short? num3;
		short? from = default(short?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				int16Range = (Int16Range)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				num3 = 0;
				break;
			default:
				from = int16Range.From;
				num2 = 3;
				continue;
			case 3:
				if (!from.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 2;
					}
					continue;
				}
				num3 = int16Range.From;
				break;
			}
			break;
		}
		return num3;
	}

	public Int16RangeShortConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jQnYxWbERA4HmykQYvj5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type OwO1UxbEigXD8v1ie5DD(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool xnCrFGbEVf4QYel1gFcX()
	{
		return gcjiwmbEICsXjSoGCkUB == null;
	}

	internal static Int16RangeShortConvertTypeWrapper P3Tv6RbESoH0TGB9WijA()
	{
		return gcjiwmbEICsXjSoGCkUB;
	}

	internal static void jQnYxWbERA4HmykQYvj5()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
