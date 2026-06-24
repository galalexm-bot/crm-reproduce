using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Helpers;

[Component]
public class MoneyRangeMoneyConvertTypeWrapper : IConvertTypeWrapper
{
	private static MoneyRangeMoneyConvertTypeWrapper xqcCUwbfIuVoOFT67SoI;

	public Type OriginalType => typeof(MoneyRange);

	public Type ConvertType => qJTJ2KbficPCVI81dnob(typeof(Money).TypeHandle);

	public bool RelativeConvertNeeded(Type type)
	{
		return true;
	}

	public object ConvertWrapper(object obj)
	{
		int num = 1;
		int num2 = num;
		MoneyRange moneyRange = default(MoneyRange);
		while (true)
		{
			switch (num2)
			{
			default:
				return moneyRange.From;
			case 1:
				moneyRange = (MoneyRange)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public MoneyRangeMoneyConvertTypeWrapper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IKf9XNbfRr9YYT45ZdxE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type qJTJ2KbficPCVI81dnob(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool ANCWa7bfV3S63ofNF7CQ()
	{
		return xqcCUwbfIuVoOFT67SoI == null;
	}

	internal static MoneyRangeMoneyConvertTypeWrapper kQ3PV5bfSNZBrhIFphXx()
	{
		return xqcCUwbfIuVoOFT67SoI;
	}

	internal static void IKf9XNbfRr9YYT45ZdxE()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
