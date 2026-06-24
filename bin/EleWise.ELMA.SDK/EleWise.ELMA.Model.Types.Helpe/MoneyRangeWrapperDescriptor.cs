using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component(Order = 1000)]
public class MoneyRangeWrapperDescriptor : ITypeWrapperDescriptor
{
	internal static MoneyRangeWrapperDescriptor X0NgimbfQCnOInZ29ewe;

	public Type OriginalType => vLApCxbf8UirKOXPJptF(typeof(MoneyRange).TypeHandle);

	public Type WrapperType => vLApCxbf8UirKOXPJptF(typeof(MoneyRangeWrapper).TypeHandle);

	public Type[] GenericArgumentsTypes => null;

	public object CreateWrapper(object obj)
	{
		return new MoneyRangeWrapper((MoneyRange)obj);
	}

	public object GetObject(object wrapper)
	{
		int num = 4;
		MoneyRangeWrapper moneyRangeWrapper = default(MoneyRangeWrapper);
		MoneyRange moneyRange = default(MoneyRange);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (moneyRangeWrapper == null)
					{
						moneyRange = default(MoneyRange);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto end_IL_0012;
				default:
					return moneyRange;
				case 6:
					moneyRange.From = DrhEl5bfubITNU9OwjMs(H99xZIbfZqvtvkcEqCCL(moneyRangeWrapper));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					moneyRange = default(MoneyRange);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 6;
					}
					break;
				case 4:
					moneyRangeWrapper = wrapper as MoneyRangeWrapper;
					num2 = 3;
					break;
				case 1:
					moneyRange.To = DrhEl5bfubITNU9OwjMs(moneyRangeWrapper.To);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return moneyRange;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public bool TestType(Type type)
	{
		return false;
	}

	public MoneyRangeWrapperDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type vLApCxbf8UirKOXPJptF(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool a57dtbbfCiWO0TCU3Lr2()
	{
		return X0NgimbfQCnOInZ29ewe == null;
	}

	internal static MoneyRangeWrapperDescriptor eaoeBqbfvYBBlqtIueV2()
	{
		return X0NgimbfQCnOInZ29ewe;
	}

	internal static object H99xZIbfZqvtvkcEqCCL(object P_0)
	{
		return ((MoneyRangeWrapper)P_0).From;
	}

	internal static Money DrhEl5bfubITNU9OwjMs(object P_0)
	{
		return ((MoneyWrapper)P_0).Value;
	}
}
